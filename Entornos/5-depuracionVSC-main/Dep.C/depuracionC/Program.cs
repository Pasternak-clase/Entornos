using System;

namespace entornos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 234;
            int num2 = 40;

            int suma = num + num2;
            int multiplicacion = num * num2;
            int division = num / num2;
            
            Console.WriteLine($"{num}, {suma}, {multiplicacion}, {division}");
        }
    }
}