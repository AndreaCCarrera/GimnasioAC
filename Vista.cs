using GimnasioAC;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioAC
{
    public class Vista { 

    private Gym gimnasio;

    public Vista() { 
     gimnasio= new Gym();
    
    }

        public void Menu() { 

        Gym gimnasio = new Gym();
    
        Console.WriteLine("Introduce la opcion que deseas hacer:");
        Console.WriteLine("1 crear gimnasio");
        Console.WriteLine("2 para añadir un usuario de máquinas.");
        Console.WriteLine("3 para añadir un usuario de clases.");
        Console.WriteLine("4 para borrar un usuario.");
        Console.WriteLine("5 para modificar un usuario.");
        Console.WriteLine("6 para mostrar los socios de máquinas.");
        Console.WriteLine("7 para mostrar los socios de clases.");
        Console.WriteLine("8 para mostrar todos los usuarios");
        Console.WriteLine("0 para salir.");
        string input = Console.ReadLine();
        int opcion = Int32.Parse(input);
        
        while(opcion!=0){
             
             switch(opcion){
                 case 1:
                  
                  Console.WriteLine("Introduce el nombre del gimnasio");
                  string nombre= Console.ReadLine();
                  gimnasio = new Gym(nombre);
                  gimnasio.Lista = new List<Usuario>();
                        
                 break;
                 case 2:
                  
                  Console.WriteLine("Introduce el nombre del usuario");
                  string name = Console.ReadLine();
                  Console.WriteLine("Introduce la edad del usuario");
                  input = Console.ReadLine();
                  int age = Int32.Parse(input);
                  Console.WriteLine("Introduce los apellidos del usuario");
                  string surname = Console.ReadLine();
                  Console.WriteLine("Introduce el número de DNI del usuario");
                  input = Console.ReadLine();
                  int userdni = Int32.Parse(input);
                  Dni dni = new Dni(userdni);
                  Msocio user = new Msocio(name, age, surname, dni);
                  Console.WriteLine("Introduce el número de máquinas que va a usar");
                  input = Console.ReadLine();
                  int num = Int32.Parse(input);
                        for (int n = 0; n < num; n++) { 
                  Console.WriteLine("Introduce el nombre de la máquina que va a usar");
                  String maquina = Console.ReadLine();
                  Maquina m = new Maquina(maquina);
                  user.AgregarMaquina(m);

                        }
                  gimnasio.AnadirUsuario(user);

                 break;

                case 3:

                    Console.WriteLine("Introduce el nombre del usuario");
                    name = Console.ReadLine();
                    Console.WriteLine("Introduce la edad del usuario");
                    input = Console.ReadLine();
                    age = Int32.Parse(input);
                    Console.WriteLine("Introduce los apellidos del usuario");
                    surname = Console.ReadLine();
                    Console.WriteLine("Introduce el número de DNI del usuario");
                    input = Console.ReadLine();
                    userdni = Int32.Parse(input);
                    dni = new Dni(userdni);
                    Console.WriteLine("Introduce los minutos de clase que va a tener");
                    input = Console.ReadLine();
                    double min = double.Parse(input);
                    Csocio socio = new Csocio(name, age, surname, dni, min);
                    gimnasio.AnadirUsuario(socio);

                        break;
                    case 4:
                        Console.WriteLine("Introduce el Id del usuario a borrar");
                        input = Console.ReadLine();
                        int id = Int32.Parse(input);
                        gimnasio.Borrar(id);

                        break;

                    case 5:

                        Console.WriteLine("Introduce el id del usuario");
                        input = Console.ReadLine();
                        id = Int32.Parse(input);

                        foreach (Usuario u in gimnasio.Lista)
                        {

                            if (u.Id == id)
                            {

                                Console.WriteLine("Introduce el nuevo nombre de usuario");
                                u.Nombre = Console.ReadLine();
                                Console.WriteLine("Introduce la edad del usuario");
                                input = Console.ReadLine();
                                u.Edad = Int32.Parse(input);
                                Console.WriteLine("Introduce los apellidos del usuario");
                                u.Apellidos = Console.ReadLine();
                                Console.WriteLine("Introduce el número de DNI del usuario");
                                input = Console.ReadLine();
                                userdni = Int32.Parse(input);
                                u.Dni = new Dni(userdni);
                                break;

                            }
                            else
                            {
                                Console.WriteLine("El usuario no se encuentra en la lista.");
                            }
                        }        
                    break;

                    case 6:

                        gimnasio.MostrarSMaquinas();


                        break;
                    case 7:

                        gimnasio.MostrarSClases();

                        break;

                    case 8:

                        gimnasio.MostrarGimnasio();

                        break;


                 default:
                     Console.WriteLine("No has introducido una opción válida");
                 break;                
            }

                Console.WriteLine("Introduce la opcion que deseas hacer:");
                Console.WriteLine("1 crear gimnasio");
                Console.WriteLine("2 para añadir un usuario de máquinas.");
                Console.WriteLine("3 para añadir un usuario de clases.");
                Console.WriteLine("4 para borrar un usuario.");
                Console.WriteLine("5 para modificar un usuario.");
                Console.WriteLine("6 para mostrar los socios de máquinas.");
                Console.WriteLine("7 para mostrar los socios de clases.");
                Console.WriteLine("8 para mostrar todos los usuarios");
                Console.WriteLine("0 para salir.");
                input = Console.ReadLine();
                opcion = Int32.Parse(input);
            }

            Console.WriteLine("¡Gracias por usar nuestra aplicación!");


        }

    }
     
    
}


