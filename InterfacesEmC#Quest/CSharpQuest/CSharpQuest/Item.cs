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
    class Item : GameObject, IPrintable
    {
        private int value;

        // From IPrintable interface
        private int foreColor;
        private int backColor;
        private char myChar;

        public void SetForeColor(int color) { this.foreColor = color; }
        public void SetBackColor(int color) { this.backColor = color; }
        public void SetChar(char character) { this.myChar = character; }
        public char GetChar() { return this.myChar; }
        public int GetForeColor() { return this.foreColor; }
        public int GetBackColor() { return this.backColor; }

        public void Print()
        {
            Console.SetCursorPosition(this.GetX(), this.GetY());
            Console.ForegroundColor = (ConsoleColor)(this.foreColor);
            Console.BackgroundColor = (ConsoleColor)(this.backColor);
            Console.Write(myChar);
        }

        public Item(int x, int y, int value,
            char myChar = '#', int foreColor = 14, int backColor = 0) :
            base(x, y)
        {
            this.value = value;
            this.myChar = myChar;
            this.foreColor = foreColor;
            this.backColor = backColor;
        }

        public int GetValue()
        {
            return this.value;
        }

        public void SetValue(int value)
        {
            this.value = value;
        }
    }
}
