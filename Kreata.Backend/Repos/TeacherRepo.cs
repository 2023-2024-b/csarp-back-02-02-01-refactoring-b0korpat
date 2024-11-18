using Kreata.Backend.Context;
using Kreata.Backend.Repos;
using Kreta.Shared.Models.Datas.Entities;
using Kreta.Shared.Models.Responses;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos
{
    public class TeacherRepo : ITeacherRepo
    {
        private readonly KretaInMemoryContext _dbcontext;
        public TeacherRepo(KretaInMemoryContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public Task<List<Teacher>> GetAll()
        {
            return _dbcontext.Teachers.ToListAsync();
        }

        public Task<Teacher?> GetBy(Guid id)
        {
            return _dbcontext.Teachers.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<ControllerResponse> UpdateTeacherAsync(Teacher teacher)
        {
            ControllerResponse response = new ControllerResponse();
            _dbcontext.ChangeTracker.Clear();
            _dbcontext.Entry(teacher).State = EntityState.Modified;

            try
            {
                await _dbcontext.SaveChangesAsync();
            }
            catch (Exception e)
            {

                response.AppendNewError(e.Message);
                response.AppendNewError($"{nameof(TeacherRepo)} osztály, {nameof(UpdateTeacherAsync)} metódusban hiba keletkezett");
                response.AppendNewError($"{teacher} frissítése nem sikerült!");
            }
            return response;
        }
    }
}