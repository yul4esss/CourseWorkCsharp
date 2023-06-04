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

        // Оголошення списку співробітників
        private List<Coworker> coworkersList;


        private Salary salaryCalculator;

        public Form1()
        {
            InitializeComponent();

            // Додавання елементів до comboBox для визначення статі, встановлення випадаючого списку
            comboBox.Items.Add("Ж");
            comboBox.Items.Add("Ч");
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            // Створення списку співробітників
            coworkersList = new List<Coworker>();

            // Додаємо ініціалізовані об'єкти до таблиці
            addObjectsToList();

            // Створення масиву співробітників для яких потрібно розраховувати зарплату
            salaryCalculator = new Salary(coworkersList.Count);

            // Додаємо співробітників у список
            foreach (var coworker in coworkersList)
            {
                salaryCalculator.AddCoworkerToList(coworker);
            }

            // Можливість редагування даних безпосередньо у таблиці. Оновлення таблиці
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;

            // Додавання стовпців
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

            // Встановлення автоматичного розміру стовпців
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

            // Додаємо стовпець для обрахунку зарплати
            dataGridView1.Columns["Зарплата"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Додавання нових працівників у список
            for (int i = 0; i < coworkersList.Count; i++)
            {
                Coworker coworker = coworkersList[i];
                dataGridView1.Rows.Add(coworker.TableNumber, coworker.Surname, coworker.Name, coworker.MiddleName, coworker.BirthDate, coworker.Gender, coworker.Salary, coworker.Experience, coworker.HoursWorked, coworker.SalaryPerHour);
            }
        }

        // Додавання ініціалізованих об'єктів у таблицю для попереднього відображення
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

        // Кнопка для показу списку, або ж щоб його приховати
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

        // Кнопка для додавання нових працівників до списку
        private void addCoworkerbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Coworker coworker = new Coworker();

                // Перевірка на те чи заповнені поля ПІБ та дати народження. Якщо не заповнене, значення встановлюється як незаповнене,
                // а якщо поле є заповнене, тоді записуємо значення у рядок
                coworker.Surname = string.IsNullOrEmpty(txtSurname.Text) ? string.Empty : txtSurname.Text;
                coworker.Name = string.IsNullOrEmpty(txtName.Text) ? string.Empty : txtName.Text;
                coworker.MiddleName = string.IsNullOrEmpty(txtMiddleName.Text) ? string.Empty : txtMiddleName.Text;
                coworker.BirthDate = string.IsNullOrEmpty(txtBirthDate.Text) ? string.Empty : txtBirthDate.Text;

                // Встановлення статі працівника
                coworker.Gender = comboBox.SelectedItem as string;

                // Перевірка валідності введених даних. Аби введені значення не містили цифр
                if (!ValidateName(coworker.Surname) || !ValidateName(coworker.Name) || !ValidateName(coworker.MiddleName))
                {
                    throw new CustomException("Неправильний формат. Поле не повинно містити цифри");
                }

                // Перевірка формату дати народження
                if (!string.IsNullOrEmpty(txtBirthDate.Text))
                {
                    if (!ValidateDateFormat(txtBirthDate.Text))
                    {
                        throw new CustomException("Неправильний формат дати. Введіть значення у форматі 'дд.мм.рррр'.");
                    }
                    coworker.BirthDate = txtBirthDate.Text;
                }

                // Парсимо числові значення, у методі ParseIntValue та ParseDoubleValue перевіряємо чи значення містить букви
                coworker.TableNumber = ParseIntValue(txtTableNumber.Text, "Табличний номер");
                coworker.Salary = ParseDoubleValue(txtSalary.Text, "Оклад");
                coworker.Experience = ParseDoubleValue(txtExperience.Text, "Стаж роботи");
                coworker.HoursWorked = ParseDoubleValue(txtHoursWorked.Text, "Кількість відпрацьованих годин");
                coworker.SalaryPerHour = ParseDoubleValue(txtSalaryPerHour.Text, "ЗП/год");

                // Перевірка на те, що значення не можуть бути менше 0
                if (coworker.TableNumber < 0 || coworker.Salary < 0 || coworker.Experience < 0 || coworker.HoursWorked < 0 || coworker.SalaryPerHour < 0)
                {
                    throw new CustomException("Неправильний формат. Значення не може бути меншим за 0");
                }

                // Перевірка на те, чи є вже співробітник з таким табличним номером при додаванні
                if (coworkersList.Any(c => c.TableNumber == coworker.TableNumber))
                {
                    throw new CustomException("Співробітник з таким табличним номером вже існує. Змініть номер");
                }

                // Якщо всі значення встановлені правильно, тоді додаємо співробітника до списку
                dataGridView1.Rows.Add(coworker.TableNumber, coworker.Surname, coworker.Name, coworker.MiddleName, coworker.BirthDate, coworker.Gender, coworker.Salary, coworker.Experience, coworker.HoursWorked, coworker.SalaryPerHour);
                coworkersList.Add(coworker);
            }
            catch (CustomException ex)
            {
                // Обробка виключних ситуацій, описаних вище
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        // Перевірка формату дати
        private bool ValidateDateFormat(string date)
        {
            if (DateTime.TryParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                return true;
            }
            return false;
        }

        // Перевірка наявності цифр у полях Ім'я, Прізвище, По батькові
        private bool ValidateName(string name)
        {
            return !name.Any(char.IsDigit);
        }

        // Перевірка формату статі
        private bool ValidateGender(string gender)
        {
            return gender == "Ч" || gender == "Ж";
        }

        // Перевірка на те, чи є букви у числових полях
        private int ParseIntValue(string text, string fieldName)
        {
            int value;
            if (!int.TryParse(text, out value))
            {
                throw new CustomException($"Неправильний формат поля {fieldName}");
            }
            return value;
        }

        // Перевірка на те, чи є букви у числових полях
        private double ParseDoubleValue(string text, string fieldName)
        {
            double value;
            if (!double.TryParse(text, out value))
            {
                throw new CustomException($"Invalid {fieldName} format.");
            }
            return value;
        }

        // Кнопка для розрахунку зарплати
        private void countSalarybtn_Click(object sender, EventArgs e)
        {
            foreach (var coworker in coworkersList)
            {
                // Присвоюємо змінній salary повернене значення з методу CalculateSalary для кожного працівника у списку працівників
                double salary = salaryCalculator.CalculateSalary(coworker);
                string salaryString = salary.ToString("F2"); // Форматуємо значення до 2 знаків після коми
                dataGridView1.Rows[coworkersList.IndexOf(coworker)].Cells["Зарплата"].Value = salaryString; // Для кожного працівника присвоюється розраховане значення
            }
        }

        // Метод для редагування даних безпосередньо у таблиці
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Змінні, у яяких міститиметься індекс стовпця та рядка для якого відбулося редагування
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;

            // Перевіряємо чи клітинка знаходиться в допустимих межах для редагування та не виходить за межі таблиці
            if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count &&
                columnIndex >= 0 && columnIndex < dataGridView1.Columns.Count)
            {
                string columnName = dataGridView1.Columns[columnIndex].Name;
                string cellValue = dataGridView1.Rows[rowIndex].Cells[columnIndex].Value.ToString();

                // Перевірка правильності редагованих значень
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
                            MessageBox.Show("Значення не може бути меншим за 0");
                            dataGridView1.Rows[rowIndex].Cells[columnIndex].Value = GetOriginalValue(columnName, coworkersList[rowIndex]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неправильний формат. Будь ласка, введіть число");
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
                        MessageBox.Show("Поле не може містити цифр. Введіть правильне значення");
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
                        MessageBox.Show("Поле не може містити цифр. Введіть правильне значення");
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
                        MessageBox.Show("Поле не може містити цифр. Введіть правильне значення");
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
                        MessageBox.Show("Неправильний формат дати. Будь ласка, введіть у форматі 'дд.мм.рррр'");
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
                        MessageBox.Show("Неправильне значення. Введіть стать як 'Ч' або 'Ж'");
                        dataGridView1.Rows[rowIndex].Cells[columnIndex].Value = coworkersList[rowIndex].Gender;
                    }
                }
                else if (columnName == "Табельний номер")
                {
                    if (int.TryParse(cellValue, out int tableNumber))
                    {
                        if(tableNumber > 0)
                        {
                            coworkersList[rowIndex].TableNumber = tableNumber;
                        }
                        else
                        {
                            MessageBox.Show("Значення не може бути меншим за 0");
                            dataGridView1.Rows[rowIndex].Cells[columnIndex].Value = GetOriginalValue(columnName, coworkersList[rowIndex]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неправильний формат. Будь ласка, введіть число");
                        dataGridView1.Rows[rowIndex].Cells[columnIndex].Value = coworkersList[rowIndex].TableNumber;
                    }
                }
            }
        }


        // Це метод для отримання попередніх значень, якщо у таблиці при редагуванні нове значення було введено неправильно
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

        // Метод для очищення списку
        private void clearListbtn_Click(object sender, EventArgs e)
        {
            coworkersList.Clear();
            dataGridView1.Rows.Clear();
        }

        // Обробник подій, якщо користувач у числове поле введе . замість , значення все одно запишеться правильно
        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                // Заміна крапки на кому
                e.KeyChar = ',';
            }
        }

        private void txtSalaryPerHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                // Заміна крапки на кому
                e.KeyChar = ',';
            }
        }

        private void txtExperience_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                // Заміна крапки на кому
                e.KeyChar = ',';
            }
        }

        private void txtHoursWorked_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                // Заміна крапки на кому
                e.KeyChar = ',';
            }
        }

        private void txtSalaryPerHour_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                // Заміна крапки на кому
                e.KeyChar = ',';
            }
        }

        // Кнопка для пошуку співробітника
        private void findCoworker_Click(object sender, EventArgs e)
        {
            FindCoworker findCoworker = new FindCoworker(this);
            findCoworker.ShowDialog();
        }

        // Метод, який повертає першого знайденого співробітника за вказаним табельним номером
        public Coworker FindCoworkerByTableNumber(int tableNumber)
        {
            // с - кожен елемент списку у coworkersList, c.TableNumber - табличний номер кожного співробітника, який порівнюється із переданим у метод значенням
            // Якщо значення знайдено, повертаємо співробітника із даним номером
            return coworkersList.FirstOrDefault(c => c.TableNumber == tableNumber);
        }


    }
}
