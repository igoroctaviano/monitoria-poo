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
    class Contato
    {
        private string nomePessoa;
        private List<string> telefones;

        public Contato(string nome, string tel)
            :this(nome)
        {
            telefones.Add(tel);
        }

        public Contato(string nome)
        {
            this.nomePessoa = nome;
            telefones = new List<string>();
        }

        public string imprimeContatosPessoa(List<Pessoa> lista)
        {
            StringBuilder dadosPessoa = new StringBuilder();
            Pessoa aux = lista.Find(p => p.Nome.Equals(this.nomePessoa));

            if (aux != null)
            {
                dadosPessoa.Append(aux.Ficha());
                foreach (string tel in telefones)
                {
                    dadosPessoa.AppendLine("Telefone: " + tel);
                }
            }

            return dadosPessoa.ToString();
        }

        public bool addContato(string tel)
        {
            if (telefones.Find(t => t.Equals(tel)) != null)
                return false;
            else
            {
                telefones.Add(tel);
                return true;
            }
        }
    }
}




