using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioAC
{
    public class Dni
    {

            private int numero;
            private string letra;

            public Dni()
            {

                this.numero = 0;
                this.letra = "";

            }

            public Dni(int numero)
            {

                this.numero = numero;
                this.letra = Generador(numero);

            }

            public int Numero { get => numero; set => numero = value; }
            public string Letra { get => letra; set => letra = value; }

            public override string ToString()
            {
                return this.numero + this.letra;

            }

            public void Mostrar()
            {

                Console.WriteLine(this.ToString());

            }

            private string Generador(int numero)
            {


                string[] l = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };

                return l[numero % 23];

            }

        }

    }

