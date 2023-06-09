﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CourseWorkC_
{
    public class Osoba
    {
        private string surname;
        private string name;
        private string middleName;
        private DateTime birthDate;
        private string gender;

        public string Surname { get { return surname; } set { surname = value; } }
        public string Name { get { return name; } set {  name = value; } }
        public string MiddleName { get { return middleName; } set {  middleName = value; } }
        public DateTime BirthDate { get {  return birthDate; } set {  birthDate = value; } }
        public string Gender { get {  return gender; } set {  gender = value; } }

        public Osoba() { }

        public Osoba(string surname, string name, string middleName, DateTime birthDate)
        {
            Surname = surname;
            Name = name;
            MiddleName = middleName;
            BirthDate = birthDate;
            Gender = gender;
        }

        public Osoba(Osoba other)
        {
            Surname = other.Surname;
            Name = other.Name;
            MiddleName = other.MiddleName;
            BirthDate = other.BirthDate;
            Gender = other.Gender;
        }
    }
}
