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

namespace TAD_Data_AED
{
    public class AEDData
    {
        // Constante privada: dias de cada mês
        private int[] diasDoMes = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        // Atributos privados
        private int dia, mes, ano;

        /// <summary>
        /// Construtor, verifica a validade da data. Em caso de não-validade, a data vai para 01/01/1977.
        /// </summary>
        /// <param name="d">dia</param>
        /// <param name="m">mês</param>
        /// <param name="a">ano</param>
        public AEDData(int d, int m, int a)
        {
            this.dia = d;
            this.mes = m;
            this.ano = a;
            if (!this.dataValida())     // Se a data não é válida... (método da própria classe)
            {
                this.dia = 1;           // Data --> 01/01/1977
                this.mes = 1;
                this.ano = 1977;
            }
        }

        /// <summary>
        /// Método que retorna se o ano é bissexto ou não.
        /// </summary>
        /// <returns>Booleano, se o ano é bissexto (true) ou não (false).</returns>
        private Boolean bissexto()
        {
            if ((this.ano % 400) == 0) return true;        // Ano divisível por 400 --> bissexto
            else if ((this.ano % 100) == 0) return false;  // Ano não divisível por 400 e divisível por 100 --> não bissexto
            else if ((this.ano % 4) == 0) return true;     // Ano não divisível por 100 e divisível por 4 --> bissexto
            else return false;                             // Demais --> não bissexto
        }

        /// <summary>
        /// Devolve a diferença, em anos completos, entre esta e outra data. Supõe que a data2 seja mais recente.
        /// </summary>
        /// <param name="data2">A data usada como base para calcular a diferença.</param>
        /// <returns></returns>
        public int DiffAnos(AEDData data2)
        {
            if (this.ano == data2.ano) return 0;

            int anos = Math.Abs(data2.ano - this.ano);      // Calcula a diferença absoluta (sem sinal) entre os anos

            if (this.mes < data2.mes)
            {      // Corrige a diferença: se o mês da data ainda não foi alcançado neste anos...
                return (anos - 1);           // Diminui um ano e retorna
            }
            if ((this.mes == data2.mes) && (this.dia > data2.dia))
            {      // Corrige a diferença: se o mês foi alcançado, mas o dia não...
                return (anos - 1);           // Diminui um ano e retorna
            }
            return anos;        // Retorna a diferença original
        }

        /// <summary>
        /// Devolve a diferença, em dias, de duas datas DO MESMO ANO. Supõe que a data2 seja mais recente.
        /// </summary>
        /// <param name="data2">A data usada como base para a diferença. Será considerada sempre como data do mesmo ano.</param>
        /// <returns></returns>
        public int DiffDiasAno(AEDData data2)
        {
            int cont = 0;
            AEDData aux = (AEDData)(this.MemberwiseClone());  // Clona a data, para não modificar o valor do objeto

            while (aux.mes != data2.mes)        // Cálculo "braçal": avança de um em um dia até chegar ao mês da 2a data.
            {
                aux.acrescentaDias(1);
                cont++;
            }
            cont += data2.dia;                  // Dentro do mês, soma os dias da 2a data.
            return cont;
        }

        /// <summary>
        /// Verifica se uma data é válida.
        /// </summary>
        /// <returns>True se é válida // False se não é válida.</returns>
        public Boolean dataValida()
        {
            Boolean resposta = true;                                        // Resposta sobre a validade

            if (this.mes < 1 || this.mes > 12)                              // mês<1 ou mês>12 --> data inválida
                resposta = false;
            else
                    if (this.bissexto() && this.mes == 2 && this.dia == 29) // Senão, caso de 29/02 em ano bissexto --> data válida
                resposta = true;
            else
                        if (this.dia > diasDoMes[this.mes])                 // Senao, verifica validade de acordo com o mês atual
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
        /// Acrescenta dias à data.
        /// </summary>
        /// <param name="quant">Quantidade de dias a acrescentar.</param>
        public void acrescentaDias(int quant)
        {
            this.dia += quant;             // Acrescenta a quantidade ao dia atual e,
                                           // em seguida, devemos ajustar mês e ano
                                           // Enquanto os dias ultrapassam o limite de dias do mês atual... ajustar
            while (this.dia > diasDoMes[this.mes])
            {

                if (this.mes == 2)          // Tratamento de fevereiro: 
                {
                    if (this.bissexto())    // Se é ano bissexto...
                    {
                        if (this.dia > 29)  // Caso passou de 29
                        {
                            this.dia = this.dia - 29;   // Descontam-se 29 dias
                        }
                    }
                    else                                // Não sendo bissexto...
                    {
                        if (this.dia > 28)              // Se passou de 28
                        {
                            this.dia = this.dia - 28;   // Descontam-se 28 dias
                        }
                    }
                }
                else                             // Para os outros meses: descontam-se o máximo de dias do mês
                {
                    this.dia = this.dia - diasDoMes[this.mes];
                }

                this.mes++;                      // Avança o mês

                if (this.mes > 12)               // Se passar de 12 meses...
                {
                    this.mes = this.mes - 12;    // Desconta-se 1 ano
                    this.ano++;                  // Avança o ano.
                }
            }
        }
    }
}
