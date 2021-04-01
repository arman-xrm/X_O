using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_O
{
    public partial class X_O : Form
    {
        bool btPush = true;
        sbyte pushCount = 0;
        public X_O()
        {
            InitializeComponent();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void X_O_Load(object sender, EventArgs e)
        {

        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void btA1_MouseEnter(object sender, EventArgs e)
        {

            Button bt = (Button)sender;
            if (bt.Enabled)
            {
                if (btPush)
                {
                    bt.Text = "X";
                }
                else
                {
                    bt.Text = "O";
                }
            }

        }

        private void btA1_MouseLeave(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (bt.Enabled)
            {
                bt.Text = "";
            }
        }

        private void btA1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (btPush)
            {
                bt.Text = "X";
            }
            else
            {
                bt.Text = "O";
            }
            btPush = !btPush;
            bt.Enabled = false;
            pushCount++;
            CheckWinner();
        }
        private void CheckWinner()
        {
            bool isWinner = false;
            if ((btA1.Text == btA2.Text) && (btA2.Text == btA3.Text) && !btA1.Enabled)
            {
                isWinner = true;
            }
            if ((btB1.Text == btB2.Text) && (btB2.Text == btB3.Text) && !btB1.Enabled)
            {
                isWinner = true;
            }
            if ((btC1.Text == btC2.Text) && (btC2.Text == btC3.Text) && !btC1.Enabled)
            {
                isWinner = true;
            }
            if ((btA1.Text == btB1.Text) && (btB1.Text == btC1.Text) && !btA1.Enabled)
            {
                isWinner = true;
            }
            if ((btA2.Text == btB2.Text) && (btB2.Text == btC2.Text) && !btA2.Enabled)
            {
                isWinner = true;
            }
            if ((btA3.Text == btB3.Text) && (btB3.Text == btC3.Text) && !btA3.Enabled)
            {
                isWinner = true;
            }
            if ((btA1.Text == btB2.Text) && (btB2.Text == btC3.Text) && !btA1.Enabled)
            {
                isWinner = true;
            }
            if ((btC1.Text == btB2.Text) && (btB2.Text == btA3.Text) && !btC1.Enabled)
            {
                isWinner = true;
            }
            if (isWinner)
            {
                string winner = "";
                if (btPush)
                {
                    lbOWinnerResult.Text = (int.Parse(lbOWinnerResult.Text) + 1).ToString();
                    winner = "O";
                }
                else
                {
                    lbXWinnerResult.Text = (int.Parse(lbXWinnerResult.Text) + 1).ToString();
                    winner = "X";
                }
                MessageBox.Show("winner is - " + winner);
                StartNewGame();
            }
            else
            {
                if (pushCount == 9)
                {
                    MessageBox.Show("We don't havy any Winner");
                    lbNoWinnerResult.Text = (int.Parse(lbNoWinnerResult.Text) + 1).ToString();
                    StartNewGame();
                }
            }
        }
        void StartNewGame()
        {

            foreach (Control item in Controls)
            {

                try
                {
                    Button bt = (Button)item;

                    bt.Enabled = true;
                    bt.Text = "";

                }
                catch
                {


                }

            }
            btPush = true;
            pushCount = 0;
            button1.Text = "New Game";
        }
    }
}
