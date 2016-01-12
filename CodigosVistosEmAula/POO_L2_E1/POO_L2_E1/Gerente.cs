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
    class Gerente : Funcionario
    {
        static Gerente()
        {
            salarioBase = AnalistaSr.SalarioBase * 1.2;
        }

        public Gerente(string nome, string cpf)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.QuantosProjetos = 0;
        }

        private static double salarioBase;

        public static double SalarioBase
        {
            get { return salarioBase; }
            set { salarioBase = AnalistaSr.SalarioBase * 1.2; }
        }

        private int quantosProjetos;

        public int QuantosProjetos
        {
            get { return this.quantosProjetos; }
            set
            {
                if (value >= 0) this.quantosProjetos = value;
                else this.quantosProjetos = 0;
            }
        }

        public override double CalcularSalario()
        {
            double salario = SalarioBase;
            double adicional = QuantosProjetos * 500;

            return (salario + adicional);
        }
    }
}
