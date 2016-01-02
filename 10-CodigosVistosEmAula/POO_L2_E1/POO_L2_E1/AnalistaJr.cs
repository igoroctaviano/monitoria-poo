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

namespace POO_L2_E1
{
    class AnalistaJr : Analista
    {
        private static double salarioBase;

        static AnalistaJr()
        {
            salarioBase = AnalistaJr.salarioBase * 1.2;
        }

        public AnalistaJr(string nome, string cpf) :
         base(nome, cpf)
        {
        }

        public static double SalarioBase
        {
            get { return salarioBase; }

            set
            {
                if (value >= 0) salarioBase = value;
                else salarioBase = 0.0;
            }
        }

        public override double CalcularSalario()
        {
            double salario = salarioBase;
            double horaExtra = CalcularValorHoraExtra();

            return (salario + horaExtra * QuantidadeHorasExtras);

        }

        protected override double CalcularValorHoraExtra()
        {
            double val = salarioBase;
            val = val / (40 * 4.5); // Horas semanais * semanas
            val = val * 1.5;
            return val;
        }
    }
}
