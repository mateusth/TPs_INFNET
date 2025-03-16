using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DR2_TP3
{
    internal class Matematica
    {
        static void Main(string[] args)
        {
            Circulo c1 = new Circulo();
            Esfera e1 = new Esfera();

            c1.Raio = 3;
            e1.Raio = 5;
            Console.WriteLine(c1.CalcularArea());
            Console.WriteLine(e1.CalcularVolume());
        }
    }

    internal class Circulo
    {
        public double Raio;
        public double CalcularArea()
        {
            return Math.PI * (Raio * Raio);
        }
    }

    internal class Esfera
    {
        public double Raio;
        public double CalcularVolume()
        {
            return (4.0 / 3.0) * Math.PI * (Raio * Raio * Raio);
        }
    }

}
