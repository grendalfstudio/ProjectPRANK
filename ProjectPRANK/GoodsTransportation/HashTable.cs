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

        public void Add(string key, int value)
        {
            if (capacity >= size) return;
            else
            {
                capacity++;
                HashNode node = new HashNode(key, value);
                int x = HashFunc(key);

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
                    if (entry.Key == key)
                    {
                        entry.Data = value;
                    }
                    else
                    {
                        entry.Next = node;
                    }
                }
            }
        }

        public void Delete(string key)
        {
            int y = HashFunc(key);
            if (hashTable[y] != null)
            {
                HashNode entry = hashTable[y];
                //HashNode head = entry;
                if (entry.Key == key)
                {
                    entry = null;
                    return;
                }

                HashNode temp = entry.Next;
                while (entry.Next.Key != key)
                {
                    entry = entry.Next;
                    temp = temp.Next;
                }
                entry.Next = temp.Next;
                temp = null;
            }
        }

        public int Get(string key)
        {
            int hash = HashFunc(key);
            if (hashTable[hash] == null)
            {
                return -1;
            }
            else
            {
                HashNode entry = hashTable[hash];
                while(entry.Key != key)
                {
                    entry = entry.Next;
                }
                return entry.Data;
            }
        }
    }
}
