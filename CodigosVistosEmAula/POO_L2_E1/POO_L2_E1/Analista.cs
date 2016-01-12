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
    public abstract class Analista : Funcionario
    {
        protected int horasExtras;

        public Analista(string nome, string cpf)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.QuantidadeHorasExtras = 0;
        }

        protected int QuantidadeHorasExtras
        {
            get { return horasExtras; }
            set
            {
                if (value >= 0)
                    this.horasExtras = value;
                else
                    this.horasExtras = 0;
            }
        }

        protected abstract double CalcularValorHoraExtra();

        public abstract override double CalcularSalario();
    }
}
