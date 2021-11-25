using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_S.A.L
{
    class Funcio
    {
        private string nome;
        private string aliadas;

 
        
        public Funcio(string nome,string aliadas)
        {
            this.nome = nome;
            this.aliadas = aliadas;
        }
        public void alterarAliadas(string aliadas)
        {
            this.aliadas = aliadas;
        }
        public string getNome()
        {
            return this.nome;
        }
        public string getAliadas()
        {
            return this.aliadas;
        }
    }
}
