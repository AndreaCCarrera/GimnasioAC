using GimnasioAC;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace GimnasioAC
{
    public class Program
    {
       /* Un gimnasio de Logroño, se pone en contacto con nosotros para crear una aplicación para llevar el control de sus usuarios.
        De cada uno de ellos les interesa saber su nombre, apellidos, edad y número de DNI.Para poder llevar un control mucho más exhaustivo, a cada socio se le generará un identificador único y personal de forma automática.
        Existirán dos tipos de socios unos que trabajen solo en gimnasio con máquinas el cual tendrán un listado de las máquinas que usan más habitualmente y otro socio que se han apuntado a las clases que imparten nuestros monitores que contendrá el tiempo que dedican a la semana a esas clases en minutos (Un socio solo podrá ser de uno de los tipos y en ningún caso podrá ser de los dos a la vez).
        Tenemos que tener en cuenta que nuestro gimnasio cuenta con más de un socio, por lo que nuestra aplicación debe ser capaz de guardar a un número indeterminado de socios.
        Nuestra aplicación será capaz de buscar por el identificador de Socio y nos mostrará toda la información relacionada con dicho socio.
        Deberemos poder mostrar la información de todos los socios distinguiéndolos por el tipo de socio que es(si solo trabaja maquinas o si está apuntado a las clases).
        También queremos mostrar los socios de un grupo determinado es decir solo los socios de máquinas o también solo los de clases.
        Tendremos que tener la funcionalidad de añadir socio y eliminar socio por identificador.
        También nos interesa ser capaces de modificar los datos de un determinado socio. */



        static void Main(string[] args)
        {

            Vista vista = new Vista();
            vista.Menu();


            Console.ReadLine();
        }




    }
}

