using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_3
{
    class Vacas
    {
        //Atributos
        string nombre;
        int tiempo;


        //Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Tiempo
        {
            get { return tiempo; }
            set { tiempo = value; }
        }

        //Constructor
        public Vacas() { }


        public Vacas(string nombre, int tiempo)
        {
            this.nombre = nombre;
            this.tiempo = tiempo;

        }
    }
}
