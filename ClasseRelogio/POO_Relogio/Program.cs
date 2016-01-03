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

namespace POO_Relogio
{
    class Program
    {
        static void Main(string[] args)
        {
            Relogio meuRelogio = new Relogio();
     
            meuRelogio.ajusteData(14, 8, 2014); // Data configurada para 14/08/2014
            meuRelogio.ajusteHora(19, 59, 55);  // Hora configurada para 19:59:55
                        
            int opcao = 0;
            while (opcao != 1)
            {         
                if (opcao == 2)
                {
                    Console.Clear();
                    meuRelogio.passarTempo();
                    Console.WriteLine("Hora: {0}", meuRelogio.mostrarHora());
                }

                Console.WriteLine("Digite 2 para passar a hora. 1 para sair");
                opcao = int.Parse(Console.ReadLine());
            }
        }
    }
}
