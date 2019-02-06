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

namespace lab2_laserowa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\lab\Documents\Visual Studio 2013\Projects\lab2_laserowa\lab2_laserowa\laserowa";
            FileStream file = File.Create(path);
            StreamWriter writer = new StreamWriter(file);

            writer.WriteLine("\x1B" + "E"); // Reset drukarki
            writer.WriteLine("\x1B" + "&s0C"); //zawijanie 
            writer.WriteLine("\x1B" + "&10O"); // 0 pionowo 1 poziomo
            writer.WriteLine("\x1B" + "*o0M"); // wydruk normal
            writer.WriteLine("\x1B" + "&126A"); //rozmiar papieru
            writer.WriteLine("\x1B" + "&a5C"); //idz do 5 kolumny
            writer.WriteLine("\x1B" + "&a4R"); //idz do 4 wiersza

            if(pogrubienie.Checked)
            {
                writer.WriteLine("\x1B" + "(s3B");
            }

            if(Kursywa.Checked)
            {
                writer.WriteLine("\x1B" + "(s1S");
            }

            if(podkreslenie.Checked)
            {
                writer.WriteLine("\x1B" + "&d0D");
            }

            writer.WriteLine("\x1B" + "(s"+ (numericUpDown1.Value - 16) + "H"); //zmaiana rozmiaru


            
            if(comboBox1.Text == "CG Times")
            {
                writer.WriteLine("\x1B" + "(s4101T");
            }
            else if (comboBox1.Text == "Arial")
            {
                writer.WriteLine("\x1B" + "(s16602T");
            }
            else if (comboBox1.Text == "Windings")
            {
                writer.WriteLine("\x1B" + "(s2730T");
            }
            

            writer.WriteLine("\n");

            writer.WriteLine(textBox_text.Text);

            writer.WriteLine("\x1B" + "E");
            writer.Close();
            File.Copy(path, "LPT3");


        }

        private void button_picture_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\lab\Documents\Visual Studio 2013\Projects\lab2_laserowa\lab2_laserowa\obraz.txt";
        
            File.Copy(path, "LPT3");
        }
    }
}
