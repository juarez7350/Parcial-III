using System;
using System.Linq;
using Xunit;

using Totito;

namespace connect_4_tests
{
    public class VerificarCambiarTiroTest
    {
        [Fact]
        public void VerificarCambioTiro()
        {
            string[,] tablero = new string[5,5]
            Form1 form = new Form1(tablero);
            Assert.True(form.EsTiroValido(0,0));
            Assert.True(form.EsTiroValido(0,1));
            //Assert.False(form.EsTiroValido("x", tablero));
            //Assert.True(form.EsTiroValido("o", tablero));
            //Assert.False(form.EsTiroValido("o", tablero));
        }

        [Fact]
        public void VerificarTiroInvalido()
        {
            string[,] tablero = new string[,]{
                {"x", "o"}
            };
            Form1 form = new Form1(tablero);
            Assert.True(form.EsTiroValido(0,0));
            Assert.True(form.EsTiroValido(0,1));
            //Assert.False(form.EsTiroValido("x", tablero));
            //Assert.True(form.EsTiroValido("o", tablero));
            //Assert.False(form.EsTiroValido("o", tablero));
        }
    }
}
