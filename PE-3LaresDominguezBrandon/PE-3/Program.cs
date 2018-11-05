
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lares Dominguez Brandon
            Practicas PE3 = new Practicas();

            inicio:
            Console.Clear();
            Console.WriteLine("Practicas Evaluativas, Seleccione una: ");
            Console.WriteLine("1.- Practica 1: Vacas");
            Console.WriteLine("2.- Practica 2: Torre de Hanoi");
            Console.WriteLine("3.- Practica 3: To Do List");
            Console.WriteLine("Cualquier otro valor: Salir");
            int numero = Int32.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    PE3.PracticaVacas();
                    goto inicio;
                case 2:
                    PE3.PracticaTorresHanoi();
                    goto inicio;
                case 3:
                    PE3.PracticaToDoList();
                    goto inicio;                    
                case 0:
                    Console.WriteLine("Gracias...");
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
          

        }
        
        




    }
}
