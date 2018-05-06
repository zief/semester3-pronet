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
    public partial class datamenu : Form
    {
        public datamenu()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=Z4WIND\SQLEXPRESS;Initial Catalog=kantinAmikom;Integrated Security=True");
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();

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
            txtid.Text = " ";
            txtnama.Text = " ";
            txtharga.Text = " ";
        }

        private void bindingdata()
        {
            //clear data table
            dt.Clear();

            //clear data bindings pada textbox
            txtid.DataBindings.Clear();
            txtnama.DataBindings.Clear();
            txtharga.DataBindings.Clear();

            //buat data adapter dan sqlbuilder
            SqlDataAdapter da = new SqlDataAdapter("select * from menu", con);
            SqlCommandBuilder scb = new SqlCommandBuilder(da);

            //fill data ke database
            da.Fill(dt);

            //set binding data source dan tampilkan ke grid
            bs.DataSource = dt;
            dgvmenu.DataSource = bs;

            //binding data ke dalam textbox yg ada
            txtid.DataBindings.Add("Text", bs, "idMenu");
            txtnama.DataBindings.Add("Text", bs, "namaMenu");
            txtharga.DataBindings.Add("Text", bs, "harga");

        }
        private void datamenu_Load(object sender, EventArgs e)
        {
            showdata();
            resetdata();
            bindingdata();
        }


        private void btninsert_Click(object sender, EventArgs e)
        {
           
        }

        private void btncari_Click(object sender, EventArgs e)
        {
            bs.Filter = "namaMenu like '%" + txtcaridata.Text + "%'";
        }

        private void next_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            showdata();
            resetdata();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            resetdata();
        }

        private void save_Click(object sender, EventArgs e)
        {
 if (txtid.Text == "" | txtnama.Text == "" | txtharga.Text == "")
            {
                MessageBox.Show("Semua data menu harus di isi", "Peringatan");
                goto berhenti;
            }

            int num;
            bool isNum = int.TryParse(txtharga.Text.ToString(), out num);

            if(!isNum){
                MessageBox.Show("Isi harga harus angka", "Peringatan");
                goto berhenti;
            }

             con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " insert into menu values('"+ txtid.Text+ "','"+ txtnama.Text +"','" + int.Parse(txtharga.Text)+ ")";
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();

            berhenti:
            ;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" | txtnama.Text == "" | txtharga.Text == "")
            {
                MessageBox.Show("Semua data menu harus di isi", "Peringatan");
                goto berhenti;
            }

            int num;
            bool isNum = int.TryParse(txtharga.Text.ToString(), out num);

            if(!isNum){
                MessageBox.Show("Isi harga harus angka", "Peringatan");
                goto berhenti;
            }

             con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " update menu set namaMenu='"+ txtnama.Text+ "',harga='"+ int.Parse(txtharga.Text) +"' where idMenu='" + txtid.Text+ "'";
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();

            berhenti:
            ;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Isi id menu yang akan di hapus");
                goto berhenti;
            }

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " delete from menu wher idMenu = '" + txtid.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();

        berhenti:
            ;

        }



    }
}
