namespace RentACar
{
    partial class FormAddCar
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Brands = new System.Windows.Forms.ComboBox();
            this.cb_Models = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Types = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.num_Year = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_RegPlate = new System.Windows.Forms.MaskedTextBox();
            this.num_Engine = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Fuel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pic_Car = new System.Windows.Forms.PictureBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_InsertPic = new System.Windows.Forms.Button();
            this.btn_RemovePic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_Year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Engine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Car)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka";
            // 
            // cb_Brands
            // 
            this.cb_Brands.AccessibleDescription = "cb_Brands";
            this.cb_Brands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Brands.FormattingEnabled = true;
            this.cb_Brands.Location = new System.Drawing.Point(128, 26);
            this.cb_Brands.Name = "cb_Brands";
            this.cb_Brands.Size = new System.Drawing.Size(121, 21);
            this.cb_Brands.TabIndex = 1;
            // 
            // cb_Models
            // 
            this.cb_Models.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Models.FormattingEnabled = true;
            this.cb_Models.Location = new System.Drawing.Point(128, 66);
            this.cb_Models.Name = "cb_Models";
            this.cb_Models.Size = new System.Drawing.Size(121, 21);
            this.cb_Models.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model";
            // 
            // cb_Types
            // 
            this.cb_Types.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Types.FormattingEnabled = true;
            this.cb_Types.Location = new System.Drawing.Point(128, 109);
            this.cb_Types.Name = "cb_Types";
            this.cb_Types.Size = new System.Drawing.Size(121, 21);
            this.cb_Types.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Typ własności";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rok produkcji";
            // 
            // num_Year
            // 
            this.num_Year.Location = new System.Drawing.Point(129, 151);
            this.num_Year.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.num_Year.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.num_Year.Name = "num_Year";
            this.num_Year.Size = new System.Drawing.Size(120, 20);
            this.num_Year.TabIndex = 7;
            this.num_Year.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Numer rejestracyjny";
            // 
            // tb_RegPlate
            // 
            this.tb_RegPlate.Location = new System.Drawing.Point(149, 194);
            this.tb_RegPlate.Mask = ">Aaaaaaaa";
            this.tb_RegPlate.Name = "tb_RegPlate";
            this.tb_RegPlate.Size = new System.Drawing.Size(100, 20);
            this.tb_RegPlate.TabIndex = 9;
            this.tb_RegPlate.ValidatingType = typeof(int);
            this.tb_RegPlate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_RegPlate_KeyPress);
            // 
            // num_Engine
            // 
            this.num_Engine.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.num_Engine.Location = new System.Drawing.Point(129, 236);
            this.num_Engine.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.num_Engine.Minimum = new decimal(new int[] {
            650,
            0,
            0,
            0});
            this.num_Engine.Name = "num_Engine";
            this.num_Engine.Size = new System.Drawing.Size(120, 20);
            this.num_Engine.TabIndex = 11;
            this.num_Engine.Value = new decimal(new int[] {
            1598,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pojemność silnika";
            // 
            // cb_Fuel
            // 
            this.cb_Fuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Fuel.FormattingEnabled = true;
            this.cb_Fuel.Items.AddRange(new object[] {
            "PB",
            "ON",
            "LPG"});
            this.cb_Fuel.Location = new System.Drawing.Point(128, 278);
            this.cb_Fuel.Name = "cb_Fuel";
            this.cb_Fuel.Size = new System.Drawing.Size(121, 21);
            this.cb_Fuel.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Paliwo";
            // 
            // pic_Car
            // 
            this.pic_Car.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Car.Location = new System.Drawing.Point(310, 17);
            this.pic_Car.Name = "pic_Car";
            this.pic_Car.Size = new System.Drawing.Size(300, 300);
            this.pic_Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Car.TabIndex = 14;
            this.pic_Car.TabStop = false;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(94, 340);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 15;
            this.btn_OK.Text = "Zapisz";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(418, 340);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 16;
            this.btn_Cancel.Text = "Anuluj";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_InsertPic
            // 
            this.btn_InsertPic.Location = new System.Drawing.Point(647, 208);
            this.btn_InsertPic.Name = "btn_InsertPic";
            this.btn_InsertPic.Size = new System.Drawing.Size(99, 23);
            this.btn_InsertPic.TabIndex = 17;
            this.btn_InsertPic.Text = "Załaduj obraz";
            this.btn_InsertPic.UseVisualStyleBackColor = true;
            this.btn_InsertPic.Click += new System.EventHandler(this.btn_InsertPic_Click);
            // 
            // btn_RemovePic
            // 
            this.btn_RemovePic.Location = new System.Drawing.Point(647, 272);
            this.btn_RemovePic.Name = "btn_RemovePic";
            this.btn_RemovePic.Size = new System.Drawing.Size(99, 23);
            this.btn_RemovePic.TabIndex = 18;
            this.btn_RemovePic.Text = " Usuń obraz";
            this.btn_RemovePic.UseVisualStyleBackColor = true;
            this.btn_RemovePic.Click += new System.EventHandler(this.btn_RemovePic_Click);
            // 
            // FormAddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(765, 382);
            this.Controls.Add(this.btn_RemovePic);
            this.Controls.Add(this.btn_InsertPic);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.pic_Car);
            this.Controls.Add(this.cb_Fuel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.num_Engine);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_RegPlate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num_Year);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_Types);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Models);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Brands);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddCar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj samochód";
            this.Load += new System.EventHandler(this.FormAddCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_Year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Engine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Car)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Brands;
        private System.Windows.Forms.ComboBox cb_Models;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Types;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_Year;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox tb_RegPlate;
        private System.Windows.Forms.NumericUpDown num_Engine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_Fuel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pic_Car;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_InsertPic;
        private System.Windows.Forms.Button btn_RemovePic;
    }
}