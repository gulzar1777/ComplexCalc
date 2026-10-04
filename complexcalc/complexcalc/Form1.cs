using System;
using System.Windows.Forms;

namespace Complex_Calculator
{
    public partial class Form1 : Form
    {
        double firstNumber = 0;
        string operation = "";
        bool click = false;

        public Form1()
        {
            InitializeComponent();
            richTextBox1.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // =========================
        // RƏQƏMLƏR
        // =========================

        private void Number_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }

            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }

            richTextBox1.Text += button.Text;
        }

        // =========================
        // ƏMƏLİYYAT
        // =========================

        private void Operation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            try
            {
                firstNumber = Convert.ToDouble(richTextBox1.Text);
                operation = button.Text;
                click = true;
            }
            catch
            {
                MessageBox.Show("Yanlış ədəd!");
            }
        }

        // =========================
        // BƏRABƏR
        // =========================

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            try
            {
                double secondNumber = Convert.ToDouble(richTextBox1.Text);
                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;

                    case "-":
                        result = firstNumber - secondNumber;
                        break;

                    case "×":
                        result = firstNumber * secondNumber;
                        break;

                    case "÷":
                        if (secondNumber == 0)
                        {
                            MessageBox.Show("0-a bölmək olmaz!");
                            return;
                        }

                        result = firstNumber / secondNumber;
                        break;
                }

                richTextBox1.Text = result.ToString();
                click = true;
                operation = "";
            }
            catch
            {
                MessageBox.Show("Əməliyyat düzgün deyil!");
            }
        }

        // =========================
        // KVADRAT
        // =========================

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            try
            {
                double number = Convert.ToDouble(richTextBox1.Text);

                double result = number * number;

                richTextBox1.Text = result.ToString();
                click = true;
            }
            catch
            {
                MessageBox.Show("Yanlış ədəd!");
            }
        }

        // =========================
        // KÖK
        // =========================

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            try
            {
                double number = Convert.ToDouble(richTextBox1.Text);

                if (number < 0)
                {
                    MessageBox.Show("Mənfi ədədin həqiqi kökü yoxdur!");
                    return;
                }

                double result = Math.Sqrt(number);

                richTextBox1.Text = result.ToString();
                click = true;
            }
            catch
            {
                MessageBox.Show("Yanlış ədəd!");
            }
        }

        // =========================
        // TƏMİZLƏ
        // =========================

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";

            firstNumber = 0;
            operation = "";
            click = false;
        }

        // =========================
        // BACKSPACE
        // =========================

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 1)
            {
                richTextBox1.Text =
                    richTextBox1.Text.Substring(
                        0,
                        richTextBox1.Text.Length - 1
                    );
            }
            else
            {
                richTextBox1.Text = "0";
            }
        }
    }
}
