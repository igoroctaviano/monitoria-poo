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
    class Professor: Pessoa
    {
        private double _salario;

        public double Salario
        {
            get { return _salario; }
        }

        private void calcSalario(double valHoraAula)
        {
            double salBase = valHoraAula * this._cargaHoraria;
            double extraClasse = salBase * 0.2;

            this._salario = (salBase + extraClasse)*4.5;
        }

        private int _cargaHoraria;

        public int cargaHoraria
        {
            get { return _cargaHoraria; }
            set { if(value>11 && value<41) _cargaHoraria = value; }
        }

        private AEDData _dataAdmissao;

        public AEDData Admissao
        {
            get { return _dataAdmissao; }
            set { _dataAdmissao = value; }
        }

        public Professor(string nome, int mat, int diaN, int mesN, int anoN, int CH, int diaA, int mesA, int anoA, double horaA):        
            base(nome, mat, diaN, mesN, anoN)
        {
            this._cargaHoraria = CH;
            this._dataAdmissao = new AEDData(diaA, mesA, anoA);
            this.calcSalario(horaA);
        }

        public double calc13Salario()
        {
            AEDData fimDoAno = new AEDData(31, 12, 2014);
            double proporcao;
            int anos = this._dataAdmissao.DiffAnos(fimDoAno);

            if (anos == 0)
            {
                int dias = this._dataAdmissao.DiffDiasAno(fimDoAno);
                proporcao = dias / 365.0;
            }
            else
                proporcao = 1;

            return proporcao * this._salario;

        }
        
    }
}
