using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_3
{
    class Tareas
    {
        //Atributos
        int numeroID;
        string nom;
        string fechaIn;
        string stat;
        string fechaFi;
        string descrip;

        //Propiedades
        public int NumeroID
        {
            get { return numeroID; }
            set { numeroID = value; }
        }
        public string Nombre
        {
            get { return nom; }
            set { nom = value; }
        }
        public string FechaInicio
        {
            get { return fechaIn; }
            set { fechaIn = value; }
        }
        public string FechaFinalizacion
        {
            get { return fechaFi; }
            set { fechaFi = value; }
        }
        public string Status
        {
            get { return stat; }
            set { stat = value; }
        }
        public string Descripcion
        {
            get { return descrip; }
            set { descrip = value; }
        }
        //Constructores
        public Tareas() { }


        public Tareas(int numeroID, string nombre, string fechaInicio, string status, string fechaFinalizacion, string descripcion)
        {
            this.numeroID = numeroID;
            this.nom = nombre;
            this.fechaIn = fechaInicio;
            this.stat = status;
            this.fechaFi = fechaFinalizacion;
            this.descrip = descripcion;

        }

       //Metodo
        public void imprimir()//Imprime la tarea
        {
            Console.WriteLine("Numero de ID: {0} \nNombre de tarea: {1} \nFecha de inicio: {2}\nStatus: {3}" +
                "\nFecha de finalizacion: {4}\nDescripcion: {5}", numeroID, nom, fechaIn, stat, fechaFi, descrip);
            Console.WriteLine();
        }

    }
}
