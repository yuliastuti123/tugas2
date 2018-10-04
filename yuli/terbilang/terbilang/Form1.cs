using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassTerbilang;

namespace terbilang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nominal = int.Parse(nilai.Text);
            Class1 none = new Class1();
            lsthasil.Text = Convert.ToString(none.TerbilangIndonesia(nominal));
        }
    }
}
