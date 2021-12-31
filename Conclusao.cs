using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace Projeto_S.A.L
{
    public partial class Conclusao : Form
    {
        Thread conclusao;
        public void Tardeoff()
        {
            lblTardenumero.Visible = false;
            rdb01TardeC.Visible = false;
            rdb02TardeC.Visible = false;
        }
        public void Noiteoff()
        {
            lblNoitenumero.Visible = false;
            rdb01NoiteC.Visible = false;
            rdb02NoiteC.Visible = false;
            rdb03NoiteC.Visible = false;
        }
        public void TardeOn()
        {
            lblTardenumero.Visible = true;
            rdb01TardeC.Visible = true;
            rdb02TardeC.Visible = true;
        }
        public void NoiteOn()
        {
            lblNoitenumero.Visible = true;
            rdb01NoiteC.Visible = true;
            rdb02NoiteC.Visible = true;
            rdb03NoiteC.Visible = true;
        }
        public Conclusao()
        {
            InitializeComponent();
            //trava a txBox de aliada
            txboxNmAliado.Enabled = false;
            txboxNmAliado.ReadOnly = true;
            //habilita as duas group box
            grpBxConfirmacao.Visible = true;
            txboxRetorno.Visible = false;
            btnGerar.Visible = false;
            // desabilitar rdb de numeros
            Tardeoff();
            Noiteoff();
        }
        public void limparCampos()
        {
            txboxNmAliado.Text = "";
        }
        public void desabilitConfirmTarde()
        {
            rdb01TardeC.Visible = false;
            rdb02TardeC.Visible = false;
        }
        public void desabilitConfirmNoite()
        {
            rdb01NoiteC.Visible = false;
            rdb02NoiteC.Visible = false;
            rdb03NoiteC.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conclusao = new Thread(abrirJanela);
            conclusao.SetApartmentState(ApartmentState.STA);
            conclusao.Start();
            this.Close();
        }
        private void abrirJanela(object obj)
        {
            Application.Run(new Definicao());
        }

        int NumVisitas = 0;
        int i = 0;

        List<Aliados> ListAliados = new List<Aliados>();
        private void btnListar_Click(object sender, EventArgs e)
        {
            string turno = "";
            if (rdbManhãC.Checked)
            {
                turno = "Manhã";
                NumVisitas = 10;
            }
            else if (rdbTardeC.Checked)
            {
                turno = "Tarde";
                NumVisitas = 7;
            }
            else if (rdbNoiteC.Checked)
            {
                turno = "Noite";
                NumVisitas = 10;
            }
            else if (rdbMadrugadaC.Checked)
            {
                turno = "Madrugada";
                NumVisitas = 10;
            }
            // case para habilitar a caixa de seleção
            switch (turno)
            {
                case "Manhã":
                    grpBxConfirmacao.Visible = false;
                    break;
                case "Tarde":
                    grpBoxCIicoC.Visible = true;
                    grpBxConfirmacao.Visible = false;
                    desabilitConfirmNoite();
                    break;
                case "Noite":
                    grpBoxCIicoC.Visible = true;
                    grpBxConfirmacao.Visible = false;
                    desabilitConfirmTarde();
                    break;
            }

            
            if(txboxNmAliado.Text != "-x-")
            {
                 if(txboxNmAliado.Text != "")
                 {
                    ListAliados.Add(new Aliados(txboxNmAliado.Text));
                    string Auxald = ListAliados[i].getNome();
                    txboxRetorno.Text = Auxald + " Listada!";
                    i++;

                  }
                    
            }
            
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //Verificar se finalizou a lista
            if (txboxNmAliado.Text == "-x-")
            {
                btnListar.Visible = false;
                btnGerar.Visible = true;
                if (ListAliados.Count < NumVisitas)
                {
                    while (ListAliados.Count < NumVisitas)
                    {
                        ListAliados.Add(new Aliados("-x-"));
                        txboxRetorno.Text = "Lista fechada corretamente. \nClick em gerar para fechar.";
                    }
                }
                using (StreamWriter lst2 = File.AppendText(desktop + "\\Lista_Automatica.txt"))
                {
                    switch (turno)
                    {
                        case "Manhã":
                            lst2.WriteLine("Aliadas Visitadas:");
                            lst2.WriteLine("{0}:10:30 ás 10:40", ListAliados[0].getNome());
                            lst2.WriteLine("{0}:10:40 ás 10:50", ListAliados[1].getNome());
                            lst2.WriteLine("{0}:10:50 ás 11:00", ListAliados[2].getNome());
                            lst2.WriteLine("{0}:11:00 ás 11:10", ListAliados[3].getNome());
                            lst2.WriteLine("{0}:11:10 ás 11:20", ListAliados[4].getNome());
                            lst2.WriteLine("{0}:11:20 ás 11:30", ListAliados[5].getNome());
                            lst2.WriteLine("{0}:11:30 ás 11:40", ListAliados[6].getNome());
                            lst2.WriteLine("{0}:11:40 ás 11:50", ListAliados[7].getNome());
                            lst2.WriteLine("{0}:11:50 ás 12:00", ListAliados[8].getNome());
                            break;
                        case "Tarde":
                            if (rdb01TardeC.Checked)
                            {
                                lst2.WriteLine("Aliadas Visitadas:");
                                lst2.WriteLine("{0}:14:00 ás 14:10", ListAliados[0].getNome());
                                lst2.WriteLine("{0}:14:10 ás 14:20", ListAliados[1].getNome());
                                lst2.WriteLine("{0}:14:20 ás 14:30", ListAliados[2].getNome());
                                lst2.WriteLine("{0}:14:30 ás 14:40", ListAliados[3].getNome());
                                lst2.WriteLine("{0}:14:40 ás 14:50", ListAliados[4].getNome());
                                lst2.WriteLine("{0}:14:50 ás 15:00", ListAliados[5].getNome());
                            }
                            else if (rdb02TardeC.Checked)
                            {
                                lst2.WriteLine("Aliadas Visitadas:");
                                lst2.WriteLine("{0}:15:30 ás 15:40", ListAliados[0].getNome());
                                lst2.WriteLine("{0}:15:40 ás 15:50", ListAliados[1].getNome());
                                lst2.WriteLine("{0}:15:50 ás 16:00", ListAliados[2].getNome());
                                lst2.WriteLine("{0}:16:00 ás 16:10", ListAliados[3].getNome());
                                lst2.WriteLine("{0}:16:10 ás 16:20", ListAliados[4].getNome());
                                lst2.WriteLine("{0}:16:20 ás 16:30", ListAliados[5].getNome());
                            }
                            break;
                        case "Noite":
                            if (rdb01NoiteC.Checked)
                            {
                                lst2.WriteLine("Aliadas Visitadas:");
                                lst2.WriteLine("{0}:17:30 ás 17:40", ListAliados[0].getNome());
                                lst2.WriteLine("{0}:17:40 ás 17:50", ListAliados[1].getNome());
                                lst2.WriteLine("{0}:17:50 ás 18:00", ListAliados[2].getNome());
                                lst2.WriteLine("{0}:18:00 ás 18:10", ListAliados[3].getNome());
                                lst2.WriteLine("{0}:18:10 ás 18:20", ListAliados[4].getNome());
                                lst2.WriteLine("{0}:18:20 ás 18:30", ListAliados[5].getNome());
                                lst2.WriteLine("{0}:18:30 ás 18:40", ListAliados[6].getNome());
                                lst2.WriteLine("{0}:18:40 ás 18:50", ListAliados[7].getNome());
                                lst2.WriteLine("{0}:18:50 ás 19:00", ListAliados[8].getNome());
                            }
                            else if (rdb02NoiteC.Checked)
                            {
                                lst2.WriteLine("Aliadas Visitadas:");
                                lst2.WriteLine("{0}:19:30 ás 19:40", ListAliados[0].getNome());
                                lst2.WriteLine("{0}:19:40 ás 19:50", ListAliados[1].getNome());
                                lst2.WriteLine("{0}:19:50 ás 20:00", ListAliados[2].getNome());
                                lst2.WriteLine("{0}:20:00 ás 20:10", ListAliados[3].getNome());
                                lst2.WriteLine("{0}:20:10 ás 20:20", ListAliados[4].getNome());
                                lst2.WriteLine("{0}:20:20 ás 20:30", ListAliados[5].getNome());
                                lst2.WriteLine("{0}:20:30 ás 20:40", ListAliados[6].getNome());
                                lst2.WriteLine("{0}:20:40 ás 20:50", ListAliados[7].getNome());
                                lst2.WriteLine("{0}:20:50 ás 21:00", ListAliados[8].getNome());
                            }
                            else if (rdb03NoiteC.Checked)
                            {
                                lst2.WriteLine("Aliadas Visitadas:");
                                lst2.WriteLine("{0}:21:30 ás 21:40", ListAliados[0].getNome());
                                lst2.WriteLine("{0}:21:40 ás 21:50", ListAliados[1].getNome());
                                lst2.WriteLine("{0}:21:50 ás 22:00", ListAliados[2].getNome());
                                lst2.WriteLine("{0}:22:00 ás 22:10", ListAliados[3].getNome());
                                lst2.WriteLine("{0}:22:10 ás 22:20", ListAliados[4].getNome());
                                lst2.WriteLine("{0}:22:20 ás 22:30", ListAliados[5].getNome());
                                lst2.WriteLine("{0}:22:30 ás 22:40 ", ListAliados[6].getNome());
                                lst2.WriteLine("{0}:22:40 ás 22:50 ", ListAliados[7].getNome());
                                lst2.WriteLine("{0}:22:50 ás 23:00 ", ListAliados[8].getNome());
                            }
                            break;
                        case "Madrugada":
                            lst2.WriteLine("Aliadas Visitadas:");
                            lst2.WriteLine("{0}:00:00 ás 00:10", ListAliados[0].getNome());
                            lst2.WriteLine("{0}:00:10 ás 00:20", ListAliados[1].getNome());
                            lst2.WriteLine("{0}:00:20 ás 00:30", ListAliados[2].getNome());
                            lst2.WriteLine("{0}:00:30 ás 00:40", ListAliados[3].getNome());
                            lst2.WriteLine("{0}:00:40 ás 00:50", ListAliados[4].getNome());
                            lst2.WriteLine("{0}:00:50 ás 01:00", ListAliados[5].getNome());
                            lst2.WriteLine("{0}:01:00 ás 01:10 ", ListAliados[6].getNome());
                            lst2.WriteLine("{0}:01:10 ás 01:20 ", ListAliados[7].getNome());
                            lst2.WriteLine("{0}:01:30 ás 01:40 ", ListAliados[8].getNome());
                            break;

                    }

                    lst2.WriteLine("Lista Gerada pelo Sistema Automático de Lista(S.A.L)-I.");
                    lst2.WriteLine("Desenvoldido por:JS/Deadpool533");
                    lst2.Close();
                }
            }
            else { limparCampos(); }
            

            if(turno == "Manhã")
            {
                grpBoxCIicoC.Visible = false;
                txboxRetorno.Visible = true;
                
                // ativar a caixa de texto
                txboxNmAliado.Enabled = true;
                txboxNmAliado.ReadOnly = false;
                grpBxConfirmacao.Visible = false;
            }
            //Verificar se Algum dos radios está marcado e desabilita a caixa
            if(rdb01TardeC.Checked)
            {
                grpBoxCIicoC.Visible = false;
                txboxRetorno.Visible = true;
                
                // ativar a caixa de texto
                txboxNmAliado.Enabled = true;
                txboxNmAliado.ReadOnly = false;
                grpBxConfirmacao.Visible = false;
            }
            else if (rdb02TardeC.Checked)
            {
                grpBoxCIicoC.Visible = false;
                txboxRetorno.Visible = true;
                
                // ativar a caixa de texto
                txboxNmAliado.Enabled = true;
                txboxNmAliado.ReadOnly = false;
                grpBxConfirmacao.Visible = false;
            }
            else if (rdb01NoiteC.Checked)
            {
                grpBoxCIicoC.Visible = false;
                txboxRetorno.Visible = true;
               
                // ativar a caixa de texto
                txboxNmAliado.Enabled = true;
                txboxNmAliado.ReadOnly = false;
                grpBxConfirmacao.Visible = false;
            }
            else if (rdb02NoiteC.Checked)
            {
                grpBoxCIicoC.Visible = false;
                txboxRetorno.Visible = true;
               
                // ativar a caixa de texto
                txboxNmAliado.Enabled = true;
                txboxNmAliado.ReadOnly = false;
                grpBxConfirmacao.Visible = false;
            }
            else if (rdb03NoiteC.Checked)
            {
                grpBoxCIicoC.Visible = false;
                txboxRetorno.Visible = true;
               
                // ativar a caixa de texto
                txboxNmAliado.Enabled = true;
                txboxNmAliado.ReadOnly = false;
                grpBxConfirmacao.Visible = false;
            }

            //desativar as groupBox para o usuario
        }
        private void btnGerar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdbManhãC_CheckedChanged(object sender, EventArgs e)
        {
            grpBxConfirmacao.Visible = false;
            txboxRetorno.Visible = true;
            // ativar a caixa de texto
            txboxNmAliado.Enabled = true;
            txboxNmAliado.ReadOnly = false;
        }

        private void rdbTardeC_CheckedChanged(object sender, EventArgs e)
        {
            grpBoxCIicoC.Visible = true;
            TardeOn();
            Noiteoff();
        }

        private void rdbNoiteC_CheckedChanged(object sender, EventArgs e)
        {
            grpBoxCIicoC.Visible = true;
            NoiteOn();
            Tardeoff();
        }

        private void rdbMadrugadaC_CheckedChanged(object sender, EventArgs e)
        {
            grpBxConfirmacao.Visible = false;
            txboxRetorno.Visible = true;
            // ativar a caixa de texto
            txboxNmAliado.Enabled = true;
            txboxNmAliado.ReadOnly = false;
        }
    }
}
        
   