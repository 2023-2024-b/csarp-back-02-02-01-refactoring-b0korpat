﻿using System;

namespace Kreta.Shared.Models.Datas.Entities
{
    public class Teacher
    {
        public Teacher()
        {
            Id = Guid.Empty;
            FirstName = string.Empty;
            LastName = string.Empty;
            BirthDay = DateTime.MinValue;
            PlaceOfBirth = string.Empty;
            IsWoman = false;
            IsHeadTeacher = false;
            MathersName = string.Empty;
        }
        public Teacher(Guid id, string firstName, string lastName, DateTime birthDay, string placeOfBirth, bool isWoman, bool isHeadTeacher, string mathersName)
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

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public string PlaceOfBirth { get; set; }
        public bool IsWoman { get; set; }
        public bool IsHeadTeacher { get; set; }
        public string MathersName { get; set; }
        public string HungarianName => $"{LastName} {FirstName}";
        public bool HasId => Id != Guid.Empty;
        public bool IsMan => !IsWoman;

        public override string ToString()
        {
            string headTeacher = string.Empty;
            if (IsHeadTeacher)
            {
                headTeacher = "(osztályfőnök)";
            }
            string woman = IsWoman ? "nő" : "férfi";

            return $"{HungarianName} {woman} {headTeacher} ({String.Format("{0:yyyy.MM.dd.}", BirthDay)}) {PlaceOfBirth} {MathersName}";
        }
    }
}