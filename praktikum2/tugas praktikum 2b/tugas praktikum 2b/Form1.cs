using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugas_praktikum_2b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            int bil1, bil2, hasil;

            try
            {
                bil1 = int.Parse(txtbil1.Text);
                bil2 = int.Parse(txtbil2.Text);

                if (bil1 < 0 | bil2 < 0)
                {
                    throw new Exception("Angka tidak boleh minus");
                }
                else
                {
                    hasil = bil1 + bil2;
                    txthasil.Text = hasil.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtbil1.Text = "";
                txtbil2.Text = "";
                txthasil.Text = "";
                txtbil1.Focus();
            }
            finally
            {
                txthasil.ReadOnly = true;
                txthasil.BackColor = Color.Ivory;
            }

        }
    }
}
