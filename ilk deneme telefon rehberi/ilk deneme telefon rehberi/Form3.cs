using System;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilk_deneme_telefon_rehberi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
      
        private void Form3_Load(object sender, EventArgs e)
        {


            string DosyaYolu = @"C:\Users\LENOVO\source\repos\ilk deneme telefon rehberi\ilk deneme telefon rehberi\bin\Debug\musa.txt";
            FileStream fs = new FileStream(DosyaYolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string metin;
            string[] kume;
            int basla = 0;

             metin = sw.ReadLine();

            while (metin != null)
            {
                kume = metin.Split(' ');

                richTextBox1.Text += kume[1] + " " + kume[2] + " " + kume[3]+"\n";
                metin = sw.ReadLine();
            }

            sw.Close();
            fs.Close();

            sw = new StreamReader("musa.txt");
              metin = sw.ReadLine();

            while(metin!=null)
            {
                kume = metin.Split(' ');

                if (kume[0] == "kkk")
                {
                    richTextBox1.Select(basla, kume[1].Length);
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + 1, kume[2].Length);
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + kume[2].Length+2, kume[3].Length);
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.DeselectAll();

                    basla += kume[1].Length + kume[2].Length + kume[3].Length+3;
                }

                if (kume[0] == "kky")
                {
                    richTextBox1.Select(basla, kume[1].Length);
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + 1, kume[2].Length);
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + kume[2].Length + 2, kume[3].Length);
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.DeselectAll();

                    basla += kume[1].Length + kume[2].Length + kume[3].Length + 3;
                }


                if (kume[0] == "kkm")
                {
                    richTextBox1.Select(basla, kume[1].Length);
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + 1, kume[2].Length);
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + kume[2].Length + 2, kume[3].Length);
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.DeselectAll();

                    basla += kume[1].Length + kume[2].Length + kume[3].Length + 3;
                }

                if (kume[0] == "kyy")
                {
                    richTextBox1.Select(basla, kume[1].Length);
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + 1, kume[2].Length);
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + kume[2].Length + 2, kume[3].Length);
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.DeselectAll();

                    basla += kume[1].Length + kume[2].Length + kume[3].Length + 3;
                }


                if (kume[0] == "kym")
                {
                    richTextBox1.Select(basla, kume[1].Length);
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + 1, kume[2].Length);
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + kume[2].Length + 2, kume[3].Length);
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.DeselectAll();

                    basla += kume[1].Length + kume[2].Length + kume[3].Length + 3;
                }


                if (kume[0] == "kyk")
                {
                    richTextBox1.Select(basla, kume[1].Length);
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + 1, kume[2].Length);
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + kume[2].Length + 2, kume[3].Length);
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.DeselectAll();

                    basla += kume[1].Length + kume[2].Length + kume[3].Length + 3;
                }

                if (kume[0] == "kmm")
                {
                    richTextBox1.Select(basla, kume[1].Length);
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + 1, kume[2].Length);
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + kume[2].Length + 2, kume[3].Length);
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.DeselectAll();

                    basla += kume[1].Length + kume[2].Length + kume[3].Length + 3;
                }

                if (kume[0] == "kmy")
                {
                    richTextBox1.Select(basla, kume[1].Length);
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + 1, kume[2].Length);
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + kume[2].Length + 2, kume[3].Length);
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.DeselectAll();

                    basla += kume[1].Length + kume[2].Length + kume[3].Length + 3;
                }

                if (kume[0] == "kmk")
                {
                    richTextBox1.Select(basla, kume[1].Length);
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + 1, kume[2].Length);
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + kume[2].Length + 2, kume[3].Length);
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.DeselectAll();

                    basla += kume[1].Length + kume[2].Length + kume[3].Length + 3;
                }







                if (kume[0] == "mkk")
                {
                    richTextBox1.Select(basla, kume[1].Length);
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + 1, kume[2].Length);
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + kume[2].Length + 2, kume[3].Length);
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.DeselectAll();

                    basla += kume[1].Length + kume[2].Length + kume[3].Length + 3;
                }

                if (kume[0] == "mky")
                {
                    richTextBox1.Select(basla, kume[1].Length);
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + 1, kume[2].Length);
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + kume[2].Length + 2, kume[3].Length);
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.DeselectAll();

                    basla += kume[1].Length + kume[2].Length + kume[3].Length + 3;
                }


                if (kume[0] == "mkm")
                {
                    richTextBox1.Select(basla, kume[1].Length);
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + 1, kume[2].Length);
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + kume[2].Length + 2, kume[3].Length);
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.DeselectAll();

                    basla += kume[1].Length + kume[2].Length + kume[3].Length + 3;
                }

                if (kume[0] == "myy")
                {
                    richTextBox1.Select(basla, kume[1].Length);
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + 1, kume[2].Length);
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + kume[2].Length + 2, kume[3].Length);
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.DeselectAll();

                    basla += kume[1].Length + kume[2].Length + kume[3].Length + 3;
                }


                if (kume[0] == "mym")
                {
                    richTextBox1.Select(basla, kume[1].Length);
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + 1, kume[2].Length);
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + kume[2].Length + 2, kume[3].Length);
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.DeselectAll();

                    basla += kume[1].Length + kume[2].Length + kume[3].Length + 3;
                }


                if (kume[0] == "myk")
                {
                    richTextBox1.Select(basla, kume[1].Length);
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + 1, kume[2].Length);
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + kume[2].Length + 2, kume[3].Length);
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.DeselectAll();

                    basla += kume[1].Length + kume[2].Length + kume[3].Length + 3;
                }

                if (kume[0] == "mmm")
                {
                    richTextBox1.Select(basla, kume[1].Length);
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + 1, kume[2].Length);
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + kume[2].Length + 2, kume[3].Length);
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.DeselectAll();

                    basla += kume[1].Length + kume[2].Length + kume[3].Length + 3;
                }

                if (kume[0] == "mmy")
                {
                    richTextBox1.Select(basla, kume[1].Length);
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + 1, kume[2].Length);
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + kume[2].Length + 2, kume[3].Length);
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.DeselectAll();

                    basla += kume[1].Length + kume[2].Length + kume[3].Length + 3;
                }

                if (kume[0] == "mmk")
                {
                    richTextBox1.Select(basla, kume[1].Length);
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + 1, kume[2].Length);
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + kume[2].Length + 2, kume[3].Length);
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.DeselectAll();

                    basla += kume[1].Length + kume[2].Length + kume[3].Length + 3;
                }








                if (kume[0] == "ykk")
                {
                    richTextBox1.Select(basla, kume[1].Length);
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + 1, kume[2].Length);
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + kume[2].Length + 2, kume[3].Length);
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.DeselectAll();

                    basla += kume[1].Length + kume[2].Length + kume[3].Length + 3;
                }

                if (kume[0] == "yky")
                {
                    richTextBox1.Select(basla, kume[1].Length);
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + 1, kume[2].Length);
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + kume[2].Length + 2, kume[3].Length);
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.DeselectAll();

                    basla += kume[1].Length + kume[2].Length + kume[3].Length + 3;
                }


                if (kume[0] == "ykm")
                {
                    richTextBox1.Select(basla, kume[1].Length);
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + 1, kume[2].Length);
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + kume[2].Length + 2, kume[3].Length);
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.DeselectAll();

                    basla += kume[1].Length + kume[2].Length + kume[3].Length + 3;
                }

                if (kume[0] == "yyy")
                {
                    richTextBox1.Select(basla, kume[1].Length);
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + 1, kume[2].Length);
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + kume[2].Length + 2, kume[3].Length);
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.DeselectAll();

                    basla += kume[1].Length + kume[2].Length + kume[3].Length + 3;
                }


                if (kume[0] == "yym")
                {
                    richTextBox1.Select(basla, kume[1].Length);
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + 1, kume[2].Length);
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + kume[2].Length + 2, kume[3].Length);
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.DeselectAll();

                    basla += kume[1].Length + kume[2].Length + kume[3].Length + 3;
                }


                if (kume[0] == "yyk")
                {
                    richTextBox1.Select(basla, kume[1].Length);
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + 1, kume[2].Length);
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + kume[2].Length + 2, kume[3].Length);
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.DeselectAll();

                    basla += kume[1].Length + kume[2].Length + kume[3].Length + 3;
                }

                if (kume[0] == "ymm")
                {
                    richTextBox1.Select(basla, kume[1].Length);
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + 1, kume[2].Length);
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + kume[2].Length + 2, kume[3].Length);
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.DeselectAll();

                    basla += kume[1].Length + kume[2].Length + kume[3].Length + 3;
                }

                if (kume[0] == "ymy")
                {
                    richTextBox1.Select(basla, kume[1].Length);
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + 1, kume[2].Length);
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + kume[2].Length + 2, kume[3].Length);
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.DeselectAll();

                    basla += kume[1].Length + kume[2].Length + kume[3].Length + 3;
                }

                if (kume[0] == "ymk")
                {
                    richTextBox1.Select(basla, kume[1].Length);
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + 1, kume[2].Length);
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.DeselectAll();

                    richTextBox1.Select(basla + kume[1].Length + kume[2].Length + 2, kume[3].Length);
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.DeselectAll();

                    basla += kume[1].Length + kume[2].Length + kume[3].Length + 3;
                }


                metin = sw.ReadLine();



            }

            sw.Close();
            fs.Close();





        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 anasayfa= new Form1();
            anasayfa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 kayıt = new Form2();
            kayıt.Show();
            this.Hide();
        }
    }
}
