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
using System.IO;

namespace ProjetoPessoa
{
    class Program
    {
        static List<Contato> agenda;
        static ListaPessoas amigos;

        static private int CarregaDadosAmigos(string nomeArquivo)
        {
            StreamReader arqDados = new StreamReader(nomeArquivo);

            int auxCont = 0;

            string linha = arqDados.ReadLine();

            while (linha != null)
            {
                string[] temp = linha.Split(';');
                string[] detalhesData = temp[3].Split('/');
                if (temp[0] == "1")
                {
                    PessoaFisica novaPF = new PessoaFisica(temp[1], temp[5], "não tem", new AEDData(int.Parse(detalhesData[0]), int.Parse(detalhesData[1]), int.Parse(detalhesData[2])), temp[4]);
                    if (novaPF != null)
                        amigos.AdicionarPessoa(novaPF);

                }
                else if (temp[0] == "2")
                {
                    PessoaJuridica novaPJ = new PessoaJuridica(temp[1], temp[5], "não tem", new AEDData(int.Parse(detalhesData[0]), int.Parse(detalhesData[1]), int.Parse(detalhesData[2])), temp[4]);
                    if (novaPJ != null)
                        amigos.AdicionarPessoa(novaPJ);
                }
                auxCont++;
            }

            return auxCont;
        }

        static void Main(string[] args)
        {
            string arqDados = @"c:\temp\dadosAgenda.txt";
            CarregaDadosAmigos(arqDados);
        }
    }
}









