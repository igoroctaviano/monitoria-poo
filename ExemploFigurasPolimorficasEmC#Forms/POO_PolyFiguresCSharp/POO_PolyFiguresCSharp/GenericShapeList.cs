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
    class GenericShapeList
    {
        private Shape[] figures;
        private int figCounter;
        private int maxFigures;

        public int MaxFigures
        {
            get { return this.maxFigures; }
            set { if (value > 0) this.maxFigures = value; }
        }

        public int FiguresCounter
        {
            get { return this.figCounter; }
        }

        public GenericShapeList()
        {
            this.Init(10);
        }

        public GenericShapeList(int n)
        {
            this.Init(n);
        }

        private void Init(int maxFigures)
        {
            this.figCounter = 0;
            this.maxFigures = maxFigures;
            this.figures = new Shape[maxFigures];
        }


        public bool Add(Shape element)
        {
            if (this.figCounter < this.maxFigures)
            {
                this.figures[figCounter] = element;
                this.figCounter++;
                return true;
            }
            else
                return false;
        }

        public bool ClearAll()
        {
            for (int i = 0; i < this.maxFigures; i++)
                this.figures[i] = null;

            this.figCounter = 0;

            return true;
        }

        public double TotalArea()
        {
            double areaAux = 0;
            foreach (Shape element in this.figures)
            {
                areaAux += element.Area();
            }

            return areaAux;
        }

        public Shape Largest()
        {
            Shape max = figures[0];

            foreach (Shape element in figures)
            {
                if (element.Area() > max.Area())
                    max = element;
            }

            return max;
        }

        public void DrawAll(System.Windows.Forms.Form form)
        {
            System.Drawing.Graphics canvas = form.CreateGraphics();
            canvas.Clear(form.BackColor);

            foreach (Shape element in figures)
            {
                element.Draw(canvas);
                System.Threading.Thread.Sleep(500);
            }

            canvas.Dispose();
        }
    }
}
