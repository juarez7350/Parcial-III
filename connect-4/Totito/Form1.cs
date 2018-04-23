using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Totito
{
    public partial class Form1 : Form
    {
        string[,] tablero = new string[5, 5];
        string tiro = "X";

        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Button botonElegido = (Button)sender;
            switch (botonElegido.Name)
            {
                case "b1":
                    if (EsTiroValido(0, 0))
                    {
                        tablero[0, 0] = tiro;
                        botonElegido.Text = tiro;
                    }


                    break;
                case "b2":
                    if (EsTiroValido(0, 1))
                    {
                        tablero[0, 1] = tiro;
                        botonElegido.Text = tiro;
                    }

                    break;
                case "b3":
                    if (EsTiroValido(0, 2))
                    {
                        tablero[0, 2] = tiro;
                        botonElegido.Text = tiro;
                    }

                    break;
                case "b4":
                    if (EsTiroValido(0, 3))
                    {
                        tablero[0, 3] = tiro;
                        botonElegido.Text = tiro;
                    }

                    break;
                case "b5":
                    if (EsTiroValido(0, 4))
                    {
                        tablero[0, 4] = tiro;
                        botonElegido.Text = tiro;
                    }

                    break;
                case "b6":
                    if (EsTiroValido(1, 0))
                    {
                        tablero[1, 0] = tiro;
                        botonElegido.Text = tiro;
                    }

                    break;
                case "b7":
                    if (EsTiroValido(1, 1))
                    {
                        tablero[1, 1] = tiro;
                        botonElegido.Text = tiro;
                    }

                    break;
                case "b8":
                    if (EsTiroValido(1, 2))
                    {
                        tablero[1, 2] = tiro;
                        botonElegido.Text = tiro;
                    }

                    break;
                case "b9":
                    if (EsTiroValido(1, 3))
                    {
                        tablero[1, 3] = tiro;
                        botonElegido.Text = tiro;
                    }

                    break;
                case "b10":
                    if (EsTiroValido(1, 4))
                    {
                        tablero[1, 4] = tiro;
                        botonElegido.Text = tiro;
                    }

                    break;
                case "b11":
                    if (EsTiroValido(2, 0))
                    {
                        tablero[2, 0] = tiro;
                        botonElegido.Text = tiro;
                    }

                    break;
                case "b12":
                    if (EsTiroValido(2, 1))
                    {
                        tablero[2, 1] = tiro;
                        botonElegido.Text = tiro;
                    }

                    break;
                case "b13":
                    if (EsTiroValido(2, 2))
                    {
                        tablero[2, 2] = tiro;
                        botonElegido.Text = tiro;
                    }

                    break;
                case "b14":
                    if (EsTiroValido(2, 3))
                    {
                        tablero[2, 3] = tiro;
                        botonElegido.Text = tiro;
                    }

                    break;
                case "b15":
                    if (EsTiroValido(2, 4))
                    {
                        tablero[2, 4] = tiro;
                        botonElegido.Text = tiro;
                    }

                    break;
                case "b16":
                    if (EsTiroValido(3, 0))
                    {
                        tablero[3, 0] = tiro;
                        botonElegido.Text = tiro;
                    }

                    break;
                case "b17":
                    if (EsTiroValido(3, 1))
                    {
                        tablero[3, 1] = tiro;
                        botonElegido.Text = tiro;
                    }

                    break;
                case "b18":
                    if (EsTiroValido(3, 2))
                    {
                        tablero[3, 2] = tiro;
                        botonElegido.Text = tiro;
                    }

                    break;
                case "b19":
                    if (EsTiroValido(3, 3))
                    {
                        tablero[3, 3] = tiro;
                        botonElegido.Text = tiro;
                    }

                    break;
                case "b20":
                    if (EsTiroValido(3, 4))
                    {
                        tablero[3, 4] = tiro;
                        botonElegido.Text = tiro;
                    }

                    break;
                case "b21":
                    if (EsTiroValido(4, 0))
                    {
                        tablero[4, 0] = tiro;
                        botonElegido.Text = tiro;
                    }

                    break;
                case "b22":
                    if (EsTiroValido(4, 1))
                    {
                        tablero[4, 1] = tiro;
                        botonElegido.Text = tiro;
                    }

                    break;
                case "b23":
                    if (EsTiroValido(4, 2))
                    {
                        tablero[4, 2] = tiro;
                        botonElegido.Text = tiro;
                    }

                    break;
                case "b24":
                    if (EsTiroValido(4, 3))
                    {
                        tablero[4, 3] = tiro;
                        botonElegido.Text = tiro;
                    }

                    break;
                case "b25":
                    if (EsTiroValido(4, 4))
                    {
                        tablero[4, 4] = tiro;
                        botonElegido.Text = tiro;
                    }

                    break;
                default:
                    break;
            }
            if (VerificarLineas(botonElegido))
            {
                MessageBox.Show("Ganaste!");
                IB();
            }
            Draw(); 
            CambiarTiro();
        }

        //public bool VerificarLineas(string v, string[,] tablero)
        //{
          //  throw new NotImplementedException();
        //}
        //private bool VerificarLineas(string name, string [,] tablero)
        public bool VerificarLineas(Button Elegir, string v, string [,] tablero)
        {
            bool hayGanador = false;
            if (Elegir.Name.Equals("b1"))
            {
                if (tablero[0, 1] == tiro && tablero[0, 2] == tiro && tablero[0, 3] == tiro)
                    hayGanador = true;
                else if (tablero[1, 0] == tiro && tablero[2, 0] == tiro && tablero[3, 0] == tiro && tablero[4, 0] == tiro)
                    hayGanador = true;
                else if (tablero[1, 1] == tiro && tablero[2, 2] == tiro && tablero[3, 3] == tiro && tablero[4, 4] == tiro)
                    hayGanador = true;
            }

            if (Elegir.Name.Equals("b2"))
            {
                if (tablero[0, 0] == tiro && tablero[0, 2] == tiro && tablero[0, 3] == tiro && tablero[0, 4] == tiro)
                    hayGanador = true;
                else if (tablero[1, 1] == tiro && tablero[2, 1] == tiro && tablero[3, 1] == tiro && tablero[4, 1] == tiro)
                    hayGanador = true;
            }

            if (Elegir.Name.Equals("b3"))
            {
                if (tablero[0, 0] == tiro && tablero[0, 1] == tiro && tablero[0, 3] == tiro && tablero[0, 4] == tiro)
                    hayGanador = true;
                else if (tablero[1, 2] == tiro && tablero[2, 2] == tiro && tablero[3, 2] == tiro && tablero[4, 2] == tiro)
                    hayGanador = true;
            }

            if (Elegir.Name.Equals("b4"))
            {
                if (tablero[0, 0] == tiro && tablero[0, 1] == tiro && tablero[0, 2] == tiro && tablero[0, 4] == tiro)
                    hayGanador = true;
                else if (tablero[1, 3] == tiro && tablero[2, 3] == tiro && tablero[3, 3] == tiro && tablero[4, 3] == tiro)
                    hayGanador = true;
            }

            if (Elegir.Name.Equals("b5"))
            {
                if (tablero[1, 4] == tiro && tablero[2, 4] == tiro && tablero[3, 4] == tiro && tablero[4, 4] == tiro)
                    hayGanador = true;
                else if (tablero[0, 1] == tiro && tablero[0, 2] == tiro && tablero[0, 3] == tiro && tablero[0, 0] == tiro)
                    hayGanador = true;
                else if (tablero[1, 3] == tiro && tablero[2, 2] == tiro && tablero[3, 1] == tiro && tablero[4, 0] == tiro)
                    hayGanador = true;
            }

            if (Elegir.Name.Equals("b6"))
            {
                if (tablero[0, 0] == tiro && tablero[2, 0] == tiro && tablero[3, 0] == tiro && tablero[4, 0] == tiro)
                    hayGanador = true;
                else if (tablero[1, 1] == tiro && tablero[1, 2] == tiro && tablero[1, 3] == tiro && tablero[1, 4] == tiro)
                    hayGanador = true;
            }

            if (Elegir.Name.Equals("b7"))
            {
                if (tablero[0, 1] == tiro && tablero[2, 1] == tiro && tablero[3, 1] == tiro && tablero[4, 1] == tiro)
                    hayGanador = true;
                else if (tablero[1, 0] == tiro && tablero[1, 2] == tiro && tablero[1, 3] == tiro && tablero[1, 4] == tiro)
                    hayGanador = true;
                else if (tablero[0, 0] == tiro && tablero[2, 2] == tiro && tablero[3, 3] == tiro && tablero[4, 4] == tiro)
                    hayGanador = true;
            }

            if (Elegir.Name.Equals("b8"))
            {
                if (tablero[0, 2] == tiro && tablero[2, 2] == tiro && tablero[3, 2] == tiro && tablero[4, 2] == tiro)
                    hayGanador = true;
                else if (tablero[1, 0] == tiro && tablero[1, 1] == tiro && tablero[1, 3] == tiro && tablero[1, 4] == tiro)
                    hayGanador = true;
            }

            if (Elegir.Name.Equals("b9"))
            {
                if (tablero[0, 3] == tiro && tablero[2, 3] == tiro && tablero[3, 3] == tiro && tablero[4, 3] == tiro)
                    hayGanador = true;
                else if (tablero[1, 1] == tiro && tablero[1, 2] == tiro && tablero[1, 4] == tiro && tablero[1, 0] == tiro)
                    hayGanador = true;
            }

            if (Elegir.Name.Equals("b10"))
            {
                if (tablero[0, 4] == tiro && tablero[2, 4] == tiro && tablero[3, 4] == tiro && tablero[4, 4] == tiro)
                    hayGanador = true;
                else if (tablero[1, 1] == tiro && tablero[1, 2] == tiro && tablero[1, 3] == tiro && tablero[1, 0] == tiro)
                    hayGanador = true;
            }

            if (Elegir.Name.Equals("b11"))
            {
                if (tablero[0, 0] == tiro && tablero[1, 0] == tiro && tablero[3, 0] == tiro && tablero[4, 0] == tiro)
                    hayGanador = true;
                else if (tablero[2, 1] == tiro && tablero[2, 2] == tiro && tablero[2, 3] == tiro && tablero[2, 4] == tiro)
                    hayGanador = true;
            }

            if (Elegir.Name.Equals("b12"))
            {
                if (tablero[0, 1] == tiro && tablero[1, 1] == tiro && tablero[3, 1] == tiro && tablero[4, 1] == tiro)
                    hayGanador = true;
                else if (tablero[2, 0] == tiro && tablero[2, 2] == tiro && tablero[2, 3] == tiro && tablero[2, 4] == tiro)
                    hayGanador = true;
            }

            if (Elegir.Name.Equals("b13"))
            {
                if (tablero[0, 2] == tiro && tablero[1, 2] == tiro && tablero[3, 2] == tiro && tablero[4, 2] == tiro)
                    hayGanador = true;
                else if (tablero[0, 0] == tiro && tablero[1, 1] == tiro && tablero[3, 3] == tiro && tablero[4, 4] == tiro)
                    hayGanador = true;
                else if (tablero[2, 0] == tiro && tablero[2, 1] == tiro && tablero[2, 3] == tiro && tablero[2, 4] == tiro)
                    hayGanador = true;
            }

            if (Elegir.Name.Equals("b14"))
            {
                if (tablero[0, 3] == tiro && tablero[1, 3] == tiro && tablero[3, 3] == tiro && tablero[4, 3] == tiro)
                    hayGanador = true;
                else if (tablero[2, 1] == tiro && tablero[2, 2] == tiro && tablero[2, 4] == tiro && tablero[2, 0] == tiro)
                    hayGanador = true;
            }

            if (Elegir.Name.Equals("b15"))
            {
                if (tablero[0, 4] == tiro && tablero[1, 4] == tiro && tablero[3, 4] == tiro && tablero[4, 4] == tiro)
                    hayGanador = true;
                else if (tablero[2, 1] == tiro && tablero[2, 2] == tiro && tablero[2, 3] == tiro && tablero[2, 0] == tiro)
                    hayGanador = true;
            }

            if (Elegir.Name.Equals("b16"))
            {
                if (tablero[0, 0] == tiro && tablero[1, 0] == tiro && tablero[2, 0] == tiro && tablero[4, 0] == tiro)
                    hayGanador = true;
                else if (tablero[3, 1] == tiro && tablero[3, 2] == tiro && tablero[3, 3] == tiro && tablero[3, 4] == tiro)
                    hayGanador = true;
            }

            if (Elegir.Name.Equals("b17"))
            {
                if (tablero[0, 1] == tiro && tablero[1, 1] == tiro && tablero[2, 1] == tiro && tablero[4, 1] == tiro)
                    hayGanador = true;
                else if (tablero[3, 0] == tiro && tablero[3, 2] == tiro && tablero[3, 4] == tiro && tablero[3, 4] == tiro)
                    hayGanador = true;
                else if (tablero[4, 0] == tiro && tablero[2, 2] == tiro && tablero[1, 3] == tiro && tablero[0, 4] == tiro)
                    hayGanador = true;
            }

            if (Elegir.Name.Equals("b18"))
            {
                if (tablero[0, 2] == tiro && tablero[1, 2] == tiro && tablero[2, 2] == tiro && tablero[4, 2] == tiro)
                    hayGanador = true;
                else if (tablero[3, 0] == tiro && tablero[3, 1] == tiro && tablero[3, 3] == tiro && tablero[3, 4] == tiro)
                    hayGanador = true;
            }

            if (Elegir.Name.Equals("b19"))
            {
                if (tablero[0, 3] == tiro && tablero[1, 3] == tiro && tablero[2, 3] == tiro && tablero[4, 3] == tiro)
                    hayGanador = true;
                else if (tablero[3, 0] == tiro && tablero[3, 1] == tiro && tablero[3, 2] == tiro && tablero[3, 4] == tiro)
                    hayGanador = true;
            }

            if (Elegir.Name.Equals("b20"))
            {
                if (tablero[0, 4] == tiro && tablero[1, 4] == tiro && tablero[2, 4] == tiro && tablero[4, 4] == tiro)
                    hayGanador = true;
                else if (tablero[3, 1] == tiro && tablero[3, 2] == tiro && tablero[3, 3] == tiro && tablero[3, 0] == tiro)
                    hayGanador = true;
            }

            if (Elegir.Name.Equals("b21"))
            {
                if (tablero[1, 0] == tiro && tablero[2, 0] == tiro && tablero[3, 0] == tiro && tablero[0, 0] == tiro)
                    hayGanador = true;
                else if (tablero[4, 1] == tiro && tablero[4, 2] == tiro && tablero[4, 3] == tiro && tablero[4, 4] == tiro)
                    hayGanador = true;
                else if (tablero[3, 1] == tiro && tablero[2, 2] == tiro && tablero[1, 3] == tiro && tablero[0, 4] == tiro)
                    hayGanador = true;
            }

            if (Elegir.Name.Equals("b22"))
            {
                if (tablero[1, 1] == tiro && tablero[2, 1] == tiro && tablero[3, 1] == tiro && tablero[0, 1] == tiro)
                    hayGanador = true;
                else if (tablero[4, 0] == tiro && tablero[4, 2] == tiro && tablero[4, 3] == tiro && tablero[4, 4] == tiro)
                    hayGanador = true;
            }

            if (Elegir.Name.Equals("b23"))
            {
                if (tablero[4, 0] == tiro && tablero[4, 1] == tiro && tablero[4, 3] == tiro && tablero[4, 4] == tiro)
                    hayGanador = true;
                else if (tablero[1, 2] == tiro && tablero[2, 2] == tiro && tablero[3, 2] == tiro && tablero[0, 2] == tiro)
                    hayGanador = true;
            }

            if (Elegir.Name.Equals("b24"))
            {
                if (tablero[4, 1] == tiro && tablero[4, 2] == tiro && tablero[4, 4] == tiro && tablero[4, 0] == tiro)
                    hayGanador = true;
                else if (tablero[1, 3] == tiro && tablero[2, 3] == tiro && tablero[3, 3] == tiro && tablero[0, 3] == tiro)
                    hayGanador = true;
            }

            if (Elegir.Name.Equals("b25"))
            {
                if (tablero[1, 4] == tiro && tablero[2, 4] == tiro && tablero[3, 4] == tiro && tablero[0, 4] == tiro)
                    hayGanador = true;
                else if (tablero[4, 1] == tiro && tablero[4, 2] == tiro && tablero[4, 3] == tiro && tablero[4, 0] == tiro)
                    hayGanador = true;
                else if (tablero[1, 1] == tiro && tablero[2, 2] == tiro && tablero[3, 3] == tiro && tablero[0, 0] == tiro)
                    hayGanador = true;
            }

            return hayGanador;

        }

        public bool EsTiroValido(int fila, int columna)
        {
            if (tablero[fila, columna] == null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Elija otra");
                return false;
            }
        }

        public void CambiarTiro()
        {
            if (tiro == "X")
            {
                tiro = "O";
            }
            else
            {
                tiro = "X";
            }
        }
        
        private void IB()
        {
            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            b4.Text = "";
            b5.Text = "";
            b6.Text = "";
            b7.Text = "";
            b8.Text = "";
            b9.Text = "";
            b10.Text = "";
            b11.Text = "";
            b12.Text = "";
            b13.Text = "";
            b14.Text = "";
            b15.Text = "";
            b16.Text = "";
            b17.Text = "";
            b18.Text = "";
            b19.Text = "";
            b20.Text = "";
            b21.Text = "";
            b22.Text = "";
            b23.Text = "";
            b24.Text = "";
            b25.Text = "";

            for (int fila = 0; fila <= tablero.GetUpperBound(0); fila++)
            {
                for (int columna = 0; columna <= tablero.GetUpperBound(0); columna++)
                {
                    Console.WriteLine(tablero[fila, columna]);
                    tablero[fila, columna] = null;    
                }

            }           
        }    
        
        public void Draw()
        {
            int contador = 0;
            for (int fila = 0; fila <= tablero.GetUpperBound(0); fila++)
            {
                for (int columna = 0; columna <= tablero.GetUpperBound(0); columna++)
                {
                    if (tablero[fila, columna]  !=null)
                    {
                        contador++;
                    }
                }
            }

            if (contador == tablero.Length)
            {
                MessageBox.Show("Empate");
                IB();
            }
        }

    }
}
