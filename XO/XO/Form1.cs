using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO
{
    public partial class Form1 : Form
    {
        public Boolean turn = true, jer = false;
        public string write = "X";

        public Form1()
        {
            InitializeComponent();
        }

        private void GetTurn() 
        {
            if (turn == true)
            {
                write = "X";
            }
            else
            {
                write = "O";
            }
        }

        private void ChangeTurn() 
        {
            turn = !turn;
        }

        private void ActiveButtonFound()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void SetUpdateFound()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        private void CheckWin()
        {
            string [,] arr = {{button1.Text,button2.Text,button3.Text},{button4.Text,button5.Text,button6.Text},{button7.Text,button8.Text,button9.Text},{button1.Text,button4.Text,button7.Text},{button2.Text,button5.Text,button8.Text},{button3.Text,button6.Text,button9.Text},{button1.Text,button5.Text,button9.Text},{button3.Text,button5.Text,button7.Text}};
            for (int i = 0; i < 8; i++)
            {
                if ((arr[i, 0] == arr[i, 1]) && (arr[i, 1] == arr[i, 2]) && (arr[i,0] != "" || arr[i,1] != "" || arr[i,2] != ""))
                {
                    MessageBox.Show("Turn " + arr[i, 0] + " is win. ");
                    jer = true;
                    ActiveButtonFound();
                    break;
                }
            }
            if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false && jer == false)
            {
                MessageBox.Show("Both players are draw. ");
                jer = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetTurn();
            button1.Text = write;
            ChangeTurn();
            button1.Enabled = false;
            CheckWin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetTurn();
            button2.Text = write;
            ChangeTurn();
            button2.Enabled = false;
            CheckWin();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetTurn();
            button3.Text = write;
            ChangeTurn();
            button3.Enabled = false;
            CheckWin();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetTurn();
            button4.Text = write;
            ChangeTurn();
            button4.Enabled = false;
            CheckWin();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GetTurn();
            button5.Text = write;
            ChangeTurn();
            button5.Enabled = false;
            CheckWin();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GetTurn();
            button6.Text = write;
            ChangeTurn();
            button6.Enabled = false;
            CheckWin();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GetTurn();
            button7.Text = write;
            ChangeTurn();
            button7.Enabled = false;
            CheckWin();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GetTurn();
            button8.Text = write;
            ChangeTurn();
            button8.Enabled = false;
            CheckWin();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GetTurn();
            button9.Text = write;
            ChangeTurn();
            button9.Enabled = false;
            CheckWin();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SetUpdateFound();
            turn = true;
            write = "X";
            jer = false;
        }
    }
}
