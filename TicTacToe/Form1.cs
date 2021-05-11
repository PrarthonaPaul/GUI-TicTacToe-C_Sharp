using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class frmTicTacToe : Form
    {
        bool player = true;     //sets the turn as a true or false, if true, it is player 1, if false, player 2
        int num1 = 0, num2 = 0, round = 1;

        public frmTicTacToe()
        {
            InitializeComponent();
        }
        
        private void lblTopLeft_Click(object sender, EventArgs e)
        {
            placeMark(lblTopLeft);
        }

        private void lblTopMid_Click(object sender, EventArgs e)
        {
            placeMark(lblTopMid);
        }

        private void lblTopRight_Click(object sender, EventArgs e)
        {
            placeMark(lblTopRight);
        }

        private void lblCentreLeft_Click(object sender, EventArgs e)
        {
            placeMark(lblCentreLeft);
        }

        private void lblCentre_Click(object sender, EventArgs e)
        {
            placeMark(lblCentre);
        }

        private void lblCentreRight_Click(object sender, EventArgs e)
        {
            placeMark(lblCentreRight);
        }

        private void lblBotLeft_Click(object sender, EventArgs e)
        {
            placeMark(lblBotLeft);
        }

        private void lblBottomRight_Click(object sender, EventArgs e)
        {
            placeMark(lblBottomRight);
        }

        private void lblBotMid_Click(object sender, EventArgs e)
        {
            placeMark(lblBotMid);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearBoard(); 
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            if (lblTopLeft.Text == "O" && lblCentre.Text == "O" && lblBottomRight.Text == "O")
                player1Wins(lblTopLeft, lblCentre, lblBottomRight);

            else if (lblTopLeft.Text == "X" && lblCentre.Text == "X" && lblBottomRight.Text == "X")
                player2Wins(lblTopLeft, lblCentre, lblBottomRight);

            else if (lblTopRight.Text == "O" && lblCentre.Text == "O" && lblBotLeft.Text == "O")
                player1Wins(lblTopRight, lblCentre, lblBotLeft);

            else if (lblTopRight.Text == "X" && lblCentre.Text == "X" && lblBotLeft.Text == "X")
                player2Wins(lblTopRight, lblCentre, lblBotLeft);

            else if (lblTopRight.Text == "O" && lblCentreRight.Text == "O" && lblBottomRight.Text == "O")
                player1Wins(lblTopRight, lblCentreRight, lblBottomRight);

            else if (lblTopRight.Text == "X" && lblCentreRight.Text == "X" && lblBottomRight.Text == "X")
                player2Wins(lblTopRight, lblCentreRight, lblBottomRight);

            else if (lblTopLeft.Text == "O" && lblCentreLeft.Text == "O" && lblBotLeft.Text == "O")
                player1Wins(lblTopLeft, lblCentreLeft, lblBotLeft);

            else if (lblTopLeft.Text == "X" && lblCentreLeft.Text == "X" && lblBotLeft.Text == "X")
                player2Wins(lblTopLeft, lblCentreLeft, lblBotLeft);

            else if (lblTopLeft.Text == "O" && lblTopRight.Text == "O" && lblTopMid.Text == "O")
                player1Wins(lblTopLeft, lblTopMid, lblTopRight);

            else if (lblTopLeft.Text == "X" && lblTopMid.Text == "X" && lblTopRight.Text == "X")
                player2Wins(lblTopLeft, lblTopMid, lblTopRight);

            else if (lblCentreLeft.Text == "O" && lblCentre.Text == "O" && lblCentreRight.Text == "O")
                player1Wins(lblCentreLeft, lblCentre, lblCentreRight);

            else if (lblCentreLeft.Text == "X" && lblCentre.Text == "X" && lblCentreRight.Text == "X")
                player2Wins(lblCentreLeft, lblCentre, lblCentreRight);

            else if (lblBotLeft.Text == "O" && lblBotMid.Text == "O" && lblBottomRight.Text == "O")
                player1Wins(lblBottomRight, lblBotMid, lblBotLeft);

            else if (lblBotLeft.Text == "X" && lblBotMid.Text == "X" && lblBottomRight.Text == "X")
                player2Wins(lblBotLeft, lblBotMid, lblBottomRight);

            else if (lblTopMid.Text == "O" && lblCentre.Text == "O" && lblBotMid.Text == "O")
                player1Wins(lblTopMid, lblCentre, lblBotMid);

            else if (lblTopMid.Text == "X" && lblCentre.Text == "X" && lblBotMid.Text == "X")
                player2Wins(lblTopMid, lblCentre, lblBotMid);
            else
                MessageBox.Show("NO WINNERS!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearBoard();
            round++;
            lblRound.Text = "Round " + round.ToString(); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            txt1.Text = null;
            txt2.Text = null;
            if(num1 > num2)
                MessageBox.Show("Player 1 wins the game!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if(num2 > num1)
                MessageBox.Show("Player 2 wins the game!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("The game ends in a tie.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            num1 = 0;
            num2 = 0;
            round = 1;
            lblRound.Text = "Round " + round.ToString();
        }

        //This Function received the label that the user created and based on the player variable, places an O or and X ok the label
        private void placeMark(Label currentPosition)
        {
            if (player)
            {
                currentPosition.Text = "O";  //Player 1 plays with O
                currentPosition.Enabled = false; //disables the label so that it can not be clicked till a new game starts
            }
            else if (player == false)
            {
                currentPosition.Text = "X";  //Player 2 plays with X
                currentPosition.Enabled = false;
            }
            player = !player; //Switches to the other player's turn
        }
        private void player1Wins(Label lbl1, Label lbl2, Label lbl3)
        {
            lbl1.ForeColor = Color.Red; //Changes text color to red if player 1 wins
            lbl1.Enabled = true;
            lbl2.ForeColor = Color.Red;
            lbl2.Enabled = true;
            lbl3.ForeColor = Color.Red;
            lbl3.Enabled = true;
            MessageBox.Show("Player 1 wins this Round!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            num1++;
            txt1.Text = num1.ToString();
        }
        private void player2Wins(Label lbl1, Label lbl2, Label lbl3)
        {
            lbl1.ForeColor = Color.BlueViolet; //Changes text color to blueviolet if player 2 wins
            lbl1.Enabled = true;
            lbl2.ForeColor = Color.BlueViolet;
            lbl2.Enabled = true;
            lbl3.ForeColor = Color.BlueViolet;
            lbl3.Enabled = true;
            MessageBox.Show("Player 2 wins this round!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            num2++;
            txt2.Text = num2.ToString();
        }

        private void clearBoard()
        {
            Label[] positionsOnBoard = { lblTopRight, lblTopLeft, lblTopMid, lblCentre, lblCentreLeft, lblCentreRight, lblBotLeft, lblBotMid, lblBottomRight };

            for (int i = 0; i < positionsOnBoard.Length; i++)
            {
                positionsOnBoard[i].Enabled = true;
                positionsOnBoard[i].Text = null;
                player = true;
            }
        }
    }
}
