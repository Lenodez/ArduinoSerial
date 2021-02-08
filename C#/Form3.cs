using System;
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

        public void button6_Click(object sender, EventArgs e)
        {
            int k = 400; // Коэффициент перевода миллиметров в шаги
            int xSpeed = Int32.Parse(x_speed.Text); // Скорость по X
            int xLenght = Int32.Parse(x_lenght.Text); // Длина стекла по X
            float xShift = Int32.Parse(x_shift.Text); // Длина смещения по X
            int yLenght = Int32.Parse(y_lenght.Text); // Длина стекла по Y
            float yShift = Int32.Parse(y_shift.Text); // Длина смещения по Y
            int repeat = Int32.Parse(R.Text); // Количество повторов операции

            float move_on_x = xLenght / xShift; // Количество смещений по X
            float move_on_y = yLenght / yShift; // Количество смещений по Y
            float dx = xShift * k; // Длина смещения в Шагах по X
            float dy = yShift * k; // Длина смещения в шагах по Y
            float ud = (60000 * xShift) / xSpeed; // Задержка между передвижениями по X
            
            int[] myIntArray = {repeat, (int)move_on_x, (int)dx, (int)ud, (int)move_on_y, (int)dy };
            Commands_Sender(myIntArray);
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void Commands_Sender(params int[] list)
        {
            for (int i = 0; i < list.Length; i++) { }
            int repeat = list[0];
            int move_on_x = list[1];
            int dx = list[2];
            int ud = list[3];
            int move_on_y = list[4];
            int dy = list[5];
            int current_x = 0;
            int current_y = 0;
            for (int i = 0; i < repeat; i++)
            {
                for (int j = 0; j < move_on_y; j++)
                {
                    for (int k = 0; k < move_on_x; k++)
                    {
                        current_x += dx;
                        serialPort1.WriteLine($"F{current_x}");
                        labelTest.Text = ($"F{current_x}");
                        System.Threading.Thread.Sleep(ud);
                        
                    }
                    current_y += dy;
                    serialPort1.WriteLine($"S{current_y}");
                    labelTest.Text = ($"F{current_y}");
                    System.Threading.Thread.Sleep(ud);
                    current_x = -dx;
                    
                }
                serialPort1.WriteLine($"F{-current_x}");
                labelTest.Text = ($"F{-current_x}");
                serialPort1.WriteLine($"S{-current_y}");
                labelTest.Text = ($"F{-current_y}");
                current_x = 0;
                current_y = 0;

            }

        }


    }
}
