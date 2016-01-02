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
using TAD_Data_AED;

namespace PM_Heranca1_Pessoa
{
    class Pessoa
    {
        private string _nome;

        public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private int _matricula;

        public int matricula
        {
            get { return _matricula; }
            set { _matricula = value; }
        }

        private AEDData _dataNasc;

        public AEDData dataNasc
        {
            get { return _dataNasc; }
            set { _dataNasc = value; }
        }

        public Pessoa(string nome, int mat, int dia, int mes, int ano)
        {
            this._nome = nome;
            this._matricula = mat;
            this._dataNasc = new AEDData(dia, mes, ano);
        }

        public int CalcularIdade(AEDData hoje)
        {
            int diff = _dataNasc.DiffAnos(hoje);
            
            return diff;
        }
    }
}
