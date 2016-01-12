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
    class Conta
    {
        static int ultimaConta = 0;

        private int numConta;
        private string titular;
        private double saldo;
        private IAplicacao tipoConta;

        public Conta(string titular, IAplicacao tipo)
        {
            ultimaConta++;
            this.numConta = ultimaConta;
            this.titular = titular;
            this.tipoConta = tipo;
            this.saldo = 0;
        }

        public void SetTipo(IAplicacao tipo)
        {
            this.tipoConta = tipo;
        }

        public void Deposito(double valor)
        {
            this.saldo += tipoConta.Deposito(valor);
        }

        public void Rendimento(double pct)
        {
            this.saldo += tipoConta.Rendimento(pct, saldo);
        }

        public void Saque(double valor)
        {
            this.saldo -= tipoConta.Saque(valor, saldo);
        }

        public void CobrancaTaxa(double pct)
        {
            this.saldo -= tipoConta.CobrarTaxa(pct, saldo);
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        public override string ToString()
        {
            StringBuilder stringConta = new StringBuilder("Titular: ");
            stringConta.AppendLine(this.titular);
            stringConta.Append("Conta: ");
            stringConta.AppendLine(this.numConta.ToString());
            stringConta.Append("Saldo: ");
            stringConta.AppendLine(String.Format("{0:c}", this.saldo));

            return stringConta.ToString();
        }
    }
}
