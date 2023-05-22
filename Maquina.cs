using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioAC
{
    public class Maquina
    {
        private String nombre;


        public Maquina()
        {
            this.nombre = "";
        }

        public Maquina(String nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
    

    public override String ToString()
    {
        return "Maquina " + this.nombre;
    }

}


}
  



