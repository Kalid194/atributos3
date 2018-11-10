using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtributosMetodos
{
    class Computadora
    {
        string marca = "", modelo = "", tipo = "",color="";
        double tamaño = 0.0;

        public void Procesar()
        {
            Console.WriteLine("la computadora esta procesando");
        }

        public void Almacenar()
        {
            Console.WriteLine("La computadora esta almacenando");
        }

        public void Reproducir()
        {
            Console.WriteLine("La computadora esta reproduciendo");
        }

        public void Encender()
        {
            Console.WriteLine("la compuradora esta encendiendo");
        }

        public void Apagar()
        {
            Console.WriteLine("La computadora se esta apagando");
        }
    }
}
