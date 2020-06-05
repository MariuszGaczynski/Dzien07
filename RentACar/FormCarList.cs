using MySql.Data.MySqlClient;
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
    public partial class FormCarList : Form
    {
        public FormCarList()
        {
            InitializeComponent();
        }


        BindingSource bSource = new BindingSource();

        private void FormCarList_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string sql = @"SELECT 
                            c.id,b.name AS brand, m.name AS model,t.name AS car_type, 
                            c.registration_plate, c.engine,c.manufacturer_year,
                            c.avail, c.fuel
                             FROM 
                            cars AS c , car_models AS m , car_types AS t, car_brands AS b
                            WHERE 
                            c.model_id = m.id
                            AND c.type_id = t.id
                            AND m.brand_id = b.id";

            adapter.SelectCommand = new MySqlCommand(sql, GlobalData.connection);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            bSource.DataSource = dt;
            Grid.DataSource = bSource;

            Grid.Columns["id"].HeaderText = "ID";
            Grid.Columns["brand"].HeaderText = "Marka";
            Grid.Columns["model"].HeaderText = "Model";
            Grid.Columns["car_type"].HeaderText = "Typ własności";
            Grid.Columns["registration_plate"].HeaderText = "Numer rejestracyjny";
            Grid.Columns["engine"].HeaderText = "Pojemność [cm3]";
            Grid.Columns["engine"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Grid.Columns["manufacturer_year"].HeaderText = "Rok produkcji";
            Grid.Columns["manufacturer_year"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Grid.Columns["avail"].HeaderText = "Dostępny";
            Grid.Columns["avail"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Grid.Columns["fuel"].HeaderText = "Paliwo";


        }

        private void Grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == Grid.Columns["avail"].Index)
            {
                e.Value = (Convert.ToInt32(e.Value) == 1 ) ? "TAK" : "NIE";
            }

            
        }

        private void mmu_DeleteCar_Click(object sender, EventArgs e)
        {
            if (Grid.SelectedRows.Count == 0) return;
            DialogResult res = MessageBox.Show("Czy na pewno usunąć rekord?", "Pytanie",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes) return;

            String sql = " DELETE FROM cars where id= @rowId ";
            using (MySqlCommand deleteCommand = new MySqlCommand(sql, GlobalData.connection))
            {
                deleteCommand.Parameters.Add("@rowId", MySqlDbType.Int32);

                int selectedIndex = Grid.SelectedRows[0].Index;
                deleteCommand.Parameters["@rowId"].Value = Grid["id", selectedIndex].Value;

                deleteCommand.ExecuteNonQuery();

                // update danych w datagridview
                Grid.Rows.RemoveAt(selectedIndex);
            }

            
        }


        private void RefreshData()   // oświeża dane w gridzie
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string sql = @"SELECT 
                 c.id, b.name AS brand, m.name AS model, t.name AS car_type, 
                 c.registration_plate, c.engine, c.manufacturer_year,
                 c.avail, c.fuel
                FROM
                cars AS c , car_models AS m, car_types AS t, car_brands AS b
                WHERE
                 c.model_id = m.id AND c.type_id = t.id AND m.brand_id = b.id";

            adapter.SelectCommand = new MySqlCommand(sql, GlobalData.connection);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            bSource.DataSource = dt;
            Grid.DataSource = bSource;
        }

        private void tsb_Refresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void mmu_Refresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void tsb_Insert_Click(object sender, EventArgs e)
        {
            AddNewCar();
        }

        private void AddNewCar()
        {
            FormAddCar form = new FormAddCar();
            
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshData();
            }
        }

        private void mmu_EditCar_Click (object sender, EventArgs e)
        {
            //if (Grid.SelectedRows.Count == 0) return;
            //int selectedIndex = Grid.SelectedRows[0].Index;
            //int rowId = Convert.ToInt32(Grid["id", selectedIndex].Value);

            //FormAddCar form = new FormAddCar();
            //form.RowId = rowId;
            //if(form.ShowDialog() == DialogResult.OK)
            //{
            //    Refresh();
            //}


            if (Grid.SelectedRows.Count == 0) return;
            int selectedIndex = Grid.SelectedRows[0].Index;
            int rowId = Convert.ToInt32(Grid["id", selectedIndex].Value);

            FormAddCar form = new FormAddCar();
            form.RowId = rowId;
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshData();
            }

        }

        private void mmu_CarOper_Click(object sender, EventArgs e)
        {


            if (Grid.SelectedRows.Count == 0) return;
            int selectedIndex = Grid.SelectedRows[0].Index;
            int rowId = Convert.ToInt32(Grid["id", selectedIndex].Value);
            string regPlate = Grid["registration_plate", selectedIndex].Value.ToString();
            int avail = Convert.ToInt32(Grid["avail", selectedIndex].Value);


            FormOperation form = new FormOperation();
            form.CarId = rowId;
            form.RegPlate = regPlate;
            form.OperBack = (avail == 0);


            if(form.ShowDialog()== DialogResult.OK)
            {
                RefreshData();
            }
        }
    }
}
