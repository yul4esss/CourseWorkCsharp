namespace CourseWorkC_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.countSalarybtn = new System.Windows.Forms.Button();
            this.clearListbtn = new System.Windows.Forms.Button();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMiddlename = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblTablenumber = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.lblHoursworker = new System.Windows.Forms.Label();
            this.lblSalaryPerHour = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.txtTableNumber = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtExperience = new System.Windows.Forms.TextBox();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.txtSalaryPerHour = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.findCoworker = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(583, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(849, 396);
            this.dataGridView1.TabIndex = 1;
            // 
            // countSalarybtn
            // 
            this.countSalarybtn.BackColor = System.Drawing.Color.SlateGray;
            this.countSalarybtn.Location = new System.Drawing.Point(663, 504);
            this.countSalarybtn.Name = "countSalarybtn";
            this.countSalarybtn.Size = new System.Drawing.Size(146, 53);
            this.countSalarybtn.TabIndex = 3;
            this.countSalarybtn.Text = "Розрахувати ЗП";
            this.countSalarybtn.UseVisualStyleBackColor = false;
            this.countSalarybtn.Click += new System.EventHandler(this.countSalarybtn_Click);
            // 
            // clearListbtn
            // 
            this.clearListbtn.BackColor = System.Drawing.Color.SlateGray;
            this.clearListbtn.Location = new System.Drawing.Point(940, 504);
            this.clearListbtn.Name = "clearListbtn";
            this.clearListbtn.Size = new System.Drawing.Size(146, 53);
            this.clearListbtn.TabIndex = 4;
            this.clearListbtn.Text = "Очистити список";
            this.clearListbtn.UseVisualStyleBackColor = false;
            this.clearListbtn.Click += new System.EventHandler(this.clearListbtn_Click);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblSurname.Location = new System.Drawing.Point(64, 51);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(70, 17);
            this.lblSurname.TabIndex = 5;
            this.lblSurname.Text = "Прізвище";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblName.Location = new System.Drawing.Point(64, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 17);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Ім\'я";
            // 
            // lblMiddlename
            // 
            this.lblMiddlename.AutoSize = true;
            this.lblMiddlename.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddlename.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblMiddlename.Location = new System.Drawing.Point(64, 145);
            this.lblMiddlename.Name = "lblMiddlename";
            this.lblMiddlename.Size = new System.Drawing.Size(86, 17);
            this.lblMiddlename.TabIndex = 7;
            this.lblMiddlename.Text = "По батькові";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblBirthDate.Location = new System.Drawing.Point(64, 186);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(210, 17);
            this.lblBirthDate.TabIndex = 8;
            this.lblBirthDate.Text = "Дата народження (дд.мм.рррр)";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblGender.Location = new System.Drawing.Point(64, 230);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(46, 17);
            this.lblGender.TabIndex = 9;
            this.lblGender.Text = "Стать";
            // 
            // lblTablenumber
            // 
            this.lblTablenumber.AutoSize = true;
            this.lblTablenumber.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablenumber.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblTablenumber.Location = new System.Drawing.Point(64, 273);
            this.lblTablenumber.Name = "lblTablenumber";
            this.lblTablenumber.Size = new System.Drawing.Size(125, 17);
            this.lblTablenumber.TabIndex = 10;
            this.lblTablenumber.Text = "Табельний номер";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblSalary.Location = new System.Drawing.Point(64, 315);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(49, 17);
            this.lblSalary.TabIndex = 11;
            this.lblSalary.Text = "Оклад";
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExperience.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblExperience.Location = new System.Drawing.Point(64, 351);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(92, 17);
            this.lblExperience.TabIndex = 12;
            this.lblExperience.Text = "Стаж роботи";
            // 
            // lblHoursworker
            // 
            this.lblHoursworker.AutoSize = true;
            this.lblHoursworker.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursworker.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblHoursworker.Location = new System.Drawing.Point(64, 386);
            this.lblHoursworker.Name = "lblHoursworker";
            this.lblHoursworker.Size = new System.Drawing.Size(215, 17);
            this.lblHoursworker.TabIndex = 13;
            this.lblHoursworker.Text = "Кількість відпрацьованих годин";
            // 
            // lblSalaryPerHour
            // 
            this.lblSalaryPerHour.AutoSize = true;
            this.lblSalaryPerHour.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryPerHour.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblSalaryPerHour.Location = new System.Drawing.Point(64, 424);
            this.lblSalaryPerHour.Name = "lblSalaryPerHour";
            this.lblSalaryPerHour.Size = new System.Drawing.Size(53, 17);
            this.lblSalaryPerHour.TabIndex = 14;
            this.lblSalaryPerHour.Text = "ЗП/год";
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSurname.Location = new System.Drawing.Point(295, 53);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(134, 20);
            this.txtSurname.TabIndex = 15;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtName.Location = new System.Drawing.Point(295, 95);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(134, 20);
            this.txtName.TabIndex = 16;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtMiddleName.Location = new System.Drawing.Point(295, 140);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(134, 20);
            this.txtMiddleName.TabIndex = 17;
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtBirthDate.Location = new System.Drawing.Point(295, 188);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(134, 20);
            this.txtBirthDate.TabIndex = 18;
            // 
            // txtTableNumber
            // 
            this.txtTableNumber.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtTableNumber.Location = new System.Drawing.Point(295, 272);
            this.txtTableNumber.Name = "txtTableNumber";
            this.txtTableNumber.Size = new System.Drawing.Size(134, 20);
            this.txtTableNumber.TabIndex = 20;
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSalary.Location = new System.Drawing.Point(295, 314);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(134, 20);
            this.txtSalary.TabIndex = 21;
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
            // 
            // txtExperience
            // 
            this.txtExperience.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtExperience.Location = new System.Drawing.Point(295, 350);
            this.txtExperience.Name = "txtExperience";
            this.txtExperience.Size = new System.Drawing.Size(134, 20);
            this.txtExperience.TabIndex = 22;
            this.txtExperience.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExperience_KeyPress);
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtHoursWorked.Location = new System.Drawing.Point(295, 385);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(134, 20);
            this.txtHoursWorked.TabIndex = 23;
            this.txtHoursWorked.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoursWorked_KeyPress);
            // 
            // txtSalaryPerHour
            // 
            this.txtSalaryPerHour.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSalaryPerHour.Location = new System.Drawing.Point(295, 423);
            this.txtSalaryPerHour.Name = "txtSalaryPerHour";
            this.txtSalaryPerHour.Size = new System.Drawing.Size(134, 20);
            this.txtSalaryPerHour.TabIndex = 24;
            this.txtSalaryPerHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalaryPerHour_KeyPress_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.Location = new System.Drawing.Point(58, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Додати співробітника";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.addCoworkerbtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateGray;
            this.button2.Location = new System.Drawing.Point(274, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 53);
            this.button2.TabIndex = 2;
            this.button2.Text = "Переглянути список";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.showListbtn_Click);
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(295, 232);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(134, 21);
            this.comboBox.TabIndex = 25;
            // 
            // findCoworker
            // 
            this.findCoworker.BackColor = System.Drawing.Color.SlateGray;
            this.findCoworker.Location = new System.Drawing.Point(1186, 504);
            this.findCoworker.Name = "findCoworker";
            this.findCoworker.Size = new System.Drawing.Size(142, 53);
            this.findCoworker.TabIndex = 26;
            this.findCoworker.Text = "Знайти співробітника";
            this.findCoworker.UseVisualStyleBackColor = false;
            this.findCoworker.Click += new System.EventHandler(this.findCoworker_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1472, 635);
            this.Controls.Add(this.findCoworker);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.txtSalaryPerHour);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.txtExperience);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtTableNumber);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblSalaryPerHour);
            this.Controls.Add(this.lblHoursworker);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblTablenumber);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblMiddlename);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.clearListbtn);
            this.Controls.Add(this.countSalarybtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Курсова робота С#";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button countSalarybtn;
        private System.Windows.Forms.Button clearListbtn;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMiddlename;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblTablenumber;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.Label lblHoursworker;
        private System.Windows.Forms.Label lblSalaryPerHour;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.TextBox txtTableNumber;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtExperience;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.TextBox txtSalaryPerHour;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button findCoworker;
    }
}

