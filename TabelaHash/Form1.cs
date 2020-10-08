using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;


namespace TabelaHash
{
    public partial class FrmTabelaHash : Form
    {
        public FrmTabelaHash()
        {
            InitializeComponent();
        }

        TabelaHash tbHash = new TabelaHash(20000);
        int totalArquivos;
        private void ui_btnCarregar_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                string pathaArquivo = Path.Combine(folderBrowserDialog1.SelectedPath, "entrada.txt");
                if (File.Exists(pathaArquivo))
                {
                    Thread thread = new Thread(ProcessarArquivo);
                    thread.IsBackground = true;
                    thread.Start();
                }
                else
                {
                    MessageBox.Show(this, "Arquivo de entrada não encontrado no diretório selecionado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ui_txtPalavra.Focus();
        }
        protected void ExecutarNaGUI(Action acao)
        {
            if (InvokeRequired)
            {
                BeginInvoke(acao);
            }
            else
            {
                acao();
            }
        }

        private void ProcessarArquivo()
        {
            string pathArquivo = Path.Combine(folderBrowserDialog1.SelectedPath, "entrada.txt");
            ExecutarNaGUI(() => { ui_txtDiretorio.Text = folderBrowserDialog1.SelectedPath; });
            string[] linhas = File.ReadAllLines(pathArquivo);
            totalArquivos = Convert.ToInt32(linhas[0]);
            for (int i = 1; i <= totalArquivos; i++)
            {
                pathArquivo = Path.Combine(folderBrowserDialog1.SelectedPath, linhas[i]);
                if (File.Exists(pathArquivo))
                {
                    string[] linhasArquivo = File.ReadAllLines(pathArquivo);
                    string nomeArquivo = Path.GetFileName(pathArquivo);
                    List<string> listaPalavras = new List<string>();
                    int palavrasDis = 0;
                    foreach (string linha in linhasArquivo)
                    {
                        //tira os caracteres speciais da linha, separa as palavras e converte para minisculo 
                        string[] palavras = linha.Replace(".", string.Empty).Replace("!", string.Empty).Replace("?", string.Empty).Replace(",", string.Empty).Replace(";", " ")
                            .Replace(":",string.Empty).ToLower().Split(new char[] { ' ' });

                        foreach (string palavra in palavras)
                        {
                            //valida se a string esta vazia, a primeira posição seja uma letra, e que seja no minimo 2 letras
                            if (palavra != string.Empty && (int)palavra[0] > 96 && (int)palavra[0] < 123 && palavra.Length > 1)
                            {
                                if (!listaPalavras.Contains(palavra))
                                {
                                    palavrasDis++;
                                }
                                listaPalavras.Add(palavra);
                            }
                        }
                    }
                    Application.DoEvents();
                    for (int k = 0; k < listaPalavras.Count; k++)
                    {
                        if (!tbHash.contains(listaPalavras[k]))
                        {
                            //se nao contem a chave na tabela hash, adciona-se um novo elemento na tabela
                            Node elemento = new Node(listaPalavras[k], new Arquivo(nomeArquivo, palavrasDis), totalArquivos);
                            tbHash.put(elemento);
                        }
                        else
                        {

                            if (tbHash.get(listaPalavras[k]).listaArq.Exists(x => x.nome.Equals(nomeArquivo)))
                            {
                                tbHash.get(listaPalavras[k]).listaArq.Find(x => x.nome.Equals(nomeArquivo)).ocorrencias++;
                            }
                            else
                            {
                                //ja existe esta chave na tabela mas o ultimo arquivo lido nao existe na lista de arquivos do nó;
                                tbHash.get(listaPalavras[k]).listaArq.Add(new Arquivo(nomeArquivo, palavrasDis));
                            }

                        }
                    }
                }
            }
        }

        private void ui_btnPesquisar_Click(object sender, EventArgs e)
        {
            string key = ui_txtPalavra.Text;
            ui_txtResultado.Text = string.Empty;
            key = key.ToLower();

            try
            {
                if (ui_rdbtnApenasUma.Checked && key.Contains(" "))
                {
                    ui_rdbtnPeloMenosUma.Checked = true;
                }

                //recebe um array de Documento com a relevancia e o arquivo correspondente
                List<Arquivo> listaArq = calcularRelevancia(key);

                for (int i = listaArq.Count - 1; i >= 0; i--)
                {
                    ui_txtResultado.Text += listaArq[i].nome + " - Relevancia: " + listaArq[i].relevancia + Environment.NewLine;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ui_txtPalavra.Focus();
        }

        private List<Arquivo> calcularRelevancia(string key)
        {
            //somatorio do peso
            double somaPeso = 0;

            if (ui_rdbtnApenasUma.Checked)
            {
                //seleciona a lista de arquivos que contem a chave
                List<Arquivo> listaArq = tbHash.get(key).listaArq;
                int tamLista = listaArq.Count;

                for (int i = 0; i < tamLista; i++)
                {
                    somaPeso += listaArq[i].ocorrencias * Math.Log(totalArquivos) / tamLista;
                }
                for (int i = 0; i < tamLista; i++)
                {
                    listaArq[i].relevancia = somaPeso / listaArq[i].palavrasDis;
                }
                quickSort(listaArq, 0, listaArq.Count - 1);
                return listaArq;
            }
            else
            {
                string[] palavras = key.Split(' ');
                List<Arquivo> listaArq = new List<Arquivo>();

                for (int i = 0; i < palavras.Length; i++)
                {
                    if (tbHash.contains(palavras[i]))
                    {
                        List<Arquivo> listaTemp = tbHash.get(palavras[i]).listaArq;
                        int tamLista = listaTemp.Count;

                        for (int j = 0; j < tamLista; j++)
                        {
                            somaPeso += listaTemp[j].ocorrencias * Math.Log(totalArquivos) / tamLista;
                        }

                        for (int j = 0; j < tamLista; j++)
                        {
                            listaTemp[j].relevancia = somaPeso / listaTemp[j].palavrasDis;
                            if (listaArq.Exists(x => x.nome.Equals(listaTemp[j].nome)))
                            {
                                int index = listaArq.FindIndex(x => x.nome.Equals(listaTemp[j].nome));
                                listaArq[index].relevancia += listaTemp[j].relevancia;
                            }
                            else
                            {
                                listaArq.Add(listaTemp[j]);
                            }
                        }
                    }
                    somaPeso = 0;
                }
                if (listaArq.Count == 0)
                {
                    throw new Exception("Nenhuma palavra encontrada");
                }
                quickSort(listaArq, 0, listaArq.Count - 1);
                return listaArq;
            }

        }
        private void quickSort(List<Arquivo> listaArq, int esquerda, int direita)
        {
            int i, j;
            i = esquerda;
            j = direita;
            double x = listaArq[(esquerda + direita) / 2].relevancia;
            Arquivo aux;

            while (i <= j)
            {
                while (listaArq[i].relevancia < x && i < direita)
                {
                    i++;
                }
                while (listaArq[j].relevancia > x && j > esquerda)
                {
                    j--;
                }
                if (i <= j)
                {
                    aux = listaArq[i];
                    listaArq[i] = listaArq[j];
                    listaArq[j] = aux;
                    i++;
                    j--;
                }
            }
            if (j > esquerda)
            {
                quickSort(listaArq, esquerda, j);
            }
            if (i < direita)
            {
                quickSort(listaArq, i, direita);
            }
        }
        private void ui_txtPalavra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                ui_btnPesquisar_Click(sender, e);
            }
            else
            {
                if (ui_rdbtnApenasUma.Checked && e.KeyCode == Keys.Space)
                {
                    ui_rdbtnPeloMenosUma.Checked = true;
                }
            }
        }
    }
}
