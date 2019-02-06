using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Limilabs.Barcode;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Barcode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            BaseBarcode barcode = BarcodeFactory.GetBarcode(Symbology.EAN13);
            barcode.Number = textBoxEAN.Text;
            if (checkBoxSumCtrl.Checked)
                barcode.ChecksumAdd = true;
            else
                barcode.ChecksumAdd = false;
            pictureBoxBarcode.Image = barcode.Render();
            barcode.Save("barcode.png", ImageType.Png);
        }

        private void print_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += printBarcode;
            doc.Print();
        }

        private void printBarcode(object sender, PrintPageEventArgs e)
        {
            Image image = Image.FromFile("barcode.png");
            Point loc = new Point(100, 100);
            e.Graphics.DrawImage(image, loc);
        }
    }
}
