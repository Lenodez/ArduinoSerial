namespace ArduinoSerial
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.speed_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Acceleration_Box = new System.Windows.Forms.ComboBox();
            this.Set_accel = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 276);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 48);
            this.button1.TabIndex = 16;
            this.button1.Text = "К выбору порта";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(187, 94);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(149, 32);
            this.button6.TabIndex = 31;
            this.button6.Text = "К двигателю";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "label1";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(29, 94);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(149, 32);
            this.button5.TabIndex = 29;
            this.button5.Text = "От двигателя";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(29, 32);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 28;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(53, 22);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "МкМ";
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM5";
            // 
            // speed_box
            // 
            this.speed_box.Location = new System.Drawing.Point(492, 123);
            this.speed_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.speed_box.Name = "speed_box";
            this.speed_box.Size = new System.Drawing.Size(132, 22);
            this.speed_box.TabIndex = 32;
            this.speed_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.speed_box_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(660, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Скорость";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(109, 196);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 32);
            this.button2.TabIndex = 36;
            this.button2.Text = "СТОП";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(583, 402);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 54);
            this.button3.TabIndex = 37;
            this.button3.Text = "Задать как ноль текущую позицию";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(583, 316);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 52);
            this.button4.TabIndex = 38;
            this.button4.Text = "Калибровать ноль по началу ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Acceleration_Box
            // 
            this.Acceleration_Box.FormattingEnabled = true;
            this.Acceleration_Box.Items.AddRange(new object[] {
            "400",
            "800",
            "1600",
            "3200",
            "6400"});
            this.Acceleration_Box.Location = new System.Drawing.Point(492, 235);
            this.Acceleration_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Acceleration_Box.Name = "Acceleration_Box";
            this.Acceleration_Box.Size = new System.Drawing.Size(132, 24);
            this.Acceleration_Box.TabIndex = 39;
            // 
            // Set_accel
            // 
            this.Set_accel.Location = new System.Drawing.Point(492, 185);
            this.Set_accel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Set_accel.Name = "Set_accel";
            this.Set_accel.Size = new System.Drawing.Size(133, 43);
            this.Set_accel.TabIndex = 40;
            this.Set_accel.Text = "Установить ускорение";
            this.Set_accel.UseVisualStyleBackColor = true;
            this.Set_accel.Click += new System.EventHandler(this.Set_accel_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(29, 133);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(149, 32);
            this.button7.TabIndex = 41;
            this.button7.Text = "От двигателя";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(187, 133);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(149, 32);
            this.button8.TabIndex = 42;
            this.button8.Text = "К двигателю";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 471);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.Set_accel);
            this.Controls.Add(this.Acceleration_Box);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.speed_box);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Мануальное управление";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox speed_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox Acceleration_Box;
        private System.Windows.Forms.Button Set_accel;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}