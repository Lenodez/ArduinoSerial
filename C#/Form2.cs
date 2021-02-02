using System;
using System.Windows.Forms;

namespace ArduinoSerial
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();


        }


        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (!serialPort1.IsOpen)

            {
                serialPort1.PortName = (string)main.comboBox2.SelectedItem;
                serialPort1.Open();
                label1.Text = (string)main.comboBox2.SelectedItem;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            serialPort1.Close();
            main.Show();
            Hide();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int shags = Int32.Parse(textBox2.Text);
            int speed = Int32.Parse(speed_box.Text);

            serialPort1.WriteLine($"P{shags} {speed}");
            label1.Text = ($"P{shags} {speed}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int shags = Int32.Parse(textBox2.Text);
            int speed = Int32.Parse(speed_box.Text);

            serialPort1.WriteLine($"N{shags} {speed}");
            label1.Text = ($"N{shags} {speed}");
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void speed_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void Set_accel_Click(object sender, EventArgs e)
        {
            int speed_accel = Int32.Parse((string)Acceleration_Box.SelectedItem);


            serialPort1.WriteLine($"A{speed_accel}");
            label1.Text = ($"A{speed_accel}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine($"U");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int shags = Int32.Parse(textBox2.Text);
            int speed = Int32.Parse(speed_box.Text);

            serialPort1.WriteLine($"R{shags} {speed}");
            label1.Text = ($"R{shags} {speed}");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int shags = Int32.Parse(textBox2.Text);
            int speed = Int32.Parse(speed_box.Text);

            serialPort1.WriteLine($"r{shags} {speed}");
            label1.Text = ($"r{shags} {speed}");
        }
    }
}
