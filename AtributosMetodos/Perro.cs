using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtributosMetodos
{
    class Perro
    {
        string nombre = "", raza= "",color="";
        int edad = 0;
        double peso = 0.0;

        public void Dormir()
        {
            Console.WriteLine("El perro esta durmiedo");
        }

        public void Cuidar()
        {
            Console.WriteLine("el perro esta cuidando");
        }

        public void Comer()
        {
            Console.WriteLine("El perro esta comiendo");
        }

        public void Correr()
        {
            Console.WriteLine("El perro esta corriendo");
        }

        public void Ladrar()
        {
            Console.WriteLine("el perro esta ladrando");
        }
    }
}
