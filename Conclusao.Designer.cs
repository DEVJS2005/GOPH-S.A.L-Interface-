
namespace Projeto_S.A.L
{
    partial class Conclusao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conclusao));
            this.label1 = new System.Windows.Forms.Label();
            this.txboxNmAliado = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.grpBxConfirmacao = new System.Windows.Forms.GroupBox();
            this.rdbMadrugadaC = new System.Windows.Forms.RadioButton();
            this.rdbNoiteC = new System.Windows.Forms.RadioButton();
            this.rdbTardeC = new System.Windows.Forms.RadioButton();
            this.rdbManhãC = new System.Windows.Forms.RadioButton();
            this.txboxRetorno = new System.Windows.Forms.TextBox();
            this.grpBoxCIicoC = new System.Windows.Forms.GroupBox();
            this.rdb02NoiteC = new System.Windows.Forms.RadioButton();
            this.rdb01NoiteC = new System.Windows.Forms.RadioButton();
            this.rdb03NoiteC = new System.Windows.Forms.RadioButton();
            this.rdb02TardeC = new System.Windows.Forms.RadioButton();
            this.rdb01TardeC = new System.Windows.Forms.RadioButton();
            this.lblNoitenumero = new System.Windows.Forms.Label();
            this.lblTardenumero = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpBxConfirmacao.SuspendLayout();
            this.grpBoxCIicoC.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(179, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aliada:";
            // 
            // txboxNmAliado
            // 
            this.txboxNmAliado.Location = new System.Drawing.Point(132, 109);
            this.txboxNmAliado.Name = "txboxNmAliado";
            this.txboxNmAliado.Size = new System.Drawing.Size(212, 23);
            this.txboxNmAliado.TabIndex = 1;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListar.Location = new System.Drawing.Point(27, 295);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(114, 35);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Salvar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(325, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGerar.Location = new System.Drawing.Point(179, 296);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(98, 32);
            this.btnGerar.TabIndex = 4;
            this.btnGerar.Text = "Gerar Lista";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // grpBxConfirmacao
            // 
            this.grpBxConfirmacao.Controls.Add(this.rdbMadrugadaC);
            this.grpBxConfirmacao.Controls.Add(this.rdbNoiteC);
            this.grpBxConfirmacao.Controls.Add(this.rdbTardeC);
            this.grpBxConfirmacao.Controls.Add(this.rdbManhãC);
            this.grpBxConfirmacao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpBxConfirmacao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grpBxConfirmacao.Location = new System.Drawing.Point(12, 138);
            this.grpBxConfirmacao.Name = "grpBxConfirmacao";
            this.grpBxConfirmacao.Size = new System.Drawing.Size(240, 156);
            this.grpBxConfirmacao.TabIndex = 6;
            this.grpBxConfirmacao.TabStop = false;
            this.grpBxConfirmacao.Text = "Confirme o turno do ciclo";
            // 
            // rdbMadrugadaC
            // 
            this.rdbMadrugadaC.AutoSize = true;
            this.rdbMadrugadaC.Location = new System.Drawing.Point(15, 128);
            this.rdbMadrugadaC.Name = "rdbMadrugadaC";
            this.rdbMadrugadaC.Size = new System.Drawing.Size(113, 23);
            this.rdbMadrugadaC.TabIndex = 3;
            this.rdbMadrugadaC.Text = "Madrugada";
            this.rdbMadrugadaC.UseVisualStyleBackColor = true;
            this.rdbMadrugadaC.CheckedChanged += new System.EventHandler(this.rdbMadrugadaC_CheckedChanged);
            // 
            // rdbNoiteC
            // 
            this.rdbNoiteC.AutoSize = true;
            this.rdbNoiteC.Location = new System.Drawing.Point(15, 98);
            this.rdbNoiteC.Name = "rdbNoiteC";
            this.rdbNoiteC.Size = new System.Drawing.Size(67, 23);
            this.rdbNoiteC.TabIndex = 2;
            this.rdbNoiteC.Text = "Noite";
            this.rdbNoiteC.UseVisualStyleBackColor = true;
            this.rdbNoiteC.CheckedChanged += new System.EventHandler(this.rdbNoiteC_CheckedChanged);
            // 
            // rdbTardeC
            // 
            this.rdbTardeC.AutoSize = true;
            this.rdbTardeC.Location = new System.Drawing.Point(15, 68);
            this.rdbTardeC.Name = "rdbTardeC";
            this.rdbTardeC.Size = new System.Drawing.Size(70, 23);
            this.rdbTardeC.TabIndex = 1;
            this.rdbTardeC.Text = "Tarde";
            this.rdbTardeC.UseVisualStyleBackColor = true;
            this.rdbTardeC.CheckedChanged += new System.EventHandler(this.rdbTardeC_CheckedChanged);
            // 
            // rdbManhãC
            // 
            this.rdbManhãC.AutoSize = true;
            this.rdbManhãC.Location = new System.Drawing.Point(15, 39);
            this.rdbManhãC.Name = "rdbManhãC";
            this.rdbManhãC.Size = new System.Drawing.Size(78, 23);
            this.rdbManhãC.TabIndex = 0;
            this.rdbManhãC.Text = "Manhã";
            this.rdbManhãC.UseVisualStyleBackColor = true;
            this.rdbManhãC.CheckedChanged += new System.EventHandler(this.rdbManhãC_CheckedChanged);
            // 
            // txboxRetorno
            // 
            this.txboxRetorno.Enabled = false;
            this.txboxRetorno.Location = new System.Drawing.Point(0, 1);
            this.txboxRetorno.Name = "txboxRetorno";
            this.txboxRetorno.ReadOnly = true;
            this.txboxRetorno.Size = new System.Drawing.Size(303, 23);
            this.txboxRetorno.TabIndex = 8;
            this.txboxRetorno.Visible = false;
            // 
            // grpBoxCIicoC
            // 
            this.grpBoxCIicoC.Controls.Add(this.rdb02NoiteC);
            this.grpBoxCIicoC.Controls.Add(this.rdb01NoiteC);
            this.grpBoxCIicoC.Controls.Add(this.rdb03NoiteC);
            this.grpBoxCIicoC.Controls.Add(this.rdb02TardeC);
            this.grpBoxCIicoC.Controls.Add(this.rdb01TardeC);
            this.grpBoxCIicoC.Controls.Add(this.lblNoitenumero);
            this.grpBoxCIicoC.Controls.Add(this.lblTardenumero);
            this.grpBoxCIicoC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpBoxCIicoC.Location = new System.Drawing.Point(258, 140);
            this.grpBoxCIicoC.Name = "grpBoxCIicoC";
            this.grpBoxCIicoC.Size = new System.Drawing.Size(215, 156);
            this.grpBoxCIicoC.TabIndex = 7;
            this.grpBoxCIicoC.TabStop = false;
            this.grpBoxCIicoC.Text = "Confirme o numero do ciclo";
            this.grpBoxCIicoC.Visible = false;
            // 
            // rdb02NoiteC
            // 
            this.rdb02NoiteC.AutoSize = true;
            this.rdb02NoiteC.Location = new System.Drawing.Point(127, 90);
            this.rdb02NoiteC.Name = "rdb02NoiteC";
            this.rdb02NoiteC.Size = new System.Drawing.Size(39, 20);
            this.rdb02NoiteC.TabIndex = 6;
            this.rdb02NoiteC.TabStop = true;
            this.rdb02NoiteC.Text = "02";
            this.rdb02NoiteC.UseVisualStyleBackColor = true;
            // 
            // rdb01NoiteC
            // 
            this.rdb01NoiteC.AutoSize = true;
            this.rdb01NoiteC.Location = new System.Drawing.Point(127, 64);
            this.rdb01NoiteC.Name = "rdb01NoiteC";
            this.rdb01NoiteC.Size = new System.Drawing.Size(39, 20);
            this.rdb01NoiteC.TabIndex = 5;
            this.rdb01NoiteC.TabStop = true;
            this.rdb01NoiteC.Text = "01";
            this.rdb01NoiteC.UseVisualStyleBackColor = true;
            // 
            // rdb03NoiteC
            // 
            this.rdb03NoiteC.AutoSize = true;
            this.rdb03NoiteC.Location = new System.Drawing.Point(127, 116);
            this.rdb03NoiteC.Name = "rdb03NoiteC";
            this.rdb03NoiteC.Size = new System.Drawing.Size(39, 20);
            this.rdb03NoiteC.TabIndex = 4;
            this.rdb03NoiteC.TabStop = true;
            this.rdb03NoiteC.Text = "03";
            this.rdb03NoiteC.UseVisualStyleBackColor = true;
            // 
            // rdb02TardeC
            // 
            this.rdb02TardeC.AutoSize = true;
            this.rdb02TardeC.Location = new System.Drawing.Point(6, 85);
            this.rdb02TardeC.Name = "rdb02TardeC";
            this.rdb02TardeC.Size = new System.Drawing.Size(39, 20);
            this.rdb02TardeC.TabIndex = 3;
            this.rdb02TardeC.TabStop = true;
            this.rdb02TardeC.Text = "02";
            this.rdb02TardeC.UseVisualStyleBackColor = true;
            // 
            // rdb01TardeC
            // 
            this.rdb01TardeC.AutoSize = true;
            this.rdb01TardeC.Location = new System.Drawing.Point(6, 58);
            this.rdb01TardeC.Name = "rdb01TardeC";
            this.rdb01TardeC.Size = new System.Drawing.Size(39, 20);
            this.rdb01TardeC.TabIndex = 2;
            this.rdb01TardeC.TabStop = true;
            this.rdb01TardeC.Text = "01";
            this.rdb01TardeC.UseVisualStyleBackColor = true;
            // 
            // lblNoitenumero
            // 
            this.lblNoitenumero.AutoSize = true;
            this.lblNoitenumero.Location = new System.Drawing.Point(122, 39);
            this.lblNoitenumero.Name = "lblNoitenumero";
            this.lblNoitenumero.Size = new System.Drawing.Size(44, 16);
            this.lblNoitenumero.TabIndex = 1;
            this.lblNoitenumero.Text = "Noite:";
            // 
            // lblTardenumero
            // 
            this.lblTardenumero.AutoSize = true;
            this.lblTardenumero.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTardenumero.Location = new System.Drawing.Point(7, 39);
            this.lblTardenumero.Name = "lblTardenumero";
            this.lblTardenumero.Size = new System.Drawing.Size(47, 16);
            this.lblTardenumero.TabIndex = 0;
            this.lblTardenumero.Text = "Tarde:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(123, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Para finalizar digite \"-x-\" e aperte em salvar";
            // 
            // Conclusao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(481, 349);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txboxRetorno);
            this.Controls.Add(this.grpBoxCIicoC);
            this.Controls.Add(this.grpBxConfirmacao);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txboxNmAliado);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Conclusao";
            this.Text = "Sistema Automático de Lista";
            this.grpBxConfirmacao.ResumeLayout(false);
            this.grpBxConfirmacao.PerformLayout();
            this.grpBoxCIicoC.ResumeLayout(false);
            this.grpBoxCIicoC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txboxNmAliado;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.GroupBox grpBxConfirmacao;
        private System.Windows.Forms.RadioButton rdbMadrugadaC;
        private System.Windows.Forms.RadioButton rdbNoiteC;
        private System.Windows.Forms.RadioButton rdbTardeC;
        private System.Windows.Forms.RadioButton rdbManhãC;
        private System.Windows.Forms.GroupBox grpBoxCIicoC;
        private System.Windows.Forms.RadioButton rdb02NoiteC;
        private System.Windows.Forms.RadioButton rdb01NoiteC;
        private System.Windows.Forms.RadioButton rdb03NoiteC;
        private System.Windows.Forms.RadioButton rdb02TardeC;
        private System.Windows.Forms.RadioButton rdb01TardeC;
        private System.Windows.Forms.Label lblNoitenumero;
        private System.Windows.Forms.Label lblTardenumero;
        private System.Windows.Forms.TextBox txboxRetorno;
        private System.Windows.Forms.Label label4;
    }
}