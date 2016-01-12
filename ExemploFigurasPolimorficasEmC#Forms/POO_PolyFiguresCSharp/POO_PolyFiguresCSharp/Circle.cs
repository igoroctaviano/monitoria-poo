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
    class Circle : Shape
    {
        public int radius;

        public Circle(int r) { radius = r; }

        public double Area() { return radius * radius * Math.PI; }

        public override void Draw(System.Drawing.Graphics drawArea)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Yellow);
            drawArea.FillEllipse(myBrush, posX, posY, radius * 2, radius * 2);
            myBrush.Dispose();

            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.DarkOrange);
            myPen.Width = 5;
            drawArea.DrawEllipse(myPen, posX, posY, radius * 2, radius * 2);
            myPen.Dispose();
        }
    }
}
