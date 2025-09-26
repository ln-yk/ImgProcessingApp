namespace ImageProcessingApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            tabPage2 = new TabPage();
            button5 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            tabPage3 = new TabPage();
            checkBox1 = new CheckBox();
            comboBoxCameras = new ComboBox();
            button17 = new Button();
            button16 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            label4 = new Label();
            label3 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(1, 9);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1137, 526);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Controls.Add(button8);
            tabPage1.Controls.Add(button7);
            tabPage1.Controls.Add(button6);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1129, 493);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Basic Image Process";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(858, 5);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 34;
            label2.Text = "Processed Image";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 5);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 33;
            label1.Text = "Loaded Image";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Control;
            pictureBox2.Location = new Point(704, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(401, 320);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button8
            // 
            button8.Location = new Point(994, 437);
            button8.Name = "button8";
            button8.Size = new Size(111, 29);
            button8.TabIndex = 31;
            button8.Text = "Save Image";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(18, 437);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 30;
            button7.Text = "Copy";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(855, 437);
            button6.Name = "button6";
            button6.Size = new Size(133, 29);
            button6.TabIndex = 29;
            button6.Text = "Load Image";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.Location = new Point(418, 437);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 28;
            button4.Text = "Histogram";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(318, 437);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 27;
            button3.Text = "Sepia";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(218, 437);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 26;
            button2.Text = "Invert";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(118, 437);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 25;
            button1.Text = "Grayscale";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Location = new Point(18, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(401, 320);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(button9);
            tabPage2.Controls.Add(button10);
            tabPage2.Controls.Add(button11);
            tabPage2.Controls.Add(button12);
            tabPage2.Controls.Add(pictureBox3);
            tabPage2.Controls.Add(pictureBox4);
            tabPage2.Controls.Add(pictureBox5);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1129, 493);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Subtraction Process";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(309, 401);
            button5.Name = "button5";
            button5.Size = new Size(117, 29);
            button5.TabIndex = 16;
            button5.Text = "Clear Images";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button9
            // 
            button9.Location = new Point(909, 397);
            button9.Name = "button9";
            button9.Size = new Size(108, 37);
            button9.TabIndex = 15;
            button9.Text = "Save";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(909, 342);
            button10.Name = "button10";
            button10.Size = new Size(108, 29);
            button10.TabIndex = 14;
            button10.Text = "Subtract";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(482, 342);
            button11.Name = "button11";
            button11.Size = new Size(153, 29);
            button11.TabIndex = 13;
            button11.Text = "Load Background";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(107, 342);
            button12.Name = "button12";
            button12.Size = new Size(99, 29);
            button12.TabIndex = 12;
            button12.Text = "Load Image";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.Control;
            pictureBox3.Location = new Point(806, 58);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(308, 236);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.Control;
            pictureBox4.Location = new Point(410, 58);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(308, 236);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.Control;
            pictureBox5.Location = new Point(15, 58);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(308, 236);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(checkBox1);
            tabPage3.Controls.Add(comboBoxCameras);
            tabPage3.Controls.Add(button17);
            tabPage3.Controls.Add(button16);
            tabPage3.Controls.Add(button13);
            tabPage3.Controls.Add(button14);
            tabPage3.Controls.Add(button15);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(pictureBox6);
            tabPage3.Controls.Add(pictureBox7);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1129, 493);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "WebCam Process";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(150, 433);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(149, 24);
            checkBox1.TabIndex = 46;
            checkBox1.Text = "Activate WebCam";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // comboBoxCameras
            // 
            comboBoxCameras.FormattingEnabled = true;
            comboBoxCameras.Location = new Point(87, 383);
            comboBoxCameras.Name = "comboBoxCameras";
            comboBoxCameras.Size = new Size(287, 28);
            comboBoxCameras.TabIndex = 45;
            comboBoxCameras.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button17
            // 
            button17.Location = new Point(839, 430);
            button17.Name = "button17";
            button17.Size = new Size(136, 29);
            button17.TabIndex = 44;
            button17.Text = "Clear Effects";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // button16
            // 
            button16.Location = new Point(1010, 383);
            button16.Name = "button16";
            button16.Size = new Size(94, 29);
            button16.TabIndex = 43;
            button16.Text = "Subtract";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button13
            // 
            button13.Location = new Point(910, 383);
            button13.Name = "button13";
            button13.Size = new Size(94, 29);
            button13.TabIndex = 42;
            button13.Text = "Sepia";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Location = new Point(810, 383);
            button14.Name = "button14";
            button14.Size = new Size(94, 29);
            button14.TabIndex = 41;
            button14.Text = "Invert";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.Location = new Point(710, 383);
            button15.Name = "button15";
            button15.Size = new Size(94, 29);
            button15.TabIndex = 40;
            button15.Text = "Grayscale";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(184, 9);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 39;
            label4.Text = "WebCam";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(861, 9);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 38;
            label3.Text = "Processed Image";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = SystemColors.Control;
            pictureBox6.Location = new Point(707, 29);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(401, 320);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 36;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = SystemColors.Control;
            pictureBox7.Location = new Point(21, 29);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(401, 320);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 35;
            pictureBox7.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 534);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Image Processing App";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button button5;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label3;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private Label label4;
        private Button button17;
        private Button button16;
        private Button button13;
        private Button button14;
        private Button button15;
        private ComboBox comboBoxCameras;
        private CheckBox checkBox1;
    }
}
