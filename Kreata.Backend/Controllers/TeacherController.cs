
using Kreta.Backend.Repos;
using Kreta.Shared.Dtos;
using Kreta.Shared.Extensions;
using Kreta.Shared.Models.Datas.Entities;
using Kreta.Shared.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController : ControllerBase
    {
        private ITeacherRepo _classRoomRepo;

        public TeacherController(ITeacherRepo classRoomRepo)
        {
            _classRoomRepo = classRoomRepo;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBy(Guid id)
        {
            Teacher? teacher = new();
            if (_classRoomRepo is not null)
            {
                teacher = await _classRoomRepo.GetBy(id);
                if (teacher != null)
                    return Ok(teacher.ToTeacherDto);
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }

        [HttpGet]
        public async Task<IActionResult> SelectAllRecordToListAsync()
        {
            List<Teacher>? teachers = new();

            if (_classRoomRepo is not null)
            {
                teachers = await _classRoomRepo.GetAll();
                return Ok(teachers.Select(teacher => teacher.ToTeacherDto()));
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }
        [HttpPut()]
        public async Task<ActionResult> UpdateTeacherAsync(TeacherDto entity)
        {
            ControllerResponse response = new();
            if (_classRoomRepo is not null)
            {
                response = await _classRoomRepo.UpdateTeacherAsync(entity.ToTeacher());
                if (response.HasError)
                {
                    return BadRequest(response);
                }
                else
                {
                    return Ok(response);
                }
            }
            response.ClearAndAddError("Az adatok frissítés nem lehetséges!");
            return BadRequest(response);
        }
    }
}