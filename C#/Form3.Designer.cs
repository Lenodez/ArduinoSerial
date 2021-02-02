
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
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 269);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 48);
            this.button1.TabIndex = 17;
            this.button1.Text = "К выбору порта";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // x_lenght
            // 
            this.x_lenght.Location = new System.Drawing.Point(60, 29);
            this.x_lenght.Margin = new System.Windows.Forms.Padding(4);
            this.x_lenght.Name = "x_lenght";
            this.x_lenght.Size = new System.Drawing.Size(132, 22);
            this.x_lenght.TabIndex = 33;
            // 
            // x_shift
            // 
            this.x_shift.Location = new System.Drawing.Point(224, 29);
            this.x_shift.Margin = new System.Windows.Forms.Padding(4);
            this.x_shift.Name = "x_shift";
            this.x_shift.Size = new System.Drawing.Size(132, 22);
            this.x_shift.TabIndex = 34;
            // 
            // x_speed
            // 
            this.x_speed.Location = new System.Drawing.Point(396, 29);
            this.x_speed.Margin = new System.Windows.Forms.Padding(4);
            this.x_speed.Name = "x_speed";
            this.x_speed.Size = new System.Drawing.Size(132, 22);
            this.x_speed.TabIndex = 35;
            // 
            // y_lenght
            // 
            this.y_lenght.Location = new System.Drawing.Point(60, 82);
            this.y_lenght.Margin = new System.Windows.Forms.Padding(4);
            this.y_lenght.Name = "y_lenght";
            this.y_lenght.Size = new System.Drawing.Size(132, 22);
            this.y_lenght.TabIndex = 36;
            // 
            // y_shift
            // 
            this.y_shift.Location = new System.Drawing.Point(224, 82);
            this.y_shift.Margin = new System.Windows.Forms.Padding(4);
            this.y_shift.Name = "y_shift";
            this.y_shift.Size = new System.Drawing.Size(132, 22);
            this.y_shift.TabIndex = 37;
            // 
            // R
            // 
            this.R.Location = new System.Drawing.Point(396, 82);
            this.R.Margin = new System.Windows.Forms.Padding(4);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(132, 22);
            this.R.TabIndex = 38;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(630, 72);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(132, 22);
            this.textBox6.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Длина по X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Смещение по X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Скорость по X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Длина по Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Смещение по Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Количество повторений";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(671, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "label7";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(396, 126);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(149, 32);
            this.button6.TabIndex = 47;
            this.button6.Text = "Запуск обработки";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.R);
            this.Controls.Add(this.y_shift);
            this.Controls.Add(this.y_lenght);
            this.Controls.Add(this.x_speed);
            this.Controls.Add(this.x_shift);
            this.Controls.Add(this.x_lenght);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Отбеливание Стекла";
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
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button6;
    }
}