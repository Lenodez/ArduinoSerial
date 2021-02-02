using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoSerial
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (!serialPort1.IsOpen)

            {
                serialPort1.PortName = (string)main.comboBox2.SelectedItem;
                serialPort1.Open();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            serialPort1.Close();
            main.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int xSpeed = Int32.Parse(x_speed.Text);
            int xLenght = Int32.Parse(x_lenght.Text);
            int xShift = Int32.Parse(x_shift.Text);
            int yLenght = Int32.Parse(y_lenght.Text);
            int yShift = Int32.Parse(y_shift.Text);
            int repeat = Int32.Parse(R.Text);

            serialPort1.WriteLine($"N{""} {""}");
            label1.Text = ($"N{""} {""}");
        }
    }
}
