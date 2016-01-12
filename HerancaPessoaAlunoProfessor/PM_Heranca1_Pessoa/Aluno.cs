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

namespace PM_Heranca1_Pessoa
{
    class Aluno:Pessoa
    {
        private int _idCurso;

        public int Curso
        {
            get { return _idCurso; }
            set { _idCurso = value; }
        }

        private int _cargaHoraria;

        public int CargaHorariaMatriculada
        {
            get { return _cargaHoraria; }
            set { if (value >= 34)_cargaHoraria = value; else _cargaHoraria = 0; }
        }

        public Aluno(string nome, int mat, int dia, int mes, int ano, int curso, int CH) :
            base(nome, mat, dia, mes, ano)
        {
            this._idCurso = curso;
            this.CargaHorariaMatriculada = CH;
        }

        public double CalcularMensalidade(double horaAula)
        {
            double valTotal = this._cargaHoraria * horaAula;
            double mensalidade = valTotal / 6;
            return mensalidade;
        }
        
    }
}
