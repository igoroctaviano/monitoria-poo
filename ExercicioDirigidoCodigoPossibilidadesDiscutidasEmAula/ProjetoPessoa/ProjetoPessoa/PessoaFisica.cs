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

namespace ProjetoPessoa
{
    class PessoaFisica : Pessoa
    {
        private char Sexo;
        private string CPF;

        public PessoaFisica(string nome, string ender, string email, AEDData data, string cpf)
            : base(nome, ender, email, data)
        {
            this.CPF = cpf;
        }

        public String Ficha()
        {
            String aux;
            aux = "";
            aux += "\nNome: " + this.Nome;
            aux += "\nSexo: " + this.Sexo;
            aux += "\nEndereço: " + this.Endereco;
            aux += "\nEmail: " + this.Email;
            aux += "\nAniversário: " + this.DataPessoa.GetData(); ;
            aux += "\nCPF: " + this.CPF;
            return aux;
        }
    }
}

