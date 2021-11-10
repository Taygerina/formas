using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    class Retangulo : forma
    {
        //declarando a class do Retangulo  
        public double Largura { get; set; }
        public double Altura { get; set; }

        //declarando as variaveis
        public Retangulo (double largura, double altura, Color cor ) : base(cor)
        {
            Largura = largura;
            Altura = altura;
        }
        //calculo da area
        public override double Area()
        {
            return Largura * Altura;
        }
    }
}
