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

namespace POO_Relogio
{
    class Relogio
    {
        // Constantes (privadas)
        private int[] diasMes = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        // Atributos (privados)
        private int hora;
        private int min;
        private int seg;
        private int dia;
        private int mes;
        private int ano;

        // Métodos
        public void AjustarHora(int hora, int min, int seg)  // Sem verificação de validade
        {
            this.hora = hora;
            this.min = min;
            this.seg = seg;
        }

        public void AjustarData(int d, int m, int a)        // Sem verificação de validade
        {
            dia = d;
            mes = m;
            ano = a;
        }

        public void Reiniciar()
        {
            hora = min = seg = 0;
            dia = mes = 1;
            ano = 2000;
        }

        public string MostrarHora()
        {
            string horaFormatada = hora.ToString("00") + ":"
                                   + min.ToString("00") + ":"
                                   + seg.ToString("00");
            return horaFormatada;
        }

        public string MostrarHoraCompleta()
        {
            string horaCompleta = MostrarHora();
            horaCompleta += " - " + dia.ToString("00") + "/" + mes.ToString("00") + "/" + ano.ToString("0000");
            return horaCompleta;
        }

        /// <summary>
        /// Método para simular a passagem de um segundo.
        /// O acúmulo de segundos pode acarretar, consecutivamente, a passagem de minutos, horas, dias, meses e anos.
        /// </summary>
        public void PassarTempo()
        {
            seg++;              // Passa um segundo
            if (seg == 60)      // Se completou um minuto...
            {
                min++;          // Passa um minuto e zera os segundos
                seg = 0;
                if (min == 60)  // Se completou uma hora...
                {
                    hora++;     // Passa uma hora e zera os minutos
                    min = 0;
                    if (hora == 24)     // Se completou um dia...
                    {
                        dia++;          // Passa um dia e zera as horas
                        hora = 0;
                        if (dia > diasMes[mes]) // Se o dia ultrapassou o limite do mês... (não considera bissexto)
                        {
                            mes++;              // Passa o mês e retorna o dia para 1
                            dia = 1;
                            if (mes == 13)      // Se passou um ano...
                            {
                                ano++;          // Soma um ano e retorna o mês para 1
                                mes = 1;
                            }
                        }
                    }
                }
            }
        }
    }
}