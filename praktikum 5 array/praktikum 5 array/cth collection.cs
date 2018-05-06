using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikum_5_array
{
    public partial class cth_collection : Form
    {
        public cth_collection()
        {
            InitializeComponent();
        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            List<int> mylist = new List<int>();

            mylist.Add(1);
            mylist.Add(2);
            mylist.Add(3);
            mylist.Add(4);

            listBox1.Items.Add("Isi list : ");
            foreach (int i in mylist)
            {
                listBox1.Items.Add(i);
            }

            listBox1.Items.Add(" ");
            listBox1.Items.Add("Isi list [ Hapus Item 3 ]: ");
            mylist.Remove(3);
            foreach (int i in mylist)
            {
                listBox1.Items.Add(i);
            }

            listBox1.Items.Add(" ");
            listBox1.Items.Add("Isi list [ Tambah Item 5 ]: ");
            mylist.Add(5);
            foreach (int i in mylist)
            {
                listBox1.Items.Add(i);
            }

        }

        private void btnqueue_Click(object sender, EventArgs e)
        {
            Queue<char> antrianku = new Queue<char>();

            antrianku.Enqueue('A');
            antrianku.Enqueue('B');
            antrianku.Enqueue('C');
            antrianku.Enqueue('D');


            listBox1.Items.Add("Isi Queue : ");
            foreach (char i in antrianku)
            {
                listBox1.Items.Add(i);
            }

            listBox1.Items.Add(" ");
            listBox1.Items.Add("Isi Queue [ Mengurangi Queue ]:");
            antrianku.Dequeue();
            foreach (char i in antrianku)
            {
                listBox1.Items.Add(i);
            }

            listBox1.Items.Add(" ");
            listBox1.Items.Add("Isi Queue [ Menambah Queue ]:");
            antrianku.Enqueue('F');
            foreach (char i in antrianku)
            {
                listBox1.Items.Add(i);
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnstack_Click(object sender, EventArgs e)
        {
            Stack<char> tumpukanku = new Stack<char>();

            tumpukanku.Push('A');
            tumpukanku.Push('B');
            tumpukanku.Push('C');
            tumpukanku.Push('D');

            listBox1.Items.Add("Isi Stack : ");
            foreach (char i in tumpukanku)
            {
                listBox1.Items.Add(i);
            }

            listBox1.Items.Add(" ");
            listBox1.Items.Add("Isi Stack [ Mengurangi Stack ]:");
            tumpukanku.Pop();
            foreach (char i in tumpukanku)
            {
                listBox1.Items.Add(i);
            }

            listBox1.Items.Add(" ");
            listBox1.Items.Add("Isi Stack [ Menambah Stack ]:");
            tumpukanku.Push('F');
            foreach (char i in tumpukanku)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}
