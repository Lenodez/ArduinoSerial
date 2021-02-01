using System;
using System.ComponentModel;
using System.IO.Ports;
using System.Windows.Forms;

namespace ArduinoSerial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }




        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Get a list of serial port names.
            comboBox2.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            // Display each port name to the console.
            foreach (string port in ports)
            {
                comboBox2.Items.Add(port);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Owner = this;
            f.Show();
            Hide();
        }


    }
}

