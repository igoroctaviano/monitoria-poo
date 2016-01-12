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

namespace POO_L2_E1
{
    class AnalistaSr : Analista
    {
        private static double salarioBase;

        static AnalistaSr()
        {
            SalarioBase = AnalistaJr.SalarioBase * 1.2;
        }

        public AnalistaSr(string nome, string cpf) :
         base(nome, cpf)
        {
        }

        public static double SalarioBase
        {
            get { return salarioBase; }

            set
            {
                salarioBase = AnalistaJr.SalarioBase * 1.2;
            }
        }

        public override double CalcularSalario()
        {
            double salario = SalarioBase;
            double horaExtra = CalcularValorHoraExtra();

            return (salario + horaExtra * QuantidadeHorasExtras);
        }

        protected override double CalcularValorHoraExtra()
        {
            double val = SalarioBase;
            val = val / (40 * 4.5); //horas semanais * semanas
            val = val * 1.5;
            return val;
        }
    }
}
