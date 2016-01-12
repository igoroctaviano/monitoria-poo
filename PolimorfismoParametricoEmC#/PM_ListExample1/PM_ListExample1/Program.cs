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
using TAD_Data_AED;

namespace PM_ListExample1
{
    class Program
    {

        static void mostrarDados(List<AEDData> lista, int posX, int posY)
        {
            Console.SetCursorPosition(posX, posY++);
            Console.WriteLine("Lista:");
            foreach (AEDData x in lista)
            {
                Console.SetCursorPosition(posX, posY++);
                Console.WriteLine(x.getData());
            }
        }

        static void mostrarDados(Dictionary<string, AEDData> hash, int posX, int posY)
        {
            Console.SetCursorPosition(posX, posY++);
            Console.WriteLine("Hash:");
            foreach (KeyValuePair<string, AEDData> x in hash)
            {
                Console.SetCursorPosition(posX, posY++);
                Console.WriteLine(x.Value.getData());
            }
        }

        static int menu()
        {
            Console.Clear();
            Console.WriteLine("Digite uma operação: ");
            Console.WriteLine("1 - Procurar na Hash ");
            Console.WriteLine("2 - Procurar na Lista ");
            Console.WriteLine("3 - Remover da Hash ");
            Console.WriteLine("4 - Remover da Lista ");
            Console.WriteLine("5 - Mostrar Hash ");
            Console.WriteLine("6 - Mostrar Lista ");
            Console.WriteLine("0 - Sair ");

            int op = int.Parse(Console.ReadLine());
            return op;
        }

        static void Main(string[] args)
        {
            List<AEDData> listaDatas = new List<AEDData>();
            Dictionary<string, AEDData> hashDatas = new Dictionary<string, AEDData>();

            Random random = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < 20; ++i)
            {
                int dia = random.Next(1, 32);
                int mes = random.Next(1, 13);
                int ano = random.Next(2000, 2015);

                AEDData aux = new AEDData(dia, mes, ano);
                hashDatas.Add(aux.getData(), aux);
                listaDatas.Add(aux);
            }

            foreach (AEDData x in listaDatas)
            {
                Console.WriteLine(x.getData());
            }
            Console.WriteLine("---------------");
            Console.ReadKey();

            int op = menu();

            while (op != 0)
            {
                string dataAux;

                switch (op)
                {
                    case 1:
                        Console.Write("Digite uma data: ");
                        dataAux = Console.ReadLine();
                        if (hashDatas.ContainsKey(dataAux))
                            Console.WriteLine("Data existe.");
                        else
                            Console.WriteLine("Data não existe.");
                        break;
                    case 2:
                        Console.Write("Digite uma data: ");
                        dataAux = Console.ReadLine();
                        AEDData achou = listaDatas.Find(x => x.getData().CompareTo(dataAux) == 0);

                        if (achou != null)
                            Console.WriteLine("Data existe.");
                        else
                            Console.WriteLine("Data não existe.");

                        break;
                    case 3:
                        Console.Write("Digite uma data: ");
                        dataAux = Console.ReadLine();
                        if (hashDatas.Remove(dataAux))
                            Console.WriteLine("Data removida.");
                        else
                            Console.WriteLine("Data não existe: não removida.");
                        break;
                    case 4:
                        Console.Write("Digite uma data: ");
                        dataAux = Console.ReadLine();
                        AEDData localizou = listaDatas.Find(x => x.getData().CompareTo(dataAux) == 0);
                        if (listaDatas.Remove(localizou))
                            Console.WriteLine("Data removida.");
                        else
                            Console.WriteLine("Data não existe: não removida.");
                        break;
                    case 5:
                        mostrarDados(hashDatas, 40, 1);
                        break;
                    case 6:
                        mostrarDados(listaDatas, 40, 1);
                        break;
                }
                Console.ReadKey();
                op = menu();
            }
        }
    }
}
