using GoodsTransportation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTAProgect
{
    class HashTable
    {

        HashNode[] hashTable;
        int capacity;
        int hash;
        int size;

        public HashTable(int size)
        {
            this.size = size;
            hashTable = new HashNode[size];
            for (int i = 0; i<size; i++)
            {
                hashTable[i] = null;
            }
        }

        public int HashFunc(string key)
        {
            int hash = 0;
            int i = 0;
            foreach (char c in key)
            {
                hash += c * ((int)Math.Pow(3, i));
                i++;
            }
            return Math.Abs(hash % size);
        }

        public void Add(Goods good)
        {
            if (capacity >= size) return;
            else
            {
                capacity++;
                HashNode node = new HashNode(good);
                int x = HashFunc(good.name);

                if (hashTable[x] == null)
                {
                    hashTable[x] = node;
                }
                else
                {
                    HashNode entry = hashTable[x];
                    while (entry.Next != null)
                    {
                        entry = entry.Next;
                    }
                    if (entry.Good.name == good.name)
                    {
                        entry.Good = good;
                    }
                    else
                    {
                        entry.Next = node;
                    }
                }
            }
        }

        public void Delete(Goods good)
        {
            int y = HashFunc(good.name);
            if (hashTable[y] != null)
            {
                HashNode entry = hashTable[y];
                //HashNode head = entry;
                if (entry.Good.name == good.name)
                {
                    hashTable[y] = null;
                    return;
                }

                HashNode temp = entry.Next;
                while (entry.Next.Good.name != good.name)
                {
                    entry = entry.Next;
                    temp = temp.Next;
                }
                entry.Next = temp.Next;
                temp = null;
            }
        }

        public Goods Get(Goods good)
        {
            int hash = HashFunc(good.name);
            if (hashTable[hash] == null)
            {
                return new Goods(null, 0, 0);
            }
            else
            {
                HashNode entry = hashTable[hash];
                while(entry.Good.name != good.name)
                {
                    entry = entry.Next;
                }
                return entry.Good;
            }
        }

        public List<Goods> GetAll()
        {
            for (int i = 0; i<size; i++)
            {
                if (hashTable[i] != null)
                {
                    foreach (Goods good in hashTable[i])
                    {

                    }
                }
            }
        }
    }
}
