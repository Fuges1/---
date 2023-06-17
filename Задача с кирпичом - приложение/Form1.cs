using System;

namespace Задача_с_кирпичом___приложение
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            label1.Visible = false;
            button2.Visible = true;

            pictureBox1.Visible = true;
            pictureBox4.Visible = true;
            button1.Visible = false;
            button3.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = true;
            comboBox4.Visible = true;
            comboBox5.Visible = true;

        }


        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label9.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label9.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string g = comboBox1.Text;
            string t = comboBox2.Text;
            string u = comboBox3.Text;
            string j = comboBox4.Text;
            string o = comboBox5.Text;

            Double a;
            Double b;
            Double X;
            Double Y;
            Double Z;

            comboBox1.Items.Add(g);
            comboBox2.Items.Add(t);
            comboBox3.Items.Add(u);
            comboBox4.Items.Add(j);
            comboBox5.Items.Add(o);
            if (g == "," || g == "" || t == "," || t == "" || u == "," || u == "" || j == "," || j == "" || o == "," || o == "")
            {
                MessageBox.Show("Поле не может быть пустым или содержать только ',''", "Ошибка");
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox4.Items.Clear();
                comboBox5.Items.Clear();
            }
            else
            {
                a = Convert.ToDouble(g); //Ширина отверстия
                b = Convert.ToDouble(t); //Длина отверстия
                X = Convert.ToDouble(u); //Длина кирпича
                Y = Convert.ToDouble(j); //Ширина кирпича
                Z = Convert.ToDouble(o); //Высота кирпича


                if (a <= 0 || b <= 0 || X <= 0 || Y <= 0 || Z <= 0)
                {

                    MessageBox.Show("Возможно одно из значений меньше или равно 0", "Ошибка");
                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox4.Items.Clear();
                    comboBox5.Items.Clear();
                }
                else
                {
                    if (Z > a || X > b)
                    {
                        label10.Visible = true;
                        label10.Text = "Кирпич не пройдёт через отверстие";
                        pictureBox6.Visible = true;
                        button3.Visible = false;
                        button4.Visible = true;
                        pictureBox4.Visible = false;
                    }
                    else
                    {
                        label10.Visible = true;
                        label10.Text = "Кирпич пройдёт через отверстие";
                        pictureBox5.Visible = true;
                        button3.Visible = false;
                        button4.Visible = true;
                        pictureBox4.Visible = false;
                    }
                }

            }


        }

        private void label10_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void label8_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
        }

        private void label7_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Visible = true;
            
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            label11.Visible = true;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            label11.Visible = false;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ',' && comboBox1.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ',' && comboBox2.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ',' && comboBox3.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ',' && comboBox4.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void comboBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ',' && comboBox5.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void zkirpich_Click(object sender, EventArgs e)
        {

        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            Akirpich.Visible = true;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            Akirpich.Visible = false;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            Bkirpich.Visible = true;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            Bkirpich.Visible = false;
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            xkirpich.Visible = true;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            xkirpich.Visible = false;
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            ykirpich.Visible = true;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            ykirpich.Visible = false;
        }

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            zkirpich.Visible = true;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            zkirpich.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            double minValue = 1.0;
            double maxValue = 100.0;
            double randomValue = random.NextDouble() * (maxValue - minValue) + minValue;
            double randomValue1 = random.NextDouble() * (maxValue - minValue) + minValue;
            double roundedValue = Math.Round(randomValue, 2);
            double roundedValue1 = Math.Round(randomValue1, 2);
            if (comboBox1.Text == "" && comboBox2.Text == "")
            {
                comboBox1.Text = Convert.ToString(roundedValue);
                comboBox2.Text = Convert.ToString(roundedValue1);
                comboBox1.Items.Add(roundedValue);
                comboBox2.Items.Add(roundedValue1);


            }
            else
            {

                MessageBox.Show("Возможно вы вписали цифру или ','. Поле 'A' и 'B' должно быть пустым", "Ошибка");
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();

            }
        }
    }
}