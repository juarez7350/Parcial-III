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
            form1 form = new form1();
            string[,] tablero = new string[,]
            {
                { "x", "o"}
            };
            Assert.True(form.EsTiroValido("x", tablero));
            Assert.False(form.EsTiroValido("x", tablero));
            Assert.True(form.EsTiroValido("o", tablero));
            Assert.False(form.EsTiroValido("o", tablero));
        }
    }
}
