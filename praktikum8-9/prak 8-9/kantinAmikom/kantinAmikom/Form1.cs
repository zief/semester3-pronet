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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6KPNM0\SQLEXPRESS;Initial Catalog=kantinAmikom;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            resetdata();
            showdata();

        }

        private void resetdata()
        {
            txtId.Text = " ";
            txtNama.Text = " ";
            txtVoucher.Text = " ";
        }

        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "Select * from customer";

            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds, "customer");

            dgvcustomer.DataSource = ds;

            dgvcustomer.DataMember = "customer";

            dgvcustomer.ReadOnly = true;
        }

        private void btncari_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from customer where namaCustomer like '%" +txtcaridata.Text + "%'";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds, "customer");
            dgvcustomer.DataSource = ds;
            dgvcustomer.DataMember = "customer";
            dgvcustomer.ReadOnly = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" | txtNama.Text == "" | txtVoucher.Text == "")
            {
                MessageBox.Show("Semua Data harus Di isi", "Peringatan");
                goto berhenti;
            }

            int num;
            bool isNum = int.TryParse(txtVoucher.Text.ToString(), out num);

            if (!isNum)
            {
                MessageBox.Show("Isi voucher harus angka", "Peringatan");
                goto berhenti;
            }

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into customer values ('" +txtId.Text + "','"
                + txtNama.Text + "'," + int.Parse(txtVoucher.Text)+ ")" ;

            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();

        berhenti:
            ;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" | txtNama.Text == "" | txtVoucher.Text == "")
            {
                MessageBox.Show("Semua Data harus Di isi", "Peringatan");
                goto berhenti;
            }

            int num;
            bool isNum = int.TryParse(txtVoucher.Text.ToString(), out num);

            if (!isNum)
            {
                MessageBox.Show("Isi voucher harus angka", "Peringatan");
                goto berhenti;
            }

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update customer set namaCustomer = '" + txtNama.Text + "', nominalIsi = "
            + txtVoucher.Text + "where idCustomer = '"+txtId.Text +"'";

            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();

        berhenti:
            ;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" | txtNama.Text == "" | txtVoucher.Text == "")
            {
                MessageBox.Show("Semua Data harus Di isi", "Peringatan");
                goto berhenti;
            }

            int num;
            bool isNum = int.TryParse(txtVoucher.Text.ToString(), out num);

            if (!isNum)
            {
                MessageBox.Show("Isi voucher harus angka", "Peringatan");
                goto berhenti;
            }

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from customer where idCustomer = '" +txtId.Text+"'" ;

            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();

        berhenti:
            ;
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            showdata();
        }



    }
}
