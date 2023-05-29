using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
