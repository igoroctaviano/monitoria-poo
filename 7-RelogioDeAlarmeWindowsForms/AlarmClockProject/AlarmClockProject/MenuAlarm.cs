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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Windows.Forms;

namespace AlarmClockProject
{
    public partial class MenuAlarm : Form
    {
        AlarmClock meuAlarme;
        SoundPlayer simpleSound = new SoundPlayer(@"alarm-clock-01.wav");
        int tempoAlarme = 0;

        public MenuAlarm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Botão Habilitar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            bool[] dias = { false, false, false, false, false, false, false };   // Cria um vetor para os dias

            int hora = int.Parse(txtHora.Text);                  // Pega o dia ...
            int min = int.Parse(txtMin.Text);                    // e a hora na interface

            for (int i = 0; i < lstDias.CheckedIndices.Count; i++)
            {   // Pega os valores dos checkboxes na interface 
                dias[lstDias.CheckedIndices[i]] = true;          // na interface e os passa para o vetor de dias
            }

            meuAlarme = new AlarmClock(hora, min, dias);    // Cria o alarme com hora, minuto e dias capturados
            label3.BackColor = Color.Green;                 // Sinaliza programação: etiqueta verde
            timer1.Enabled = true;                          // Habilita o timer do programa
        }

        /// <summary>
        /// Código do timer. Verifica, a cada segundo, se é hora do alarme disparar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime agora = DateTime.Now;  // Pega a hora atual do sistema

            String hora = agora.Hour.ToString("d2") + ":" + agora.Minute.ToString("d2") + ":" + agora.Second.ToString("d2"); //formata hora: HH:MM:SS

            label2.Text = hora;  // Mostra a hora na interface

            if ((agora.Second == 0) && meuAlarme.Disparar(agora.Hour, agora.Minute, (int)(agora.DayOfWeek)))
            {   // Se o segundo é ZERO, verifica se o alarme deve disparar... 
                simpleSound.Play();        // Caso positivo, toca o som.
                timer2.Enabled = true;       // Habilita o segundo timer (controla o tempo do som)
            }

        }

        /// <summary>
        /// Timer que controla o tempo do som. Pára o alarme após 10 segundos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            tempoAlarme++;                      // Soma mais um ao tempo
            if (tempoAlarme == 10)              // Se passarem 10 segundos...
            {
                simpleSound.Stop();             // Desliga o som
                tempoAlarme = 0;
                timer2.Enabled = false;         // Se auto desabilita
                meuAlarme.Desprogramar();       // Desprograma o alarme (já tocou!)
                label3.BackColor = Color.Red;   // Sinaliza a desprogramação: etiqueta vermelha
            }

        }

        /// <summary>
        /// Botão de desprogramar; Serve também para desligar o som quando o alarme disparar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            meuAlarme.Desprogramar();       // Desprograma/desliga o alarme
            simpleSound.Stop();             // Pára o som, caso esteja ligado
            label3.BackColor = Color.Red;   // Sinaliza a desprogramação: etiqueta vermelha
        }

        /// <summary>
        /// Botão de soneca.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (meuAlarme.Soneca())         // Tenta aplicar a soneca. Em caso de sucesso...
            {
                txtHora.Text = meuAlarme.GetHora().ToString();      // Atualiza a hora na interface
                txtMin.Text = meuAlarme.GetMinuto().ToString();     // Atualiza o minuto na interface
                label3.BackColor = Color.Yellow;                    // Sinaliza a soneca: etiqueta amarela
                timer2.Enabled = false;                             // Sesabilita o controle de som
                simpleSound.Stop();                                 // Pára o som
                tempoAlarme = 0;                                    // Zera o tempo do som tocando
            }
        }

        private void MenuAlarm_Load(object sender, EventArgs e) { }
    }
}
