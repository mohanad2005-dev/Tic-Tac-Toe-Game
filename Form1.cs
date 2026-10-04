using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Player = "P1";

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen1 = new Pen(Color.White);
            pen1.Width = 10;
            Pen pen2 = new Pen(Color.White);
            pen2.Width = 1;

            e.Graphics.DrawLine(pen1, 280, 185, 690, 185);
            e.Graphics.DrawLine(pen1, 280, 295, 690, 295);
            e.Graphics.DrawLine(pen1, 410, 80, 410, 405);
            e.Graphics.DrawLine(pen1, 560, 80, 560, 405);
            e.Graphics.DrawLine(pen2, 235, 0, 235, 430);
        }

        void Calculate_Resutl()
        {
            if (lb1.Text == lb2.Text)
            {
                if (lb2.Text == lb3.Text)
                {
                    if (lb3.Text == "x")
                        lbWinnerAnswer.Text = "Player 1";
                    else if (lb3.Text == "o")
                        lbWinnerAnswer.Text = "Player 2";

                    if(lb1.Text != "?")
                    {
                        lb1.BackColor = Color.ForestGreen;
                        lb2.BackColor = Color.ForestGreen;
                        lb3.BackColor = Color.ForestGreen;
                    }
                }
            }

            if (lb4.Text == lb5.Text)
            {
                if (lb5.Text == lb6.Text)
                {
                    if (lb6.Text == "x")
                        lbWinnerAnswer.Text = "Player 1";
                    else if (lb6.Text == "o")
                        lbWinnerAnswer.Text = "Player 2";

                    if (lb4.Text != "?")
                    {
                        lb4.BackColor = Color.ForestGreen;
                        lb5.BackColor = Color.ForestGreen;
                        lb6.BackColor = Color.ForestGreen;
                    }
                }
            }

            if (lb7.Text == lb8.Text)
            {
                if (lb8.Text == lb9.Text)
                {
                    if (lb9.Text == "x")
                        lbWinnerAnswer.Text = "Player 1";
                    else if (lb9.Text == "o")
                        lbWinnerAnswer.Text = "Player 2";

                    if (lb7.Text != "?")
                    {
                        lb7.BackColor = Color.ForestGreen;
                        lb8.BackColor = Color.ForestGreen                   ;
                        lb9.BackColor = Color.ForestGreen;
                    }
                }
            }

            if (lb1.Text == lb4.Text)
            {
                if (lb4.Text == lb7.Text)
                {
                    if (lb7.Text == "x")
                        lbWinnerAnswer.Text = "Player 1";
                    else if (lb7.Text == "o")
                        lbWinnerAnswer.Text = "Player 2";

                    if (lb1.Text != "?")
                    {
                        lb1.BackColor = Color.ForestGreen;
                        lb4.BackColor = Color.ForestGreen;
                        lb7.BackColor = Color.ForestGreen;
                    }
                }
            }

            if (lb2.Text == lb5.Text)
            {
                if (lb5.Text == lb8.Text)
                {
                    if (lb8.Text == "x")
                        lbWinnerAnswer.Text = "Player 1";
                    else if (lb8.Text == "o")
                        lbWinnerAnswer.Text = "Player 2";

                    if (lb2.Text != "?")
                    {
                        lb2.BackColor = Color.ForestGreen;
                        lb5.BackColor = Color.ForestGreen   ;
                        lb8.BackColor = Color.ForestGreen;
                    }
                }
            }

            if (lb3.Text == lb6.Text)
            {
                if (lb6.Text == lb9.Text)
                {
                    if (lb9.Text == "x")
                        lbWinnerAnswer.Text = "Player 1";
                    else if (lb9.Text == "o")
                        lbWinnerAnswer.Text = "Player 2";

                    if (lb3.Text != "?")
                    {
                        lb3.BackColor = Color.ForestGreen;
                        lb6.BackColor = Color.ForestGreen;
                        lb9.BackColor = Color.ForestGreen;
                    }
                }
            }

            if (lb1.Text == lb5.Text)
            {
                if (lb5.Text == lb9.Text)
                {
                    if (lb9.Text == "x")
                        lbWinnerAnswer.Text = "Player 1";
                    else if (lb9.Text == "o")
                        lbWinnerAnswer.Text = "Player 2";

                    if (lb1.Text != "?")
                    {
                        lb1.BackColor = Color.ForestGreen;
                        lb5.BackColor = Color.ForestGreen;
                        lb9.BackColor = Color.ForestGreen;
                    }
                }
            }

            if (lb3.Text == lb5.Text)
            {
                if (lb5.Text == lb7.Text)
                {
                    if (lb7.Text == "x")
                        lbWinnerAnswer.Text = "Player 1";
                    else if (lb7.Text == "o")
                        lbWinnerAnswer.Text = "Player 2";

                    if (lb3.Text != "?")
                    {
                        lb3.BackColor = Color.ForestGreen;
                        lb5.BackColor = Color.ForestGreen;
                        lb7.BackColor = Color.ForestGreen;
                    }
                }
            }

            if(lb1.Text != "?" && lb2.Text != "?" && lb3.Text != "?" && lb4.Text != "?" &&
                lb5.Text != "?" && lb6.Text != "?" && lb7.Text != "?" &&
                    lb7.Text != "?" && lb9.Text != "?")
            {
                if (lbWinnerAnswer.Text == "In Progress")
                    lbWinnerAnswer.Text = "Draw";
            }
        }

        private void lb1_Click(object sender, EventArgs e)
        {
            if (lbWinnerAnswer.Text != "In Progress")
                return;

            if (Player == "P1" && lb1.Text == "?")
            {
                lb1.Text = "x";
                Player = "P2";
                lbTurnAnswer.Text = "Player 2";
            }
            else if (Player == "P2" && lb1.Text == "?")
            {
                lb1.Text = "o";
                Player = "P1";
                lbTurnAnswer.Text = "Player 1";
            }

            lb1.ForeColor = Color.DeepSkyBlue;
            Calculate_Resutl();
        }

        private void lb2_Click(object sender, EventArgs e)
        {
            if (lbWinnerAnswer.Text != "In Progress")
                return;

            if (Player == "P1" && lb2.Text == "?")
            {
                lb2.Text = "x";
                Player = "P2";
                lbTurnAnswer.Text = "Player 2";
            }
            else if (Player == "P2" && lb2.Text == "?")
            {
                lb2.Text = "o";
                Player = "P1";
                lbTurnAnswer.Text = "Player 1";
            }

            lb2.ForeColor = Color.DeepSkyBlue;
            Calculate_Resutl();
        }

        private void lb3_Click(object sender, EventArgs e)
        {
            if (lbWinnerAnswer.Text != "In Progress")
                return;

            if (Player == "P1" && lb3.Text == "?")
            {
                lb3.Text = "x";
                Player = "P2";
                lbTurnAnswer.Text = "Player 2";
            }
            else if (Player == "P2" && lb3.Text == "?")
            {
                lb3.Text = "o";
                Player = "P1";
                lbTurnAnswer.Text = "Player 1";
            }

            lb3.ForeColor = Color.DeepSkyBlue;
            Calculate_Resutl();
        }

        private void lb4_Click(object sender, EventArgs e)
        {
            if (lbWinnerAnswer.Text != "In Progress")
                return;

            if (Player == "P1" && lb4.Text == "?")
            {
                lb4.Text = "x";
                Player = "P2";
                lbTurnAnswer.Text = "Player 2";
            }
            else if (Player == "P2" && lb4.Text == "?")
            {
                lb4.Text = "o";
                Player = "P1";
                lbTurnAnswer.Text = "Player 1";
            }

            lb4.ForeColor = Color.DeepSkyBlue;
            Calculate_Resutl();
        }

        private void lb5_Click(object sender, EventArgs e)
        {
            if (lbWinnerAnswer.Text != "In Progress")
                return;

            if (Player == "P1" && lb5.Text == "?")
            {
                lb5.Text = "x";
                Player = "P2";
                lbTurnAnswer.Text = "Player 2";
            }
            else if (Player == "P2" && lb5.Text == "?")
            {
                lb5.Text = "o";
                Player = "P1";
                lbTurnAnswer.Text = "Player 1";
            }

            lb5.ForeColor = Color.DeepSkyBlue;
            Calculate_Resutl();
        }

        private void lb6_Click(object sender, EventArgs e)
        {
            if (lbWinnerAnswer.Text != "In Progress")
                return;

            if (Player == "P1" && lb6.Text == "?")
            {
                lb6.Text = "x";
                Player = "P2";
                lbTurnAnswer.Text = "Player 2";
            }
            else if (Player == "P2" && lb6.Text == "?")
            {
                lb6.Text = "o";
                Player = "P1";
                lbTurnAnswer.Text = "Player 1";
            }

            lb6.ForeColor = Color.DeepSkyBlue;
            Calculate_Resutl();
        }

        private void lb7_Click(object sender, EventArgs e)
        {
            if (lbWinnerAnswer.Text != "In Progress")
                return;

            if (Player == "P1" && lb7.Text == "?")
            {
                lb7.Text = "x";
                Player = "P2";
                lbTurnAnswer.Text = "Player 2";
            }
            else if (Player == "P2" && lb7.Text == "?")
            {
                lb7.Text = "o";
                Player = "P1";
                lbTurnAnswer.Text = "Player 1";
            }

            lb7.ForeColor = Color.DeepSkyBlue;
            Calculate_Resutl();
        }

        private void lb8_Click(object sender, EventArgs e)
        {
            if (lbWinnerAnswer.Text != "In Progress")
                return;

            if (Player == "P1" && lb8.Text == "?")
            {
                lb8.Text = "x";
                Player = "P2";
                lbTurnAnswer.Text = "Player 2";
            }
            else if (Player == "P2" && lb8.Text == "?")
            {
                lb8.Text = "o";
                Player = "P1";
                lbTurnAnswer.Text = "Player 1";
            }

            lb8.ForeColor = Color.DeepSkyBlue;
            Calculate_Resutl();
        }

        private void lb9_Click(object sender, EventArgs e)
        {
            if (lbWinnerAnswer.Text != "In Progress")
                return;

            if (Player == "P1" && lb9.Text == "?")
            {
                lb9.Text = "x";
                Player = "P2";
                lbTurnAnswer.Text = "Player 2";
            }
            else if (Player == "P2" && lb9.Text == "?")
            {
                lb9.Text = "o";
                Player = "P1";
                lbTurnAnswer.Text = "Player 1";
            }

            lb9.ForeColor = Color.DeepSkyBlue;
            Calculate_Resutl();
        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            lb1.Text = "?";
            lb2.Text = "?";
            lb3.Text = "?";
            lb4.Text = "?";
            lb5.Text = "?";
            lb6.Text = "?";
            lb7.Text = "?";
            lb8.Text = "?";
            lb9.Text = "?";

            lb1.ForeColor = Color.OrangeRed;
            lb2.ForeColor = Color.OrangeRed;
            lb3.ForeColor = Color.OrangeRed;
            lb4.ForeColor = Color.OrangeRed;
            lb5.ForeColor = Color.OrangeRed;
            lb6.ForeColor = Color.OrangeRed;
            lb7.ForeColor = Color.OrangeRed;
            lb8.ForeColor = Color.OrangeRed;
            lb9.ForeColor = Color.OrangeRed;

            lb1.BackColor = default;
            lb2.BackColor = default;
            lb3.BackColor = default;
            lb4.BackColor = default;
            lb5.BackColor = default;
            lb6.BackColor = default;
            lb7.BackColor = default;
            lb8.BackColor = default;
            lb9.BackColor = default;

            Player = "P1";
            lbTurnAnswer.Text = "Player 1";
            lbWinnerAnswer.Text = "In Progress";
        }
    }
}