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

namespace POO_PolyFiguresCSharp
{
    public class Shape
    {
        protected int posX, posY;

        public void SetPos(int x, int y)
        {
            if (x >= 0) this.posX = x;
            if (y >= 0) this.posY = y;
        }

        public double Area() { return 0; }

        public virtual void Draw(System.Drawing.Graphics drawArea) {; }
    }
}
