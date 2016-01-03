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
    class GameObject : IEquatable<GameObject>
    {
        private int posX;
        private int posY;

        public GameObject(int x, int y)
        { this.posX = x; this.posY = y; }

        public bool Equals(GameObject other)
        {
            if ((this.posX == other.posX) &&
                (this.posY == other.posY))
                return true;
            else return false;
        }

        public void SetX(int pos) { if ((pos > 0) && (pos < 70)) posX = pos; }
        public void SetY(int pos) { if ((pos > 0) && (pos < 20)) posY = pos; }
        public int GetX() { return posX; }
        public int GetY() { return posY; }
    }
}
