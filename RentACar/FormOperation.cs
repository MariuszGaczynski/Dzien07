using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;

namespace RentACar
{

    

    public partial class FormOperation : Form
    {

        public int CarId { get; set; } = 0;
        public string RegPlate { get; set; } = "";
        public bool OperBack { get; set; } = false;


        public FormOperation()
        {
            InitializeComponent();
        }

        int lastRecordId;

        private void FormOperation_Load(object sender, EventArgs e)
        {
            if (OperBack)
            {
                // zwrto pojazdu
                Text = "Zwrot pojazdu " + RegPlate;
                string sql = "SELECT id, description FROM operations WHERE car_id= {0} ORDER BY id DESC LIMIT 0,1";

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                sql = string.Format(sql, CarId);
                adapter.SelectCommand = new MySqlCommand(sql, GlobalData.connection);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count>0)
                {
                    tb_Descr.Text = dt.Rows[0]["description"].ToString();
                    lastRecordId = Convert.ToInt32(dt.Rows[0]["id"]);
                }

            }
            else
            {
                //wydanie pojazdu

                Text = "Wydanie pojazdu " + RegPlate;
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {

            string fileName =
                Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "rent-a-car.docx");

            DocX document = DocX.Load(fileName);
            document.ReplaceText("{REG_PLATE}", RegPlate);
            document.ReplaceText("{MILAGE}", num_Mileage.Value.ToString());
            document.ReplaceText("{TS}", dt_Date.Value.ToString("yyyy-MM-dd HH:mm"));

            if (OperBack)

            {
                document.ReplaceText("{DOC_TYPE}", "ZWROT POJAZDU");
            }
            else
            {
                document.ReplaceText("{DOC_TYPE}", "WYDANIE POJAZDU");
            }
            fileName = Path.Combine(@"C:\Users\Mariusz Gaczyński\Desktop\tmp", "RentAcar_" + DateTime.Now.ToString("yyyyMMddHHmm") + ".docx");
            document.SaveAs(fileName);

            MySqlTransaction tr = null;

            try
            {

                tr = GlobalData.connection.BeginTransaction();

                string sql;
                int avail;

                if (OperBack == false)
                {
                    //wydaj auto - dodaj rekord

                    sql = @"INSERT INTO operations 
                    (car_id, ts_out, mileage_out,description) VALUES
                  (@car_id, @ts, @mileage, @descr)";
                    avail = 0;
                }
                else
                {
                    // przyjmij auto - zakutailizuj ostatni rekord operacji dla auta
                    sql = @"UPDATE operations SET
                     ts_in=@ts, mileage_in=@mileage, description=@descr  WHERE id=@id";
                    avail = 1;
                }

                MySqlCommand cmd = new MySqlCommand(sql, GlobalData.connection);

                cmd.Transaction = tr;
                cmd.Parameters.Add("@car_id", MySqlDbType.Int32).Value = CarId;
                cmd.Parameters.Add("@ts", MySqlDbType.DateTime).Value = dt_Date.Value;
                cmd.Parameters.Add("@mileage", MySqlDbType.Int32).Value = num_Mileage.Value;
                cmd.Parameters.Add("@descr", MySqlDbType.Text).Value = tb_Descr.Text;
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = lastRecordId;
                cmd.ExecuteNonQuery();

                sql = "UPDATE cars SET avail = @avail Where id=@id";
                cmd = new MySqlCommand(sql, GlobalData.connection);
                cmd.Transaction = tr;
                cmd.Parameters.Add("@avail", MySqlDbType.Int32).Value = avail;
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = CarId;
                cmd.ExecuteNonQuery();

                tr.Commit();

                DialogResult = DialogResult.OK;
                Close();

            }
            catch (Exception exc)
            {
                if (tr!= null)
                {
                    tr.Rollback();
                }
                
                DialogHelper.E(exc.Message);
            }
        }
    }
}
