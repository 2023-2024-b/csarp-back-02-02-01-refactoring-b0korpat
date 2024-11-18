using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Shared.Dtos
{
    public class TeacherDto
    {

        public TeacherDto(Guid id, string firstName, string lastName, DateTime birthDay, string placeOfBirth, bool isWoman, bool isHeadTeacher, string mathersName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            PlaceOfBirth = placeOfBirth;
            IsWoman = isWoman;
            IsHeadTeacher = isHeadTeacher;
            MathersName = mathersName;
        }

        public TeacherDto(string firstName, string lastName, DateTime birthDay, string placeOfBirth, bool isWoman, bool isHeadTeacher, string mathersName)
        {
            Id = new Guid();
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            PlaceOfBirth = placeOfBirth;
            IsWoman = isWoman;
            IsHeadTeacher = isHeadTeacher;
            MathersName = mathersName;
        }

        public TeacherDto()
        {
            Id = new Guid();
            FirstName = string.Empty; 
            LastName = string.Empty;
            BirthDay = new DateTime();
            PlaceOfBirth = string.Empty;
            IsWoman = false;
            IsHeadTeacher = false;
            MathersName = string.Empty;
        }


        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthDay { get; set; }
        public string PlaceOfBirth { get; set; } = string.Empty;
        public bool IsWoman { get; set; }
        public bool IsHeadTeacher { get; set; }
        public string MathersName { get; set; } = string.Empty;
    }
}