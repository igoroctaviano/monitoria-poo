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

namespace POO_DelegacaoContas
{
    class Poupanca: IAplicacao
    {
        public double Rendimento(double pct, double saldoAtual)
        {
            double rend = pct / 100 * saldoAtual;
            return rend;
        }

        public double Saque(double valor, double saldoAtual)
        {
            if (valor <= saldoAtual)
                return valor;
            else
                return saldoAtual;
        }

        public double Deposito(double valor)
        {
            if (valor > 0)
                return valor;
            else
                return 0;
        }

        public double CobrarTaxa(double pct, double saldoAtual)
        {
            return 0;
        }   
    }
}
