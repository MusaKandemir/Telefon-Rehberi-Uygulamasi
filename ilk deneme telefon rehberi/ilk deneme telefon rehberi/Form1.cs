using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilk_deneme_telefon_rehberi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 kaydet = new Form2 ();
            kaydet.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Form3 listele = new Form3();
            listele.Show();
            this.Hide();



        }
    }
}
