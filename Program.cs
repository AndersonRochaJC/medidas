using System;

namespace medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            Double metros = 0;
            
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("Digite a medida (em metros) para conversão: ");
            metros = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n -Conversão em Quilometros/metros/centimetros-");
            Console.WriteLine($"{metros/1000} Km");
            Console.WriteLine($"{metros} m");
            Console.WriteLine($"{metros*100} cm");
            
            Console.ResetColor();
           





        }
    }
}
