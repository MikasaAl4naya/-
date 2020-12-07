namespace particles
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
            this.tbDirection = new System.Windows.Forms.TrackBar();
            this.lblDirection = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSpreading = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGraviton2 = new System.Windows.Forms.Label();
            this.tbEllipse = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lbY = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.CngColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEllipse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbY)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(9, 12);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(1144, 526);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbDirection
            // 
            this.tbDirection.Location = new System.Drawing.Point(10, 559);
            this.tbDirection.Maximum = 359;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(142, 45);
            this.tbDirection.TabIndex = 1;
            this.tbDirection.Scroll += new System.EventHandler(this.tbDirection_Scroll);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(152, 559);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(0, 13);
            this.lblDirection.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 541);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Направление";
            // 
            // lblSpreading
            // 
            this.lblSpreading.AutoSize = true;
            this.lblSpreading.Location = new System.Drawing.Point(316, 559);
            this.lblSpreading.Name = "lblSpreading";
            this.lblSpreading.Size = new System.Drawing.Size(0, 13);
            this.lblSpreading.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 541);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Размер всех точек";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblGraviton2
            // 
            this.lblGraviton2.AutoSize = true;
            this.lblGraviton2.Location = new System.Drawing.Point(296, 559);
            this.lblGraviton2.Name = "lblGraviton2";
            this.lblGraviton2.Size = new System.Drawing.Size(0, 13);
            this.lblGraviton2.TabIndex = 8;
            // 
            // tbEllipse
            // 
            this.tbEllipse.Location = new System.Drawing.Point(154, 559);
            this.tbEllipse.Maximum = 359;
            this.tbEllipse.Name = "tbEllipse";
            this.tbEllipse.Size = new System.Drawing.Size(142, 45);
            this.tbEllipse.TabIndex = 10;
            this.tbEllipse.Scroll += new System.EventHandler(this.tbEllipse_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(681, 564);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Вкл\\Выкл гравитацию";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(684, 580);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(105, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Гравитация вкл";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(684, 603);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(113, 17);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.Text = "Гравитация выкл";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // lbY
            // 
            this.lbY.Location = new System.Drawing.Point(302, 559);
            this.lbY.Maximum = 359;
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(142, 45);
            this.lbY.TabIndex = 16;
            this.lbY.Scroll += new System.EventHandler(this.lbY_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 541);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Перемещение точек по горизонтали";
            // 
            // CngColor
            // 
            this.CngColor.Location = new System.Drawing.Point(985, 574);
            this.CngColor.Name = "CngColor";
            this.CngColor.Size = new System.Drawing.Size(75, 23);
            this.CngColor.TabIndex = 18;
            this.CngColor.Text = "button1";
            this.CngColor.UseVisualStyleBackColor = true;
            this.CngColor.Click += new System.EventHandler(this.CngColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 645);
            this.Controls.Add(this.CngColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbY);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbEllipse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblGraviton2);
            this.Controls.Add(this.lblSpreading);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.tbDirection);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEllipse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbDirection;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSpreading;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGraviton2;
        private System.Windows.Forms.TrackBar tbEllipse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TrackBar lbY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CngColor;
    }
}

