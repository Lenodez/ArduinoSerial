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
            int microns = Int32.Parse(textBox2.Text);
            int high = 0;
            int mid = 0;
            double low = 0;
            high = microns / 10000;
            mid = (microns - (high * 10000)) / 1000;
            low = Math.Round((microns % 1000) / 0.71875);
            serialPort1.WriteLine($"1 {low} {mid} {high}");
            label1.Text = ($"1 {low} {mid} {high}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int microns = Int32.Parse(textBox2.Text);
            int high = 0;
            int mid = 0;
            double low = 0;
            high = microns / 10000;
            mid = (microns - (high * 10000)) / 1000;
            low = Math.Round((microns % 1000) / 0.71875);
            //low = (microns - (high * 10000) - (mid * 1000));
            serialPort1.WriteLine($"2 {low} {mid} {high}");
            label1.Text = ($"2 {low} {mid} {high}");
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
    }
}
