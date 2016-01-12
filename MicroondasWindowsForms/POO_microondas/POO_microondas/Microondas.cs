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

namespace POO_microondas
{
    class Microondas
    {
        private bool ligado;
        private bool portaFechada;
        private int minutos;
        private int segundos;
        private int potencia;

        public Microondas()
        {
            this.ligado = false;
            this.portaFechada = true;
            this.minutos = 0;
            this.segundos = 0;
            this.potencia = 10;
        }

        /// <summary>
        /// Getters and setters - seção de métodos de acesso.
        /// </summary>
        public bool Ligado
        {
            get { return this.ligado; }
        }

        public bool PortaFechada
        {
            get { return this.portaFechada; }
        }

        public int Minutos
        {
            get { return this.minutos; }
        }

        public int Segundos
        {
            get { return this.segundos; }
        }

        public int Potencia
        {
            get { return this.potencia; }
        }

        public void MudarPotencia()              // Acrescenta 1 a potência
        {
            this.potencia++;
            this.potencia = this.potencia % 11;  // Se a potência chegou a 11, volta a 0
        }

        public void AdicionarMinuto()
        {
            this.minutos++;
        }

        public void SubtrairMinuto()
        {
            if (this.minutos > 0)        // Diminui o valor do minuto
                this.minutos--;
            else
                this.Desligar();         // Se baixou de zero, acabou o tempo: desligar
        }

        public void AdicionarSegundo()
        {
            this.segundos++;
            if (this.segundos == 60)     // Se passaram 60seg...
            {
                this.AdicionarMinuto();  // Adiciona o minuto e zera os segundos
                this.segundos = 0;
            }
        }

        public void SubtrairSegundo()
        {
            this.segundos--;
            if (this.segundos < 0)       // Se o segundo baixou de zero...
            {
                this.segundos = 59;      // Diminui um minuto e configura os 59seg restantes
                this.SubtrairMinuto();
            }
        }

        public void Ligar()              // Só liga com a porta fechada
        {
            if (this.portaFechada) this.ligado = true;
        }

        public void Desligar()           // Desliga e zera minutos e segundos.
        {
            this.ligado = false;
            this.segundos = this.minutos = 0;
        }

        public void AbrirPorta()         // Só abre se estiver desligado.
        {
            if (this.ligado == false) this.portaFechada = false;
        }

        public void FecharPorta()
        {
            this.portaFechada = true;
        }

        public void Temporizador()       // A ser executado para diminuir o tempo
        {
            if (this.ligado)             // Só diminui o tempo se estiver ligado
            {
                this.SubtrairSegundo();
            }
        }

        public string MostrarHora()
        {
            string tempo = minutos.ToString("00") + ":" + segundos.ToString("00");
            return tempo;
        }
    }
}
