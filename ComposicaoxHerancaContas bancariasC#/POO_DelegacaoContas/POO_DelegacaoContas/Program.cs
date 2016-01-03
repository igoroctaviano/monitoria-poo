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

namespace POO_DelegacaoContas
{
    class Program
    {
        const int NUM_CONTAS = 5;
        static string[] vetorNomes = { "João", "Pedro", "Maria", "Ana", "Tiago", "Carla", "Rosa", "Elisa", "Antonio" };

        static Conta criaConta(string nome)
        {
            Random tipo = new Random(DateTime.Now.Millisecond);
            IAplicacao tipoConta = null;
            Conta novaConta = null;

            int numTipoConta = tipo.Next(1, 4);
            double limite = (double)tipo.Next(0, 2000);
            double valorInicial = (double)tipo.Next(0, 2000);

            switch (numTipoConta)
            {
                case 1:
                    tipoConta = new Poupanca();
                    break;
                case 2:
                    tipoConta = new ContaCorrente(limite);
                    break;
                case 3:
                    tipoConta = new Poupanca();
                    break;
            }

            novaConta = new Conta(nome, tipoConta);
            novaConta.Deposito(valorInicial);

            return novaConta;
        }

        static void Init(List<Conta> contas)
        {
            for (int i = 0; i < NUM_CONTAS; i++)
            {
                Conta novaConta = criaConta(vetorNomes[i]);
                contas.Add(novaConta);

                // Aguardar um tempo de 100 milisegundos
                System.Threading.Thread.Sleep(100);
            }
        }

        private static void ImprimirContas(List<Conta> contas)
        {
            Console.Clear();
            foreach (Conta auxConta in contas)
            {
                Console.WriteLine(auxConta.ToString());
            }
        }

        private static int GetConta()
        {
            Console.Write("Número da conta: ");
            int aux = int.Parse(Console.ReadLine());
            return aux;
        }

        private static int MenuOperacoes()
        {
            Console.Clear();
            Console.WriteLine("1 - Mudar para poupança");
            Console.WriteLine("2 - Mudar para conta corrente");
            Console.WriteLine("3 - Mudar para investimento");
            Console.WriteLine("4 - Incorporar rendimento");
            Console.WriteLine("5 - Cobrar taxa");
            Console.WriteLine("6 - Mostrar posição atual");
            Console.WriteLine("9 - Sair");
            Console.WriteLine("");
            Console.Write("Opção: ");

            int aux = int.Parse(Console.ReadLine());
            return aux;
        }

        static void Main(string[] args)
        {
            List<Conta> listaContas = new List<Conta>();
            Init(listaContas);

            ImprimirContas(listaContas);
            Console.ReadKey();

            int opc = 0;
            opc = MenuOperacoes();

            while (opc != 9)
            {
                int numConta = GetConta() - 1;
                switch (opc)
                {
                    case 1:
                        listaContas[numConta].SetTipo(new Poupanca());
                        break;
                    case 2:
                        listaContas[numConta].SetTipo(new ContaCorrente(100));
                        break;
                    case 3:
                        listaContas[numConta].SetTipo(new Investimento());
                        break;
                    case 4:
                        listaContas[numConta].Rendimento(0.6);
                        break;
                    case 5:
                        listaContas[numConta].CobrancaTaxa(0.1);
                        break;
                }

                Console.WriteLine("");
                Console.WriteLine("Posição: ");
                Console.WriteLine("---------------");
                Console.WriteLine(listaContas[numConta].ToString());
                Console.ReadKey();

                opc = MenuOperacoes();
            }
        }
    }
}
