using System;

namespace ContagemRegressiva
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Preparar...");
            Console.WriteLine("Aperta qualquer tecla para continuar");
            Console.ReadKey();
            Console.Write("\n");

            Console.WriteLine("Apontar...");
            Console.WriteLine("Aperta qualquer tecla para continuar");
            Console.ReadKey();
            Console.Write("\n");
            
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("FOGO!");
            Console.WriteLine("Aperta qualquer tecla para continuar");
            Console.ReadKey();
            Console.ResetColor();

        }
    }
}
