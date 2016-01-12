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

namespace POO_Aluno_Encapsulamento
{
    /// <summary>
    /// Um aluno é avaliado, em um curso, por meio de 4 avaliações
    /// valendo 25 pontos cada uma.A nota final do aluno é a soma
    /// das avaliações e ele é considerado aprovado se sua nota
    /// final é maior ou igual a 60.
    /// </summary>
    class Aluno
    {
        // Constante: quantidade de notas
        private const int QUANTNOTAS = 4;

        // Atributo privado: vetor de notas
        private double[] notas;

        /// <summary>
        /// Construtor: cria o vetor com a quantidade de notas indicada pela constante.
        /// </summary>
        public Aluno()
        {
            this.notas = new double[QUANTNOTAS];
        }

        /// <summary>
        /// Método para atribuir uma nota. Verifica o valor da nota e a validade em relação à quantidade de notas.
        /// </summary>
        /// <param name="valor">Valor a ser atribuído.</param>
        /// <param name="qualNota">Qual nota deve ser atribuída.</param>
        public void setNota(double valor, int qualNota)
        {
            if (qualNota < QUANTNOTAS)                  // Se a posição da nota é válida...
                if (valor <= (100.0d / QUANTNOTAS))     // Se o valor é válido... (considera avaliações do mesmo valor totalizando 100)
                    this.notas[qualNota] = valor;       // Atribui a nota
        }                                               // Caso contrário, ignora o valor

        /// <summary>
        /// Método para retornar uma nota.
        /// </summary>
        /// <param name="qualNota">A posição da nota a ser retornada.</param>
        /// <returns>
        /// O valor da nota, se ele existir,
        /// Retorna -1 em caso de posição inválida.
        /// </returns>
        public double GetNota(int qualNota)
        {
            if (qualNota < QUANTNOTAS)      // Verifica validade da posição
                return this.notas[qualNota];
            else
                return -1;
        }

        /// <summary>
        /// Soma notas e verifica aprovação do aluno (notaFinal maior ou igual a 60).
        /// </summary>
        /// <returns>
        /// True, se aprovado
        /// False, se reprovado.
        /// </returns>
        public bool Aprovado()
        {
            double notaFinal = 0.0;
            for (int i = 0; i < QUANTNOTAS; ++i)   // Laço para somar notas
            {
                notaFinal += this.notas[i];
            }
            if (notaFinal >= 60)                   // Verifica aprovação
                return true;
            else
                return false;
        }
    }
}
