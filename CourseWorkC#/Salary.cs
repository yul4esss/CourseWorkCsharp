using CourseWorkC_;
using System;
using System.Collections.Generic;

public class Salary : IEnumerable<Coworker>
{
    private List<Coworker> coworkersListInfo;

    public Salary(int size)
    {
        coworkersListInfo = new List<Coworker>(size);
    }

    public void AddCoworkerToList(Coworker coworker)
    {
        coworkersListInfo.Add(coworker);
    }

    public double CalculateSalary(Coworker coworker)
    {
        double salary = coworker.Salary + (coworker.HoursWorked * coworker.SalaryPerHour);
        // Розрахунок зарплати для конкретного співробітника

        return salary;
    }

    public string PrintCoworkersInfo()
    {
        string result = "";
        foreach (var coworker in coworkersListInfo)
        {
            double salary = coworker.Salary;
            string salaryString = salary.ToString("F2"); // Форматуємо до двох знаків після коми
            result += $"Заробітна плата працівника з табельним номером {coworker.TableNumber} складає {salaryString}\n";
        }

        return result;
    }

    public IEnumerator<Coworker> GetEnumerator()
    {
        return coworkersListInfo.GetEnumerator();
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
