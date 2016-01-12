//
// Pontif�cia Universidade Cat�lica de Minas Gerais
// Unidade S�o Gabriel
// Disciplina: Programa��o Orientada a Objetos
// *Object-Oriented Programming
// 
// Igor Octaviano
// More? access: https://github.com/igoroctaviano/
// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TAD_Data_AED
{
    public class AEDData
    {
        // Constante privada: dias de cada m�s
        private int[] diasDoMes = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        // Atributos privados
        private int dia, mes, ano;

        /// <summary>
        /// Construtor, verifica a validade da data. Em caso de n�o-validade, a data vai para 01/01/1977.
        /// </summary>
        /// <param name="d">dia</param>
        /// <param name="m">m�s</param>
        /// <param name="a">ano</param>
        public AEDData(int d, int m, int a)
        {
            this.dia = d;
            this.mes = m;
            this.ano = a;
            if (!this.dataValida())     // Se a data n�o � v�lida... (m�todo da pr�pria classe)
            {
                this.dia = 1;           // Data --> 01/01/1977
                this.mes = 1;
                this.ano = 1977;
            }
        }

        /// <summary>
        /// M�todo que retorna se o ano � bissexto ou n�o.
        /// </summary>
        /// <returns>Booleano, se o ano � bissexto (true) ou n�o (false).</returns>
        private Boolean bissexto()
        {
            if ((this.ano % 400) == 0) return true;        // Ano divis�vel por 400 --> bissexto
            else if ((this.ano % 100) == 0) return false;  // Ano n�o divis�vel por 400 e divis�vel por 100 --> n�o bissexto
            else if ((this.ano % 4) == 0) return true;     // Ano n�o divis�vel por 100 e divis�vel por 4 --> bissexto
            else return false;                             // Demais --> n�o bissexto
        }

        /// <summary>
        /// Verifica se uma data � v�lida.
        /// </summary>
        /// <returns>True se � v�lida // False se n�o � v�lida.</returns>
        public Boolean dataValida()
        {
            Boolean resposta = true;          // Resposta sobre a validade

            if (this.mes < 1 || this.mes > 12)                              // m�s<1 ou m�s>12 --> data inv�lida
                resposta = false;
            else
                    if (this.bissexto() && this.mes == 2 && this.dia == 29) // Sen�o, caso de 29/02 em ano bissexto --> data v�lida
                resposta = true;
            else
                        if (this.dia > diasDoMes[this.mes])                 // Senao, verifica validade de acordo com o m�s atual
                resposta = false;

            return resposta;    // Retorna a resposta obtida
        }

        /// <summary>
        /// Retorna a data formatada.
        /// </summary>
        /// <returns>String com a data no formato dd/mm/aaaa.</returns>
        public String getData()
        {

            return (String.Format("{0:d2}", this.dia) + "/" + String.Format("{0:d2}", this.mes) + "/" + this.ano);
        }

        /// <summary>
        /// Acrescenta dias � data.
        /// </summary>
        /// <param name="quant">Quantidade de dias a acrescentar.</param>
        public void acrescentaDias(int quant)
        {
            this.dia += quant;             // Acrescenta a quantidade ao dia atual e,
                                           //em seguida, devemos ajustar m�s e ano
            // Enquanto os dias ultrapassam o limite de dias do m�s atual... ajustar
            while (this.dia > diasDoMes[this.mes])
            {    

                if (this.mes == 2)          // Tratamento de fevereiro: 
                {
                    if (this.bissexto())    // Se � ano bissexto...
                    {
                        if (this.dia > 29)  // Caso passou de 29
                        {
                            this.dia = this.dia - 29;   // Descontam-se 29 dias
                        }
                    }
                    else                                // N�o sendo bissexto...
                    {
                        if (this.dia > 28)              // Se passou de 28
                        {
                            this.dia = this.dia - 28;   // Descontam-se 28 dias
                        }
                    }
                }
                else                             // Para os outros meses: descontam-se o m�ximo de dias do m�s
                {
                    this.dia = this.dia - diasDoMes[this.mes];
                }

                this.mes++;                      // Avan�a o m�s

                if (this.mes > 12)               // Se passar de 12 meses...
                {
                    this.mes = this.mes - 12;    // Desconta-se 1 ano
                    this.ano++;                  // Avan�a o ano.
                }
            }
        }
    }
}
