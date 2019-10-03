namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.EditSwitch = new System.Windows.Forms.Button();
            this.dbSwitch = new System.Windows.Forms.Button();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.paneldb = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelMenu.SuspendLayout();
            this.panelEdit.SuspendLayout();
            this.paneldb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.EditSwitch);
            this.panelMenu.Controls.Add(this.dbSwitch);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(157, 415);
            this.panelMenu.TabIndex = 0;
            // 
            // EditSwitch
            // 
            this.EditSwitch.FlatAppearance.BorderSize = 0;
            this.EditSwitch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.EditSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditSwitch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditSwitch.ForeColor = System.Drawing.Color.White;
            this.EditSwitch.Location = new System.Drawing.Point(11, 117);
            this.EditSwitch.Name = "EditSwitch";
            this.EditSwitch.Size = new System.Drawing.Size(132, 36);
            this.EditSwitch.TabIndex = 0;
            this.EditSwitch.Text = "Редактировать";
            this.EditSwitch.UseVisualStyleBackColor = true;
            // 
            // dbSwitch
            // 
            this.dbSwitch.FlatAppearance.BorderSize = 0;
            this.dbSwitch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.dbSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dbSwitch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dbSwitch.ForeColor = System.Drawing.Color.White;
            this.dbSwitch.Location = new System.Drawing.Point(11, 162);
            this.dbSwitch.Name = "dbSwitch";
            this.dbSwitch.Size = new System.Drawing.Size(132, 36);
            this.dbSwitch.TabIndex = 0;
            this.dbSwitch.Text = "База Данных";
            this.dbSwitch.UseVisualStyleBackColor = true;
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.dtpDate);
            this.panelEdit.Controls.Add(this.DeleteButton);
            this.panelEdit.Controls.Add(this.EditButton);
            this.panelEdit.Controls.Add(this.AddButton);
            this.panelEdit.Controls.Add(this.cmbGender);
            this.panelEdit.Controls.Add(this.cmbStatus);
            this.panelEdit.Controls.Add(this.label6);
            this.panelEdit.Controls.Add(this.txt_Phone);
            this.panelEdit.Controls.Add(this.label4);
            this.panelEdit.Controls.Add(this.txtName);
            this.panelEdit.Controls.Add(this.txt_LastName);
            this.panelEdit.Controls.Add(this.label5);
            this.panelEdit.Controls.Add(this.label7);
            this.panelEdit.Controls.Add(this.label2);
            this.panelEdit.Controls.Add(this.label3);
            this.panelEdit.Controls.Add(this.textBox1);
            this.panelEdit.Controls.Add(this.label1);
            this.panelEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEdit.Location = new System.Drawing.Point(157, 0);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(627, 415);
            this.panelEdit.TabIndex = 1;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(338, 226);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(208, 23);
            this.dtpDate.TabIndex = 4;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.SteelBlue;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(353, 304);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(129, 38);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.SteelBlue;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Location = new System.Drawing.Point(218, 304);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(129, 38);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.SteelBlue;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(83, 304);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(129, 38);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.cmbGender.Location = new System.Drawing.Point(338, 163);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(208, 25);
            this.cmbGender.TabIndex = 2;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Свободен (-а)",
            "Занят (-а)"});
            this.cmbStatus.Location = new System.Drawing.Point(83, 224);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(208, 25);
            this.cmbStatus.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Год рождения:";
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(338, 113);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(208, 23);
            this.txt_Phone.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Статус:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(83, 113);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 23);
            this.txtName.TabIndex = 1;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(83, 165);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(208, 23);
            this.txt_LastName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Пол:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Номер телефона:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Фамилия:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // paneldb
            // 
            this.paneldb.BackColor = System.Drawing.SystemColors.Control;
            this.paneldb.Controls.Add(this.label8);
            this.paneldb.Controls.Add(this.txt_Search);
            this.paneldb.Controls.Add(this.dataGridView1);
            this.paneldb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldb.Location = new System.Drawing.Point(157, 0);
            this.paneldb.Name = "paneldb";
            this.paneldb.Size = new System.Drawing.Size(627, 415);
            this.paneldb.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Поиск:";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(382, 29);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(233, 23);
            this.txt_Search.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(627, 302);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 415);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.paneldb);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программа";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.paneldb.ResumeLayout(false);
            this.paneldb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button dbSwitch;
        private System.Windows.Forms.Button EditSwitch;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Panel paneldb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

