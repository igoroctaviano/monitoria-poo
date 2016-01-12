//
// Pontifícia Universidade Católica de Minas Gerais
// Unidade São Gabriel
// Disciplina: Programação Orientada a Objetos
// *Object-Oriented Programming
// 
// Igor Octaviano
// More? access: https://github.com/igoroctaviano/
// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PM_ExcecoesCSharp
{
    class Program
    {
        static string[] SplitString(string inputString)
        {
            if (inputString == null)
            {
                throw new ArgumentNullException("A string do parâmetro de SplitString está nula!");
            }
            else return (inputString.Split('-'));
        }

        static void Main(string[] args)
        {
            string s = null;
            // s = Console.ReadLine();
            try
            {
                SplitString(s);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}






