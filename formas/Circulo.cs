using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    class Circulo : forma
    {
        //declarando a classe de circulo.
        public double Raio { get; set; }
        public Circulo (double raio, Color cor) : base(cor)
        {
            Raio = raio;
            Color = cor;
        }
        //Calculo do circulo
        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
