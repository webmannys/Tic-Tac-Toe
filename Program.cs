/* 
 * Manpreet Sangha
 * CS 39
 * Project: Tic Tac Toe Game
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Player
    {
        private int ID;
        private string Name;
        private string Letter;

        public Player(int id, string playerletter = "X", string inputname = "Player")
        {
            ID = id;
            Letter = playerletter;
            Name = inputname;
        }

        public int GetID
        {
            get
            {
                return ID;
            }
        }

        public string NameProperty
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public string LetterProperty
        {
            get
            {
                return Letter;
            }
            set
            {
                Letter = value;
            }
        }
    }

    public class Game
    {
        private List<Player> Players = new List<Player>();
        private int PlayerCount;
        private int Turn;
        private string[,] gamearray = new string[3, 3];

        public Game(int whogoesfirst = 1)
        {
            Turn = whogoesfirst;
        }

        public int PlayerCountProperty
        {
            get
            {
                return PlayerCount;
            }
            set
            {
                PlayerCount = value;
            }
        }

        public int TurnProperty
        {
            get
            {
                return Turn;
            }
            set
            {
                Turn = value;
            }

        }

        public void AddPlayer(Player newplayer)
        {
            bool playerexists = Players.Contains(newplayer);
            if (playerexists == false)
            {
                Players.Add(newplayer);
            }
        }

        public void ChangeTurn()
        {
            if (Turn == 1)
            {
                Turn = 2;
                if (PlayerCount == 1)
                {
                    AIMove();
                }
            }
            else
            {
                Turn = 1;
            }
        }

        public Boolean ValidateLetter(string letter)
        {
            if (letter == "X" || letter == "O")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean ValidateUser(string Letter)
        {
            foreach (Player currentplayer in Players)
            {
                if (currentplayer.GetID == Turn)
                {
                    if (currentplayer.LetterProperty == Letter)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        public void AddToGameArray(int horizontal, int vertical, string Letter)
        {
            gamearray[horizontal, vertical] = Letter;
        }

        public string ReadFromGameArray(int horizontal, int vertical)
        {
            return gamearray[horizontal, vertical];
        }

        public Boolean CheckWinner()
        {
            string row = "";

            for (int i = 0; i < 3; i++)
            {
                row = "";

                for (int j = 0; j < 3; j++)
                {
                    row += gamearray[i, j];
                }

                if (row == "XXX" || row == "OOO")
                {
                    return true;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                row = "";

                for (int j = 0; j < 3; j++)
                {
                    row += gamearray[j, i];
                }

                if (row == "XXX" || row == "OOO")
                {
                    return true;
                }
            }

            row = "";
            for (int i = 0; i < 3; i++)
            {
                row += gamearray[i, i];

                if (row == "XXX" || row == "OOO")
                {
                    return true;
                }
            }

            row = gamearray[0, 2] + gamearray[1, 1] + gamearray[2, 0];
            if (row == "XXX" || row == "OOO")
            {
                return true;
            }

            return false;
        }

        public Boolean CheckDraw()
        {
            int flag = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (gamearray[i, j] == null)
                    {
                        flag = 1;
                    }
                }
            }

            if (flag == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ClearGame()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gamearray[i, j] = null;
                }
            }
        }

        public void AIMove()
        {
            string playerletter = "";

            foreach (Player currentplayer in Players)
            {
                if (currentplayer.GetID == Turn)
                {
                    playerletter = currentplayer.LetterProperty;
                }
            }

            int count = 0;
            Random rnd = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (gamearray[i, j] == null)
                    {
                        count++;
                    }
                }
            }

            int randomnumber = rnd.Next(1, count);

            count = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (gamearray[i, j] == null)
                    {
                        count++;
                        if (count == randomnumber)
                        {
                            gamearray[i, j] = playerletter;
                        }
                    }
                }
            }

        }
    }
}
