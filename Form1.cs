/* 
 * Manpreet Sangha
 * CS 39
 * Project: Tic Tac Toe Game
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        Game newgame = new Game();
        Player player1 = new Player(1);
        Player player2 = new Player(2);
        int gameon = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameon = 0;
            ResetGame();

            player1_txtbox.Text = "";
            whosx_combobox.SelectedIndex = -1;
            whogoesfirst_combobox.SelectedIndex = -1;

            game_panel.Visible = false;
            newplayer_panel.Visible = true;

            gameon = 1;
        }

        private void ExitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (player1_txtbox.Text == string.Empty)
            {
                MessageBox.Show("Please enter a name for Player 1!");
                return;
            }
            else if (whosx_combobox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select who will be X!");
                return;
            }
            else if (whogoesfirst_combobox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select who goes first!");
                return;
            }
            else
            {
                player1.NameProperty = player1_txtbox.Text;
                player2.NameProperty = player2_txtbox.Text;

                if (whosx_combobox.SelectedItem.ToString().ToLower() == "player1")
                {
                    player1.LetterProperty = "X";
                    player2.LetterProperty = "O";
                }
                else
                {
                    player1.LetterProperty = "O";
                    player2.LetterProperty = "X";
                }

                newgame.AddPlayer(player1);
                newgame.AddPlayer(player2);

                if (whogoesfirst_combobox.SelectedItem.ToString().ToLower() == "player1")
                {
                    newgame.TurnProperty = 1;
                }
                else
                {
                    newgame.TurnProperty = 2;
                }

                player1_label.Text = "Player 1: " + player1.NameProperty + " (" + player1.LetterProperty + ")";
                player2_label.Text = "Player 2: " + player2.NameProperty + " (" + player2.LetterProperty + ")";

                if (newgame.TurnProperty == 1)
                {
                    current_player_label.Text = "Current Player: Player 1 - " + player1.NameProperty;

                }
                else
                {
                    current_player_label.Text = "Current Player: Player 2 - " + player2.NameProperty;
                    if (newgame.PlayerCountProperty == 1)
                    {
                        AIFirstMove();
                        ChangeTurn();
                    }
                }

                newplayer_panel.Visible = false;
                game_panel.Visible = true;
                gameon = 1;
            }
        }

        private void Ticbox_top_left_TextChanged(object sender, EventArgs e)
        {
            if (Validate_Letter(ticbox_top_left.Text))
            {
                newgame.AddToGameArray(0, 0, ticbox_top_left.Text);
                ticbox_top_left.ReadOnly = true;
                CheckWinner();
                ChangeTurn();
                ReadFromArray();
                CheckDraw();
            }
        }

        private void Ticbox_top_middle_TextChanged(object sender, EventArgs e)
        {
            if (Validate_Letter(ticbox_top_middle.Text))
            {
                newgame.AddToGameArray(0, 1, ticbox_top_middle.Text);
                ticbox_top_middle.ReadOnly = true;
                CheckWinner();
                ChangeTurn();
                ReadFromArray();
                CheckDraw();
            }
        }

        private void Ticbox_top_right_TextChanged(object sender, EventArgs e)
        {
            if (Validate_Letter(ticbox_top_right.Text))
            {
                newgame.AddToGameArray(0, 2, ticbox_top_right.Text);
                ticbox_top_right.ReadOnly = true;
                CheckWinner();
                ChangeTurn();
                ReadFromArray();
                CheckDraw();
            }
        }

        private void Ticbox_middle_left_TextChanged(object sender, EventArgs e)
        {
            if (Validate_Letter(ticbox_middle_left.Text))
            {
                newgame.AddToGameArray(1, 0, ticbox_middle_left.Text);
                ticbox_middle_left.ReadOnly = true;
                CheckWinner();
                ChangeTurn();
                ReadFromArray();
                CheckDraw();
            }
        }

        private void Ticbox_middle_middle_TextChanged(object sender, EventArgs e)
        {
            if (Validate_Letter(ticbox_middle_middle.Text))
            {
                newgame.AddToGameArray(1, 1, ticbox_middle_middle.Text);
                ticbox_middle_middle.ReadOnly = true;
                CheckWinner();
                ChangeTurn();
                ReadFromArray();
                CheckDraw();
            }
        }

        private void Ticbox_middle_right_TextChanged(object sender, EventArgs e)
        {
            if (Validate_Letter(ticbox_middle_right.Text))
            {
                newgame.AddToGameArray(1, 2, ticbox_middle_right.Text);
                ticbox_middle_right.ReadOnly = true;
                CheckWinner();
                ChangeTurn();
                ReadFromArray();
                CheckDraw();
            }
        }

        private void Ticbox_bottom_left_TextChanged(object sender, EventArgs e)
        {
            if (Validate_Letter(ticbox_bottom_left.Text))
            {
                newgame.AddToGameArray(2, 0, ticbox_bottom_left.Text);
                ticbox_bottom_left.ReadOnly = true;
                CheckWinner();
                ChangeTurn();
                ReadFromArray();
                CheckDraw();
            }
        }

        private void Ticbox_bottom_middle_TextChanged(object sender, EventArgs e)
        {
            if (Validate_Letter(ticbox_bottom_middle.Text))
            {
                newgame.AddToGameArray(2, 1, ticbox_bottom_middle.Text);
                ticbox_bottom_middle.ReadOnly = true;
                CheckWinner();
                ChangeTurn();
                ReadFromArray();
                CheckDraw();
            }
        }

        private void Ticbox_bottom_right_TextChanged(object sender, EventArgs e)
        {
            if (Validate_Letter(ticbox_bottom_right.Text))
            {
                newgame.AddToGameArray(2, 2, ticbox_bottom_right.Text);
                ticbox_bottom_right.ReadOnly = true;
                CheckWinner();
                ChangeTurn();
                ReadFromArray();
                CheckDraw();
            }
        }

        private Boolean Validate_Letter(string Letter)
        {
            if (gameon == 1)
            {
                if (newgame.ValidateLetter(Letter))
                {
                    if (newgame.ValidateUser(Letter))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Wrong letter for current user.");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Only X or O allowed");
                    return false;
                }
            }

            return false;
        }

        private void ChangeTurn()
        {
            newgame.ChangeTurn();

            if (newgame.TurnProperty == 1)
            {
                current_player_label.Text = "Current Player: Player 1 - " + player1.NameProperty;

            }
            else
            {
                current_player_label.Text = "Current Player: Player 2 - " + player2.NameProperty;
            }
        }

        private void CheckWinner()
        {
            if (newgame.CheckWinner())
            {

                if (newgame.TurnProperty == 1)
                {
                    MessageBox.Show("Player 1 - " + player1.NameProperty + " Wins!");

                }
                else
                {
                    MessageBox.Show("Player 2 - " + player2.NameProperty + " Wins!");
                }

                const string message = "Do you want to play again?";
                const string caption = "Play Again";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    gameon = 0;
                    ChangeTurn();
                    ResetGame();
                    gameon = 1;
                }

                if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void CheckDraw()
        {
            if (newgame.CheckDraw())
            {
                MessageBox.Show("Draw Game!");
                const string message = "Do you want to play again?";
                const string caption = "Play Again";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    gameon = 0;
                    ResetGame();

                    if (whogoesfirst_combobox.SelectedItem.ToString().ToLower() == "player1")
                    {
                        newgame.TurnProperty = 2;
                    }
                    else
                    {
                        newgame.TurnProperty = 1;
                    }

                    if (newgame.TurnProperty == 1)
                    {
                        current_player_label.Text = "Current Player: Player 1 - " + player1.NameProperty;

                    }
                    else
                    {
                        current_player_label.Text = "Current Player: Player 2 - " + player2.NameProperty;
                    }
                    gameon = 1;
                }

                if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void ReadFromArray()
        {
            ticbox_top_left.Text = newgame.ReadFromGameArray(0, 0);
            ticbox_top_middle.Text = newgame.ReadFromGameArray(0, 1);
            ticbox_top_right.Text = newgame.ReadFromGameArray(0, 2);
            ticbox_middle_left.Text = newgame.ReadFromGameArray(1, 0);
            ticbox_middle_middle.Text = newgame.ReadFromGameArray(1, 1);
            ticbox_middle_right.Text = newgame.ReadFromGameArray(1, 2);
            ticbox_bottom_left.Text = newgame.ReadFromGameArray(2, 0);
            ticbox_bottom_middle.Text = newgame.ReadFromGameArray(2, 1);
            ticbox_bottom_right.Text = newgame.ReadFromGameArray(2, 2);
        }

        private void ResetGame()
        {
            newgame.ClearGame();

            ticbox_top_left.Clear();
            ticbox_top_left.ReadOnly = false;

            ticbox_top_middle.Clear();
            ticbox_top_middle.ReadOnly = false;

            ticbox_top_right.Clear();
            ticbox_top_right.ReadOnly = false;

            ticbox_middle_left.Clear();
            ticbox_middle_left.ReadOnly = false;

            ticbox_middle_middle.Clear();
            ticbox_middle_middle.ReadOnly = false;

            ticbox_middle_right.Clear();
            ticbox_middle_right.ReadOnly = false;

            ticbox_bottom_left.Clear();
            ticbox_bottom_left.ReadOnly = false;

            ticbox_bottom_middle.Clear();
            ticbox_bottom_middle.ReadOnly = false;

            ticbox_bottom_right.Clear();
            ticbox_bottom_right.ReadOnly = false;
        }

        private void AIFirstMove()
        {
            newgame.AIMove();
            ReadFromArray();
        }

        private void player1_button_Click(object sender, EventArgs e)
        {
            players_panel.Visible = false;
            newplayer_panel.Visible = true;
            player2_txtbox.Text = "Computer";
            player2_txtbox.ReadOnly = true;
            newgame.PlayerCountProperty = 1;
        }

        private void player2_button_Click(object sender, EventArgs e)
        {
            players_panel.Visible = false;
            newplayer_panel.Visible = true;
            newgame.PlayerCountProperty = 2;
        }
    }
}
