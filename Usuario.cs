using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioAC
{
    public class Usuario
    {
        private int id;
        private String nombre;
        private String apellidos;
        private int edad;
        private Dni dni;
        private static int contador = 0;


        public Usuario()
        {
            this.nombre = "";
            this.apellidos = "";
            this.edad = 0;
            this.dni = new Dni();
            this.id = contador;
            contador++;
        }
        public Usuario(string nombre, string apellidos, int edad, Dni dni)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
            this.dni = dni;
            this.id = contador;
            contador++;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public Dni Dni { get => dni; set => dni = value; }
        public int Id { get => id; }

        public override string ToString()
        {
            return this.id+" "+this.nombre + " " + this.edad + " " + this.apellidos + " " + this.dni;

        }
    }
}