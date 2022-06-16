
namespace pasvlas
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonOrders = new System.Windows.Forms.Button();
            this.buttonBio = new System.Windows.Forms.Button();
            this.buttonPatient = new System.Windows.Forms.Button();
            this.labelHello = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.buttonServices = new System.Windows.Forms.Button();
            this.buttonOtchets = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxAva = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOrders
            // 
            this.buttonOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.buttonOrders.FlatAppearance.BorderSize = 0;
            this.buttonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrders.Location = new System.Drawing.Point(12, 116);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(417, 48);
            this.buttonOrders.TabIndex = 0;
            this.buttonOrders.Text = "Заказы";
            this.buttonOrders.UseVisualStyleBackColor = false;
            this.buttonOrders.Click += new System.EventHandler(this.buttonPriem_Click);
            // 
            // buttonBio
            // 
            this.buttonBio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.buttonBio.FlatAppearance.BorderSize = 0;
            this.buttonBio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBio.Location = new System.Drawing.Point(12, 170);
            this.buttonBio.Name = "buttonBio";
            this.buttonBio.Size = new System.Drawing.Size(417, 48);
            this.buttonBio.TabIndex = 1;
            this.buttonBio.Text = "Биоматериалы";
            this.buttonBio.UseVisualStyleBackColor = false;
            this.buttonBio.Click += new System.EventHandler(this.buttonBio_Click);
            // 
            // buttonPatient
            // 
            this.buttonPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.buttonPatient.FlatAppearance.BorderSize = 0;
            this.buttonPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPatient.Location = new System.Drawing.Point(12, 224);
            this.buttonPatient.Name = "buttonPatient";
            this.buttonPatient.Size = new System.Drawing.Size(417, 48);
            this.buttonPatient.TabIndex = 2;
            this.buttonPatient.Text = "Пациенты";
            this.buttonPatient.UseVisualStyleBackColor = false;
            this.buttonPatient.Click += new System.EventHandler(this.buttonPatient_Click);
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Location = new System.Drawing.Point(112, 12);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(47, 23);
            this.labelHello.TabIndex = 3;
            this.labelHello.Text = "прив";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(112, 35);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(38, 23);
            this.labelType.TabIndex = 4;
            this.labelType.Text = "тип";
            // 
            // buttonServices
            // 
            this.buttonServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.buttonServices.FlatAppearance.BorderSize = 0;
            this.buttonServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonServices.Location = new System.Drawing.Point(12, 332);
            this.buttonServices.Name = "buttonServices";
            this.buttonServices.Size = new System.Drawing.Size(417, 48);
            this.buttonServices.TabIndex = 7;
            this.buttonServices.Text = "Услуги";
            this.buttonServices.UseVisualStyleBackColor = false;
            this.buttonServices.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOtchets
            // 
            this.buttonOtchets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.buttonOtchets.FlatAppearance.BorderSize = 0;
            this.buttonOtchets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOtchets.Location = new System.Drawing.Point(12, 278);
            this.buttonOtchets.Name = "buttonOtchets";
            this.buttonOtchets.Size = new System.Drawing.Size(417, 48);
            this.buttonOtchets.TabIndex = 6;
            this.buttonOtchets.Text = "Отчеты";
            this.buttonOtchets.UseVisualStyleBackColor = false;
            this.buttonOtchets.Click += new System.EventHandler(this.buttonOtchets_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.White;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(176, 61);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(253, 48);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pasvlas.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(112, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxAva
            // 
            this.pictureBoxAva.Image = global::pasvlas.Properties.Resources.laborant_1;
            this.pictureBoxAva.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAva.Name = "pictureBoxAva";
            this.pictureBoxAva.Size = new System.Drawing.Size(94, 98);
            this.pictureBoxAva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAva.TabIndex = 5;
            this.pictureBoxAva.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(443, 396);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonServices);
            this.Controls.Add(this.buttonOtchets);
            this.Controls.Add(this.pictureBoxAva);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.buttonPatient);
            this.Controls.Add(this.buttonBio);
            this.Controls.Add(this.buttonOrders);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Button buttonBio;
        private System.Windows.Forms.Button buttonPatient;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.PictureBox pictureBoxAva;
        private System.Windows.Forms.Button buttonServices;
        private System.Windows.Forms.Button buttonOtchets;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExit;
    }
}