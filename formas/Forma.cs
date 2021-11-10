using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    abstract class forma
    {
        //declarando a classe de forma
        public Color Color { get; set; }
        public forma(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
