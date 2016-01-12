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
    interface IPrintable
    {
        void SetForeColor(int color);
        void SetBackColor(int color);
        void SetChar(char ch);
        char GetChar();
        int GetForeColor();
        int GetBackColor();
        void Print();
    }
}
