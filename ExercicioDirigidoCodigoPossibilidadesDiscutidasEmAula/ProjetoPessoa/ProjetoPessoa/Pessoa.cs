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
    class Pessoa
    {
        protected string nome;
        protected string endereco;
        protected string email;
        protected AEDData DataPessoa;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Pessoa(string n, string e, string em, AEDData data)
        {
            this.Nome = n;
            this.Endereco = e;
            this.Email = em;
            this.DataPessoa = data;
        }

        public virtual String Ficha()
        {
            String aux="";
            aux += "\nNome: " + this.Nome;
            aux += "\nEndereço: " + this.Endereco;
            aux += "\nEmail: " + this.Email;
            aux += "\nData Associada: " + this.DataPessoa.GetData(); ;
            return aux;
        }
    }
}
