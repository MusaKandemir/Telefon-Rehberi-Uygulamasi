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

namespace ilk_deneme_telefon_rehberi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        char k, m, y;

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
        }

       

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string DosyaYolu = @"C:\Users\LENOVO\source\repos\ilk deneme telefon rehberi\ilk deneme telefon rehberi\bin\Debug\musa.txt";
            FileStream fs = new FileStream(DosyaYolu, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            if (radioButton1.Checked && radioButton6.Checked && radioButton9.Checked) { sw.WriteLine("yyy" +' ' + textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text); }
            if (radioButton1.Checked && radioButton6.Checked && radioButton8.Checked) { sw.WriteLine("yym" + ' ' + textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text); }
            if (radioButton1.Checked && radioButton6.Checked && radioButton7.Checked) { sw.WriteLine("yyk" + ' ' + textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text); }
            if (radioButton1.Checked && radioButton5.Checked && radioButton9.Checked) { sw.WriteLine("ymy" + ' ' + textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text); }
            if (radioButton1.Checked && radioButton5.Checked && radioButton8.Checked) { sw.WriteLine("ymm" + ' ' + textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text); }
            if (radioButton1.Checked && radioButton5.Checked && radioButton7.Checked) { sw.WriteLine("ymk" + ' ' + textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text); }
            if (radioButton1.Checked && radioButton4.Checked && radioButton9.Checked) { sw.WriteLine("yky" + ' ' + textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text); }
            if (radioButton1.Checked && radioButton4.Checked && radioButton8.Checked) { sw.WriteLine("ykm" + ' ' + textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text); }
            if (radioButton1.Checked && radioButton4.Checked && radioButton7.Checked) { sw.WriteLine("ykk" + ' ' + textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text); }
            if (radioButton2.Checked && radioButton6.Checked && radioButton9.Checked) { sw.WriteLine("myy" + ' ' + textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text); }
            if (radioButton2.Checked && radioButton6.Checked && radioButton8.Checked) { sw.WriteLine("mym" + ' ' + textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text); }
            if (radioButton2.Checked && radioButton6.Checked && radioButton7.Checked) { sw.WriteLine("myk" + ' ' + textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text); }
            if (radioButton2.Checked && radioButton5.Checked && radioButton9.Checked) { sw.WriteLine("mmy" + ' ' + textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text); }
            if (radioButton2.Checked && radioButton5.Checked && radioButton8.Checked) { sw.WriteLine("mmm" + ' ' + textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text); }
            if (radioButton2.Checked && radioButton5.Checked && radioButton7.Checked) { sw.WriteLine("mmk" + ' ' + textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text); }
            if (radioButton2.Checked && radioButton4.Checked && radioButton9.Checked) { sw.WriteLine("mky" + ' ' + textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text); }
            if (radioButton2.Checked && radioButton4.Checked && radioButton8.Checked) { sw.WriteLine("mkm" + ' ' + textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text); }
            if (radioButton2.Checked && radioButton4.Checked && radioButton7.Checked) { sw.WriteLine("mkk" + ' ' + textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text); }
            if (radioButton3.Checked && radioButton6.Checked && radioButton9.Checked) { sw.WriteLine("kyy" + ' ' + textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text); }
            if (radioButton3.Checked && radioButton6.Checked && radioButton8.Checked) { sw.WriteLine("kym" + ' ' + textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text); }
            if (radioButton3.Checked && radioButton6.Checked && radioButton7.Checked) { sw.WriteLine("kyk" + ' ' + textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text); }
            if (radioButton3.Checked && radioButton5.Checked && radioButton9.Checked) { sw.WriteLine("kmy" + ' ' + textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text); }
            if (radioButton3.Checked && radioButton5.Checked && radioButton8.Checked) { sw.WriteLine("kmm" + ' ' + textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text); }
            if (radioButton3.Checked && radioButton5.Checked && radioButton7.Checked) { sw.WriteLine("kmk" + ' ' + textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text); }
            if (radioButton3.Checked && radioButton4.Checked && radioButton9.Checked) { sw.WriteLine("kky" + ' ' + textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text); }
            if (radioButton3.Checked && radioButton4.Checked && radioButton8.Checked) { sw.WriteLine("kkm" + ' ' + textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text); }
            if (radioButton3.Checked && radioButton4.Checked && radioButton7.Checked) { sw.WriteLine("kkk" + ' ' + textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text); }

            sw.Flush();
            sw.Close();
            fs.Close();

            
        }

        
    }
}
