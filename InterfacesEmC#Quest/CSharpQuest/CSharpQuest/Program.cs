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

namespace CSharpQuest
{
    class Program
    {
        const int NUM_ITEMS = 10;
        static Random random = new Random(DateTime.Now.Millisecond);
        static int itemsToCollect = 0;
        static int totalMovements = 0;
        static bool notFinished = true;

        static void InitItems(List<Item> myItems)
        {
            for (int i = 0; i < (NUM_ITEMS); i++)
            {
                int type = random.Next(2);
                int x = random.Next(71);
                int y = random.Next(20);

                Item auxItem;
                if (type % 2 == 0)
                {
                    auxItem = new Item(x, y, 10, '*', (int)ConsoleColor.Green, (int)ConsoleColor.Black);
                    itemsToCollect++;
                }
                else {
                    auxItem = new Item(x, y, -10, '*', (int)ConsoleColor.Yellow, (int)ConsoleColor.Black);
                }
                myItems.Add(auxItem);
            }
        }

        static bool GetInput(Player player, List<Item> myItems)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo movement;
                movement = Console.ReadKey(true);

                if (movement.KeyChar == 'x') Environment.Exit(0);
                if (movement.KeyChar == 'z') notFinished = false;

                player.Move(movement.KeyChar);
                totalMovements++;

                for (int i = 0; i < myItems.Count; i++)
                {
                    if (player.Equals((myItems[i])))
                    {
                        if (player.EatItem(myItems[i]) > 0)
                            itemsToCollect--;

                        myItems[i].SetChar('\0');
                        myItems[i].SetValue(0);

                        if (itemsToCollect == 0) notFinished = false;
                    }
                }

                return true;
            }

            return false;
        }

        static void RenderScene(Player player, List<Item> myItems)
        {
            Console.Clear();
            for (int i = 0; i < myItems.Count(); i++)
            {
                myItems[i].Print();
            }
            player.Print();
        }

        static void PrintInitGUI()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;

            Console.Clear();
            Console.SetCursorPosition(16, 10);
            Console.WriteLine("Welcome to the C# Lone Ranger Quest!!!");
            Console.SetCursorPosition(0, 14);
            Console.WriteLine("INSTRUCTIONS:");
            Console.WriteLine("Collect all the green dots. Run away from the yellow dots.");
            Console.WriteLine("Use as few movements as you can.");
            Console.WriteLine("Press A W S or D to move. ");
            Console.WriteLine("Good luck. ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        static void PrintFinalGUI(Player player)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;

            Console.Clear();
            Console.SetCursorPosition(20, 10);
            Console.WriteLine("Congratulations!! You've finished the quest!");
            Console.WriteLine("Total points: {0:00}", player.points);
            Console.WriteLine("Total movements: {0:00}", totalMovements);
        }

        static void PrintGUI(Player player, List<Item> myItems)
        {
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("Pontos: {0:00}", player.points);
        }

        static void MadBlocks(List<Item> myItems)
        {
            foreach (Item i in myItems)
            {
                int dir = random.Next(-1, 2);
                int dir2 = random.Next(-1, 2);

                switch (dir)
                {
                    case -1:
                        i.SetX(i.GetX() - 1);
                        break;
                    case 1:
                        i.SetX(i.GetX() + 1);
                        break;
                }
                switch (dir2)
                {
                    case -1:
                        i.SetY(i.GetY() - 1);
                        break;
                    case 1:
                        i.SetY(i.GetY() + 1);
                        break;
                }
            }
        }

        static int Main()
        {
            Player LoneRanger = new Player(40, 10);
            List<Item> objects = new List<Item>();

            InitItems(objects);

            PrintInitGUI();
            Console.ReadKey();

            Console.Clear();
            while (notFinished)
            {
                if (GetInput(LoneRanger, objects))
                {
                    MadBlocks(objects);
                    RenderScene(LoneRanger, objects);
                }

                PrintGUI(LoneRanger, objects);
                System.Threading.Thread.Sleep(100);
            }

            PrintFinalGUI(LoneRanger);
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();

            return 0;
        }
    }
}
