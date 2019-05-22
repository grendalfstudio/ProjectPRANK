using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTAProgect
{
    class HashNode
    {
        string key;
        int data;
        HashNode next;

        public HashNode(string key, int data)
        {
            this.key = key;
            this.data = data;
            this.next = null;
        }

        public string Key
        {
            get
            {
                return key;
            }
            set
            {
                key = value;
            }
        }

        public int Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

        public HashNode Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }
    }
}
