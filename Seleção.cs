using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projeto_S.A.L
{
    public partial class Seleção : Form
    {

        
        public Seleção()
        {
            InitializeComponent();
            if (rdbManha.Checked)
            {
                rdbTarde1.Checked = false;
                rdbTarde2.Checked = false;
                rdbTarde1.Checked = false;
                rdbTarde2.Checked = false;
                rdbNoite3.Checked = false;
            }else if (rdbMadrugada.Checked)
            {
                rdbTarde1.Checked = false;
                rdbTarde2.Checked = false;
                rdbTarde1.Checked = false;
                rdbTarde2.Checked = false;
                rdbNoite3.Checked = false;
            }
        }

        

        private void btnCabeçarioEnviar_Click_1(object sender, EventArgs e)
        {
            string data = DateTime.Now.ToString("dd-MM-yyyy");
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            StreamWriter lista = new StreamWriter(desktop + "\\Lista_Automatica.txt");
            string Turno = "";
            int ciclo = 0;
            // verificação do turno do ciclo
            if (rdbManha.Checked)
            {
                Turno = "Manhã";
                rdbTarde1.Checked = false;
                rdbTarde2.Checked = false;
                rdbTarde1.Checked = false;
                rdbTarde2.Checked = false;
                rdbNoite3.Checked = false;
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
            this.Hide();
            Definicao telaDefin = new Definicao();
            telaDefin.Show();
        }  
    }
}
