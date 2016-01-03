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

namespace POO_PolyFiguresCSharp
{
    public class Square : Rectangle
    {
        public Square(int s) :
            base(s, s)
        {
        }

        public double Area() { return (sides[0] * sides[0]); }

        public override void Draw(System.Drawing.Graphics drawArea)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Green);
            drawArea.FillRectangle(myBrush, posX, posY, sides[0], sides[0]);
            myBrush.Dispose();

            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.LightGreen);
            myPen.Width = 5;
            drawArea.DrawRectangle(myPen, posX, posY, sides[0], sides[0]);
            myPen.Dispose();
        }
    }
}
