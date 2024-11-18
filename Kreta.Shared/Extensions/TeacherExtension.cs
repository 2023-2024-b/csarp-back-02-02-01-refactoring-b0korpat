using Kreta.Shared.Dtos;
using Kreta.Shared.Models.Datas.Entities;

namespace Kreta.Shared.Extensions
{
    public static class TeacherExtension
    {
        public static TeacherDto ToTeacherDto(this Teacher teacher)
        {
            return new TeacherDto
            {
                Id = teacher.Id,
                FirstName = teacher.FirstName,
                LastName = teacher.LastName,
                BirthDay = teacher.BirthDay,
                IsWoman = teacher.IsWoman,
                MathersName = teacher.MathersName,
                PlaceOfBirth = teacher.PlaceOfBirth,
            };
        }

        public static Teacher ToTeacher(this TeacherDto teacher)
        {
            return new Teacher
            {
                Id = teacher.Id,
                FirstName = teacher.FirstName,
                LastName = teacher.LastName,
                BirthDay = teacher.BirthDay,
                IsWoman = teacher.IsWoman,
                MathersName = teacher.MathersName,
                PlaceOfBirth = teacher.PlaceOfBirth,
            };
        }
    }
}
