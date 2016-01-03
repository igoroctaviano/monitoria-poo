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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POO_PolyFiguresCSharp
{
    public partial class MenuPolyFigures : Form
    {
        GenericShapeList myFigures;
        public MenuPolyFigures()
        {
            InitializeComponent();
            myFigures = new GenericShapeList();
        }

        private Shape createRandomFig(Random guess)
        {
            int x = guess.Next(25,75);
            int y = guess.Next(25,75);
            int posX = guess.Next(0, this.Width-this.panel1.Width-75);
            int posy = guess.Next(0, this.Height-75);
            Shape aux = null;
            
            int type = guess.Next(0,3);

            switch (type)
            {
                case 0: aux = new Rectangle(x, y);
                    break;
                case 1: aux = new Square(x);                    
                    break;
                case 2: aux = new Circle(y);
                    break;
                default: aux = new Square(10);
                    break;
            }
            aux.SetPos(posX, posy);
            return aux;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            myFigures.DrawAll(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics canvas = this.CreateGraphics();
            canvas.Clear(this.BackColor);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numFig = myFigures.MaxFigures;
            Random draw = new Random(DateTime.Now.Millisecond);
            myFigures.ClearAll();

            for (int i=0; i<numFig; i++){
                Shape newShape = createRandomFig(draw);
                myFigures.Add(newShape);
            }

            myFigures.DrawAll(this);

	    }

        private void MenuPolyFigures_Load(object sender, EventArgs e) { }
    }
}
