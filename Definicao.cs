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

    public partial class Definicao : Form
    {
        Thread definicao;
        public Definicao()
        {
            InitializeComponent();
        }
        public void limparCampos()
        {
            txBoxName.Text = "";
            txBoxAliadaVisi.Text = "";
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            definicao = new Thread(abrirJanela);
            definicao.SetApartmentState(ApartmentState.STA);
            definicao.Start();
            this.Close();
        }
        private void abrirJanela(object obj)
        {
            Application.Run(new Conclusao());
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            
            
            List<Funcio> listaFuncio = new List<Funcio>();
            listaFuncio.Add(new Funcio(txBoxName.Text, txBoxAliadaVisi.Text));
            
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            // Reescrevendo na lista
            using (StreamWriter lst = File.AppendText(desktop + "\\Lista_Automatica.txt"))
            {
                
                for (int i = 0; i < listaFuncio.Count; i++)
                {
                    if (rdbCP.Checked)
                    {
                        lst.WriteLine("Nick:{0} {1}", listaFuncio[i].getNome(),"[C.P]");
                    }
                    else if(rdbSP.Checked) 
                    { 
                        lst.WriteLine("Nick:{0} {1}", listaFuncio[i].getNome(),"[S.P]"); 
                    }
                    else { lst.WriteLine("Nick:{0}", listaFuncio[i].getNome()); }
                    lst.WriteLine("Aliadas visitadas:{0}", listaFuncio[i].getAliadas());
                    lst.WriteLine("-");
                    lst.WriteLine("-");
                    rdbCP.Checked = false;
                    rdbSP.Checked = false;
                }
                lst.Close();
            }
            //Função de limpar texto
            limparCampos();
            StreamReader lista = new StreamReader(desktop + "\\Lista_Automatica.txt");
            string linha;
            do
            {
                linha = lista.ReadToEnd();

                txBoxCorpoLista.Text = linha;
                linha = lista.ReadLine();
            } while (linha != null);
            lista.Close();

        }
    }
}
