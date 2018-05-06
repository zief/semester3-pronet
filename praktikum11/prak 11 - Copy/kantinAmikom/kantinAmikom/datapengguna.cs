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
    public partial class datapengguna : Form
    {
        public datapengguna()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=Z4WIND\SQLEXPRESS;Initial Catalog=kantinAmikom;Integrated Security=True");
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();

        private void resetdata()
        {
            txtuser.Text = " ";
            txtpassword.Text = " ";
        }

        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "Select * from admin";

            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds, "admin");

            dgvuser.DataSource = ds;

            dgvuser.DataMember = "admin";

            dgvuser.ReadOnly = true;
        }

        private void bindingdata()
        {
            //clear data table
            dt.Clear();

            //clear data bindings pada textbox
            txtuser.DataBindings.Clear();
            txtpassword.DataBindings.Clear();

            //buat data adapter dan sqlbuilder
            SqlDataAdapter da = new SqlDataAdapter("select * from admin", con);
            SqlCommandBuilder scb = new SqlCommandBuilder(da);

            //fill data ke database
            da.Fill(dt);

            //set binding data source dan tampilkan ke grid
            bs.DataSource = dt;
            dgvuser.DataSource = bs;

            //binding data ke dalam textbox yg ada
            txtuser.DataBindings.Add("Text", bs, "userid");
            txtpassword.DataBindings.Add("Text", bs, "password");
            
        }

        private string CaesarCipher(string value, int shift)
        {
            string[] joinCipher = new string[200];
            string joinText = " ";
            string[] wordArray = value.Split(' ');

            try
            {
                for (int x = 0; x < wordArray.Length; x++)
                {
                    //konversi string charac dalam array
                    char[] buffer = wordArray[x].ToCharArray();

                    for (int i = 0; i < buffer.Length; i++)
                    {
                        //ambil karakter berdasarkan indek array kemudian di konversi ke bentuk karakter
                        char letter = buffer[i];
                        //jumlah dg nilai shift
                        letter = (char)(letter + shift);

                        //substract 26 on overflow
                        //add 26 on underflow

                        if (letter > 'z')
                        {
                            letter = (char)(letter - 26);

                        }
                        else if (letter < 'a')
                        {
                            letter = (char)(letter + 26);

                        }

                        //store
                        buffer[i] = letter;
                    }

                    string HasilKonversi = new string(buffer);
                    joinCipher[x] = HasilKonversi;
                }
                joinText = string.Join(" ", joinCipher);
                return joinText;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datapengguna_Load(object sender, EventArgs e)
        {
            resetdata();
            showdata();
            bindingdata();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "" | txtpassword.Text == "")
            {
                MessageBox.Show("Semua data harus diisi", "Peringatan");
                goto berhenti;
            }

            string tekschiper = null;
            tekschiper = CaesarCipher(txtpassword.Text, 17);

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into admin values ('" + txtuser.Text + "','" + tekschiper + "')";

            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();

        berhenti:
            ;
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToLower());
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                MessageBox.Show("Isi user id yang akan di hapus");
                goto berhenti;
            }

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from admin where userid = '" + txtuser.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();

        berhenti:
            ;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "" | txtpassword.Text == "")
            {
                MessageBox.Show("Semuda data harus di isi", "Peringatan");
                goto berhenti;
            }

            string tekschiper = null;
            tekschiper = CaesarCipher(txtpassword.Text, 17);

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update admin set password='" + tekschiper + "'where userid='" + txtuser.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();

        berhenti:
            ;
        }

    }
}
