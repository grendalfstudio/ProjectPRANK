using GoodsTransportation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTAProgect
{
    internal class HashNode
    {
        //string key;
        private Goods good;
        private HashNode next;

        public HashNode(Goods data)
        {
            good = data;
            next = null;
        }

        //public string Key
        //{
        //    get
        //    {
        //        return key;
        //    }
        //    set
        //    {
        //        key = value;
        //    }
        //}

        //public int Data
        //{
        //    get
        //    {
        //        return data;
        //    }
        //    set
        //    {
        //        data = value;
        //    }
        //}

        public Goods Good
        {
            get => good;
            set => good = value;
        }

        public HashNode Next
        {
            get => next;
            set => next = value;
        }
    }
}