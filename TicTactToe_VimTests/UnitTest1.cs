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
            var game = new TicTacToe();

            var result = game.RenderBoard();

            Assert.AreEqual(expected, result);
        }
    }
}
