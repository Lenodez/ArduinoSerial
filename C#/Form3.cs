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
            int k = 1; // Коэффициент перевода десятых миллиметра в шаги
            int xSpeed = Int32.Parse(x_speed.Text);
            int xLenght = Int32.Parse(x_lenght.Text);
            int xShift = Int32.Parse(x_shift.Text);
            int yLenght = Int32.Parse(y_lenght.Text);
            int yShift = Int32.Parse(y_shift.Text);
            int repeat = Int32.Parse(R.Text);

            float move_on_x = xLenght * 10 / xShift;
            float move_on_y = yLenght * 10 / yShift;
            int dx = xShift * k;
            int dy = yShift * k;
            float ud = (6000 * xShift) / xSpeed;
            //serialPort1.WriteLine($"N{""} {""}");
            labelTest.Text = ($"O{repeat} {move_on_x} {dx} {ud} {move_on_y} {dy}");
        }
    }
}
