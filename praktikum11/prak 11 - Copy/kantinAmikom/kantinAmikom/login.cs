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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=Z4WIND\SQLEXPRESS;Initial Catalog=kantinAmikom;Integrated Security=True");
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


        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "" | txtpassword.Text == "")
            {
                MessageBox.Show("Semua data harus diisi", "Peringatan");
                goto berhenti;
            }

            string tekscipher = null;
            tekscipher = CaesarCipher(txtpassword.Text, 17);

            con.Close();
            SqlCommand cmd = new SqlCommand("select * from admin where userId='" + txtuser.Text + "' and password= '" + tekscipher + "'", con);
            label3.Text = tekscipher;
            con.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            if(rd.HasRows)
            {
                rd.Read();
                formmenu frm_menu = new formmenu();
                frm_menu.Show();
                this.Hide();
            }
            else{
                MessageBox.Show("User id atau password tidak valid", "Peringatan");
                txtuser.Text ="";
                txtpassword.Text="";
                txtuser.Focus();
                rd.Close();
            }

            berhenti:
            ;
            }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToLower());
        }
        
        }
    }

