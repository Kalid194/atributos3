using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtributosMetodos
{
    class Carro
    {
        string marca = "", tipo = "", agencia = "",color="";
        int modelo = 0;
        double peso = 0.0;

        public void Andar()
        {
            Console.WriteLine("El carro esta andando");
        }

        public void Encender()
        {
            Console.WriteLine("Acavo de encender el carro");
        }

        public void Apagar()
        {
            Console.WriteLine("Estoy apagando el carro");
        }

        public void Transportar()
        {
            Console.WriteLine("el carro esta transportando");
        }

        public void Frenar()
        {
            Console.WriteLine("El carro esta frenando");
        }
    }
}
