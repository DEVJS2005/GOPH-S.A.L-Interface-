using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Projeto_S.A.L
{
    public partial class Conclusao : Form
    {
        
        public Conclusao()
        {
            InitializeComponent();
            //trava a txBox de aliada
            txboxNmAliado.Enabled = false;
            txboxNmAliado.ReadOnly = true;
            //habilita as duas group box
            grpBoxCIicoC.Visible = true;
            grpBxConfirmacao.Visible = true;
        }
        public void limparCampos()
        {
            txboxNmAliado.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Definicao telaDefinicao = new Definicao();
            telaDefinicao.Show();
        }

        
        int NumVisitas = 0;
        
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


            if(txboxNmAliado.Text != "-x-")
            {
                ListAliados.Add(new Aliados(txboxNmAliado.Text));
            }
            
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //Verificação
            if (txboxNmAliado.Text == "-x-")
            {
                if (ListAliados.Count < NumVisitas)
                {
                    while (ListAliados.Count < NumVisitas)
                    {
                        ListAliados.Add(new Aliados("-x-"));
                    }
                }
                using (StreamWriter lst2 = File.AppendText(desktop + "\\Lista_Automatica.txt"))
                {
                    switch (turno)
                    {
                        case "Manhã":
                            lst2.WriteLine("Aliadas Visitadas:");
                            lst2.WriteLine("{0}:10:30 ás 10:40", ListAliados[1].getNome());
                            lst2.WriteLine("{0}:10:40 ás 10:50", ListAliados[2].getNome());
                            lst2.WriteLine("{0}:10:50 ás 11:00", ListAliados[3].getNome());
                            lst2.WriteLine("{0}:11:00 ás 11:10", ListAliados[4].getNome());
                            lst2.WriteLine("{0}:11:10 ás 11:20", ListAliados[5].getNome());
                            lst2.WriteLine("{0}:11:20 ás 11:30", ListAliados[6].getNome());
                            lst2.WriteLine("{0}:11:30 ás 11:40", ListAliados[7].getNome());
                            lst2.WriteLine("{0}:11:40 ás 11:50", ListAliados[8].getNome());
                            lst2.WriteLine("{0}:11:50 ás 12:00", ListAliados[9].getNome());
                            break;
                        case "Tarde":
                            if (rdb01TardeC.Checked)
                            {
                                lst2.WriteLine("Aliadas Visitadas:");
                                lst2.WriteLine("{0}:14:00 ás 14:10", ListAliados[1].getNome());
                                lst2.WriteLine("{0}:14:10 ás 14:20", ListAliados[2].getNome());
                                lst2.WriteLine("{0}:14:20 ás 14:30", ListAliados[3].getNome());
                                lst2.WriteLine("{0}:14:30 ás 14:40", ListAliados[4].getNome());
                                lst2.WriteLine("{0}:14:40 ás 14:50", ListAliados[5].getNome());
                                lst2.WriteLine("{0}:14:50 ás 15:00", ListAliados[6].getNome());
                            }
                            else if (rdb02TardeC.Checked)
                            {
                                lst2.WriteLine("Aliadas Visitadas:");
                                lst2.WriteLine("{0}:15:30 ás 15:40", ListAliados[1].getNome());
                                lst2.WriteLine("{0}:15:40 ás 15:50", ListAliados[2].getNome());
                                lst2.WriteLine("{0}:15:50 ás 16:00", ListAliados[3].getNome());
                                lst2.WriteLine("{0}:16:00 ás 16:10", ListAliados[4].getNome());
                                lst2.WriteLine("{0}:16:10 ás 16:20", ListAliados[5].getNome());
                                lst2.WriteLine("{0}:16:20 ás 16:30", ListAliados[6].getNome());
                            }
                            break;
                        case "Noite":
                            if (rdb01NoiteC.Checked)
                            {
                                lst2.WriteLine("Aliadas Visitadas:");
                                lst2.WriteLine("{0}:17:30 ás 17:40", ListAliados[1].getNome());
                                lst2.WriteLine("{0}:17:40 ás 17:50", ListAliados[2].getNome());
                                lst2.WriteLine("{0}:17:50 ás 18:00", ListAliados[3].getNome());
                                lst2.WriteLine("{0}:18:00 ás 18:10", ListAliados[4].getNome());
                                lst2.WriteLine("{0}:18:10 ás 18:20", ListAliados[5].getNome());
                                lst2.WriteLine("{0}:18:20 ás 18:30", ListAliados[6].getNome());
                                lst2.WriteLine("{0}:18:30 ás 18:40", ListAliados[7].getNome());
                                lst2.WriteLine("{0}:18:40 ás 18:50", ListAliados[8].getNome());
                                lst2.WriteLine("{0}:18:50 ás 19:00", ListAliados[9].getNome());
                            }
                            else if (rdb02NoiteC.Checked)
                            {
                                lst2.WriteLine("Aliadas Visitadas:");
                                lst2.WriteLine("{0}:19:30 ás 19:40", ListAliados[1].getNome());
                                lst2.WriteLine("{0}:19:40 ás 19:50", ListAliados[2].getNome());
                                lst2.WriteLine("{0}:19:50 ás 20:00", ListAliados[3].getNome());
                                lst2.WriteLine("{0}:20:00 ás 20:10", ListAliados[4].getNome());
                                lst2.WriteLine("{0}:20:10 ás 20:20", ListAliados[5].getNome());
                                lst2.WriteLine("{0}:20:20 ás 20:30", ListAliados[6].getNome());
                                lst2.WriteLine("{0}:20:30 ás 20:40", ListAliados[7].getNome());
                                lst2.WriteLine("{0}:20:40 ás 20:50", ListAliados[8].getNome());
                                lst2.WriteLine("{0}:20:50 ás 21:00", ListAliados[9].getNome());
                            }
                            else if (rdb03NoiteC.Checked)
                            {
                                lst2.WriteLine("Aliadas Visitadas:");
                                lst2.WriteLine("{0}:21:30 ás 21:40", ListAliados[1].getNome());
                                lst2.WriteLine("{0}:21:40 ás 21:50", ListAliados[2].getNome());
                                lst2.WriteLine("{0}:21:50 ás 22:00", ListAliados[3].getNome());
                                lst2.WriteLine("{0}:22:00 ás 22:10", ListAliados[4].getNome());
                                lst2.WriteLine("{0}:22:10 ás 22:20", ListAliados[5].getNome());
                                lst2.WriteLine("{0}:22:20 ás 22:30", ListAliados[6].getNome());
                                lst2.WriteLine("{0}:22:30 ás 22:40 ", ListAliados[7].getNome());
                                lst2.WriteLine("{0}:22:40 ás 22:50 ", ListAliados[8].getNome());
                                lst2.WriteLine("{0}:22:50 ás 23:00 ", ListAliados[9].getNome());
                            }
                            break;
                        case "Madrugada":
                            lst2.WriteLine("Aliadas Visitadas:");
                            lst2.WriteLine("{0}:00:00 ás 00:10", ListAliados[1].getNome());
                            lst2.WriteLine("{0}:00:10 ás 00:20", ListAliados[2].getNome());
                            lst2.WriteLine("{0}:00:20 ás 00:30", ListAliados[3].getNome());
                            lst2.WriteLine("{0}:00:30 ás 00:40", ListAliados[4].getNome());
                            lst2.WriteLine("{0}:00:40 ás 00:50", ListAliados[5].getNome());
                            lst2.WriteLine("{0}:00:50 ás 01:00", ListAliados[6].getNome());
                            lst2.WriteLine("{0}:01:00 ás 01:10 ", ListAliados[7].getNome());
                            lst2.WriteLine("{0}:01:10 ás 01:20 ", ListAliados[8].getNome());
                            lst2.WriteLine("{0}:01:30 ás 01:40 ", ListAliados[9].getNome());
                            break;

                    }
                    lst2.Close();
                    limparCampos();

                }
            }
            else { limparCampos(); }
            //desmarcar e desativar as groupBox
            grpBoxCIicoC.Visible = false;
            grpBxConfirmacao.Visible = false;
            //Ativar A caixa de texto
            txboxNmAliado.Enabled = true;
            txboxNmAliado.ReadOnly = false;
        }
        private void btnGerar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
        
   