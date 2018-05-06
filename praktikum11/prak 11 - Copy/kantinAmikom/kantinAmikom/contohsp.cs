using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kantinAmikom
{
    public partial class contohsp : Form
    {
        public contohsp()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=Z4WIND\SQLEXPRESS;Initial Catalog=kantinAmikom;Integrated Security=True");

        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "Select * from menu";

            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds, "menu");

            dgvmenu.DataSource = ds;

            dgvmenu.DataMember = "menu";

            dgvmenu.ReadOnly = true;
        }

        private void resetdata()
        {
            txtid.Text = "";
            txtnama.Text = "";
            txtharga.Text = "";
        }
        private void contohsp_Load(object sender, EventArgs e)
        {
            showdata();
            resetdata();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "ADDMENU";
            cmd.CommandType = CommandType.StoredProcedure;

            //buat sql parameter dg nama variabel yg sama pada SQL
            //Stored Procedue yang telah kita buat
            SqlParameter idMenu = new SqlParameter("@id", SqlDbType.VarChar);
            SqlParameter namaMenu = new SqlParameter("@nama", SqlDbType.VarChar);
            SqlParameter harga = new SqlParameter("@harga", SqlDbType.Int);

            //Isi var sql td dg nilai
            // yang telah kita input dari textbox
            idMenu.Value = txtid.Text;
            namaMenu.Value = txtnama.Text;
            harga.Value = txtharga.Text;

            //kemudian add parameter yang telah dibuat tadi
            //kedalam command yang ada
            cmd.Parameters.Add(idMenu);
            cmd.Parameters.Add(namaMenu);
            cmd.Parameters.Add(harga);

            //jalankan StoredProcedure
            cmd.ExecuteNonQuery();

            con.Close();
            showdata();
            resetdata();


        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELMENU";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter idMenu = new SqlParameter("@id", SqlDbType.VarChar);

            idMenu.Value = txtid.Text;
            cmd.Parameters.Add(idMenu);
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
        }
    }
}
