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
    class PessoaJuridica: Pessoa
    {
        private String CNPJ;

        public PessoaJuridica(string nome, string ender, string email, AEDData data, string cnpj)
            : base(nome, ender, email, data)
        {
            this.CNPJ = cnpj;
        }

        public override String Ficha()
        {
            String aux;
            aux = "";
            aux += "\nNome: " + this.Nome;
            aux += "\nEndereço: " + this.Endereco;
            aux += "\nEmail: " + this.Email;
            aux += "\nCriação: " + this.DataPessoa.GetData(); ;
            aux += "\nCNPJ: " + this.CNPJ;
            return aux;
        }
    }
}
