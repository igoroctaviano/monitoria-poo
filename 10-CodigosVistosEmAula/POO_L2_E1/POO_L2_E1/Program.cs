//
// Monitoria *Monitoring - Pontifícia Universidade Católica de Minas Gerais
// Unidade: São Gabriel
// Disciplina: Programação Orientada a Objetos
// *Discipline: Object-Oriented Programming
// Igor Octaviano
// https://github.com/igoroctaviano
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_L2_E1
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario[] osCaras = new Funcionario[5];

            AnalistaJr.SalarioBase = 1200;
            AnalistaJr junim = new AnalistaJr("Junior", "12345678900");
            AnalistaSr sinho = new AnalistaSr("Sinhozim", "00987654321");
            Gerente chefao = new Gerente("Chefe", "66600099900");

            osCaras[0] = chefao;
            osCaras[1] = junim;
            osCaras[2] = sinho;

            for (int i = 0; i < 3; ++i)
            {
                Console.WriteLine(osCaras[i].ToString());
                Console.WriteLine("{0:c}", osCaras[i].CalcularSalario());
                Console.WriteLine("----------");
            }

            Console.ReadKey();
        }
    }
}
