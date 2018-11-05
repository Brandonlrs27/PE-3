using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_3
{
    public class Practicas
    {

        public void PracticaVacas()
        {
            /* 1.- Supongamos que Bob tiene cuatro vacas que quiere cruzar por un puente,
          * pero solo un yugo, que puede sostener hasta dos vacas, lado a lado, atadas
          * al yugo.El yugo es demasiado pesado para que lo lleve a través del puente, 
          * pero puede atar(y desatar) vacas a él en muy poco tiempo.De sus cuatro vacas,
          * Mazie puede cruzar el puente en 2 minutos, Daisy puede cruzarlo en 4 minutos, 
          * Crazy puede cruzarlo en 10 minutos y Lazy puede cruzar en 20 minutos.
          * Por supuesto, cuando dos vacas están atadas al yugo, deben ir a la velocidad 
          * de la vaca más lenta.Describe cómo Bob puede conseguir que todas sus vacas 
          * crucen el puente en 34 minutos*/


            List<Vacas> vacas = new List<Vacas>// Lista de vacas de Bob
            {
             new Vacas ("Mazie", 2),//Llama la clase vaca y asigna nombre y tiempo de cruce
             new Vacas ("Daisy", 4),
             new Vacas ("Crazy", 10),
             new Vacas("Lazy", 20)
            };

            List<Vacas> nohanpasado = new List<Vacas>();//Lista de vacas que no han cruzado el puente
            nohanpasado.Add(vacas.ElementAt(0));
            nohanpasado.Add(vacas.ElementAt(1));
            nohanpasado.Add(vacas.ElementAt(2));
            nohanpasado.Add(vacas.ElementAt(3));

            Vacas[] yugo = new Vacas[2];//Arreglo de solo 2 vacas para el Yugo

            List<Vacas> hanpasado = new List<Vacas>();//Vacas que ya cruzaron el puente

            int tiempoT = 0; //Tiempo que va transcurriendo en el problema
            int recorrido = 0;//Recorrido en el que va el problema

            imprimirVacas(tiempoT, nohanpasado, yugo, hanpasado, recorrido);//Llama la funcion para imprimir estado de vacsa.


            //Primera vuelta
            recorrido++;

            yugo[0] = vacas.ElementAt(0);//pongo en el yugo la vaca Mazie
            yugo[1] = vacas.ElementAt(1);//pongo en el yugo a vaca Daisy

            nohanpasado.Remove(vacas.ElementAt(0));//paso el puente por lo que elimino vaca de esta lista
            nohanpasado.Remove(vacas.ElementAt(1));


            tiempoT += vacas.ElementAt(1).Tiempo;//Sumo tiempo de recorrido

            hanpasado.Add(vacas.ElementAt(0));//Agrego vacas que ya pasaron el puente
            hanpasado.Add(vacas.ElementAt(1));

            imprimirVacas(tiempoT, nohanpasado, yugo, hanpasado, recorrido);//Llamo a funcion para imprimir estado nuevamente

            //Regreso
            recorrido++;

            hanpasado.Remove(vacas.ElementAt(1));// Elimino de lista de los que ya pasaron porque Daisy se va a regresar
            yugo[0] = null;//yugo en posicion 0 se queda vacio porque Mazie se queda al otro lado de puente


            tiempoT += vacas.ElementAt(1).Tiempo;//sumo tiempo de recorrido de regreso de daisy

            nohanpasado.Add(vacas.ElementAt(1)); //regreso a daisy en lista sin pasar


            imprimirVacas(tiempoT, nohanpasado, yugo, hanpasado, recorrido);//lamo a funcion para imprimir estado
            yugo[1] = null;// el yugo en posicion 1  queda vacio puesto que se quita a daisy del yugo


            //segunda vuelta
            recorrido++;
            yugo[0] = vacas.ElementAt(2);//pongo en el yugo la vaca crazy
            yugo[1] = vacas.ElementAt(3);//pongo en el yugo a vaca lazy

            nohanpasado.Remove(vacas.ElementAt(2));//pasaron el puente por lo que elimino vacas de esta lista
            nohanpasado.Remove(vacas.ElementAt(3));


            tiempoT += vacas.ElementAt(3).Tiempo;//sumo tiempo de recorrido

            hanpasado.Add(vacas.ElementAt(2));//agrego vacas que ya pasaron el puente
            hanpasado.Add(vacas.ElementAt(3));

            imprimirVacas(tiempoT, nohanpasado, yugo, hanpasado, recorrido);//Llamo la funcion para imprimir estado

            //regreso
            recorrido++;
            hanpasado.Remove(vacas.ElementAt(0));// elimino a mazie de lista de los que ya pasaron porque mazie se va a regresar
            yugo[0] = null; yugo[1] = null;// el yugo  se queda vacio porque crazy y lazy se quedan al otro lado de puente
            yugo[0] = vacas.ElementAt(0);//pongo en el yugo a vaca mazie

            tiempoT += vacas.ElementAt(0).Tiempo;//sumo tiempo de recorrido de regreso de mazie

            nohanpasado.Add(vacas.ElementAt(0)); //regreso a mazie en lista sin pasar

            imprimirVacas(tiempoT, nohanpasado, yugo, hanpasado, recorrido);//lamo a funcion para imprimir estado

            //tercera vuelta

            recorrido++;
            yugo[1] = vacas.ElementAt(1);//pongo en el yugo a vaca daisy

            nohanpasado.Remove(vacas.ElementAt(0));//pasaron el puente por lo que elimino vacas de esta lista
            nohanpasado.Remove(vacas.ElementAt(1));


            tiempoT += vacas.ElementAt(1).Tiempo;//sumo tiempo de recorrido

            hanpasado.Add(vacas.ElementAt(0));//agrego vacas  porque ya pasaron el puente
            hanpasado.Add(vacas.ElementAt(1));

            imprimirVacas(tiempoT, nohanpasado, yugo, hanpasado, recorrido);//llamo a funcion para imprimir estado

        }

        public void PracticaTorresHanoi()
        {
            Stack <int> torre1 = new Stack<int>();//pila de inicio
            Stack<int> torre2 = new Stack<int>();//pila de apoyo
            Stack<int> torre3 = new Stack<int>();//pila a donde se deben mover los discos en orden de mayor a menor


            Console.WriteLine("Discos en la torre 1 para iniciar juego: ");
            int disc = Int32.Parse(Console.ReadLine());//numero de discos en el juego

            for(int i = disc; i > 0; i--)//ingresa datos en pila torre 1
            {
                torre1.Push(i);
            }

            Hanoi(disc, torre1, torre2, torre3);//manda llamar a la funcion para cambiar posiciones de torre de hanoi
            ImpHanoi(torre1, torre2, torre3);

            Console.ReadKey(); 
        }

        public void PracticaToDoList()
        {
            /*Agregar y ver tareas numero ID,Tareas con nombre, fecha de inicio, status, fecha de finalizacion, descripcion
             * Debe haber listas globales, listas pendientes, listas terminadas, Lista en proceso   */

            List<Tareas> globales= new List<Tareas>();//lista de todas las tareas
            List<Tareas> pendientes = new List<Tareas>();//lista de tareas pendientes
            List<Tareas> enProceso = new List<Tareas>();//lista de tareas en proceso
            List<Tareas> terminadas = new List<Tareas>();//listas terminadas

            MENUTAREAS:
            Console.WriteLine("To Do List, inserte valor: ");//Empieza el ejercicio
            Console.WriteLine("1. Agregar tarea");
            Console.WriteLine("2. Ver tareas actuales");
            Console.WriteLine("0. Salir");
            int numero = Int32.Parse(Console.ReadLine());
            
            switch (numero)
            {
                case 1://Caso uno es para agregar una tarea a listas
                    Console.WriteLine("Numero de Id de la tarea: "); //pregunta los atributos de tarea
                    int numeroID = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Nombre de documento: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Fecha de inicio: ");
                    string fechaInicio = Console.ReadLine();
                    Console.WriteLine("Status (Puede ser: pendiente, en proceso o terminado):  ");
                    string status= Console.ReadLine();
                    Console.WriteLine("Fecha de finalizacion: ");
                    string fechaFinalizacion = Console.ReadLine();
                    Console.WriteLine("Descripcion: ");
                    string descripcion = Console.ReadLine();

                    switch (status)// dependiendo del estatus que le dio el usuario se agrega a determinada lista
                    {//segun el caso agrega en la lista correspondiente el nuevo elemento mandando llamar 
                      //a la clase e ingresando los datos que se pidieron al usuario
                        case "pendiente":
                            pendientes.Add(new Tareas(numeroID, nombre, fechaInicio, status, fechaFinalizacion, descripcion));
                            break;
                        case "en proceso":
                            enProceso.Add(new Tareas(numeroID, nombre, fechaInicio, status, fechaFinalizacion, descripcion));
                            break;
                        case "terminado":
                            terminadas.Add(new Tareas(numeroID, nombre, fechaInicio, status, fechaFinalizacion, descripcion)); 
                            break;
                        default:
                            
                            break;
                    }
                    //se agrega tambien en globales puesto que todos deben ingresarse aqui
                    globales.Add(new Tareas(numeroID, nombre, fechaInicio, status, fechaFinalizacion,  descripcion));

                    goto MENUTAREAS;//Regresa a menu de To Do List 
                    
                case 2://caso dos es para ver elementos de una lista determinada
                    Console.WriteLine("¿En que Status se encuentra tu tarea?");//da a escoger la lista
                    Console.WriteLine("1. Pendientes");
                    Console.WriteLine("2. En proceso");
                    Console.WriteLine("3. Terminadas");
                    int numEleccion = Int32.Parse(Console.ReadLine());
                    switch (numEleccion)
                    {
                        case 1:
                            ver(pendientes);//llama a la funcion ver que es para ver los elementos de la lista ya sean todos o uno solo
                            
                            break;
                        case 2:
                            ver(enProceso);
                            break;
                        case 3:
                            ver(terminadas);
                            break;
                        default:

                            break;
                    }
                    goto MENUTAREAS;
                   
                case 0:
                    break;
                default:
                    break;
            }


        }

        static void imprimirVacas(int tiempoT, List<Vacas> nohanpasado, Vacas[] yugo, List<Vacas> hanpasado, int recorrido)//imprimir lo que transcurre cada vuelta
        {
            Console.WriteLine("Presione cualquier tecla...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Recorrido: " + recorrido);
            Console.Write("Vacas sin pasar por el puente: ");

            foreach (Vacas x in nohanpasado)
            {
                Console.Write(x.Nombre + "  ");
            }

            Console.WriteLine();

            Console.Write("Vacas en yugo: ");

            foreach (Vacas x in yugo)
            {
                if (x != null)
                {
                    Console.Write(x.Nombre + "  ");
                }
            }

            Console.WriteLine();

            Console.Write("Vacas que han cruzado el puente: ");

            foreach (Vacas x in hanpasado)
            {
                Console.Write(x.Nombre + "  ");
            }

            Console.WriteLine();

            Console.WriteLine("Tiempo transcurrido: {0}", tiempoT);

            Console.WriteLine();
        }

        static void ver(List<Tareas>lista)//funcion para dar a elegir entre si ver todos los elementos de la lista o uno en especifico
        {
            Console.WriteLine("Escoga una opcion: ");
            Console.WriteLine("1. Ver todos los elementos");
            Console.WriteLine("2. Ver un solo elemento de la lista");
            int opcion = Int32.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    foreach (Tareas elemento in lista)//imprime todos los elementos de la lista
                    {
                        elemento.imprimir();
                    }
                    break;
                case 2:
                    Console.WriteLine("Orden numerico en el que esta el elemento que desea ver");//pide el numero del elemento que desea ver para poder buscarlo y mostrarlo
                    int orden = Int32.Parse(Console.ReadLine());
                    lista.ElementAt(orden-1).imprimir();//Resta un elemento porque la lista empieza en 0
                    break;
                default:
                    Console.WriteLine("Error");
                    break;

            }
        }


        static void Hanoi(int n,Stack<int>o,Stack<int>a, Stack<int>d)
        {

            ImpHanoi(o, a, d);


            if (n == 1)//Si solo tiene un disco, lo manda directamente a torre 3
            {
                d.Push(o.Pop());
            }
            else// si no, se debe seguir la siguiente formula
            {
                Hanoi(n - 1, o, d, a);

                ImpHanoi(o, a, d);

                Hanoi(1, o, a, d);

                ImpHanoi(o, a, d);

                Hanoi(n - 1, a, o, d);
                

            }

            ImpHanoi(o, a, d);
        }

        static void ImpHanoi(Stack<int> o, Stack<int> a, Stack<int> d)// imprime los numeros que tienen las pilas
        {
            Console.WriteLine("presione una tecla");
            Console.ReadKey();
            Console.Clear();

            Console.Write("torre 1: \n ");
            foreach (int num in o)//elementos en torre 1
            {
                Console.Write(num + "\n ");
            }

            Console.WriteLine();
            Console.Write("torre 2: \n");//elementos en pila torre 2
            foreach (int num in a)
            {
                Console.Write(num + "\n ");
            }

            Console.WriteLine();
            Console.Write("torre 3:\n ");//elementos en pila torre 3
            foreach (int num in d)
            {
                Console.Write(num + "\n ");
            }

            Console.WriteLine();
        }
    }
}
