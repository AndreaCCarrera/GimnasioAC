using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioAC
{
    public class Gym
    {
        private string nombre;
        private List<Usuario> lista; //

        public string Nombre { get => nombre; set => nombre = value; }
        public List<Usuario> Lista { get => lista; set => lista = value; }

        public Gym() {

            this.nombre = "";
            this.lista = new List<Usuario>();
        
        }

        public Gym(string nombre)
        {
            this.nombre = nombre;
            this.lista = new List<Usuario>();

        }

        public void MostrarSMaquinas()
        {

            foreach (Usuario a in lista)
            
            if (a is Msocio)
                {
                Console.WriteLine(a);

            }

        }

        public void MostrarSClases()
        {

            foreach (Usuario a in lista)

                if (a is Csocio)
                {
                    Console.WriteLine(a);

                }

        }

        public void MostrarTodos() {


            foreach (Usuario a in lista) {
                Console.WriteLine(a);
            
            }
       
        }

        public override string ToString() 
        {
            return this.nombre; 
        }

        public void AnadirUsuario(Usuario u) {

            lista.Add(u);
        
        }

        public void Borrar(int id) {

            foreach (Usuario u in lista)
            {

                if (u.Id == id)
                {
                    lista.Remove(u);
                    break;

                }
                
            }

        }

        public void MostrarGimnasio() {


            Console.WriteLine(ToString());
            MostrarTodos();
        }

    }
}
