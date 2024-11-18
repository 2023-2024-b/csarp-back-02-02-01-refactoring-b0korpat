using Kreata.Backend.Datas.Entities;
using Kreata.Shared.Models.Datas.Enums;
using Kreta.Shared.Models.Datas.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Context
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="János",
                    LastName="Jegy",
                    BirthsDay=new DateTime(2022,10,10),
                    SchoolYear=9,
                    SchoolClass = SchoolClassType.ClassA,
                    EducationLevel="érettségi"
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="Szonja",
                    LastName="Stréber",
                    BirthsDay=new DateTime(2021,4,4),
                    SchoolYear=10,
                    SchoolClass = SchoolClassType.ClassB,
                    EducationLevel="érettségi"
                }
            };

            List<Parent> parents= new List<Parent>
            {
                new Parent
                {
                    Id=Guid.NewGuid(),
                    FirstName="Nagy Károly",
                    LastName="Henrik",
                    Address = "Péter utca 8.",
                    IsWomen = false,
                },
                new Parent
                {
                    Id=Guid.NewGuid(),
                    FirstName="Papp",
                    LastName="Imre",
                    Address = "Keceli út 88.",
                    IsWomen = false,
                }
            };

            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher
                {
                    Id=Guid.NewGuid(),
                    FirstName="János",
                    LastName="Elek",
                    BirthDay=new DateTime(1980,2,4),
                    PlaceOfBirth="Szeged",
                    MathersName="Judit Nagy",
                    IsWoman=false,
                    IsHeadTeacher=false,
                },
                new Teacher
                {
                    Id=Guid.NewGuid(),
                    FirstName="Etelka",
                    LastName="Szegedi",
                    BirthDay=new DateTime(1989,3,10),
                    PlaceOfBirth="Szeged",
                    MathersName="Közepes Icu",
                    IsWoman=true,
                    IsHeadTeacher=true,
                }
            };

            List<ClassRoom> classrooms = new List<ClassRoom>
            {
                new ClassRoom
                {
                    Id = Guid.NewGuid(),
                    Name = "SZT-1",
                    Capacity = 20,
                    Floor = 2
                },
                new ClassRoom
                {
                    Id = Guid.NewGuid(),
                    Name = "30",
                    Capacity = 20,
                    Floor = 1
                }
            };

            // Students
            modelBuilder.Entity<Student>().HasData(students);
            modelBuilder.Entity<Parent>().HasData(parents);
            modelBuilder.Entity<Teacher>().HasData(teachers);
            modelBuilder.Entity<ClassRoom>().HasData(classrooms);
        }
    }
}
