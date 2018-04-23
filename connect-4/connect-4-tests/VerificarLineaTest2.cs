using System;
using System.Linq;
using Xunit;

using Totito;

namespace connect_4_tests
{
    public class VerificarLineaTests2
    {
        [Fact]
        public void TestVerificarLineaPerdioX()
        {
            Form1 form = new Form1();

            string[,] tablero = new string[,]
            {
                { "x", "o" }
            };

            Assert.False(form.VerificarLineas("x", tablero));
        }
        [Fact]
        public void TestVerificarLineaPerdioO()
        {
            Form1 form = new Form1();

            string[,] tablero = new string[,]
            {
                { "x", "o" }
            };

            Assert.False(form.VerificarLineas("o", tablero));
        }
    }
}
