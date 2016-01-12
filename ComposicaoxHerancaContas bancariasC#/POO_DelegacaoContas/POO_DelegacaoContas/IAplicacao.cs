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
    interface IAplicacao
    {
        double Rendimento(double pct, double saldoAtual);
        double Saque(double valor, double saldoAtual);
        double Deposito(double valor);
        double CobrarTaxa(double pct, double saldoAtual);
    }
}
