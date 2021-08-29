using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xem_Ngay.ultility
{
    public class BiMap1Type<K>
    {
        private Map<K, K> map1; // example: <string,int>
        private Map<K, K> map2; // -> <int,string>

        public BiMap1Type()
        {
            this.map1 = new Map<K, K>();
            this.map2 = new Map<K, K>();
        }
        public void add(K key1, K key2)
        {
            // neu ton tai thi khong lam gi
            if (this.isContain(key1) == false) return;
            this.map1.add(key1, key2);
            this.map2.add(key2, key1);
        }
        public BiMap1Type<K> with(K key1, K key2)
        {
            this.add(key1, key2);
            return this;
        }
        public K get(K key)
        {
            if (this.map1.ContainsKey(key)) return this.map1.get(key);
            if(this.map2.ContainsKey(key)) return this.map2.get(key);
            return default(K);
        }
        public bool isContain(K key)
        {
            if (this.map1.ContainsKey(key)) return true;
            if (this.map2.ContainsKey(key)) return true;
            return false;
        }
    }
}
