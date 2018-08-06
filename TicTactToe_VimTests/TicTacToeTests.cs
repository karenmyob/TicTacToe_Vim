using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe_Vim;

namespace TicTactToe_VimTests
{
    [TestClass]
    public class TicTacToeTests
    {
        [TestMethod]
        public void ShouldRenderAnEmpty3X3Board()
        {
            const string expected = "...\n" +
                                    "...\n" +
                                    "...\n";
            var input = new List<string>
            {
                ".", ".", ".",
                ".", ".", ".",
                ".", ".", ".",
            };
            var game = new TicTacToe();

            var result = game.RenderBoard(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ShouldRenderABoardWithOneX()
        {
            const string expected = "...\n" +
                                    ".X.\n" +
                                    "...\n";
            var input = new List<string>
            {
               ".", ".", ".",
               ".", "X", ".",
               ".", ".", ".", 
            };

            var game = new TicTacToe();

            var result = game.RenderBoard(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ShouldPlaceXTokenAtPosition()
        {
            var expected = new List<string>
            {
               ".", "X", ".",
               ".", ".", ".",
               ".", ".", ".", 
            };

            var inputBoard = new List<string>
            {
               ".", ".", ".",
               ".", ".", ".",
               ".", ".", ".", 
            };
            const int position = 2;

            var game = new TicTacToe();
            var result = game.PlaceToken(inputBoard, position);
            
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
