using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace kolko_krzyzyk.Model
{
    class TicTacToe
    {       
        private bool playing = false;
        private string nowPlays()
        {
            if (playing)
            {
                playing = false;
                return "O";
            }
            playing = true;
            return "X";
            
        }
        public void playerResetter()
        {
            playing = false;
        }
        public string CheckWin(string[]board)
        {
            if (board[0] != null && board[0] == board[1] && board[0] == board[2]) return board[0];
            if (board[3] != null && board[3] == board[4] && board[3] == board[5]) return board[3];
            if (board[6] != null && board[6] == board[7] && board[6] == board[8]) return board[6];
            if (board[0] != null && board[0] == board[3] && board[0] == board[6]) return board[0];
            if (board[1] != null && board[1] == board[4] && board[1] == board[7]) return board[1];
            if (board[2] != null && board[2] == board[5] && board[2] == board[8]) return board[2];
            if (board[0] != null && board[0] == board[4] && board[0] == board[8]) return board[0];
            if (board[2] != null && board[2] == board[4] && board[2] == board[6]) return board[2];

            for(int i=0;i<9;i++)
            {
                if (board[i] == null) break;
                if (i == 8) return "draw";
            }
            return "0";
        }
        public string[] play(string p,string[] board)
        {
            int clicked = int.Parse(p);
            if (board[clicked] != null) return board;
            board[clicked] = nowPlays();
            return board;
        }
    }

}
