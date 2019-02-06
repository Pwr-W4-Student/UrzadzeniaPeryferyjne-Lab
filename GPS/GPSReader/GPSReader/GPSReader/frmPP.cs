using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace GPSReader
{
    public partial class frmPP : Form
    {
        public string Latitude;
        public string Longitude;
        public string Satelites;
        public string Elevation;
        public SerialPort porcik = new SerialPort("COM11",4800, Parity.None, 8, StopBits.One);
        
        public frmPP()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Start();
            btnMapIt.Enabled = false;
            textBox1.Text = "COM11";

            // otwarcie portu
            try
            {

                serialPort1.PortName = "COM11";
                porcik.Open();
                Console.WriteLine(porcik.ReadExisting());
                button1.Text = "Zatrzymaj";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                timer1.Enabled = false;
                button1.Text = "Aktualizuj";
                return;
            }
        }

        /// <span class="code-SummaryComment"><summary></span>
        /// Update jesli wczytuje z gps
        /// 
        /// <span class="code-SummaryComment"></summary></span>
        /// <span class="code-SummaryComment"><param name="sender"></param></span>
        /// <span class="code-SummaryComment"><param name="e"></param></span>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (porcik.IsOpen)
            {
                string data = porcik.ReadExisting();
                string[] strArr = data.Split('$');
                for (int i = 0; i < strArr.Length; i++)
                {
                    string strTemp = strArr[i];
                    string[] lineArr = strTemp.Split(',');
                    if (lineArr[0] == "GPGGA") // tu
                    {
                        try
                        {
                            //Latitude
                            Double dLat = Convert.ToDouble(lineArr[2]);
                            dLat = dLat / 100;
                            var dLat2 = Math.Floor(dLat);  // stopnie
                            var dLat3 = Math.Floor((dLat - dLat2)*100); // minuty
                            var dLat4 = Math.Floor((dLat - dLat3));
                            string[] lat = dLat.ToString().Split('.');
                           // Latitude = "123";
                       //  Latitude = lineArr[3].ToString() +
                        // lat[0].ToString() + "." +
                        //  ((Convert.ToDouble(lat[1]) /
                        //  60)).ToString("#####");
                            Latitude = dLat2.ToString() + "°0" + dLat3.ToString() + "'" + dLat4.ToString() + "\"" + lineArr[3].ToString();


                            //Longitude
                            Double dLon = Convert.ToDouble(lineArr[4]);
                            dLon = dLon / 100;
                            var dLon2 = Math.Floor(dLon);  // stopnie
                            var dLon3 = Math.Floor((dLon - dLon2) * 100); // minuty
                            var dLon4 = Math.Floor((dLon - dLon3));
                           string[] lon = dLon.ToString().Split('.');
                          // Longitude = "123";
                          // Longitude = lineArr[5].ToString() + (Convert.ToDouble(lon[0]) + ((Convert.ToDouble("," + lon[1]) / 60))).ToString("");
                            Longitude = dLon2.ToString() + "°0" + dLon3.ToString() + "'" + dLon4.ToString() + "\"" + lineArr[5].ToString();

                            //Satelites
                            Satelites = lineArr[7].ToString();
                          // Satelites = "123";


                            //Elevation
                           Elevation = lineArr[9].ToString();
                           // Elevation = "123";


                            //Display
                            txtLat.Text = dLat2.ToString() + "°0" + dLat3.ToString() + "'" + dLat4.ToString() + "\"" + lineArr[3].ToString();
                            txtLong.Text = dLon2.ToString() + "°0" + dLon3.ToString() + "'" + dLon4.ToString() + "\"" + lineArr[5].ToString();
                         
                            txtSat.Text = Satelites;
                            txtElv.Text = Elevation;
                            btnMapIt.Enabled = true;
                        }
                        catch
                        {
                            txtLat.Text = "GPS niedostepny";
                            txtLong.Text = "GPS niedostepny";
                            txtSat.Text = "GPS niedostepny";
                            txtElv.Text = "GPS niedostepny";
                            btnMapIt.Enabled = false;
                        }
                    }
                }
            }
            else
            {
                txtLat.Text = "Port COM zamkniety";
                txtLong.Text = "Port COM zamkniety";
                txtSat.Text = "Port COM zamkniety";
                txtElv.Text = "Port COM zamkniety";
                btnMapIt.Enabled = false;
            }
        }

        /// <span class="code-SummaryComment"><summary></span>
 
        /// <span class="code-SummaryComment"></summary></span>
        /// <span class="code-SummaryComment"><param name="sender"></param></span>
        /// <span class="code-SummaryComment"><param name="e"></param></span>
        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
            }
            else
            {
                timer1.Enabled = true;
            }

            if (button1.Text == "Aktualizuj")
            {
                button1.Text = "Zatrzymaj";
                txtLat.Text = "";
                txtLong.Text = "";
                txtSat.Text = "";
                txtElv.Text = "";
            }
            else
            {
                button1.Text = "Aktualizuj";
                txtLat.Text = "Zatrzymano";
                txtLong.Text = "Zatrzymano";
                txtSat.Text = "Zatrzymano";
                txtElv.Text = "Zatrzymano";
            }
        }

        /// <span class="code-SummaryComment"><summary></span>

        /// <span class="code-SummaryComment"></summary></span>
        /// <span class="code-SummaryComment"><param name="sender"></param></span>
        /// <span class="code-SummaryComment"><param name="e"></param></span>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <span class="code-SummaryComment"><summary></span>
        /// <span class="code-SummaryComment"></summary></span>
        /// <span class="code-SummaryComment"><param name="sender"></param></span>
        /// <span class="code-SummaryComment"><param name="e"></param></span>
        private void btnMapIt_Click(object sender, EventArgs e)
        {

            try
            {
                StringBuilder queryAddress = new StringBuilder();
                queryAddress.Append("https://www.google.com/maps/place/");

                if (Latitude != string.Empty)
                {
                    queryAddress.Append(Latitude + "+");
                }

                if (Longitude != string.Empty)
                {
                    queryAddress.Append(Longitude);
                }

                System.Diagnostics.Process.Start(queryAddress.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                porcik.Close();
                porcik.PortName = textBox1.Text;
                porcik.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                timer1.Enabled = false;
                button1.Text = "Aktualizuj";
                return;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
