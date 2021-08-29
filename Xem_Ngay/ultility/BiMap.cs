using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xem_Ngay.ultility
{
    public class BiMap<K1,K2> // this class support for read data different type K1 , K2
    {
        private Map<K1, K2> map1; // example: <string,int>
        private Map<K2, K1> map2; // -> <int,string>

        public BiMap()
        {
            this.map1 = new Map<K1, K2>();
            this.map2 = new Map<K2, K1>();
        }
        public void add(K1 key1, K2 key2)
        {
            // neu ton tai thi khong lam gi
            if (this.isContain(key1,key2) == true) return;
            this.map1.add(key1, key2);
            this.map2.add(key2, key1);
        }
        public BiMap<K1, K2> with(K1 key1, K2 key2)
        {
            this.add(key1, key2);
            return this;
        }
        // when different type
        public K2 getByKey1(K1 value)
        {
            return this.map1.get(value);
        }
        public K1 getByKey2(K2 value)
        {
            return this.map2.get(value);
        }
        public bool isContain(K1 key1, K2 key2)
        {
            if (map1.ContainsKey(key1) || map2.ContainsKey(key2)) return true;
            return false;
        }
    }
}
