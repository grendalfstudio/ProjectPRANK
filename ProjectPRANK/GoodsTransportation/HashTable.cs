using GoodsTransportation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTAProgect
{
    internal class HashTable
    {
        private HashNode[] hashTable;
        private int capacity;
        private int hash;
        private int size;

        public HashTable(int size)
        {
            this.size = size;
            hashTable = new HashNode[size];
            for (var i = 0; i < size; i++) hashTable[i] = null;
        }

        public int HashFunc(string key)
        {
            var hash = 0;
            var i = 0;
            foreach (var c in key)
            {
                hash += c * (int) Math.Pow(3, i);
                i++;
            }

            return Math.Abs(hash % size);
        }

        public void Add(Goods good)
        {
            if (capacity >= size)
            {
                return;
            }
            else
            {
                capacity++;
                var node = new HashNode(good);
                var x = HashFunc(good.name);

                if (hashTable[x] == null)
                {
                    hashTable[x] = node;
                }
                else
                {
                    var entry = hashTable[x];
                    while (entry.Next != null) entry = entry.Next;
                    if (entry.Good.name == good.name)
                        entry.Good = good;
                    else
                        entry.Next = node;
                }
            }
        }

        public void Delete(Goods good)
        {
            var y = HashFunc(good.name);
            if (hashTable[y] != null)
            {
                var entry = hashTable[y];
                //HashNode head = entry;
                if (entry.Good.name == good.name)
                {
                    hashTable[y] = null;
                    return;
                }

                var temp = entry.Next;
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
            var hash = HashFunc(good.name);
            if (hashTable[hash] == null)
            {
                return new Goods(null, 0, 0);
            }
            else
            {
                var entry = hashTable[hash];
                while (entry.Good.name != good.name) entry = entry.Next;
                return entry.Good;
            }
        }

        public List<Goods> GetAll()
        {
            var goods = new List<Goods>();
            for (var i = 0; i < size; i++)
                if (hashTable[i] != null)
                {
                    var node = hashTable[i];
                    while (node != null)
                    {
                        goods.Add(node.Good);
                        node = node.Next;
                    }
                }

            return goods;
        }
    }
}