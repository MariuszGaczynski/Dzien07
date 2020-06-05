using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class FormAddCar : Form
    {

        //pole przechowwyania ID rekordu
        public int RowId = 0;

        public FormAddCar()
        {
            InitializeComponent();
        }

        private void FormAddCar_Load(object sender, EventArgs e)
        {
            LoadDictionaryData();
            num_Year.Minimum = Convert.ToInt32(ConfigurationManager.AppSettings["minYear"]);
            num_Year.Maximum = Convert.ToInt32(ConfigurationManager.AppSettings["maxYear"]);

            try
            {

                if (RowId > 0)
                {
                    //wczytaj dane edytowanego rekorsu o pokaz w kontrolkach

                    //   SELECT c.*, m.brand_id FROM cars c AS, car_models m WHERE c.id = 8 AND c.model_id = m.id
                    string sql = @"SELECT c.*, m.brand_id FROM cars c , car_models m 
                          WHERE c.id = {0} AND c.model_id = m.id";

                    sql = string.Format(sql, RowId);

                    MySqlCommand cmd = new MySqlCommand(sql, GlobalData.connection);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        // odczytwanie danych
                        num_Engine.Value = Convert.ToInt32(reader["engine"]);
                        num_Year.Value = Convert.ToInt32(reader["manufacturer_year"]);
                        tb_RegPlate.Text = reader["registration_plate"].ToString();
                        cb_Fuel.SelectedIndex = cb_Fuel.Items.IndexOf(reader["fuel"]);
                        cb_Brands.SelectedValue = reader["brand_id"];
                        cb_Models.SelectedValue = reader["model_id"];
                        cb_Types.SelectedValue = reader["type_id"];

                        cb_Models.Enabled = true;

                        if (!(reader["image"] is DBNull))
                        {
                            byte[] b = (byte[])reader["image"];

                            if (b != null && b.Length > 0)
                            {
                                using (MemoryStream ms = new MemoryStream(b))
                                {
                                    pic_Car.Image = Image.FromStream(ms);
                                }
                            }
                        }



                        // zamknąć readera
                        reader.Close();
                    }

                }
            }
            catch (Exception exc)
            {
                DialogHelper.E  (exc.Message);
            }

                

                if (RowId >0)
                {
                    btn_OK.Text = "Zapisz zmiany";
                    Text = "Edycja Pojazdu";
                }
                else
                {
                    btn_OK.Text = "Dodaj";
                    Text = "Nowy pojazd";
                }
            
        }

        BindingSource bsBrands = new BindingSource();
        BindingSource bsModels = new BindingSource();
        BindingSource bsTypes = new BindingSource();


        private void LoadDictionaryData()
        {
            

            try
            {
                // ładowanie słownika marek (brendów)
                
                String sql = " select id, name FROM car_brands ORDER BY name  ";

                //MySqlDataAdapter adapter = new MySqlDataAdapter();
                //adapter.SelectCommand = new MySqlCommand(sql, GlobalData.connection);
                //DataTable dt = new DataTable();
                //adapter.Fill(dt);

                DataTable dt = GlobalData.DataTableFiller(sql, "");

                bsBrands.DataSource = dt;
                cb_Brands.DataSource = bsBrands;
                cb_Brands.DisplayMember = "name";
                cb_Brands.ValueMember = "id";
                cb_Brands.SelectedIndex = -1;
                cb_Brands.SelectedIndexChanged += Cb_Brands_SelectedIndexChanged;

                //ładowanie słownika modeli
                sql = "SELECT * FROM car_models ORDER BY NAME ";
                //adapter = new MySqlDataAdapter();
                //adapter.SelectCommand = new MySqlCommand(sql, GlobalData.connection);
                //dt = new DataTable();
                //adapter.Fill(dt);

                dt = GlobalData.DataTableFiller(sql, "");

                bsModels.DataSource = dt;
                cb_Models.DataSource = bsModels;
                cb_Models.DisplayMember = "name";
                cb_Models.ValueMember = "id";
                cb_Models.SelectedIndex = -1;
                cb_Models.Enabled = false;

                //ładowanie słownika własnosci

                //sql = "SELECT * FROM car_types ORDER BY NAME ";
                //adapter = new MySqlDataAdapter();
                //adapter.SelectCommand = new MySqlCommand(sql, GlobalData.connection);
                //dt = new DataTable();
                //adapter.Fill(dt);

                dt = GlobalData.DataTableFiller(sql, "");

                bsTypes.DataSource = dt;
                cb_Types.DataSource = bsTypes;
                cb_Types.DisplayMember = "name";
                cb_Types.ValueMember = "id";
                cb_Types.SelectedIndex = -1;

            }
            catch (Exception exc)
            {
                DialogHelper.E(exc.Message);
            }
        }


        private void Cb_Brands_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Brands.SelectedIndex > -1)
            {
                bsModels.Filter = "brand_id=" + cb_Brands.SelectedValue;
                cb_Models.DataSource = bsModels;
                cb_Models.Enabled = true;
                cb_Models.SelectedIndex = -1;
            }

        }
        private void tb_RegPlate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private string pictureFileName = null;

        private void btn_InsertPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Pliki graficzne|*.png;*.jpg;*.jpeg;*.bmp|Pliki GIF|*.gif";
            
            if (dialog.ShowDialog()== DialogResult.OK)
            {
                //ładujemy plil

                pic_Car.Image = new Bitmap(dialog.FileName);
                pictureFileName = dialog.FileName;
            }
        }

        private void btn_RemovePic_Click(object sender, EventArgs e)
        {
            if (pic_Car != null)
            {
                pic_Car.Image.Dispose();
                pic_Car.Image = null;
                pictureFileName = null;
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                //zapis do bazy
                SaveData();
            }
        }

        private void SaveData()
        {
            try
            {
                string sql = "";

                if (RowId > 0)
                {
                    sql = @"UPDATE cars SET model_id=@model_id, type_id=@type_id,registration_plate=@reg_plate,
                        engine=@engine, manufacturer_year=@year, fuel= @fuel, image= @image
                        WHERE id=@row_id";
                }
                else
                {
                    sql = @"INSERT INTO cars (model_id, type_id,registration_plate, engine, manufacturer_year,
                avail, image, fuel) VALUES(@model_id, @type_id, @reg_plate, @engine, @year,
                1, @image, @fuel)";
                }



                MySqlCommand cmd = new MySqlCommand(sql, GlobalData.connection);

                cmd.Parameters.Add("@model_id", MySqlDbType.Int32);
                cmd.Parameters.Add("@type_id", MySqlDbType.Int32);
                cmd.Parameters.Add("@reg_plate", MySqlDbType.VarChar, 50);
                cmd.Parameters.Add("@engine", MySqlDbType.Int32);
                cmd.Parameters.Add("@year", MySqlDbType.Int32);
                cmd.Parameters.Add("@fuel", MySqlDbType.VarChar, 10);
                cmd.Parameters.Add("@image", MySqlDbType.MediumBlob);
                cmd.Parameters.Add("@row_id", MySqlDbType.Int32);

                cmd.Parameters["@model_id"].Value = cb_Models.SelectedValue;
                cmd.Parameters["@type_id"].Value = cb_Types.SelectedValue;
                cmd.Parameters["@reg_plate"].Value = tb_RegPlate.Text.Trim();
                cmd.Parameters["@engine"].Value = num_Engine.Value;
                cmd.Parameters["@year"].Value = num_Year.Value;
                cmd.Parameters["@fuel"].Value = cb_Fuel.SelectedItem;
                cmd.Parameters["@row_id"].Value = RowId;

                if (pictureFileName != null && File.Exists(pictureFileName))
                {
                    cmd.Parameters["@image"].Value = File.ReadAllBytes(pictureFileName);
                }
                else
                {
                    cmd.Parameters["@image"].Value = null;
                }


                cmd.ExecuteNonQuery();

                DialogResult = DialogResult.OK;
                Close();

            }
            catch(Exception exc)
            {
                DialogHelper.E(exc.Message);
            }
            
        }

        private bool ValidateData()
        {
            if (cb_Models.SelectedIndex>-1 &&
                cb_Types.SelectedIndex > -1 &&
                cb_Fuel.SelectedIndex > -1 &&
                tb_RegPlate.Text.Replace(" ","").Length >=3)
            {
                return true;
            }
            else
            {
                DialogHelper.E("Sprawdź i poraw pola formularza");
                return false;
            }
        }
    }
}
