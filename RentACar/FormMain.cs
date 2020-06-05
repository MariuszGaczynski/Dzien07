using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

        }

        private void mmu_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ts_Info.Text = "Oczekuję na połączenie...";
        }

        private void mmu_Login_Click(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            if (form.ShowDialog()== DialogResult.OK)
            {
                ts_Info.Text = "Połączono z bazą danych";
                mmu_CarRent.Enabled = true;
            }
        }

        private void mmu_CarList_Click(object sender, EventArgs e)
        {
            FormCarList form = new FormCarList();
            form.ShowDialog();
        }
    }
}
