using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConversorTemperatura
{
    class Program
    {
        static public int Menu()
        {
            Console.Clear();
            int op = -1;

            Console.WriteLine("Escolha a conversão: ");
            Console.WriteLine("1 - °F para °C");
            Console.WriteLine("2 - °C para °F");
            Console.WriteLine("9 - Sair");
            op = int.Parse(Console.ReadLine());

            return op;
        }
        static void Main(string[] args)
        {
            double tempConvertida;
            double tempOriginal;

            int opcao = Menu();

            while (opcao != 9)
            {

                Console.WriteLine("\nDigite o valor original: ");
                tempOriginal = double.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: tempConvertida = ConversorTemp.FahrenheitCelsius(tempOriginal);
                        Console.WriteLine("{0}°F são {1}°C", tempOriginal, tempConvertida);
                        break;
                    case 2: tempConvertida = ConversorTemp.CelsiusFahrenheit(tempOriginal);
                        Console.WriteLine("{0}°C são {1}°F", tempOriginal, tempConvertida);
                        break;
                    default: Console.WriteLine("Conversão inválida");
                        break;

                }
                Console.ReadKey();
                opcao = Menu();
            } while (opcao != 9) ;


        }
    }
}
