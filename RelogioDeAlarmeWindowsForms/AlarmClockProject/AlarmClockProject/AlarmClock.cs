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

namespace AlarmClockProject
{
    /* Crie uma classe Alarme. Este alarme pode:
       • Ser programado para hora e minuto determinados;
       • Ser programado para despertar em quaisquer combinações de dias da semana;
       • Ser desprogramado(cancelar a programação para despertar);
       • Ser adiado (função soneca) por cinco minutos a partir da hora em que despertar
       • Lembre- se de que deve haver um método para verificar se é hora de despertar, recebendo hora, minuto e dia da semana como parâmetro. */

    class AlarmClock
    {
        // Atributos privados
        private int hora, minuto;  
        private bool []dias;      // Vetor de dias da semana em que o alarme deve ser ativado
        private bool ativado;     // Indica se está ativado(programado) ou não

        /// <summary>
        /// Construtor.
        /// </summary>
        /// <param name="h">Hora para despertar.</param>
        /// <param name="m">Minuto para despertar.</param>
        /// <param name="d">Vetor de 7 booleanos, indicando os dias para despertar.</param>
        public AlarmClock(int h, int m, bool[] d)
        {
            if ((h < 0) || (h > 23)) h = 0;   // Hora ou minuto inválidos --> joga para o valor 0 
            if ((m < 0) || (m > 59)) m = 0;
            this.hora = h;
            this.minuto = m;
            this.ativado = true;              // Alarme programado
            this.dias = d;
        }

        /// <summary>
        /// Simplesmente desativa o alarme, sem mexer nos outros atributos.
        /// </summary>
        public void Desprogramar()
        {
            this.ativado = false;
        }

        /// <summary>
        /// Simplesmente ativa o alarme, sem mexer nos outros atributos.
        /// </summary>
        public void Ativar()
        {
            this.ativado = true;
        }

        /// <summary>
        /// Função soneca: adia o alarme em 5 minutos.
        /// </summary>
        /// <returns>Retorna falso caso o alarme não esteja ativado e true se estiver.</returns>
        public bool Soneca()
        {
            if ((ativado))      // Só adiciona minutos se o alarme está ativado
            {
                this.AdicionarMinutos(5);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Método privado para adicionar 5 minutos ao alarme e reajustar a hora, se for o caso.
        /// </summary>
        /// <param name="quantos">Quantos minutos devem ser adicionados.</param>
        private void AdicionarMinutos(int quantos)
        {
            this.minuto += quantos;     // Soma os minutos
            if (this.minuto > 59)       // Se passou de 59...
            {
                this.hora++;            // Passa uma hora
                this.minuto -= 60;      // Descontam-se 60 minutos da hora
                
                if (this.hora == 24)    // Se a hora passou de 23..
                    this.hora = 0;      // Zera a hora (passou um dia)
            }
        }

        /// <summary>
        /// Método que verifica se é hora de disparar. Deve ser chamado a cada segundo por um programa que usa a classe.        /// </summary>
        /// <param name="h">Hora atual.</param>
        /// <param name="m">Minuto atual.</param>
        /// <param name="d">Dia da semana atual.</param>
        /// <returns>Retorna verdadeiro se tem que disparar e falso em contrário.</returns>
        public bool Disparar(int h, int m, int d)
        {
            if (this.ativado)   // Só dispara se estiver ativado
            {
                if (dias[d])    // Se o vetor de dias está verdadeiro para aquele dia...
                {
                    if ((this.hora == h) && (this.minuto == m)) // Se a hora e o minuto estão coincidindo, 
                        return true;                            // Dispara
                }
            }
            return false;       // Caso contrário, não dispara
        }

        // Getters para Hora e Minuto, se necessário
        public string GetHora() { return this.hora.ToString("d2"); }
        public string GetMinuto() { return this.minuto.ToString("d2"); }  
    }
}
