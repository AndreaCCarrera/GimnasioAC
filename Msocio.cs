using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioAC
{
    public class Msocio : Usuario
    {

        private List<Maquina> lista;

        public Msocio(string nombre, int edad, string apellidos, Dni dni) : base(nombre, apellidos, edad, dni)

        {
            this.lista = new List<Maquina>();
        }

        public Msocio() : base()

        {
            this.lista = new List<Maquina>();
        }


        public List<Maquina> Lista { get => lista; set => lista = value; }



        public void AgregarMaquina(Maquina maquina)
        {
            if (lista.Exists(m => m.Nombre == maquina.Nombre))
            {
                Console.WriteLine("Ya existe una máquina con el mismo nombre.");
                return; 
            }

            lista.Add(maquina);
            Console.WriteLine("Máquina agregada correctamente.");
        }


        public void MostrarMaquinas()
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("No hay máquinas en la lista.");
                return;
            }

            Console.WriteLine("Máquinas:");
            foreach (Maquina maquina in lista)
            {
                Console.WriteLine(maquina.Nombre);
                
            
        }
    }

    public override String ToString()
        {
            MostrarMaquinas();

            return "Socio máquinas " + base.ToString();
            
        }
    }

}


