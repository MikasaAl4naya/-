namespace Курсачица
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDirection = new System.Windows.Forms.Label();
            this.lblSpreading = new System.Windows.Forms.Label();
            this.lblGraviton2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbY = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.CngColor = new System.Windows.Forms.Button();
            this.lbCount = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.GravitaionBar = new System.Windows.Forms.TrackBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GravitaionBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(9, 13);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(1221, 567);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(152, 602);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(0, 14);
            this.lblDirection.TabIndex = 2;
            // 
            // lblSpreading
            // 
            this.lblSpreading.AutoSize = true;
            this.lblSpreading.Location = new System.Drawing.Point(169, 602);
            this.lblSpreading.Name = "lblSpreading";
            this.lblSpreading.Size = new System.Drawing.Size(0, 14);
            this.lblSpreading.TabIndex = 5;
            // 
            // lblGraviton2
            // 
            this.lblGraviton2.AutoSize = true;
            this.lblGraviton2.Location = new System.Drawing.Point(149, 602);
            this.lblGraviton2.Name = "lblGraviton2";
            this.lblGraviton2.Size = new System.Drawing.Size(0, 14);
            this.lblGraviton2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poor Richard", 10F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(406, 585);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Гравитация";
            // 
            // lbY
            // 
            this.lbY.Location = new System.Drawing.Point(12, 602);
            this.lbY.Maximum = 359;
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(142, 45);
            this.lbY.TabIndex = 16;
            this.lbY.Scroll += new System.EventHandler(this.lbY_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 10F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(-5, 585);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Перемещение точек по вертикали";
            // 
            // CngColor
            // 
            this.CngColor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CngColor.Font = new System.Drawing.Font("Poor Richard", 14F, System.Drawing.FontStyle.Italic);
            this.CngColor.Location = new System.Drawing.Point(1271, 58);
            this.CngColor.Name = "CngColor";
            this.CngColor.Size = new System.Drawing.Size(167, 61);
            this.CngColor.TabIndex = 18;
            this.CngColor.Text = "Цвета по умолчанию";
            this.CngColor.UseVisualStyleBackColor = false;
            this.CngColor.Click += new System.EventHandler(this.CngColor_Click);
            // 
            // lbCount
            // 
            this.lbCount.Location = new System.Drawing.Point(210, 602);
            this.lbCount.Maximum = 200;
            this.lbCount.Minimum = 10;
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(142, 45);
            this.lbCount.TabIndex = 19;
            this.lbCount.Value = 10;
            this.lbCount.Scroll += new System.EventHandler(this.lbCount_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 10F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(223, 585);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Количество частиц";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 613);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 14);
            this.label5.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(1328, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 40);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Font = new System.Drawing.Font("Poor Richard", 14F, System.Drawing.FontStyle.Italic);
            this.button2.Location = new System.Drawing.Point(1255, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 48);
            this.button2.TabIndex = 24;
            this.button2.Text = "Запустить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.Font = new System.Drawing.Font("Poor Richard", 14F, System.Drawing.FontStyle.Italic);
            this.button3.Location = new System.Drawing.Point(1353, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 48);
            this.button3.TabIndex = 25;
            this.button3.Text = "Остановить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.Font = new System.Drawing.Font("Poor Richard", 14F, System.Drawing.FontStyle.Italic);
            this.button4.Location = new System.Drawing.Point(1288, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 59);
            this.button4.TabIndex = 26;
            this.button4.Text = "1 тик";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 613);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 14);
            this.label3.TabIndex = 29;
            // 
            // GravitaionBar
            // 
            this.GravitaionBar.Location = new System.Drawing.Point(380, 602);
            this.GravitaionBar.Minimum = 1;
            this.GravitaionBar.Name = "GravitaionBar";
            this.GravitaionBar.Size = new System.Drawing.Size(142, 45);
            this.GravitaionBar.TabIndex = 27;
            this.GravitaionBar.Value = 1;
            this.GravitaionBar.Scroll += new System.EventHandler(this.GravitaionBar_Scroll);
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Poor Richard", 14F, System.Drawing.FontStyle.Italic);
            this.checkBox1.Location = new System.Drawing.Point(1255, 228);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(202, 40);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "Выключить гравитацию";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(704, 613);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 14);
            this.label6.TabIndex = 33;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(556, 602);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(142, 45);
            this.trackBar1.TabIndex = 32;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poor Richard", 10F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(528, 585);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Минимальный радиус частицы";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(894, 613);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 14);
            this.label8.TabIndex = 36;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(746, 602);
            this.trackBar2.Maximum = 20;
            this.trackBar2.Minimum = 11;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(142, 45);
            this.trackBar2.TabIndex = 35;
            this.trackBar2.Value = 11;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poor Richard", 10F, System.Drawing.FontStyle.Italic);
            this.label9.Location = new System.Drawing.Point(743, 585);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Максимальный радиус частицы";
            // 
            // checkBox2
            // 
            this.checkBox2.Font = new System.Drawing.Font("Poor Richard", 14F, System.Drawing.FontStyle.Italic);
            this.checkBox2.Location = new System.Drawing.Point(1255, 274);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(75, 40);
            this.checkBox2.TabIndex = 37;
            this.checkBox2.Text = "Штука";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1450, 642);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GravitaionBar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.CngColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblGraviton2);
            this.Controls.Add(this.lblSpreading);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.picDisplay);
            this.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GravitaionBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Label lblSpreading;
        private System.Windows.Forms.Label lblGraviton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar lbY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CngColor;
        private System.Windows.Forms.TrackBar lbCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar GravitaionBar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

