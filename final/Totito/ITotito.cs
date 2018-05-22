using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totito
{
    public interface ITotito
    {
        void Button1_Click(object sender, EventArgs e);
    }

    public interface ILineas
    {
        bool VerificarLineas(string name, string[,] tablero);
    }

    public interface ITiro
    {
        bool EsTiroValido(int fila, int columna);
        void CambiarTiro();
    }

    public interface IDraw
    {
        void Draw();
    }

    public interface IBclass
    {
        void IB();
    }
}

