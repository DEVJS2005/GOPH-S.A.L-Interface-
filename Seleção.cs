using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Projeto_S.A.L
{
    public partial class Seleção : Form
    {
        Thread selecao;
        public void tardeNoiteoff()
        {
            rdbTarde1.Checked = false;
            rdbTarde2.Checked = false;
            rdbTarde1.Checked = false;
            rdbTarde2.Checked = false;
            rdbNoite1.Checked = false;
            rdbNoite2.Checked = false;
            rdbNoite3.Checked = false;
        }
        public void tardeOff()
        {
            rdbTarde1.Checked = false;
            rdbTarde2.Checked = false;
        }
        public void noiteOff()
        {
            rdbNoite1.Checked = false;
            rdbNoite2.Checked = false;
            rdbNoite3.Checked = false;
        }
        
        public Seleção()
        {
            InitializeComponent();
            // Botão e caixa de seleção do numero do ciclo Desabiblitada
            btnCabeçarioEnviar.Visible = false;
            grpboxNumbCiclo.Visible = false;
            // rdb de numero desabilitado
            //Tarde:
            lblTarde.Visible = false;
            rdbTarde1.Visible = false;
            rdbTarde2.Visible = false;
            // Noite:
            lblNoite.Visible = false;
            rdbNoite1.Visible = false;
            rdbNoite2.Visible = false;
            rdbNoite3.Visible = false;
            
            

        }

        string data = DateTime.Now.ToString("dd-MM-yyyy");
        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private void btnCabeçarioEnviar_Click_1(object sender, EventArgs e)
        {
            
            StreamWriter lista = new StreamWriter(desktop + "\\Lista_Automatica.txt");
            string Turno = "";
            int ciclo = 0;
            // verificação do turno do ciclo
            if (rdbManha.Checked)
            {
                Turno = "Manhã";
                tardeNoiteoff();
            }
            else if (rdbTarde.Checked)
            {
                Turno = "Tarde";
                // verificação do numero do ciclo
                if (rdbTarde1.Checked)
                {
                    ciclo = 1;
                }else if (rdbTarde2.Checked)
                {
                    ciclo = 2;
                }

            }
            else if (rdbNoite.Checked)
            {
                Turno = "Noite";
                if (rdbNoite1.Checked)
                {
                    ciclo = 1;
                }
                else if (rdbNoite2.Checked)
                {
                    ciclo = 2;
                }else if (rdbNoite3.Checked)
                {
                    ciclo = 3;
                }
            }
            else if (rdbMadrugada.Checked)
            {
                Turno = "Madrugada";
                rdbTarde1.Checked = false;
                rdbTarde2.Checked = false;
                rdbTarde1.Checked = false;
                rdbTarde2.Checked = false;
                rdbNoite3.Checked = false;
            }
            // preenchimento por turno
            switch (Turno)
            {
                case "Manhã":
                    lista.WriteLine("Data:" + data);
                    lista.WriteLine("Turno:Manhã");
                    lista.WriteLine("Ciclo:01");
                    lista.WriteLine("Código:01");
                    lista.WriteLine("Hora de inicio:10:30");
                    lista.WriteLine("Hora de fim:12:00");
                    lista.WriteLine("Comandante do código:" + txBoxComando.Text);
                    lista.WriteLine("Co.comandante do código:" + txBoxCoComando.Text);
                    lista.WriteLine("Auxiliar da lista:" + txBoxAuxLista.Text);
                    break;
                case "Tarde":
                    lista.WriteLine("data:" + data);
                    lista.WriteLine("Turno:Tarde");
                    lista.WriteLine("Ciclo:" + ciclo);
                    lista.WriteLine("Código: 01");
                    if (ciclo == 1)
                    {
                        lista.WriteLine("Hora de inicio:14:00");
                        lista.WriteLine("Hora de fim:15:00");
                    }
                    else if (ciclo == 2)
                    {
                        lista.WriteLine("Hora de inicio:15:30");
                        lista.WriteLine("Hora de fim:16:30");
                    }
                    lista.WriteLine("Comandante do código:" + txBoxComando.Text);
                    lista.WriteLine("Co.comandante do código:" + txBoxCoComando.Text);
                    lista.WriteLine("Auxiliar da lista:" + txBoxAuxLista.Text);
                    lista.WriteLine("Funcionários presentes no CÓDIGO 01: (Registrados no Sistema)");
                    break;
                case "Noite":
                    lista.WriteLine("data:" + data);
                    lista.WriteLine("Turno:Noite");
                    lista.WriteLine("Ciclo:" + ciclo);
                    lista.WriteLine("Código: 01");
                    if (ciclo == 1)
                    {
                        lista.WriteLine("Hora de inicio:17:30");
                        lista.WriteLine("Hora de fim:19:00");
                    }
                    else if (ciclo == 2)
                    {
                        lista.WriteLine("Hora de inicio:19:30");
                        lista.WriteLine("Hora de fim:21:00");
                    }
                    else if (ciclo == 3)
                    {
                        lista.WriteLine("Hora de inicio:21:30");
                        lista.WriteLine("Hora de fim:23:00");
                    }
                    lista.WriteLine("Comandante do código:" + txBoxComando.Text);
                    lista.WriteLine("Co.comandante do código:" + txBoxCoComando.Text);
                    lista.WriteLine("Auxiliar da lista:" + txBoxAuxLista.Text);
                    lista.WriteLine("Funcionários presentes no CÓDIGO 01: (Registrados no Sistema)");
                    break;
                case "Madrugada":
                    lista.WriteLine("Data:" + data);
                    lista.WriteLine("Turno:Madrugada");
                    lista.WriteLine("Ciclo:01");
                    lista.WriteLine("Código:01");
                    lista.WriteLine("Hora de inicio:00:00");
                    lista.WriteLine("Hora de fim:00:03");
                    lista.WriteLine("Comandante do código:" + txBoxComando.Text);
                    lista.WriteLine("Co.comandante do código:" + txBoxCoComando.Text);
                    lista.WriteLine("Auxiliar da lista:" + txBoxAuxLista.Text);
                    break;

            }
            lista.Close();


            
            selecao = new Thread(abrirJanela);
            selecao.SetApartmentState(ApartmentState.STA);
            selecao.Start();
            this.Close();
        }
        private void abrirJanela(object obj)
        {
            Application.Run(new Definicao());
        }
        private void rdbTarde_CheckedChanged(object sender, EventArgs e)
        {
            btnCabeçarioEnviar.Visible = false;
            grpboxNumbCiclo.Visible = true;
            //Tarde:
            lblTarde.Visible = true;
            rdbTarde1.Visible = true;
            rdbTarde2.Visible = true;
            //Desabilita a visibilidade da noite para não haver confusão
            lblNoite.Visible = false;
            rdbNoite1.Visible = false;
            rdbNoite2.Visible = false;
            rdbNoite3.Visible = false;
            //desmarcação da caixa da noite
            noiteOff();
           
        }

        private void rdbNoite_CheckedChanged(object sender, EventArgs e)
        {
            btnCabeçarioEnviar.Visible = false;
            grpboxNumbCiclo.Visible = true;
            lblNoite.Visible = true;
            rdbNoite1.Visible = true;
            rdbNoite2.Visible = true;
            rdbNoite3.Visible = true;
            //Desabilita a visibilidade da tarde para não haver confusão
            lblTarde.Visible = false;
            rdbTarde1.Visible = false;
            rdbTarde2.Visible = false;
            //desabilita a marcação na caixa da tarde 
            tardeOff();
            
        }

        private void rdbTarde1_CheckedChanged(object sender, EventArgs e)
        {
            btnCabeçarioEnviar.Visible = true;
            noiteOff();
        }

        private void rdbTarde2_CheckedChanged(object sender, EventArgs e)
        {
            btnCabeçarioEnviar.Visible = true;
            noiteOff();
        }

        private void rdbNoite1_CheckedChanged(object sender, EventArgs e)
        {
            btnCabeçarioEnviar.Visible = true;
            tardeOff();
        }

        private void rdbNoite2_CheckedChanged(object sender, EventArgs e)
        {
            btnCabeçarioEnviar.Visible = true;
            tardeOff();
        }

        private void rdbNoite3_CheckedChanged(object sender, EventArgs e)
        {
            btnCabeçarioEnviar.Visible = true;
            tardeOff();
        }

        private void rdbManha_CheckedChanged(object sender, EventArgs e)
        {
            btnCabeçarioEnviar.Visible = true;
            grpboxNumbCiclo.Visible = false;
            tardeNoiteoff();
        }

        private void rdbMadrugada_CheckedChanged(object sender, EventArgs e)
        {
            btnCabeçarioEnviar.Visible = true;
            grpboxNumbCiclo.Visible = false;
            tardeNoiteoff();
        }
    }
}
