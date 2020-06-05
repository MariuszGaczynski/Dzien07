using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Person> persons = new List<Person>();

        private void Form1_Load(object sender, EventArgs e)
        {
            persons.Add(new Person ("Jan", "Kowalski", 55, "Zdun", false));
            persons.Add(new Person ("Marek", "Nowak", 35, "Social Media Ninja", true));
            persons.Add(new Person ("Emil", "Zatopek", 66, "Biegacz", true));
            persons.Add(new Person ("Zenek", "Martyniuk", 51, "Piosenkarz", false));

            //foreach (Person item in persons)
            //{
            //    lb_Persons.Items.Add(item.FName + " " + item.LName);
            //}

            // DataBinding  - listbox

            lb_Persons.DataSource = persons;
            lb_Persons.DisplayMember =  "FullName";

            // DataBinding dla textBoxów

            tb_FName.DataBindings.Add(new Binding("Text", lb_Persons.DataSource, "FName"));
            
            tb_LName.DataBindings.Add(new Binding("Text", lb_Persons.DataSource, "LName"));
            tb_Age.DataBindings.Add(new Binding("Text", lb_Persons.DataSource, "Age"));
            tb_Job.DataBindings.Add(new Binding("Text", lb_Persons.DataSource, "Job"));

            tb_LName.DataBindings.Add(new Binding("Enabled", lb_Persons.DataSource, "Active"));
            tb_FName.DataBindings.Add(new Binding("Enabled", lb_Persons.DataSource, "Active"));
            tb_Age.DataBindings.Add(new Binding("Enabled", lb_Persons.DataSource, "Active"));
            tb_Job.DataBindings.Add(new Binding("Enabled", lb_Persons.DataSource, "Active"));




        }

        private void lb_Persons_SelectedIndexChanged(object sender, EventArgs e)
        {

            //int index = lb_Persons.SelectedIndex;

            //if (index >= 0)
            //{
            //    tb_FName.Text = persons[index].FName;
            //    tb_LName.Text = persons[index].LName;
            //    tb_Age.Text = persons[index].Age.ToString();
            //    tb_Job.Text = persons[index].Job;
            //}


        }
    }
}
