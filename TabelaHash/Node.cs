using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelaHash
{
    class Node
    {
        public string Key;
        public List<Arquivo> listaArq = new List<Arquivo>();

        public Node(string key, Arquivo arquivo, int totalArquivos)
        {
            this.Key = key;
            listaArq.Add(arquivo);
        }

    }
}
