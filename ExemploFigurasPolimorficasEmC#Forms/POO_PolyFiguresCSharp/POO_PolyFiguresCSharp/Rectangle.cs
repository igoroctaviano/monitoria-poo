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
    public class Rectangle : Quadrilateral
    {
        public Rectangle(int b, int h) :
            base(b, b, h, h)
        {
        }

        public double Area() { return sides[0] * sides[3]; }

        public override void Draw(System.Drawing.Graphics drawArea)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            drawArea.FillRectangle(myBrush, posX, posY, sides[0], sides[3]);

            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.DarkRed);
            myPen.Width = 5;
            drawArea.DrawRectangle(myPen, posX, posY, sides[0], sides[3]);

            myPen.Dispose();
            myBrush.Dispose();
        }
    }
}
