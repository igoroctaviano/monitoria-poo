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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POO_microondas
{
    public partial class MenuMicroondas : Form
    {
        Microondas fornoMicroondas;
        
        public MenuMicroondas()
        {
            InitializeComponent();
            fornoMicroondas = new Microondas();     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!fornoMicroondas.Ligado){
                fornoMicroondas.AdicionarMinuto();
                label1.Text = fornoMicroondas.MostrarHora();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!fornoMicroondas.Ligado){
                fornoMicroondas.SubtrairMinuto();
                label1.Text = fornoMicroondas.MostrarHora();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (fornoMicroondas.PortaFechada)
            {
                fornoMicroondas.Ligar();
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fornoMicroondas.Temporizador();
            label1.Text = fornoMicroondas.MostrarHora();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!fornoMicroondas.Ligado)
            {
                fornoMicroondas.AdicionarSegundo();
                label1.Text = fornoMicroondas.MostrarHora();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!fornoMicroondas.Ligado)
            {
                fornoMicroondas.SubtrairSegundo();
                label1.Text = fornoMicroondas.MostrarHora();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fornoMicroondas.Desligar();           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!fornoMicroondas.Ligado)
            {
                fornoMicroondas.AbrirPorta();
                pictureBox1.Load(".\\open.jpg");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            fornoMicroondas.FecharPorta();
            pictureBox1.Load(".\\closed.jpg");
        }

        private void MenuMicroondas_Load(object sender, EventArgs e) { }
    }
}
