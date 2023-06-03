using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkC_
{
    public class Coworker : Osoba
    {
        private int tableNumber;
        private double salary;
        private double experience;
        private double hoursWorked;
        private double salaryPerHour;

        public int TableNumber { get { return tableNumber; } set { tableNumber = value; } }
        public double Salary { get { return salary; } set { salary = value; } }
        public double Experience { get { return experience; } set { experience = value; } }
        public double HoursWorked { get { return hoursWorked; } set { hoursWorked = value; } }
        public double SalaryPerHour { get { return salaryPerHour; } set { salaryPerHour = value; } }

        public Coworker() { }

        public Coworker(string surname, string name, string middleName, string birthDate, string gender,
        int tableNumber, double salary, double experience, double hoursWorked, double salaryPerHour)
            : base(surname, name, middleName, birthDate, gender)
        {
            this.tableNumber = tableNumber;
            this.salary = salary;
            this.experience = experience;
            this.hoursWorked = hoursWorked;
            this.salaryPerHour = salaryPerHour;
        }

        public Coworker(Coworker other)
            : base(other.Surname, other.Name, other.MiddleName, other.BirthDate, other.Gender)
        {
            tableNumber = other.TableNumber;
            salary = other.Salary;
            experience = other.Experience;
            hoursWorked = other.HoursWorked;
            salaryPerHour = other.SalaryPerHour;
        }

        public override void PrintPersonInfo()
        {
            // Виклик базового методу PrintPersonInfo() для виведення інформації про особу
            base.PrintPersonInfo();

            // Виведення додаткової інформації про працівника
            Console.WriteLine($"Табельний номер: {TableNumber}\n" +
                              $"Зарплата: {Salary}\n" +
                              $"Досвід: {Experience}\n" +
                              $"Відпрацьовані години: {HoursWorked}\n" +
                              $"Зарплата за годину: {SalaryPerHour}");
        }

        public override string GetPersonData()
        {
            return tableNumber.ToString();
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nТабельний номер: {TableNumber}\nОклад: {Salary}\nСтаж роботи: {Experience}\nКількість відпрацьованих годин: {HoursWorked}\nЗарплата за годину роботи: {SalaryPerHour}";
        }

        public new static Coworker FromStreamReader(StreamReader reader)
        {
            Coworker coworker = new Coworker();
            Osoba osoba = Osoba.FromStreamReader(reader);
            coworker.Surname = osoba.Surname;
            coworker.Name = osoba.Name;
            coworker.MiddleName = osoba.MiddleName;
            coworker.BirthDate = osoba.BirthDate;
            coworker.Gender = osoba.Gender;

            Console.Write("Табличний номер співробітника: ");
            coworker.TableNumber = int.Parse(reader.ReadLine());

            Console.Write("Оклад: ");
            coworker.Salary = double.Parse(reader.ReadLine());

            Console.Write("Досвід роботи: ");
            coworker.Experience = double.Parse(reader.ReadLine());

            Console.Write("Кількість відпрацьованих годин: ");
            coworker.HoursWorked = double.Parse(reader.ReadLine());

            Console.Write("Зарплата за годину роботи: ");
            coworker.SalaryPerHour = double.Parse(reader.ReadLine());

            return coworker;
        }
    }
}
