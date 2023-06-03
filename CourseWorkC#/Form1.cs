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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CourseWorkC_
{
    public partial class Form1 : Form
    {

        private List<Coworker> coworkersList;

        private Salary salaryCalculator;

        public Form1()
        {
            InitializeComponent();

            comboBox.Items.Add("Ж");
            comboBox.Items.Add("Ч");
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            coworkersList = new List<Coworker>();

            addObjectsToList();

            salaryCalculator = new Salary(coworkersList.Count);
            foreach (var coworker in coworkersList)
            {
                salaryCalculator.AddCoworkerToList(coworker);
            }

            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;


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

            for (int i = 0; i < coworkersList.Count; i++)
            {
                Coworker coworker = coworkersList[i];
                dataGridView1.Rows.Add(coworker.TableNumber, coworker.Surname, coworker.Name, coworker.MiddleName, coworker.BirthDate, coworker.Gender, coworker.Salary, coworker.Experience, coworker.HoursWorked, coworker.SalaryPerHour);
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
            coworkersList.Add(coworker1);

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
            coworkersList.Add(coworker2);
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
            try
            {
                Coworker coworker = new Coworker();

                coworker.Surname = string.IsNullOrEmpty(txtSurname.Text) ? string.Empty : txtSurname.Text;
                coworker.Name = string.IsNullOrEmpty(txtName.Text) ? string.Empty : txtName.Text;
                coworker.MiddleName = string.IsNullOrEmpty(txtMiddleName.Text) ? string.Empty : txtMiddleName.Text;
                coworker.BirthDate = string.IsNullOrEmpty(txtBirthDate.Text) ? string.Empty : txtBirthDate.Text;
                coworker.Gender = comboBox.SelectedItem as string;

                if (!ValidateName(coworker.Surname) || !ValidateName(coworker.Name) || !ValidateName(coworker.MiddleName))
                {
                    throw new CustomException("Invalid name format. Names should not contain numbers.");
                }

                if (!string.IsNullOrEmpty(txtBirthDate.Text))
                {
                    if (!ValidateDateFormat(txtBirthDate.Text))
                    {
                        throw new CustomException("Invalid date format. Please enter the date in the format 'dd.MM.yyyy'.");
                    }
                    coworker.BirthDate = txtBirthDate.Text;
                }

                coworker.TableNumber = ParseIntValue(txtTableNumber.Text, "TableNumber");
                coworker.Salary = ParseDoubleValue(txtSalary.Text, "Salary");
                coworker.Experience = ParseDoubleValue(txtExperience.Text, "Experience");
                coworker.HoursWorked = ParseDoubleValue(txtHoursWorked.Text, "HoursWorked");
                coworker.SalaryPerHour = ParseDoubleValue(txtSalaryPerHour.Text, "SalaryPerHour");

                if (coworker.TableNumber < 0 || coworker.Salary < 0 || coworker.Experience < 0 || coworker.HoursWorked < 0 || coworker.SalaryPerHour < 0)
                {
                    throw new CustomException("Invalid input. Numbers should not be negative.");
                }

                if (coworkersList.Any(c => c.TableNumber == coworker.TableNumber))
                {
                    throw new CustomException("This table number already exists. Please enter a unique table number.");
                }

                dataGridView1.Rows.Add(coworker.TableNumber, coworker.Surname, coworker.Name, coworker.MiddleName, coworker.BirthDate, coworker.Gender, coworker.Salary, coworker.Experience, coworker.HoursWorked, coworker.SalaryPerHour);
                coworkersList.Add(coworker);
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            foreach (var coworker in coworkersList)
            {
                double salary = salaryCalculator.CalculateSalary(coworker);
                string salaryString = salary.ToString("F2");
                dataGridView1.Rows[coworkersList.IndexOf(coworker)].Cells["Зарплата"].Value = salaryString;
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;

            if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count &&
                columnIndex >= 0 && columnIndex < dataGridView1.Columns.Count)
            {
                string columnName = dataGridView1.Columns[columnIndex].Name;
                string cellValue = dataGridView1.Rows[rowIndex].Cells[columnIndex].Value.ToString();

                if (columnName == "Оклад" || columnName == "Стаж роботи" || columnName == "К-сть відпрацьованих годин" || columnName == "ЗП/год")
                {
                    if (double.TryParse(cellValue, out double numericValue))
                    {
                        if (numericValue >= 0)
                        {
                            if (columnName == "Оклад")
                            {
                                coworkersList[rowIndex].Salary = numericValue;
                            }
                            else if (columnName == "Стаж роботи")
                            {
                                coworkersList[rowIndex].Experience = numericValue;
                            }
                            else if (columnName == "К-сть відпрацьованих годин")
                            {
                                coworkersList[rowIndex].HoursWorked = numericValue;
                            }
                            else if (columnName == "ЗП/год")
                            {
                                coworkersList[rowIndex].SalaryPerHour = numericValue;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid input. Numbers should not be negative.");
                            dataGridView1.Rows[rowIndex].Cells[columnIndex].Value = GetOriginalValue(columnName, coworkersList[rowIndex]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid input format. Please enter a valid number.");
                        dataGridView1.Rows[rowIndex].Cells[columnIndex].Value = GetOriginalValue(columnName, coworkersList[rowIndex]);
                    }
                }
                else if (columnName == "Прізвище")
                {
                    if (ValidateName(cellValue))
                    {
                        coworkersList[rowIndex].Surname = cellValue;
                    }
                    else
                    {
                        MessageBox.Show("Invalid surname format. Surname should not contain numbers.");
                        dataGridView1.Rows[rowIndex].Cells[columnIndex].Value = coworkersList[rowIndex].Surname;
                    }
                }
                else if (columnName == "Ім'я")
                {
                    if (ValidateName(cellValue))
                    {
                        coworkersList[rowIndex].Name = cellValue;
                    }
                    else
                    {
                        MessageBox.Show("Invalid name format. Name should not contain numbers.");
                        dataGridView1.Rows[rowIndex].Cells[columnIndex].Value = coworkersList[rowIndex].Name;
                    }
                }
                else if (columnName == "По батькові")
                {
                    if (ValidateName(cellValue))
                    {
                        coworkersList[rowIndex].MiddleName = cellValue;
                    }
                    else
                    {
                        MessageBox.Show("Invalid middle name format. Middle name should not contain numbers.");
                        dataGridView1.Rows[rowIndex].Cells[columnIndex].Value = coworkersList[rowIndex].MiddleName;
                    }
                }
                else if (columnName == "Дата народження")
                {
                    if (ValidateDateFormat(cellValue))
                    {
                        coworkersList[rowIndex].BirthDate = cellValue;
                    }
                    else
                    {
                        MessageBox.Show("Invalid birth date format. Please enter the date in the format 'dd.MM.yyyy'.");
                        dataGridView1.Rows[rowIndex].Cells[columnIndex].Value = coworkersList[rowIndex].BirthDate;
                    }
                }
                else if (columnName == "Стать")
                {
                    if (ValidateGender(cellValue))
                    {
                        coworkersList[rowIndex].Gender = cellValue;
                    }
                    else
                    {
                        MessageBox.Show("Invalid gender. Gender should be 'Ч' or 'Ж'.");
                        dataGridView1.Rows[rowIndex].Cells[columnIndex].Value = coworkersList[rowIndex].Gender;
                    }
                }
                else if (columnName == "Табельний номер")
                {
                    if (int.TryParse(cellValue, out int tableNumber))
                    {
                        coworkersList[rowIndex].TableNumber = tableNumber;
                    }
                    else
                    {
                        MessageBox.Show("Invalid tableNumber format. Please enter a valid number.");
                        dataGridView1.Rows[rowIndex].Cells[columnIndex].Value = coworkersList[rowIndex].TableNumber;
                    }
                }
            }
        }

        private object GetOriginalValue(string columnName, Coworker coworker)
        {
            switch (columnName)
            {
                case "Прізвище":
                    return coworker.Surname;
                case "Ім'я":
                    return coworker.Name;
                case "По батькові":
                    return coworker.MiddleName;
                case "Дата народження":
                    return coworker.BirthDate;
                case "Стать":
                    return coworker.Gender;
                case "Табельний номер":
                    return coworker.TableNumber;
                case "Оклад":
                    return coworker.Salary;
                case "Стаж роботи":
                    return coworker.Experience;
                case "К-сть відпрацьованих годин":
                    return coworker.HoursWorked;
                case "ЗП/год":
                    return coworker.SalaryPerHour;
                default:
                    return null;
            }
        }

        private void clearListbtn_Click(object sender, EventArgs e)
        {
            coworkersList.Clear();
            dataGridView1.Rows.Clear();
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                // Заміна крапки на кому
                e.KeyChar = ',';
            }
        }

    }
}
