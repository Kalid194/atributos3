using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtributosMetodos
{
    class Avion
    {
        string nombre = "", marca = "", modelo = "",tipo="";
        double peso = 0.0;

        public void Volar()
        {
            Console.WriteLine("El avion esta volando");
        }

        public void Aterrizar()
        {
            Console.WriteLine("El avion esta aterrizando");
        }

        public void Transportar()
        {
            Console.WriteLine("El avion esta tranasportado");
        }

        public void Despegar()
        {
            Console.WriteLine("El avion esta despegando");
        }

        public void Frenar()
        {
            Console.WriteLine("El avion esta frenando");
        }
    }
}
