namespace pasvlas
{
    partial class Patient
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.listViewPatient = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.login = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pasport = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.polisy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPasport = new System.Windows.Forms.TextBox();
            this.labelPasport = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxStrah = new System.Windows.Forms.TextBox();
            this.labelStrah = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(204, 98);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(186, 30);
            this.textBoxPass.TabIndex = 24;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelPass.Location = new System.Drawing.Point(200, 71);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(69, 23);
            this.labelPass.TabIndex = 23;
            this.labelPass.Text = "Пароль";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(204, 38);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(186, 30);
            this.textBoxLogin.TabIndex = 22;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelLogin.Location = new System.Drawing.Point(200, 11);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(58, 23);
            this.labelLogin.TabIndex = 21;
            this.labelLogin.Text = "Логин";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(12, 98);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(186, 30);
            this.textBoxSurname.TabIndex = 20;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSurname.Location = new System.Drawing.Point(8, 71);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(78, 23);
            this.labelSurname.TabIndex = 19;
            this.labelSurname.Text = "Фамилия";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 38);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(186, 30);
            this.textBoxName.TabIndex = 18;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelName.Location = new System.Drawing.Point(8, 11);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(42, 23);
            this.labelName.TabIndex = 17;
            this.labelName.Text = "Имя";
            this.labelName.Click += new System.EventHandler(this.labelCode_Click);
            // 
            // listViewPatient
            // 
            this.listViewPatient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.surname,
            this.login,
            this.password,
            this.date,
            this.pasport,
            this.phone,
            this.email,
            this.polisy});
            this.listViewPatient.FullRowSelect = true;
            this.listViewPatient.GridLines = true;
            this.listViewPatient.HideSelection = false;
            this.listViewPatient.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewPatient.Location = new System.Drawing.Point(12, 236);
            this.listViewPatient.Name = "listViewPatient";
            this.listViewPatient.Size = new System.Drawing.Size(792, 204);
            this.listViewPatient.TabIndex = 16;
            this.listViewPatient.UseCompatibleStateImageBehavior = false;
            this.listViewPatient.View = System.Windows.Forms.View.Details;
            this.listViewPatient.SelectedIndexChanged += new System.EventHandler(this.listViewService_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "Id";
            this.id.Width = 33;
            // 
            // name
            // 
            this.name.Text = "Имя";
            this.name.Width = 49;
            // 
            // surname
            // 
            this.surname.Text = "Фамилия";
            this.surname.Width = 82;
            // 
            // login
            // 
            this.login.Text = "Логин";
            this.login.Width = 63;
            // 
            // password
            // 
            this.password.Text = "Пароль";
            this.password.Width = 76;
            // 
            // date
            // 
            this.date.Text = "Дата рождения";
            this.date.Width = 116;
            // 
            // pasport
            // 
            this.pasport.Text = "Серия и № паспорта";
            this.pasport.Width = 145;
            // 
            // phone
            // 
            this.phone.Text = "Телефон";
            this.phone.Width = 78;
            // 
            // email
            // 
            this.email.Text = "e-mail";
            // 
            // polisy
            // 
            this.polisy.Text = "№ страхового полиса";
            this.polisy.Width = 86;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonEdit.Location = new System.Drawing.Point(588, 98);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(112, 30);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.buttonDel.FlatAppearance.BorderSize = 0;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDel.Location = new System.Drawing.Point(588, 158);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(112, 30);
            this.buttonDel.TabIndex = 14;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonAdd.Location = new System.Drawing.Point(588, 38);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(112, 30);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelEmail.Location = new System.Drawing.Point(200, 131);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(56, 23);
            this.labelEmail.TabIndex = 32;
            this.labelEmail.Text = "E-mail";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelPhone.Location = new System.Drawing.Point(8, 131);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(78, 23);
            this.labelPhone.TabIndex = 30;
            this.labelPhone.Text = "Телефон";
            // 
            // textBoxPasport
            // 
            this.textBoxPasport.Location = new System.Drawing.Point(396, 98);
            this.textBoxPasport.MaxLength = 10;
            this.textBoxPasport.Name = "textBoxPasport";
            this.textBoxPasport.Size = new System.Drawing.Size(186, 30);
            this.textBoxPasport.TabIndex = 29;
            this.textBoxPasport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPasport_KeyPress);
            // 
            // labelPasport
            // 
            this.labelPasport.AutoSize = true;
            this.labelPasport.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelPasport.Location = new System.Drawing.Point(392, 71);
            this.labelPasport.Name = "labelPasport";
            this.labelPasport.Size = new System.Drawing.Size(169, 23);
            this.labelPasport.TabIndex = 28;
            this.labelPasport.Text = "Серия и № паспорта";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDate.Location = new System.Drawing.Point(392, 12);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(124, 23);
            this.labelDate.TabIndex = 26;
            this.labelDate.Text = "Дата рождения";
            this.labelDate.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxStrah
            // 
            this.textBoxStrah.Location = new System.Drawing.Point(396, 158);
            this.textBoxStrah.MaxLength = 16;
            this.textBoxStrah.Name = "textBoxStrah";
            this.textBoxStrah.Size = new System.Drawing.Size(186, 30);
            this.textBoxStrah.TabIndex = 35;
            this.textBoxStrah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStrah_KeyPress);
            // 
            // labelStrah
            // 
            this.labelStrah.AutoSize = true;
            this.labelStrah.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelStrah.Location = new System.Drawing.Point(392, 131);
            this.labelStrah.Name = "labelStrah";
            this.labelStrah.Size = new System.Drawing.Size(179, 23);
            this.labelStrah.TabIndex = 34;
            this.labelStrah.Text = "№ страхового полиса";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(396, 38);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(186, 30);
            this.dateTimePicker.TabIndex = 36;
            this.dateTimePicker.Value = new System.DateTime(2022, 6, 16, 0, 0, 0, 0);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(148, 200);
            this.textBoxSearch.MaxLength = 11;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(656, 30);
            this.textBoxSearch.TabIndex = 38;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSearch.Location = new System.Drawing.Point(8, 203);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(134, 23);
            this.labelSearch.TabIndex = 39;
            this.labelSearch.Text = "Найти пациента";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(12, 158);
            this.textBoxPhone.Mask = "+7(999)-000-00-00";
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(186, 30);
            this.textBoxPhone.TabIndex = 40;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(204, 158);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(186, 30);
            this.textBoxEmail.TabIndex = 33;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::pasvlas.Properties.Resources.logo;
            this.pictureBoxLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxLogo.Location = new System.Drawing.Point(706, 38);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(98, 150);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 25;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 452);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBoxStrah);
            this.Controls.Add(this.labelStrah);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxPasport);
            this.Controls.Add(this.labelPasport);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.listViewPatient);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пациенты";
            this.Load += new System.EventHandler(this.Patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ListView listViewPatient;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader surname;
        private System.Windows.Forms.ColumnHeader login;
        private System.Windows.Forms.ColumnHeader password;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader pasport;
        private System.Windows.Forms.ColumnHeader phone;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader polisy;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPasport;
        private System.Windows.Forms.Label labelPasport;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxStrah;
        private System.Windows.Forms.Label labelStrah;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.MaskedTextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
    }
}