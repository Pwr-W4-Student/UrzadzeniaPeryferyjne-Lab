using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modem
{
    public partial class Form1 : Form
    {
        bool enter = false;
        string filePath;
        SerialPortManager manager;
       
        public Form1()
        {
            manager = new SerialPortManager();
            InitializeComponent();


            comboBoxComList.Items.Clear();
            comboBoxComList.Items.AddRange(manager.GetCOM().ToArray());
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            if(comboBoxComList.SelectedItem!=null)
           manager.Connect(comboBoxComList.SelectedItem.ToString());
         
        }

        private void PortsBtn_Click(object sender, EventArgs e)
        {
            List<String> ComList =manager.GetCOM();
            comboBoxComList.Items.Clear();
            comboBoxComList.Items.AddRange(ComList.ToArray());
        }

        private void COMBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void SendBtn_Click(object sender, EventArgs e)
        {   
            string message;
        message = messageBox.Text;
        if (enter = true)
            message = message + Environment.NewLine;
        Console.WriteLine("MESSAGE TO SEND: " + message);
        manager.SendMessage(message);
        }

        

        private void messageBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            OpenFolderDialog();
            manager.SendFile(filePath);
        }

        private void OpenFolderDialog()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = fileDialog.FileName;
                
                Console.WriteLine("File:" + filePath + " is ready to load");

            }
        }
        
    }
}
