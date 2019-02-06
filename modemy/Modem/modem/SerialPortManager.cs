using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace modem
{
    class SerialPortManager
    {
        SerialPort _serialPort;
        Thread reader; 
        public SerialPortManager()
        {
        }
        public void Connect(string com)
        {
            if (_serialPort != null)
                _serialPort.Open();
            if(_serialPort.IsOpen)
            {
                _serialPort.DtrEnable = true;
                _serialPort.Handshake = Handshake.RequestToSend;

                Console.WriteLine(_serialPort.PortName);
                Console.WriteLine(_serialPort.BaudRate);
                Console.WriteLine(_serialPort.Parity);
                Console.WriteLine(_serialPort.DataBits);
                Console.WriteLine(_serialPort.StopBits);
                Console.WriteLine(_serialPort.Handshake);
                Console.WriteLine(_serialPort.DtrEnable);

                reader = new Thread(Read);
                reader.Start();
            }
        }
        public List<String> GetCOM()
        {
            List<String>com = new List<String>();
            foreach(string s in SerialPort.GetPortNames())
            {
                com.Add(s);
            }
            com.Sort();
            return com;
        }

        public void SendMessage(string message)
        {
            if (_serialPort != null)
                _serialPort.Write(message);
 
        }
        private void Read()
        {
            while(_serialPort.IsOpen)
            {
                try
                {
                    string message = _serialPort.ReadExisting();
                    Console.Write(message);
                }
                catch(TimeoutException)
                {
                    Console.WriteLine("ERROR");
                }
            }
        }

       public void SendFile(string file)
        {
           if(_serialPort.IsOpen)
           {
               using (FileStream stream = File.OpenRead(file))
               {
                   _serialPort.Write((new BinaryReader(stream)).ReadBytes
                       ((int)stream.Length), 0, (int)stream.Length);
               }

           }
        }
    }
}
