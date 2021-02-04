
namespace ArduinoSerial
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.x_lenght = new System.Windows.Forms.TextBox();
            this.x_shift = new System.Windows.Forms.TextBox();
            this.x_speed = new System.Windows.Forms.TextBox();
            this.y_lenght = new System.Windows.Forms.TextBox();
            this.y_shift = new System.Windows.Forms.TextBox();
            this.R = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTest = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 39);
            this.button1.TabIndex = 17;
            this.button1.Text = "К выбору порта";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // x_lenght
            // 
            this.x_lenght.Location = new System.Drawing.Point(12, 22);
            this.x_lenght.Name = "x_lenght";
            this.x_lenght.Size = new System.Drawing.Size(100, 20);
            this.x_lenght.TabIndex = 33;
            // 
            // x_shift
            // 
            this.x_shift.Location = new System.Drawing.Point(159, 22);
            this.x_shift.Name = "x_shift";
            this.x_shift.Size = new System.Drawing.Size(100, 20);
            this.x_shift.TabIndex = 34;
            // 
            // x_speed
            // 
            this.x_speed.Location = new System.Drawing.Point(309, 22);
            this.x_speed.Name = "x_speed";
            this.x_speed.Size = new System.Drawing.Size(100, 20);
            this.x_speed.TabIndex = 35;
            // 
            // y_lenght
            // 
            this.y_lenght.Location = new System.Drawing.Point(12, 67);
            this.y_lenght.Name = "y_lenght";
            this.y_lenght.Size = new System.Drawing.Size(100, 20);
            this.y_lenght.TabIndex = 36;
            // 
            // y_shift
            // 
            this.y_shift.Location = new System.Drawing.Point(159, 67);
            this.y_shift.Name = "y_shift";
            this.y_shift.Size = new System.Drawing.Size(100, 20);
            this.y_shift.TabIndex = 37;
            // 
            // R
            // 
            this.R.Location = new System.Drawing.Point(309, 66);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(100, 20);
            this.R.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Длина по X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Смещение по X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Скорость по X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Длина по Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Смещение по Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Количество повторений";
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(294, 155);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(110, 13);
            this.labelTest.TabIndex = 46;
            this.labelTest.Text = "Сверка результатов";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(297, 102);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 26);
            this.button6.TabIndex = 47;
            this.button6.Text = "Запуск обработки";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "мм";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "мм";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(265, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "мм/10";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(265, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "мм/10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(415, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "мм/мин";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(415, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "мм/мин";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.R);
            this.Controls.Add(this.y_shift);
            this.Controls.Add(this.y_lenght);
            this.Controls.Add(this.x_speed);
            this.Controls.Add(this.x_shift);
            this.Controls.Add(this.x_lenght);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Отбеливание Стекла";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox x_lenght;
        private System.Windows.Forms.TextBox x_shift;
        private System.Windows.Forms.TextBox x_speed;
        private System.Windows.Forms.TextBox y_lenght;
        private System.Windows.Forms.TextBox y_shift;
        private System.Windows.Forms.TextBox R;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}