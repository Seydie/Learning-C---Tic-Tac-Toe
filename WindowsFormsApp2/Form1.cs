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
    public partial class Form : System.Windows.Forms.Form
    {
        bool Player1 = true;

        public Form()
        {
            InitializeComponent();
            b1.Click += ClickCheck;
            b2.Click += ClickCheck;
            b3.Click += ClickCheck;
            b4.Click += ClickCheck;
            b5.Click += ClickCheck;
            b6.Click += ClickCheck;
            b7.Click += ClickCheck;
            b8.Click += ClickCheck;
            b9.Click += ClickCheck;
        }

        private void bexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void babout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Kayleigh van de Wiel");
        }

        private void ClickCheck(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button b = sender as Button;

                if (Player1 == true && b.Text == "")
                {
                    b.Text = "X";
                    Player1 = false;
                }
                else if (b.Text == "X" || b.Text == "O") {
                    MessageBox.Show("Oops!");
                }
                else
                {
                    b.Text = "O";
                    Player1 = true;
                }

                if ((b1.Text == "X" && b2.Text == "X" && b3.Text == "X") || (b1.Text == "X" && b4.Text == "X" && b7.Text == "X") || (b1.Text == "X" && b5.Text == "X" && b9.Text == "X") || (b2.Text == "X" && b5.Text == "X" && b8.Text == "X") || (b3.Text == "X" && b5.Text == "X" && b7.Text == "X") || (b3.Text == "X" && b6.Text == "X" && b9.Text == "X") || (b7.Text == "X" && b8.Text == "X" && b9.Text == "X") || (b4.Text == "X" && b5.Text == "X" && b6.Text == "X"))
                {
                    MessageBox.Show("Player 1 win!");
                    b1.Text = "";
                    b2.Text = "";
                    b3.Text = "";
                    b4.Text = "";
                    b5.Text = "";
                    b6.Text = "";
                    b7.Text = "";
                    b8.Text = "";
                    b9.Text = "";
                    Player1 = false;
                }
                if ((b1.Text == "O" && b2.Text == "O" && b3.Text == "O") || (b1.Text == "O" && b4.Text == "O" && b7.Text == "O") || (b1.Text == "O" && b5.Text == "O" && b9.Text == "O") || (b2.Text == "O" && b5.Text == "O" && b8.Text == "O") || (b3.Text == "O" && b5.Text == "O" && b7.Text == "O") || (b3.Text == "O" && b6.Text == "O" && b9.Text == "O") || (b7.Text == "O" && b8.Text == "O" && b9.Text == "O") || (b4.Text == "O" && b5.Text == "O" && b6.Text == "O"))
                {
                    MessageBox.Show("Player 2 win!");
                    b1.Text = "";
                    b2.Text = "";
                    b3.Text = "";
                    b4.Text = "";
                    b5.Text = "";
                    b6.Text = "";
                    b7.Text = "";
                    b8.Text = "";
                    b9.Text = "";
                    Player1 = true;
                }
            }
            else
            {
                MessageBox.Show("Oops! Something went wrong!");
                Application.Exit();
            }
               
        }

        private void bretry_Click(object sender, EventArgs e)
        {
            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            b4.Text = "";
            b5.Text = "";
            b6.Text = "";
            b7.Text = "";
            b8.Text = "";
            b9.Text = "";
            Player1 = true;
        }
    }
}
