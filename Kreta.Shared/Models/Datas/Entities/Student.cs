﻿using Kreata.Shared.Models.Datas.Enums;

namespace Kreta.Shared.Models.Datas.Entities
{
    public class Student
    {
        public Student(Guid id, string firstName, string lastName, DateTime birthsDay, int schoolYear, SchoolClassType schoolClass, string educationLevel, bool isWooman)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthsDay = birthsDay;
            SchoolYear = schoolYear;
            SchoolClass = schoolClass;
            EducationLevel = educationLevel;
            IsWoman = isWooman;
        }

        public Student(string firstName, string lastName, DateTime birthsDay, int schoolYear, SchoolClassType schoolClass, string educationLevel, bool isWooman)
        {
            Id = new Guid();
            FirstName = firstName;
            LastName = lastName;
            BirthsDay = birthsDay;
            SchoolYear = schoolYear;
            SchoolClass = schoolClass;
            EducationLevel = educationLevel;
            IsWoman = isWooman;
        }

        public Student()
        {
            Id = new Guid();
            FirstName = string.Empty;
            LastName = string.Empty;
            BirthsDay = new DateTime();
            SchoolYear = 9;
            SchoolClass = SchoolClassType.ClassA;
            EducationLevel = string.Empty;
            IsWoman = false;
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthsDay { get; set; }
        public int SchoolYear { get; set; }
        public SchoolClassType SchoolClass { get; set; }
        public string EducationLevel { get; set; }
        public bool IsWoman { get; set; }
        public bool IsMan => !IsWoman;

        public override string ToString()
        {
            return $"{LastName} {FirstName} ({SchoolYear}.{SchoolClass}), Szül: ({string.Format("{0:yyyy.MM.dd.}", BirthsDay)}), Tanulmányi szint: ({EducationLevel})";
        }
    }
}
