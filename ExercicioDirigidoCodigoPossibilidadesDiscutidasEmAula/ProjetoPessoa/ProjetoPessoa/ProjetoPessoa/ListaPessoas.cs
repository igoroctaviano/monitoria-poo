//
// Monitoria *Monitoring - Pontifícia Universidade Católica de Minas Gerais
// Unidade: São Gabriel
// Disciplina: Programação Orientada a Objetos
// *Discipline: Object-Oriented Programming
// Igor Octaviano
// https://github.com/igoroctaviano
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoPessoa
{
    class ListaPessoas
    {
        private List<Pessoa> dados;

        public ListaPessoas()
        {
            this.dados = new List<Pessoa>();
        }

        public int AdicionarPessoa(Pessoa pessoa)
        {
            if (this.dados.Find(pes => pes.Nome.Equals(pessoa.Nome)) != null)
                return -1;
            else
            {
                dados.Add(pessoa);
                return dados.Count;
            }
        }

        public bool DeletarPessoa(string nome)
        {
            if (dados.RemoveAll(pes => pes.Nome.Equals(nome)) == 1)
                return true;
            else
                return false;
        }

        public int ContPessoas()
        {
            return dados.Count;
        }       
    }
}
