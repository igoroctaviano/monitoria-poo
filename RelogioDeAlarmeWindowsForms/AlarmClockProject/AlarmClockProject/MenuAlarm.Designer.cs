//
// Pontifícia Universidade Católica de Minas Gerais
// Unidade São Gabriel
// Disciplina: Programação Orientada a Objetos
// *Object-Oriented Programming
// 
// Igor Octaviano
// More? access: https://github.com/igoroctaviano/
// 
namespace AlarmClockProject
{
    partial class MenuAlarm
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstDias = new System.Windows.Forms.CheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(57, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Habilitar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHora
            // 
            this.txtHora.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.Location = new System.Drawing.Point(111, 25);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(50, 46);
            this.txtHora.TabIndex = 1;
            this.txtHora.Text = "00";
            // 
            // txtMin
            // 
            this.txtMin.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMin.Location = new System.Drawing.Point(189, 25);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(50, 46);
            this.txtMin.TabIndex = 2;
            this.txtMin.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = ":";
            // 
            // lstDias
            // 
            this.lstDias.CheckOnClick = true;
            this.lstDias.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDias.FormattingEnabled = true;
            this.lstDias.Items.AddRange(new object[] {
            "D",
            "S",
            "T",
            "Q",
            "Q",
            "S",
            "S"});
            this.lstDias.Location = new System.Drawing.Point(111, 81);
            this.lstDias.Name = "lstDias";
            this.lstDias.Size = new System.Drawing.Size(128, 109);
            this.lstDias.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(150, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Desabilitar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(249, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Soneca";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 39);
            this.label2.TabIndex = 7;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(279, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 60);
            this.label3.TabIndex = 8;
            this.label3.Text = " ";
            // 
            // MenuAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 306);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lstDias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MenuAlarm";
            this.Text = "Alarme";
            this.Load += new System.EventHandler(this.MenuAlarm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox lstDias;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label3;
    }
}

