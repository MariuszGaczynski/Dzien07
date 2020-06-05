namespace DataBindExample
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
            this.lb_Persons = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_FName = new System.Windows.Forms.TextBox();
            this.tb_LName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Job = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Age = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Persons
            // 
            this.lb_Persons.FormattingEnabled = true;
            this.lb_Persons.Location = new System.Drawing.Point(21, 12);
            this.lb_Persons.Name = "lb_Persons";
            this.lb_Persons.Size = new System.Drawing.Size(340, 290);
            this.lb_Persons.TabIndex = 0;
            this.lb_Persons.SelectedIndexChanged += new System.EventHandler(this.lb_Persons_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imię";
            // 
            // tb_FName
            // 
            this.tb_FName.Location = new System.Drawing.Point(384, 43);
            this.tb_FName.Name = "tb_FName";
            this.tb_FName.Size = new System.Drawing.Size(176, 20);
            this.tb_FName.TabIndex = 2;
            // 
            // tb_LName
            // 
            this.tb_LName.Location = new System.Drawing.Point(384, 98);
            this.tb_LName.Name = "tb_LName";
            this.tb_LName.Size = new System.Drawing.Size(176, 20);
            this.tb_LName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwisko";
            // 
            // tb_Job
            // 
            this.tb_Job.Location = new System.Drawing.Point(384, 208);
            this.tb_Job.Name = "tb_Job";
            this.tb_Job.Size = new System.Drawing.Size(176, 20);
            this.tb_Job.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Zawód";
            // 
            // tb_Age
            // 
            this.tb_Age.Location = new System.Drawing.Point(384, 153);
            this.tb_Age.Name = "tb_Age";
            this.tb_Age.Size = new System.Drawing.Size(176, 20);
            this.tb_Age.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Wiek";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 322);
            this.Controls.Add(this.tb_Job);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Age);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_LName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_FName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Persons);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Persons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_FName;
        private System.Windows.Forms.TextBox tb_LName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Job;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Age;
        private System.Windows.Forms.Label label4;
    }
}

