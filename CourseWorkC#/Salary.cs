using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkC_
{
    public class Salary
    {

        private Coworker[] coworkersListInfo;
        private int amountOfCoworkers;

        public Coworker[] CoworkersListInfo { get; private set; }

        public int AmountOfCoworkers { get { return amountOfCoworkers; } set { amountOfCoworkers = value; } }


        public Salary(int size)
        {
            amountOfCoworkers = 0;
            coworkersListInfo = new Coworker[size];
        }

        public void addCoworkerToList(Coworker coworker)
        {
            coworkersListInfo[amountOfCoworkers] = coworker;
            amountOfCoworkers++;
        }

        public double CalculateSalary(Coworker coworker)
        {
            double totalSalary = coworker.Salary + (coworker.HoursWorked * coworker.SalaryPerHour);
            return totalSalary;
        }

        public string PrintCoworkersInfo()
        {
            string result = "";
            for (int i = 0; i < amountOfCoworkers; i++)
            {
                double salary = coworkersListInfo[i].Salary;
                string salaryString = salary.ToString("F2");
                result += $"Заробітна плата працівника з табельним номером {coworkersListInfo[i].TableNumber} складає {salaryString}\n";
            }

            return result;
        }

        public Coworker GetCoworkerAtIndex(int index)
        {
            if (index >= 0 && index < amountOfCoworkers)
            {
                return coworkersListInfo[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
        }

        public CustomIterator<Coworker> GetIterator()
        {
            return new CustomIterator<Coworker>(coworkersListInfo, 0, amountOfCoworkers);
        }
    }
}
