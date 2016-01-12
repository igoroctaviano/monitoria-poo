//
// Pontifícia Universidade Católica de Minas Gerais
// Unidade São Gabriel
// Disciplina: Programação Orientada a Objetos
// *Object-Oriented Programming
// 
// Igor Octaviano
// More? access: https://github.com/igoroctaviano/
// 
namespace POO_PolyFiguresCSharp
{
    partial class MenuPolyFigures
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btDesenha = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCria = new System.Windows.Forms.Button();
            this.btApaga = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btDesenha
            // 
            this.btDesenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btDesenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDesenha.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDesenha.ForeColor = System.Drawing.Color.Black;
            this.btDesenha.Location = new System.Drawing.Point(6, 161);
            this.btDesenha.Name = "btDesenha";
            this.btDesenha.Size = new System.Drawing.Size(145, 50);
            this.btDesenha.TabIndex = 0;
            this.btDesenha.Text = "Desenha";
            this.btDesenha.UseVisualStyleBackColor = false;
            this.btDesenha.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btCria);
            this.panel1.Controls.Add(this.btApaga);
            this.panel1.Controls.Add(this.btDesenha);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(484, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 400);
            this.panel1.TabIndex = 1;
            // 
            // btCria
            // 
            this.btCria.BackColor = System.Drawing.Color.Green;
            this.btCria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCria.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCria.ForeColor = System.Drawing.Color.White;
            this.btCria.Location = new System.Drawing.Point(6, 3);
            this.btCria.Name = "btCria";
            this.btCria.Size = new System.Drawing.Size(145, 87);
            this.btCria.TabIndex = 2;
            this.btCria.Text = "Cria e Desenha";
            this.btCria.UseVisualStyleBackColor = false;
            this.btCria.Click += new System.EventHandler(this.button3_Click);
            // 
            // btApaga
            // 
            this.btApaga.BackColor = System.Drawing.Color.Red;
            this.btApaga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btApaga.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApaga.ForeColor = System.Drawing.Color.White;
            this.btApaga.Location = new System.Drawing.Point(6, 276);
            this.btApaga.Name = "btApaga";
            this.btApaga.Size = new System.Drawing.Size(145, 50);
            this.btApaga.TabIndex = 1;
            this.btApaga.Text = "Apaga";
            this.btApaga.UseVisualStyleBackColor = false;
            this.btApaga.Click += new System.EventHandler(this.button2_Click);
            // 
            // MenuPolyFigures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(644, 400);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuPolyFigures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automatic PaintBrush";
            this.Load += new System.EventHandler(this.MenuPolyFigures_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btDesenha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btApaga;
        private System.Windows.Forms.Button btCria;
    }
}

