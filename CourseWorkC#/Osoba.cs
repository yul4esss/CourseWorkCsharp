using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
        private string birthDate;
        private string gender;

        public string Surname { get { return surname; } set { surname = value; } }
        public string Name { get { return name; } set {  name = value; } }
        public string MiddleName { get { return middleName; } set {  middleName = value; } }
        public string BirthDate { get {  return birthDate; } set {  birthDate = value; } }
        public string Gender { get {  return gender; } set {  gender = value; } }

        public Osoba() { }

        public Osoba(string surname, string name, string middleName, string birthDate, string gender)
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

        public virtual void PrintPersonInfo()
        {
            string personInfo = $"{Surname} {Name} {MiddleName}\nДата народження: {BirthDate}\nСтать: '{Gender}'";
            Console.WriteLine(personInfo);
        }

        // Поліморфічний кластер
        public virtual string GetPersonData()
        {
            return surname;
        }

        // Перегрузка операторів вводу та виводу
        public override string ToString()
        {
            return $"{Surname} {Name} {MiddleName}\nДата народження: {BirthDate}\nСтать: '{Gender}'";
        }

        public static Osoba FromStreamReader(StreamReader reader)
        {
            Osoba osoba = new Osoba();

            Console.Write("Прізвище: ");
            osoba.Surname = reader.ReadLine();

            Console.Write("Ім'я: ");
            osoba.Name = reader.ReadLine();

            Console.Write("По-батькові: ");
            osoba.MiddleName = reader.ReadLine();

            Console.Write("Дата народження у форматі dd.mm.yyyy: ");
            osoba.BirthDate = reader.ReadLine();

            Console.Write("Стать: ");
            osoba.Gender = reader.ReadLine();

            return osoba;
        }

    }
}
