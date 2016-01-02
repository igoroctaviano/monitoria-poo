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

namespace CSharpQuest
{
    class Player : GameObject, IPrintable
    {
        public int points;

        // From IPrintable interface
        private int foreColor;
        private int backColor;
        private char myChar;

        public void SetForeColor(int color) { foreColor = color; }
        public void SetBackColor(int color) { backColor = color; }
        public void SetChar(char character) { myChar = character; }
        public char GetChar() { return myChar; }
        public int GetForeColor() { return foreColor; }
        public int GetBackColor() { return backColor; }

        public Player(int x, int y, char mc = '#', int fc = 3, int bc = 0) :
            base(x, y)
        {
            this.points = 0;
            this.myChar = mc;
            this.foreColor = fc;
            this.backColor = bc;
        }

        public void Print()
        {
            Console.SetCursorPosition(this.GetX(), this.GetY());
            Console.ForegroundColor = (ConsoleColor)(this.foreColor);
            Console.BackgroundColor = (ConsoleColor)(this.backColor);
            Console.Write(myChar);
        }

        public void Move(char direction)
        {
            bool moved = true;
            int oldX = GetX();
            int oldY = GetY();

            switch (direction)
            {
                case 'a':
                    SetX(GetX() - 1);
                    break;
                case 'd':
                    SetX(GetX() + 1);
                    break;
                case 'w':
                    SetY(GetY() - 1);
                    break;
                case 's':
                    SetY(GetY() + 1);
                    break;
                default:
                    moved = false;
                    break;
            }

            if (GetX() > 70)
            {
                moved = false;
                SetX(70);
            }
            else if (GetX() < 1)
            {
                moved = false;
                SetX(1);
            }

            if (GetY() > 20)
            {
                moved = false;
                SetY(20);
            }
            else if (GetY() < 1)
            {
                moved = false;
                SetY(1);
            }

            if (moved)
            {
                Console.SetCursorPosition(oldX, oldY);
                Console.ForegroundColor = (ConsoleColor.Black);
                Console.BackgroundColor = (ConsoleColor.Black);
                Console.Write(' ');
            }
        }

        public int EatItem(Item i)
        {
            this.points += i.GetValue();
            return i.GetValue();
        }
    }
}
