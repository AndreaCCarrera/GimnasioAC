using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioAC
{
    public class Csocio:Usuario
    {
        private double minutos;

        public Csocio() : base()
        {
            this.minutos = 0;

        }

        public Csocio(string nombre, int edad, string apellidos, Dni dni, double minutos): base(nombre, apellidos, edad, dni)
        {
            this.minutos = minutos;

        }

        public override String ToString()
        {
            return "Socio clases "+base.ToString()+" "+this.minutos;
        }

    }


}
