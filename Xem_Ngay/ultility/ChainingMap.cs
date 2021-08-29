using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xem_Ngay.ultility
{
    class ChainingMap<K,V> : Map<K,List<V>>
    {
        public void add(K key, V value)
        {
            if (this.ContainsKey(key))
            {
                List<V> values = this.get(key);
                if (values == null) values = new List<V>();
                values.Add(value);
            }
            else
            {
                List<V> values = new List<V>();
                values.Add(value);
                this.add(key, values);
            }
        }
        public ChainingMap<K, V> withKV(K key, V value)
        {
            this.add(key, value);
            return this;
        }
    }
}
