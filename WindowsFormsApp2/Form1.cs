using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        double value;
        string soperator;
        bool check;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void PNumber(object sender, EventArgs e)
        {
            if ((soperator == "+") || (soperator == "-") || (soperator == "*") || (soperator == "/"))
            {
                if (check)
                {
                    check = false;
                    textResult.Text = "0";
                }
            }
            Button b = sender as Button;
            if (textResult.Text == "0")
                textResult.Text = b.Text;
            else
                textResult.Text += b.Text;
        }

        private void Poperator (object sender, EventArgs e)
        {
            Button b = sender as Button;
            value = double.Parse(textResult.Text);
            soperator = b.Text;
            textResult.Text += b.Text;
            check = true;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textResult.Text = "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textResult.Text = "0";
            value = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                switch (soperator)
                {
                    case "+":
                        textResult.Text = (value + double.Parse(textResult.Text)).ToString();
                        break;
                    case "-":
                        textResult.Text = (value - double.Parse(textResult.Text)).ToString();
                        break;
                    case "*":
                        textResult.Text = (value * double.Parse(textResult.Text)).ToString();
                        break;
                    case "/":
                        textResult.Text = (value / double.Parse(textResult.Text)).ToString();
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Red)
            {
                this.BackColor = Color.White;
            }
            else if (this.BackColor == Color.White)
            {
                this.BackColor = Color.Purple;
            }
            else
            {
                this.BackColor = Color.Red;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (label1.ForeColor == Color.Red)
            {
                label1.ForeColor = Color.Black;
            }
            else if (label1.ForeColor == Color.Black)
            {
                label1.ForeColor = Color.Purple;
            }
            else
            {
                label1.ForeColor = Color.Red;
            }
        }
    }
}
