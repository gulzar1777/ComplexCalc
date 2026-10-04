namespace Complex_Calculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.RichTextBox richTextBox1;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button5;

        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;

        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonSqrt;

        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();

            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();

            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();

            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();

            this.button5 = new System.Windows.Forms.Button();

            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();

            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonSqrt = new System.Windows.Forms.Button();

            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // DISPLAY
            this.richTextBox1.Font =
                new System.Drawing.Font("Segoe UI", 24F);

            this.richTextBox1.Location =
                new System.Drawing.Point(20, 20);

            this.richTextBox1.Name =
                "richTextBox1";

            this.richTextBox1.ReadOnly = true;

            this.richTextBox1.Size =
                new System.Drawing.Size(425, 65);

            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "0";

            // 1
            this.button1.Location =
                new System.Drawing.Point(20, 105);

            this.button1.Size =
                new System.Drawing.Size(75, 55);

            this.button1.Name = "button1";
            this.button1.Text = "1";

            this.button1.Click +=
                new System.EventHandler(this.Number_Click);

            // 2
            this.button8.Location =
                new System.Drawing.Point(105, 105);

            this.button8.Size =
                new System.Drawing.Size(75, 55);

            this.button8.Name = "button8";
            this.button8.Text = "2";

            this.button8.Click +=
                new System.EventHandler(this.Number_Click);

            // 3
            this.button12.Location =
                new System.Drawing.Point(190, 105);

            this.button12.Size =
                new System.Drawing.Size(75, 55);

            this.button12.Name = "button12";
            this.button12.Text = "3";

            this.button12.Click +=
                new System.EventHandler(this.Number_Click);

            // +
            this.buttonPlus.Location =
                new System.Drawing.Point(285, 105);

            this.buttonPlus.Size =
                new System.Drawing.Size(75, 55);

            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Text = "+";

            this.buttonPlus.Click +=
                new System.EventHandler(this.Operation_Click);

            // 4
            this.button2.Location =
                new System.Drawing.Point(20, 170);

            this.button2.Size =
                new System.Drawing.Size(75, 55);

            this.button2.Name = "button2";
            this.button2.Text = "4";

            this.button2.Click +=
                new System.EventHandler(this.Number_Click);

            // 5
            this.button7.Location =
                new System.Drawing.Point(105, 170);

            this.button7.Size =
                new System.Drawing.Size(75, 55);

            this.button7.Name = "button7";
            this.button7.Text = "5";

            this.button7.Click +=
                new System.EventHandler(this.Number_Click);

            // 6
            this.button11.Location =
                new System.Drawing.Point(190, 170);

            this.button11.Size =
                new System.Drawing.Size(75, 55);

            this.button11.Name = "button11";
            this.button11.Text = "6";

            this.button11.Click +=
                new System.EventHandler(this.Number_Click);

            // -
            this.buttonMinus.Location =
                new System.Drawing.Point(285, 170);

            this.buttonMinus.Size =
                new System.Drawing.Size(75, 55);

            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Text = "-";

            this.buttonMinus.Click +=
                new System.EventHandler(this.Operation_Click);

            // 7
            this.button3.Location =
                new System.Drawing.Point(20, 235);

            this.button3.Size =
                new System.Drawing.Size(75, 55);

            this.button3.Name = "button3";
            this.button3.Text = "7";

            this.button3.Click +=
                new System.EventHandler(this.Number_Click);

            // 8
            this.button6.Location =
                new System.Drawing.Point(105, 235);

            this.button6.Size =
                new System.Drawing.Size(75, 55);

            this.button6.Name = "button6";
            this.button6.Text = "8";

            this.button6.Click +=
                new System.EventHandler(this.Number_Click);

            // 9
            this.button10.Location =
                new System.Drawing.Point(190, 235);

            this.button10.Size =
                new System.Drawing.Size(75, 55);

            this.button10.Name = "button10";
            this.button10.Text = "9";

            this.button10.Click +=
                new System.EventHandler(this.Number_Click);

            // ×
            this.buttonMultiply.Location =
                new System.Drawing.Point(285, 235);

            this.buttonMultiply.Size =
                new System.Drawing.Size(75, 55);

            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Text = "×";

            this.buttonMultiply.Click +=
                new System.EventHandler(this.Operation_Click);

            // C
            this.buttonClear.Location =
                new System.Drawing.Point(20, 300);

            this.buttonClear.Size =
                new System.Drawing.Size(75, 55);

            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Text = "C";

            this.buttonClear.Click +=
                new System.EventHandler(this.buttonClear_Click);

            // 0
            this.button5.Location =
                new System.Drawing.Point(105, 300);

            this.button5.Size =
                new System.Drawing.Size(75, 55);

            this.button5.Name = "button5";
            this.button5.Text = "0";

            this.button5.Click +=
                new System.EventHandler(this.Number_Click);

            // Back
            this.buttonBack.Location =
                new System.Drawing.Point(190, 300);

            this.buttonBack.Size =
                new System.Drawing.Size(75, 55);

            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Text = "⌫";

            this.buttonBack.Click +=
                new System.EventHandler(this.buttonBack_Click);

            // ÷
            this.buttonDivide.Location =
                new System.Drawing.Point(285, 300);

            this.buttonDivide.Size =
                new System.Drawing.Size(75, 55);

            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Text = "÷";

            this.buttonDivide.Click +=
                new System.EventHandler(this.Operation_Click);

            // x²
            this.buttonSquare.Location =
                new System.Drawing.Point(380, 105);

            this.buttonSquare.Size =
                new System.Drawing.Size(65, 55);

            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Text = "x²";

            this.buttonSquare.Click +=
                new System.EventHandler(this.buttonSquare_Click);

            // √
            this.buttonSqrt.Location =
                new System.Drawing.Point(380, 170);

            this.buttonSqrt.Size =
                new System.Drawing.Size(65, 55);

            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Text = "√";

            this.buttonSqrt.Click +=
                new System.EventHandler(this.buttonSqrt_Click);

            // =
            this.buttonEqual.Location =
                new System.Drawing.Point(380, 235);

            this.buttonEqual.Size =
                new System.Drawing.Size(65, 120);

            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Text = "=";

            this.buttonEqual.Click +=
                new System.EventHandler(this.buttonEqual_Click);

            // FORM
            this.ClientSize =
                new System.Drawing.Size(470, 390);

            this.Controls.Add(this.richTextBox1);

            this.Controls.Add(this.button1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button12);

            this.Controls.Add(this.button2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button11);

            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button10);

            this.Controls.Add(this.button5);

            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonDivide);

            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonSquare);
            this.Controls.Add(this.buttonSqrt);

            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonBack);

            this.Name = "Form1";
            this.Text = "Complex Calculator";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Load +=
                new System.EventHandler(this.Form1_Load);

            this.ResumeLayout(false);
        }
    }
}

