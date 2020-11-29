using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

/*
 * 
 * 
 *  
 * @Completion Date : 
 * @Author : Daniel Lee
 */

namespace TicTacToe_Framework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void menuitemHelp_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow rules = new HelpWindow();
            rules.DisplayRules();
            rules.ShowDialog();
        }

        private void menuitemExit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        Game currentGame = new Game();
        private void menuitemNew_Click(object sender, RoutedEventArgs e)
        {
            // Enable buttons
            btnTopLeft.IsEnabled = true;
            btnTopMiddle.IsEnabled = true;
            btnTopRight.IsEnabled = true;
            btnMiddleLeft.IsEnabled = true;
            btnMiddleMiddle.IsEnabled = true;
            btnMiddleRight.IsEnabled = true;
            btnBottomLeft.IsEnabled = true;
            btnBottomMiddle.IsEnabled = true;
            btnBottomRight.IsEnabled = true;

            // Empty buttons content
            btnTopLeft.Content = string.Empty;
            btnTopMiddle.Content = string.Empty;
            btnTopRight.Content = string.Empty;

            btnMiddleLeft.Content = string.Empty;
            btnMiddleMiddle.Content = string.Empty;
            btnMiddleRight.Content = string.Empty;

            btnBottomLeft.Content = string.Empty;
            btnBottomMiddle.Content = string.Empty;
            btnBottomRight.Content = string.Empty;

            // Reset buttons clicked
            alreadyClickedTopLeft = false;
            alreadyClickedTopMiddle = false;
            alreadyClickedTopRight = false;

            alreadyClickedMiddleLeft = false;
            alreadyClickedMiddleMiddle = false;
            alreadyClickedMiddleRight = false;

            alreadyClickedBottomLeft = false;
            alreadyClickedBottomMiddle = false;
            alreadyClickedBottomRight = false;

            // Create new game
            currentGame = new Game();
            lblTurnXO.Content = currentGame.WhoseTurnIsIt;
        }

        // 1
        bool alreadyClickedTopLeft = false;
        private void btnTopLeft_Click(object sender, RoutedEventArgs e)
        {

            if (alreadyClickedTopLeft == false) {

                if (lblTurnXO.Content.ToString() == "X")
                {
                    btnTopLeft.Content = "X";

                    currentGame.TopRow.FirstCell = 'X';
                    currentGame.LeftColumn.FirstCell = 'X';
                    currentGame.LeftDiagonal.FirstCell = 'X';

                    currentGame.FlipTurn();
                    lblTurnXO.Content = currentGame.WhoseTurnIsIt;
  
                    alreadyClickedTopLeft = true;

                }
                else if (lblTurnXO.Content.ToString() == "O")
                {
                    btnTopLeft.Content = "O";

                    currentGame.TopRow.FirstCell = 'O';
                    currentGame.LeftColumn.FirstCell = 'O';
                    currentGame.LeftDiagonal.FirstCell = 'O';

                    currentGame.FlipTurn();
                    lblTurnXO.Content = currentGame.WhoseTurnIsIt;

                    alreadyClickedTopLeft = true;
                }
            }
            Check();
        }

        // 2
        bool alreadyClickedTopMiddle = false;
        private void btnTopMiddle_Click(object sender, RoutedEventArgs e)
        {
            if (alreadyClickedTopMiddle == false)
            {

                if (currentGame.WhoseTurnIsIt == 'X')
                {
                    btnTopMiddle.Content = "X";

                    currentGame.TopRow.SecondCell = 'X';
                    currentGame.MiddleColumn.FirstCell = 'X';

                    currentGame.FlipTurn();
                    lblTurnXO.Content = currentGame.WhoseTurnIsIt;

                    alreadyClickedTopMiddle = true;

                }
                else if (currentGame.WhoseTurnIsIt == 'O')
                {
                    btnTopMiddle.Content = "O";

                    currentGame.TopRow.SecondCell = 'O';
                    currentGame.MiddleColumn.FirstCell = 'O';

                    currentGame.FlipTurn();
                    lblTurnXO.Content = currentGame.WhoseTurnIsIt;

                    alreadyClickedTopMiddle = true;
                }
            }
            Check();
        }

        // 3
        bool alreadyClickedTopRight = false;
        private void btnTopRight_Click(object sender, RoutedEventArgs e)
        {
            if (alreadyClickedTopRight == false)
            {

                if (currentGame.WhoseTurnIsIt == 'X')
                {
                    btnTopRight.Content = "X";

                    currentGame.TopRow.ThirdCell = 'X';
                    currentGame.RightColumn.FirstCell = 'X';
                    currentGame.RightDiagonal.FirstCell = 'X';

                    currentGame.FlipTurn();
                    lblTurnXO.Content = currentGame.WhoseTurnIsIt;

                    alreadyClickedTopRight = true;

                }
                else if (currentGame.WhoseTurnIsIt == 'O')
                {
                    btnTopRight.Content = "O";

                    currentGame.TopRow.ThirdCell = 'O';
                    currentGame.RightColumn.FirstCell = 'O';
                    currentGame.RightDiagonal.FirstCell = 'O';

                    currentGame.FlipTurn();
                    lblTurnXO.Content = currentGame.WhoseTurnIsIt;

                    alreadyClickedTopRight = true;
                }
            }
            Check();
        }

        // 4
        bool alreadyClickedMiddleLeft = false;
        private void btnMiddleLeft_Click(object sender, RoutedEventArgs e)
        {
            if (alreadyClickedMiddleLeft == false)
            {

                if (currentGame.WhoseTurnIsIt == 'X')
                {
                    btnMiddleLeft.Content = "X";

                    currentGame.MiddleRow.FirstCell = 'X';
                    currentGame.LeftColumn.SecondCell = 'X';

                    currentGame.FlipTurn();
                    lblTurnXO.Content = currentGame.WhoseTurnIsIt;

                    alreadyClickedMiddleLeft = true;

                }
                else if (currentGame.WhoseTurnIsIt == 'O')
                {
                    btnMiddleLeft.Content = "O";

                    currentGame.MiddleRow.FirstCell = 'O';
                    currentGame.LeftColumn.SecondCell = 'O';

                    currentGame.FlipTurn();
                    lblTurnXO.Content = currentGame.WhoseTurnIsIt;

                    alreadyClickedMiddleLeft = true;
                }
            }
            Check();
        }

        // 5
        bool alreadyClickedMiddleMiddle = false;
        private void btnMiddleMiddle_Click(object sender, RoutedEventArgs e)
        {
            if (alreadyClickedMiddleMiddle == false)
            {

                if (currentGame.WhoseTurnIsIt == 'X')
                {
                    btnMiddleMiddle.Content = "X";

                    currentGame.MiddleRow.SecondCell = 'X';
                    currentGame.MiddleColumn.SecondCell = 'X';
                    currentGame.LeftDiagonal.SecondCell = 'X';
                    currentGame.RightDiagonal.SecondCell = 'X';

                    currentGame.FlipTurn();
                    lblTurnXO.Content = currentGame.WhoseTurnIsIt;

                    alreadyClickedMiddleMiddle = true;

                }
                else if (currentGame.WhoseTurnIsIt == 'O')
                {
                    btnMiddleMiddle.Content = "O";

                    currentGame.MiddleRow.SecondCell = 'O';
                    currentGame.MiddleColumn.SecondCell = 'O';
                    currentGame.LeftDiagonal.SecondCell = 'O';
                    currentGame.RightDiagonal.SecondCell = 'O';

                    currentGame.FlipTurn();
                    lblTurnXO.Content = currentGame.WhoseTurnIsIt;

                    alreadyClickedMiddleMiddle = true;
                }
            }
            Check();
        }

        // 6
        bool alreadyClickedMiddleRight = false;
        private void btnMiddleRight_Click(object sender, RoutedEventArgs e)
        {
            if (alreadyClickedMiddleRight == false)
            {

                if (currentGame.WhoseTurnIsIt == 'X')
                {
                    btnMiddleRight.Content = "X";

                    currentGame.MiddleRow.ThirdCell = 'X';
                    currentGame.RightColumn.SecondCell = 'X';

                    currentGame.FlipTurn();
                    lblTurnXO.Content = currentGame.WhoseTurnIsIt;

                    alreadyClickedMiddleRight = true;

                }
                else if (currentGame.WhoseTurnIsIt == 'O')
                {
                    btnMiddleRight.Content = "O";

                    currentGame.MiddleRow.ThirdCell = 'O';
                    currentGame.RightColumn.SecondCell = 'O';

                    currentGame.FlipTurn();
                    lblTurnXO.Content = currentGame.WhoseTurnIsIt;

                    alreadyClickedMiddleRight = true;
                }
            }
            Check();
        }

        // 7
        bool alreadyClickedBottomLeft = false;
        private void btnBottomLeft_Click(object sender, RoutedEventArgs e)
        {
            if (alreadyClickedBottomLeft == false)
            {

                if (currentGame.WhoseTurnIsIt == 'X')
                {
                    btnBottomLeft.Content = "X";

                    currentGame.BottomRow.FirstCell = 'X';
                    currentGame.LeftColumn.ThirdCell = 'X';
                    currentGame.RightDiagonal.ThirdCell = 'X';

                    currentGame.FlipTurn();
                    lblTurnXO.Content = currentGame.WhoseTurnIsIt;

                    alreadyClickedBottomLeft = true;

                }
                else if (currentGame.WhoseTurnIsIt == 'O')
                {
                    btnBottomLeft.Content = "O";

                    currentGame.BottomRow.FirstCell = 'O';
                    currentGame.LeftColumn.ThirdCell = 'O';
                    currentGame.RightDiagonal.ThirdCell = 'O';

                    currentGame.FlipTurn();
                    lblTurnXO.Content = currentGame.WhoseTurnIsIt;

                    alreadyClickedBottomLeft = true;
                }
            }
            Check();
        }

        // 8
        bool alreadyClickedBottomMiddle = false;
        private void btnBottomMiddle_Click(object sender, RoutedEventArgs e)
        {
            if (alreadyClickedBottomMiddle == false)
            {

                if (currentGame.WhoseTurnIsIt == 'X')
                {
                    btnBottomMiddle.Content = "X";

                    currentGame.BottomRow.SecondCell = 'X';
                    currentGame.MiddleColumn.ThirdCell = 'X';

                    currentGame.FlipTurn();
                    lblTurnXO.Content = currentGame.WhoseTurnIsIt;

                    alreadyClickedBottomMiddle = true;

                }
                else if (currentGame.WhoseTurnIsIt == 'O')
                {
                    btnBottomMiddle.Content = "O";

                    currentGame.BottomRow.SecondCell = 'O';
                    currentGame.MiddleColumn.ThirdCell = 'O';

                    currentGame.FlipTurn();
                    lblTurnXO.Content = currentGame.WhoseTurnIsIt;

                    alreadyClickedBottomMiddle = true;
                }
            }
            Check();
        }

        // 9
        bool alreadyClickedBottomRight = false;
        private void btnBottomRight_Click(object sender, RoutedEventArgs e)
        {
            if (alreadyClickedBottomRight == false)
            {

                if (currentGame.WhoseTurnIsIt == 'X')
                {
                    btnBottomRight.Content = "X";

                    currentGame.BottomRow.ThirdCell = 'X';
                    currentGame.RightColumn.ThirdCell = 'X';
                    currentGame.LeftDiagonal.ThirdCell = 'X';

                    currentGame.FlipTurn();
                    lblTurnXO.Content = currentGame.WhoseTurnIsIt;

                    alreadyClickedBottomRight = true;

                }
                else if (currentGame.WhoseTurnIsIt == 'O')
                {
                    btnBottomRight.Content = "O";

                    currentGame.BottomRow.ThirdCell = 'O';
                    currentGame.RightColumn.ThirdCell = 'O';
                    currentGame.LeftDiagonal.ThirdCell = 'O';

                    currentGame.FlipTurn();
                    lblTurnXO.Content = currentGame.WhoseTurnIsIt;

                    alreadyClickedBottomRight = true;
                }
            }
            Check();
        }

        int scoreO = 0;
        int scoreX = 0;
        int scoreTie = 0;

        //Check if anyone has a winning row/column/diagonal, show message box and update scores
        public void Check()
        {
            if (currentGame.TopRow.DidAnyoneWin() == true)
            {
                DisableButtons();
                UpdateScores();
                MessageBox.Show(currentGame.IsGameOver(), "WINNER");
                MessageBox.Show("Start a new game to play again.", "GAME OVER");
            }
            else if (currentGame.MiddleRow.DidAnyoneWin() == true)
            {
                DisableButtons();
                UpdateScores();
                MessageBox.Show(currentGame.IsGameOver(), "WINNER");
                MessageBox.Show("Start a new game to play again.", "GAME OVER");
            }
            else if (currentGame.BottomRow.DidAnyoneWin() == true)
            {
                DisableButtons();
                UpdateScores();
                MessageBox.Show(currentGame.IsGameOver(), "WINNER");
                MessageBox.Show("Start a new game to play again.", "GAME OVER");
            }
            else if (currentGame.LeftColumn.DidAnyoneWin() == true)
            {
                DisableButtons();
                UpdateScores();
                MessageBox.Show(currentGame.IsGameOver(), "WINNER");
                MessageBox.Show("Start a new game to play again.", "GAME OVER");
            }
            else if (currentGame.MiddleColumn.DidAnyoneWin() == true)
            {
                DisableButtons();
                UpdateScores();
                MessageBox.Show(currentGame.IsGameOver(), "WINNER");
                MessageBox.Show("Start a new game to play again.", "GAME OVER");
            }
            else if (currentGame.RightColumn.DidAnyoneWin() == true)
            {
                DisableButtons();
                UpdateScores();
                MessageBox.Show(currentGame.IsGameOver(), "WINNER");
                MessageBox.Show("Start a new game to play again.", "GAME OVER");
            }
            else if (currentGame.LeftDiagonal.DidAnyoneWin() == true)
            {
                DisableButtons();
                UpdateScores();
                MessageBox.Show(currentGame.IsGameOver(), "WINNER");
                MessageBox.Show("Start a new game to play again.", "GAME OVER");
            }
            else if (currentGame.RightDiagonal.DidAnyoneWin() == true)
            {
                DisableButtons();
                UpdateScores();
                MessageBox.Show(currentGame.IsGameOver(), "WINNER");
                MessageBox.Show("Start a new game to play again.", "GAME OVER");
            }
            else if (currentGame.TopRow.IsLaneFull() == true && currentGame.MiddleRow.IsLaneFull() == true && currentGame.BottomRow.IsLaneFull() == true)
            {
                DisableButtons();
                scoreTie++;
                lblScoreCountTies.Content = scoreTie;
                MessageBox.Show(currentGame.IsGameOver(), "TIE");
                MessageBox.Show("Start a new game to play again.", "GAME OVER");
            }
        }

        public void DisableButtons()
        {
            btnTopLeft.IsEnabled = false;
            btnTopMiddle.IsEnabled = false;
            btnTopRight.IsEnabled = false;
            btnMiddleLeft.IsEnabled = false;
            btnMiddleMiddle.IsEnabled = false;
            btnMiddleRight.IsEnabled = false;
            btnBottomLeft.IsEnabled = false;
            btnBottomMiddle.IsEnabled = false;
            btnBottomRight.IsEnabled = false;
        }

        public void UpdateScores()
        {
            if (lblTurnXO.Content.ToString() == "O") 
            {
                scoreX++;
                lblScoreCountX.Content = scoreX;
            }
            else if (lblTurnXO.Content.ToString() == "X")
            {
                scoreO++;
                lblScoreCountO.Content = scoreO;
            }
        }
    }

}
