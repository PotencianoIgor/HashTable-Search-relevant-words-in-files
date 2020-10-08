using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelaHash
{
    class TabelaHash
    {
        private int _size;
        private Node[] _tabelaHash;

        //gera um numero aleatorio para se calcular o hash
        double numberRand = new Random().NextDouble();
        public TabelaHash(int size)
        {
            this._size = size;
            _tabelaHash = new Node[size];
        }

        public int getSize() { return _size; }

        public Node get(string key)
        {
            int i = generateHash(key);
            if (_tabelaHash[i] != null)
            {
                return _tabelaHash[i];
            }
            throw new Exception("Palavra não encontrada");
        }

        public void put(Node element)
        {
            int i = generateHash(element.Key);
            _tabelaHash[i] = element;
        }
        public bool contains(string key)
        {
            int i = generateHash(key);
            if (_tabelaHash[i] != null)
            {
                return true;
            }
            return false;
        }
        public int hash1(int key)
        {
            double hash = (key * Math.Sqrt(2)) % _size;
            return (int)hash;
        }
        private int hash2(int key)
        {
            float hash = 2 * key % (_size - 1) + 1;
            return (int)hash;
        }
        public int generateKeyCode(string key)
        {
            int tam = key.Length;
            double valor = 0;
            for (int i = 0; i < tam; i++)
            {
                valor += ((i + 1) * (int)key[i]);
            }
            return (int)valor;
        }
        public int generateHash(string key)
        {
            int hash, codKey;
            codKey = generateKeyCode(key);
            hash = hash1(codKey);

            for (int i = 1; i < _size; i++)
            {
                if (_tabelaHash[hash] == null || _tabelaHash[hash].Key == key)
                {   //para o laço, pois nesta posição não existe elemento
                    break;
                }
                else
                {   //quando o primeiro indice não é valido itera o contador para gerar um indice novo
                    hash = (hash1(codKey) + i * hash2(codKey)) % _size;
                }
            }
            return hash;

        }
    }
}
