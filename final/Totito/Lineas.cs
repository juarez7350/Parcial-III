using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Totito;

namespace Totito
{
    public class Lineas : Form1
    {
        //empezo javier
        public bool CheckWinner(string[,] board, string player)
        {
            // horizontalCheck 
            for (int j = 0; j < 5 - 3; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (board[i, j] == player && board[i, j + 1] == player && board[i, j + 2] == player && board[i, j + 3] == player)
                    {
                        return true;
                    }
                }
            }
            // verticalCheck
            for (int i = 0; i < 5 - 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (board[i, j] == player && board[i + 1, j] == player && board[i + 2, j] == player && board[i + 3, j] == player)
                    {
                        return true;
                    }
                }
            }
            // ascendingDiagonalCheck 
            for (int i = 3; i < 5; i++)
            {
                for (int j = 0; j < 5 - 3; j++)
                {
                    if (board[i, j] == player && board[i - 1, j + 1] == player && board[i - 2, j + 2] == player && board[i - 3, j + 3] == player)
                        return true;
                }
            }
            // descendingDiagonalCheck
            for (int i = 3; i < 5; i++)
            {
                for (int j = 3; j < 5; j++)
                {
                    if (board[i, j] == player && board[i - 1, j - 1] == player && board[i - 2, j - 2] == player && board[i - 3, j - 3] == player)
                        return true;
                }
            }
            return false;
        } //hasta aqui hizo javier
    }
}
