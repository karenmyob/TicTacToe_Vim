using System;
using System.Collections.Generic;

namespace TicTacToe_Vim
{
    public class TicTacToe
    {
        public object RenderBoard(List<string> board)
        {
            var outputBoard = "";

            for (var position = 0; position < board.Count; position++)
            {
                outputBoard += board[position];
                if (position % 3 == 2)
                {
                    outputBoard += "\n";
                }
            }

            return outputBoard;
        }

        public List<string> PlaceToken(List<string> inputBoard, int position)
        {
            return new List<string>(inputBoard) {[position - 1] = "X"};
        }
    }
}