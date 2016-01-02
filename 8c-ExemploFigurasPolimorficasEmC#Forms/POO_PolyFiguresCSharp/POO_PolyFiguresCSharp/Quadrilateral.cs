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
    public class Quadrilateral : Shape
    {
        public int[] sides;

        public double Area() { return 0; }

        public Quadrilateral(int a, int b, int c, int d)
        {
            sides = new int[4];
            sides[0] = a; sides[1] = b; sides[2] = c; sides[3] = d;
        }
    }
}
