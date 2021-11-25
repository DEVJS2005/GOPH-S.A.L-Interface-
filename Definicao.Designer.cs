
namespace Projeto_S.A.L
{
    partial class Definicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Definicao));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblAliada = new System.Windows.Forms.Label();
            this.txBoxName = new System.Windows.Forms.TextBox();
            this.txBoxAliadaVisi = new System.Windows.Forms.TextBox();
            this.txBoxCorpoLista = new System.Windows.Forms.TextBox();
            this.Aliadas = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbSP = new System.Windows.Forms.RadioButton();
            this.rdbCP = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(18, 89);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(87, 40);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nick:";
            // 
            // lblAliada
            // 
            this.lblAliada.AutoSize = true;
            this.lblAliada.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAliada.Location = new System.Drawing.Point(18, 210);
            this.lblAliada.Name = "lblAliada";
            this.lblAliada.Size = new System.Drawing.Size(254, 40);
            this.lblAliada.TabIndex = 1;
            this.lblAliada.Text = "Aliadas Visitadas:";
            // 
            // txBoxName
            // 
            this.txBoxName.Location = new System.Drawing.Point(23, 132);
            this.txBoxName.Name = "txBoxName";
            this.txBoxName.Size = new System.Drawing.Size(201, 23);
            this.txBoxName.TabIndex = 2;
            // 
            // txBoxAliadaVisi
            // 
            this.txBoxAliadaVisi.Location = new System.Drawing.Point(18, 268);
            this.txBoxAliadaVisi.Name = "txBoxAliadaVisi";
            this.txBoxAliadaVisi.Size = new System.Drawing.Size(277, 23);
            this.txBoxAliadaVisi.TabIndex = 3;
            // 
            // txBoxCorpoLista
            // 
            this.txBoxCorpoLista.BackColor = System.Drawing.Color.White;
            this.txBoxCorpoLista.Enabled = false;
            this.txBoxCorpoLista.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txBoxCorpoLista.ForeColor = System.Drawing.Color.Black;
            this.txBoxCorpoLista.Location = new System.Drawing.Point(336, 59);
            this.txBoxCorpoLista.Multiline = true;
            this.txBoxCorpoLista.Name = "txBoxCorpoLista";
            this.txBoxCorpoLista.ReadOnly = true;
            this.txBoxCorpoLista.Size = new System.Drawing.Size(319, 468);
            this.txBoxCorpoLista.TabIndex = 4;
            // 
            // Aliadas
            // 
            this.Aliadas.AutoSize = true;
            this.Aliadas.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Aliadas.Location = new System.Drawing.Point(372, 9);
            this.Aliadas.Name = "Aliadas";
            this.Aliadas.Size = new System.Drawing.Size(258, 47);
            this.Aliadas.TabIndex = 5;
            this.Aliadas.Text = "Corpo da lista:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnviar.Location = new System.Drawing.Point(43, 549);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(87, 35);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Listar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(179, 549);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 35);
            this.button3.TabIndex = 8;
            this.button3.Text = "próximo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbSP);
            this.groupBox1.Controls.Add(this.rdbCP);
            this.groupBox1.Location = new System.Drawing.Point(23, 334);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 105);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tag de saída:";
            // 
            // rdbSP
            // 
            this.rdbSP.AutoSize = true;
            this.rdbSP.Location = new System.Drawing.Point(7, 65);
            this.rdbSP.Name = "rdbSP";
            this.rdbSP.Size = new System.Drawing.Size(49, 19);
            this.rdbSP.TabIndex = 1;
            this.rdbSP.TabStop = true;
            this.rdbSP.Text = "[S.P]";
            this.rdbSP.UseVisualStyleBackColor = true;
            // 
            // rdbCP
            // 
            this.rdbCP.AutoSize = true;
            this.rdbCP.Location = new System.Drawing.Point(6, 40);
            this.rdbCP.Name = "rdbCP";
            this.rdbCP.Size = new System.Drawing.Size(51, 19);
            this.rdbCP.TabIndex = 0;
            this.rdbCP.TabStop = true;
            this.rdbCP.Text = "[C.P]";
            this.rdbCP.UseVisualStyleBackColor = true;
            // 
            // Definicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(716, 592);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.Aliadas);
            this.Controls.Add(this.txBoxCorpoLista);
            this.Controls.Add(this.txBoxAliadaVisi);
            this.Controls.Add(this.txBoxName);
            this.Controls.Add(this.lblAliada);
            this.Controls.Add(this.lblNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Definicao";
            this.Text = "Sistema automático de lista";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblAliada;
        private System.Windows.Forms.TextBox txBoxName;
        private System.Windows.Forms.TextBox txBoxAliadaVisi;
        private System.Windows.Forms.TextBox txBoxCorpoLista;
        private System.Windows.Forms.Label Aliadas;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbSP;
        private System.Windows.Forms.RadioButton rdbCP;
    }
}