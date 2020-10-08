using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelaHash
{
    class Arquivo
    {
        public int palavrasDis;
        public string nome;
        public int ocorrencias;
        public double relevancia;
        public Arquivo(string nome, int palavrasDis)
        {
            this.nome = nome;
            this.ocorrencias = 1;
            this.palavrasDis = palavrasDis;
            relevancia = 0;
        }
    }
}
