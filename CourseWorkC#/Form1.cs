using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkC_
{
    public partial class Form1 : Form
    {

        private Salary salaryList;

        public Form1()
        {
            InitializeComponent();

            salaryList = new Salary(10);

            addObjectsToList();


            dataGridView1.ColumnCount = 10;
            dataGridView1.Columns[0].Name = "Табельний номер";
            dataGridView1.Columns[1].Name = "Прізвище";
            dataGridView1.Columns[2].Name = "Ім'я";
            dataGridView1.Columns[3].Name = "По батькові";
            dataGridView1.Columns[4].Name = "Дата народження";
            dataGridView1.Columns[5].Name = "Стать";            
            dataGridView1.Columns[6].Name = "Оклад";
            dataGridView1.Columns[7].Name = "Стаж роботи";
            dataGridView1.Columns[8].Name = "К-сть відпрацьованих годин";
            dataGridView1.Columns[9].Name = "ЗП/год";
            dataGridView1.Columns.Add("Зарплата", "Зарплата");


            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Зарплата"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < salaryList.AmountOfCoworkers; i++)
            {
                Coworker coworker = salaryList.GetCoworkerAtIndex(i);
                dataGridView1.Rows.Add(coworker.TableNumber, coworker.Surname, coworker.Name, coworker.MiddleName, coworker.BirthDate,coworker.Gender, coworker.Salary, coworker.Experience, coworker.HoursWorked, coworker.SalaryPerHour);
            }
        }

        private void addObjectsToList()
        {
            Coworker coworker1 = new Coworker();
            coworker1.Surname = "Цевіл";
            coworker1.Name = "Генрі";
            coworker1.MiddleName = "Арнольдович";
            coworker1.BirthDate = "22.03.1994";
            coworker1.Gender = "Ч";
            coworker1.TableNumber = 12;
            coworker1.Salary = 250000;
            coworker1.Experience = 10;
            coworker1.HoursWorked = 124;
            coworker1.SalaryPerHour = 230;
            salaryList.addCoworkerToList(coworker1);

            Coworker coworker2 = new Coworker();
            coworker2.Surname = "Кларк";
            coworker2.Name = "Емілія";
            coworker2.MiddleName = "Єфімія";
            coworker2.BirthDate = "23.10.2004";
            coworker2.Gender = "Ж";
            coworker2.TableNumber = 1;
            coworker2.Salary = 305500;
            coworker2.Experience = 8;
            coworker2.HoursWorked = 131;
            coworker2.SalaryPerHour = 300;
            salaryList.addCoworkerToList(coworker2);
        }

        private void showListbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Visible)
            {
                dataGridView1.Visible = false;
                this.Width = 500;
            }
            else
            {
                dataGridView1.Visible = true;
                this.Width = 1488;
            }
        }

        private void addCoworkerbtn_Click(object sender, EventArgs e)
        {
            Coworker coworker = new Coworker();

            coworker.Surname = txtSurname.Text;
            coworker.Name = txtName.Text;
            coworker.MiddleName = txtMiddleName.Text;
            coworker.BirthDate = txtBirthDate.Text;
            coworker.Gender = txtGender.Text;

            if (!ValidateName(coworker.Surname) || !ValidateName(coworker.Name) || !ValidateName(coworker.MiddleName))
            {
                MessageBox.Show("Invalid name format. Names should not contain numbers.");
                return;
            }

            if (!ValidateDateFormat(coworker.BirthDate))
            {
                MessageBox.Show("Invalid birth date format. Please enter the date in the format 'dd.MM.yyyy'.");
                return;
            }

            if (!ValidateGender(coworker.Gender))
            {
                MessageBox.Show("Invalid gender. Gender should be 'Ч' or 'Ж'.");
                return;
            }

            int tableNumber;
            if (!int.TryParse(txtTableNumber.Text, out tableNumber))
            {
                MessageBox.Show("Invalid table number. Please enter a valid integer.");
                return;
            }
            coworker.TableNumber = tableNumber;

            double salary;
            if (!double.TryParse(txtSalary.Text, out salary))
            {
                MessageBox.Show("Invalid salary format. Please enter a valid number.");
                return;
            }
            coworker.Salary = salary;

            double experience;
            if (!double.TryParse(txtExperience.Text, out experience))
            {
                MessageBox.Show("Invalid experience format. Please enter a valid number.");
                return;
            }
            coworker.Experience = experience;

            double hoursWorked;
            if (!double.TryParse(txtHoursWorked.Text, out hoursWorked))
            {
                MessageBox.Show("Invalid hours worked format. Please enter a valid number.");
                return;
            }
            coworker.HoursWorked = hoursWorked;

            double salaryPerHour;
            if (!double.TryParse(txtSalaryPerHour.Text, out salaryPerHour))
            {
                MessageBox.Show("Invalid salary per hour format. Please enter a valid number.");
                return;
            }
            coworker.SalaryPerHour = salaryPerHour;

            salaryList.addCoworkerToList(coworker);
            dataGridView1.Rows.Add(coworker.TableNumber, coworker.Surname, coworker.Name, coworker.MiddleName, coworker.BirthDate, coworker.Gender, coworker.Salary, coworker.Experience, coworker.HoursWorked, coworker.SalaryPerHour);
        }

        private bool ValidateDateFormat(string date)
        {
            if (DateTime.TryParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                return true;
            }
            return false;
        }

        private bool ValidateName(string name)
        {
            return !name.Any(char.IsDigit);
        }

        private bool ValidateGender(string gender)
        {
            return gender == "Ч" || gender == "Ж";
        }

        private int ParseIntValue(string text, string fieldName)
        {
            int value;
            if (!int.TryParse(text, out value))
            {
                MessageBox.Show($"Invalid {fieldName} format. Please enter a valid integer.");
                //throw new InvalidOperationException($"Invalid {fieldName} format.");
            }
            return value;
        }

        private double ParseDoubleValue(string text, string fieldName)
        {
            double value;
            if (!double.TryParse(text, out value))
            {
                MessageBox.Show($"Invalid {fieldName} format. Please enter a valid number.");
                //throw new InvalidOperationException($"Invalid {fieldName} format.");
            }
            return value;
        }

        private void countSalarybtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Index != dataGridView1.NewRowIndex)
                {
                    int index = row.Index; // Get the index of the row
                    Coworker coworker = salaryList.GetCoworkerAtIndex(index);

                    double totalSalary = salaryList.CalculateSalary(coworker);

                    row.Cells["Зарплата"].Value = totalSalary.ToString();
                }
            }
        }

        private void clearListbtn_Click(object sender, EventArgs e)
        {
            if (salaryList != null)
            {
                // Reset the amountOfCoworkers variable to 0
                salaryList.AmountOfCoworkers = 0;

                // Clear the CoworkersListInfo array
                Array.Clear(salaryList.CoworkersListInfo, 0, salaryList.CoworkersListInfo.Length);
            }

            // Clear the DataGridView
            dataGridView1.Rows.Clear();
        }
    }
}
