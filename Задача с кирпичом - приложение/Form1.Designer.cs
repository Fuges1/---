using System.Windows.Forms;

namespace Задача_с_кирпичом___приложение
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label11 = new Label();
            Akirpich = new Label();
            Bkirpich = new Label();
            xkirpich = new Label();
            ykirpich = new Label();
            zkirpich = new Label();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(94, 172);
            button1.Name = "button1";
            button1.Size = new Size(294, 32);
            button1.TabIndex = 0;
            button1.Text = "Начать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Brown;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.SeaShell;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(29, 35);
            label1.Name = "label1";
            label1.Size = new Size(447, 64);
            label1.TabIndex = 1;
            label1.Text = "Задача с кирпичом";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(20, 59);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            comboBox1.Visible = false;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.KeyPress += comboBox1_KeyPress;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(20, 88);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 3;
            comboBox2.Visible = false;
            comboBox2.KeyPress += comboBox2_KeyPress;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(195, 27);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 4;
            comboBox3.Visible = false;
            comboBox3.KeyPress += comboBox3_KeyPress;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(195, 56);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 5;
            comboBox4.Visible = false;
            comboBox4.KeyPress += comboBox4_KeyPress;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(195, 88);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(121, 23);
            comboBox5.TabIndex = 6;
            comboBox5.Visible = false;
            comboBox5.KeyPress += comboBox5_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 67);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 7;
            label2.Text = "A";
            label2.Visible = false;
            label2.MouseLeave += label2_MouseLeave;
            label2.MouseMove += label2_MouseMove;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 93);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 8;
            label3.Text = "B";
            label3.Visible = false;
            label3.MouseLeave += label3_MouseLeave;
            label3.MouseMove += label3_MouseMove;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(322, 30);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 9;
            label4.Text = "x";
            label4.Visible = false;
            label4.MouseLeave += label4_MouseLeave;
            label4.MouseMove += label4_MouseMove;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(322, 59);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 10;
            label5.Text = "y";
            label5.Visible = false;
            label5.MouseLeave += label5_MouseLeave;
            label5.MouseMove += label5_MouseMove;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(322, 91);
            label6.Name = "label6";
            label6.Size = new Size(12, 15);
            label6.TabIndex = 11;
            label6.Text = "z";
            label6.Visible = false;
            label6.MouseLeave += label6_MouseLeave;
            label6.MouseMove += label6_MouseMove;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(20, 117);
            button2.Name = "button2";
            button2.Size = new Size(303, 32);
            button2.TabIndex = 12;
            button2.Text = "ОК";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(53, 41);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 13;
            label7.Text = "Отверстие";
            label7.Visible = false;
            label7.MouseLeave += label7_MouseLeave;
            label7.MouseMove += label7_MouseMove;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(229, 9);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 14;
            label8.Text = "Кирпич";
            label8.Visible = false;
            label8.MouseLeave += label8_MouseLeave;
            label8.MouseMove += label8_MouseMove;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 152);
            label9.Name = "label9";
            label9.Size = new Size(484, 75);
            label9.TabIndex = 15;
            label9.Text = resources.GetString("label9.Text");
            label9.Visible = false;
            label9.Click += label9_Click;
            // 
            // button3
            // 
            button3.Location = new Point(42, 5);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 16;
            button3.Text = "Random";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            button3.MouseLeave += button3_MouseLeave;
            button3.MouseMove += button3_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImage = Properties.Resources.Info;
            pictureBox1.ImageLocation = "C:\\Users\\telaz\\source\\repos\\Задача с кирпичом - приложение\\Задача с кирпичом - приложение\\pictures\\Info.png";
            pictureBox1.Location = new Point(6, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 152);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 18;
            label10.Text = "label10";
            label10.Visible = false;
            label10.VisibleChanged += label10_VisibleChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.g;
            pictureBox2.Location = new Point(341, -17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(169, 408);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.f;
            pictureBox3.Location = new Point(322, 41);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(198, 113);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 152);
            label11.Name = "label11";
            label11.Size = new Size(446, 15);
            label11.TabIndex = 21;
            label11.Text = "Если нажмёте то сгенерируете переменные \"A\" и \"B\" случайно. (от 100,0 до 1,0)";
            label11.Visible = false;
            // 
            // Akirpich
            // 
            Akirpich.AutoSize = true;
            Akirpich.Location = new Point(7, 182);
            Akirpich.Name = "Akirpich";
            Akirpich.Size = new Size(110, 15);
            Akirpich.TabIndex = 22;
            Akirpich.Text = "Ширина отверстия";
            Akirpich.Visible = false;
            // 
            // Bkirpich
            // 
            Bkirpich.AutoSize = true;
            Bkirpich.Location = new Point(6, 182);
            Bkirpich.Name = "Bkirpich";
            Bkirpich.Size = new Size(100, 15);
            Bkirpich.TabIndex = 23;
            Bkirpich.Text = "Длина отверстия";
            Bkirpich.Visible = false;
            // 
            // xkirpich
            // 
            xkirpich.AutoSize = true;
            xkirpich.Location = new Point(6, 182);
            xkirpich.Name = "xkirpich";
            xkirpich.Size = new Size(92, 15);
            xkirpich.TabIndex = 24;
            xkirpich.Text = "Длина кирпича";
            xkirpich.Visible = false;
            // 
            // ykirpich
            // 
            ykirpich.AutoSize = true;
            ykirpich.Location = new Point(7, 182);
            ykirpich.Name = "ykirpich";
            ykirpich.Size = new Size(105, 15);
            ykirpich.TabIndex = 25;
            ykirpich.Text = "Ширина кирпича ";
            ykirpich.Visible = false;
            // 
            // zkirpich
            // 
            zkirpich.AutoSize = true;
            zkirpich.Location = new Point(7, 182);
            zkirpich.Name = "zkirpich";
            zkirpich.Size = new Size(97, 15);
            zkirpich.TabIndex = 26;
            zkirpich.Text = "Высота кирпича";
            zkirpich.Visible = false;
            zkirpich.Click += zkirpich_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.gg;
            pictureBox4.Location = new Point(276, -13);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(346, 270);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 27;
            pictureBox4.TabStop = false;
            pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.ggalka;
            pictureBox5.Location = new Point(341, -17);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(257, 475);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 28;
            pictureBox5.TabStop = false;
            pictureBox5.Visible = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.ggkrestik;
            pictureBox6.Location = new Point(341, -9);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(280, 467);
            pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox6.TabIndex = 29;
            pictureBox6.TabStop = false;
            pictureBox6.Visible = false;
            // 
            // button4
            // 
            button4.Location = new Point(42, 5);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 30;
            button4.Text = "Заново";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.d;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(502, 252);
            Controls.Add(label9);
            Controls.Add(zkirpich);
            Controls.Add(ykirpich);
            Controls.Add(xkirpich);
            Controls.Add(Bkirpich);
            Controls.Add(Akirpich);
            Controls.Add(label10);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(button4);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Задача с кирпичом";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button button1;
        public Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
        public Label label7;
        public Label label8;
        private Label label9;
        private Button button3;
        public PictureBox pictureBox1;
        private Label label10;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label11;
        private Label Akirpich;
        private Label Bkirpich;
        private Label xkirpich;
        private Label ykirpich;
        private Label zkirpich;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button button4;
    }
}