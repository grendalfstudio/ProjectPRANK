using GoodsTransportation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTAProgect
{
    class HashNode
    {
        //string key;
        Goods good;
        HashNode next;

        public HashNode(Goods data)
        {
            this.good = data;
            this.next = null;
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
            get
            {
                return good;
            }
            set
            {
                good = value;
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
