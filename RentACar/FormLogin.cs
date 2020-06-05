using MySql.Data.MySqlClient;
using RentACar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //string cs = "Server=127.0.0.1;Port = 3306; Database=rent_a_car; Uid = {0}; Pwd = {1}";

            string cs = ConfigurationManager.AppSettings["cs"];

            try
            {

                if(String.IsNullOrWhiteSpace(tb_Login.Text)|| String.IsNullOrWhiteSpace(tb_Password.Text))
                {
                    DialogHelper.E("Podaj dane do logowania");
                    return;
                }

                // zmiana kursora na kręciołkę

                Cursor.Current = Cursors.WaitCursor;

                cs = string.Format(cs, tb_Login.Text.Trim(), tb_Password.Text.Trim());
                GlobalData.connection = new MySqlConnection(cs);
                GlobalData.connection.Open();

                this.DialogResult = DialogResult.OK;

                Close();
            }
            catch(Exception exc)
            {
                DialogHelper.E(exc.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

        }
    }
}
