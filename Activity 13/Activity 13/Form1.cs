using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_13

    //CST 150
    //Chaz Pollino
    // 6/9/23
    // This is my work
{
    public partial class Activity13 : Form
    {
        public Activity13()
        {
            InitializeComponent();
            TurnLabel.Text = "X";

        }
        bool IsXTurn = true;
        String winner = "";

        String[,] gameBoard = new string[3, 3];

       void TurnLabelUpdate()
        {
            if (IsXTurn)
            {
                TurnLabel.Text = "X";
            }
            else
            {
                TurnLabel.Text = "O";
            }

        }
        bool DidSomeoneWin()
        {
            if (gameBoard[0, 0] =="X" && gameBoard[0,1] == "X" && gameBoard[0,2] == "X")
            {
                winner = "X";
                return true;
            }
            if (gameBoard[0, 0] == "O" && gameBoard[0, 1] == "O" && gameBoard[0, 2] == "O")
            {
                winner = "O";
                return true;
            }

            
            if (gameBoard[1, 0] == "X" && gameBoard[1, 1] == "X" && gameBoard[1, 2] == "X")
            {
                winner = "X";
                return true;
            }

            if (gameBoard[1, 0] == "O" && gameBoard[1, 1] == "O" && gameBoard[1, 2] == "O")
            {
                winner = "O";
                return true;
            }

            
            if (gameBoard[2, 0] == "X" && gameBoard[2, 1] == "X" && gameBoard[2, 2] == "X")
            {
                winner = "X";
                return true;
            }

            if (gameBoard[2, 0] == "O" && gameBoard[2, 1] == "O" && gameBoard[2, 2] == "O")
            {
                winner = "O";
                return true;
            }

            
            if (gameBoard[0, 0] == "X" && gameBoard[1, 0] == "X" && gameBoard[2, 0] == "X")
            {
                winner = "X";
                return true;
            }

            if (gameBoard[0, 0] == "O" && gameBoard[1, 0] == "O" && gameBoard[2, 0] == "O")
            {
                winner = "O";
                return true;
            }

            
            if (gameBoard[0, 1] == "X" && gameBoard[1, 1] == "X" && gameBoard[2, 1] == "X")
            {
                winner = "X";
                return true;
            }

            if (gameBoard[0, 1] == "O" && gameBoard[1, 1] == "O" && gameBoard[2, 1] == "O")
            {
                winner = "O";
                return true;
            }

            
            if (gameBoard[0, 2] == "X" && gameBoard[1, 2] == "X" && gameBoard[2, 2] == "X")
            {
                winner = "X";
                return true;
            }

            if (gameBoard[0, 2] == "O" && gameBoard[1, 2] == "O" && gameBoard[2, 2] == "O")
            {
                winner = "O";
                return true;
            }

            
            if (gameBoard[0, 0] == "X" && gameBoard[1, 1] == "X" && gameBoard[2, 2] == "X")
            {
                winner = "X";
                return true;
            }

            if (gameBoard[0, 0] == "O" && gameBoard[1, 1] == "O" && gameBoard[2, 2] == "O")
            {
                winner = "O";
                return true;
            }

            
            if (gameBoard[0, 2] == "X" && gameBoard[1, 1] == "X" && gameBoard[2, 0] == "X")
            {
                winner = "X";
                return true;
            }

            if (gameBoard[0, 2] == "O" && gameBoard[1, 1] == "O" && gameBoard[2, 0] == "O")
            {
                winner = "O";
                return true;
            }

            return false;
        }

        private void Activity13_Load(object sender, EventArgs e)
        {

        }

        private void TopLeftButton_Click(object sender, EventArgs e)
        {
            if (IsXTurn)
            {
                TopLeftButton.Text = "X";
                gameBoard[0, 0] = "X";
                IsXTurn = false;
                TurnLabelUpdate();
            }
            else
            {
                TopLeftButton.Text = "O";
                gameBoard[0, 0] = "O";
                IsXTurn = true;
                TurnLabelUpdate();
            }

            bool won = DidSomeoneWin();
            if (won)
            {
                WinnerLabel.Text = (winner + " Won!!!!!!");
            }
        }

        private void TopMiddleButton_Click(object sender, EventArgs e)
        {
            if (IsXTurn)
            {
                TopMiddleButton.Text = "X";
                gameBoard[0, 1] = "X";
                IsXTurn = false;
                TurnLabelUpdate();
            }
            else
            {
                TopMiddleButton.Text = "O";
                gameBoard[0, 1] = "O";
                IsXTurn = true;
                TurnLabelUpdate();
            }

            bool won = DidSomeoneWin();
            if (won)
            {
                WinnerLabel.Text = (winner + " Won!!!!!!");
            }
        }

        private void TopRightButton_Click(object sender, EventArgs e)
        {
            if (IsXTurn)
            {
                TopRightButton.Text = "X";
                gameBoard[0, 2] = "X";
                IsXTurn = false;
                TurnLabelUpdate();
            }
            else
            {
                TopRightButton.Text = "O";
                gameBoard[0, 2] = "O";
                IsXTurn = true;
                TurnLabelUpdate();
            }

            bool won = DidSomeoneWin();
            if (won)
            {
                WinnerLabel.Text = (winner + " Won!!!!!!");
            }
        }

        private void MiddleLeftButton_Click(object sender, EventArgs e)
        {
            if (IsXTurn)
            {
                MiddleLeftButton.Text = "X";
                gameBoard[1, 0] = "X";
                IsXTurn = false;
                TurnLabelUpdate();
            }
            else
            {
                MiddleLeftButton.Text = "O";
                gameBoard[1, 0] = "O";
                IsXTurn = true;
                TurnLabelUpdate();
            }

            bool won = DidSomeoneWin();
            if (won)
            {
                WinnerLabel.Text = (winner + " Won!!!!!!");
            }
        }

        private void MiddleButton_Click(object sender, EventArgs e)
        {
            if (IsXTurn)
            {
                MiddleButton.Text = "X";
                gameBoard[1, 1] = "X";
                IsXTurn = false;
                TurnLabelUpdate();
            }
            else
            {
                MiddleButton.Text = "O";
                gameBoard[1, 1] = "O";
                IsXTurn = true;
                TurnLabelUpdate();
            }

            bool won = DidSomeoneWin();
            if (won)
            {
                WinnerLabel.Text = (winner + " Won!!!!!!");
            }
        }

        private void MiddleRightButton_Click(object sender, EventArgs e)
        {
            if (IsXTurn)
            {
                MiddleRightButton.Text = "X";
                gameBoard[1, 2] = "X";
                IsXTurn = false;
                TurnLabelUpdate();
            }
            else
            {
                MiddleRightButton.Text = "O";
                gameBoard[1, 2] = "O";
                IsXTurn = true;
                TurnLabelUpdate();
            }

            bool won = DidSomeoneWin();
            if (won)
            {
                WinnerLabel.Text = (winner + " Won!!!!!!");
            }
        }

        private void BottomLeftButton_Click(object sender, EventArgs e)
        {
            if (IsXTurn)
            {
                BottomLeftButton.Text = "X";
                gameBoard[2, 0] = "X";
                IsXTurn = false;
                TurnLabelUpdate();
            }
            else
            {
                BottomLeftButton.Text = "O";
                gameBoard[2, 0] = "O";
                IsXTurn = true;
                TurnLabelUpdate();
            }

            bool won = DidSomeoneWin();
            if (won)
            {
                WinnerLabel.Text = (winner + " Won!!!!!!");
            }
        }

        private void BottomMiddleButton_Click(object sender, EventArgs e)
        {
            if (IsXTurn)
            {
                BottomMiddleButton.Text = "X";
                gameBoard[2, 1] = "X";
                IsXTurn = false;
                TurnLabelUpdate();
            }
            else
            {
                BottomMiddleButton.Text = "O";
                gameBoard[2, 1] = "O";
                IsXTurn = true;
                TurnLabelUpdate();
            }

            bool won = DidSomeoneWin();
            if (won)
            {
                WinnerLabel.Text = (winner + " Won!!!!!!");
            }
        }

        private void BottomRightButton_Click(object sender, EventArgs e)
        {
            if (IsXTurn)
            {
                BottomRightButton.Text = "X";
                gameBoard[2, 2] = "X";
                IsXTurn = false;
                TurnLabelUpdate();
            }
            else
            {
                BottomRightButton.Text = "O";
                gameBoard[2, 2] = "O";
                IsXTurn = true;
                TurnLabelUpdate();
            }

            bool won = DidSomeoneWin();
            if (won)
            {
                WinnerLabel.Text = (winner + " Won!!!!!!");
            }
        }

        private void PlayAgainButton_Click(object sender, EventArgs e)
        {
            TopLeftButton.Text = "";
            TopMiddleButton.Text = "";
            TopRightButton.Text = "";
            MiddleLeftButton.Text = "";
            MiddleButton.Text = "";
            MiddleRightButton.Text = "";
            BottomLeftButton.Text = "";
            BottomMiddleButton.Text = "";
            BottomRightButton.Text = "";
            WinnerLabel.Text = "";

            Array.Clear(gameBoard,0,gameBoard.Length);
        }
    }
}
