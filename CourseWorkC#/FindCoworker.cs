using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CourseWorkC_.Form1;


namespace CourseWorkC_
{
    public partial class FindCoworker : Form
    {
        // Створюємо екземпляр класу та передамо його у конструктор FindCoworker для використання методу FindCoworkerByTableNumber, 
        // оскільки ми викликаємо нестатичний метод
        private Form1 form1;

        public FindCoworker(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        // Кнопка закриття форми
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Кнопка для пошуку співробітника за введеним табличним номером
        private void btnFindCoworker_Click(object sender, EventArgs e)
        {
            try
            {
                int value;
                if (!int.TryParse(txtTableNumber.Text, out value) || value < 0)
                    {
                        throw new CustomException($"Неправильний формат введеного значення");
                    }

                // Створення об'єкта класу Coworker, якому присвоюємо значення із текстового поля
                Coworker coworker = form1.FindCoworkerByTableNumber(value);

                // Якщо працівника знайдено, то виводимо дані про нього за допомогою перевантаження методу для виводу даних
                if (coworker != null)
                {
                    MessageBox.Show(coworker.ToString());
                }
                else
                {
                    // Якщо ж об'єкт не містить такого табличного номеру, виводимо наступне повідомлення
                    MessageBox.Show("Співробітник не знайдений");
                }
            } catch (CustomException ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
