using System;
using System.Globalization;
using System.Collections.Generic;

namespace Formas
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarando as listas e as variaveis.
            List<forma> list = new List<forma>();
            Console.WriteLine("Entre com o número de forma: ");
            int n = int.Parse(Console.ReadLine());



            for (int i = 1; i < n; i++)
            {
                //Pega as informações do usuario.
                Console.WriteLine($"Forma#{i}: ");
                Console.Write("Retâmgulo ou Circulo (R/C)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Cor: (Preto/Azul/Vermelho):");
                Color cor = Enum.Parse<Color>(Console.ReadLine());
                if (ch == 'R')
                {
                    //informa sobre largura e altura do retangulo
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine());
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine());
                    list.Add(new Retangulo(largura, altura, cor));
                }
                else
                {
                    //informa sobre raio e cor do circulo
                    Console.WriteLine("Raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circulo(raio, cor));
                }

            }
            //faz o calculo final.
            Console.WriteLine();
            Console.WriteLine("Area de cada forma: ");
            foreach (forma forma in list)
            {
                Console.WriteLine(forma.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
