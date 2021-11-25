using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_S.A.L
{
    class Aliados
    {
        private string nome;

        public Aliados(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }
        public void alterarNome(string nome)
        {
            this.nome = nome;
        }
    }
}
