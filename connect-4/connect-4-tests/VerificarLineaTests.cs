using System;
using System.Linq;
using Xunit;

using Totito;

namespace connect_4_tests
{
    public class VerificarLineaTests
    {
        [Fact]
        public void TestVerificarLineaGanoX()
        {
            Form1 form = new Form1();

            string[,] tablero = new string[,]
            {
                { "x", "o" }
            };

            Assert.True(form.VerificarLineas("x", tablero));
        }
        [Fact]
        public void TestVerificarLineaGanoO()
        {
            Form1 form = new Form1();

            string[,] tablero = new string[,]
            {
                { "x", "o" }
            };

            Assert.True(form.VerificarLineas("o", tablero));
        }
    }
}
