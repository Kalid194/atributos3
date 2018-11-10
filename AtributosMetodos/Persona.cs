using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtributosMetodos
{
    class Persona
    {
        string nombre = "", direccion = "", apellido = "";
        int edad=0;
        double peso = 0.0;

        public void Dormir()
        {
            Console.WriteLine("Estoy durmiendo");
        }
        
        public void Leer()
        {
            Console.WriteLine("Comenzare a leer");
        }

        public void Comer()
        {
            Console.WriteLine("Estoy comiendo");
        }

        public void Trabajar()
        {
            Console.WriteLine("Estoy trabajando");
        }

        public void Caminar()
        {
            Console.WriteLine("Estoy caminando");
        }
    }
}
