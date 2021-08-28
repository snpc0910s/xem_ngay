using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xem_Ngay.ultility
{
    public class Map<K,V>: Dictionary<K,V>
    {
        public void add(K key, V value)
        {
            if (this.ContainsKey(key)){
                // exist -> replace
                this[key] = value;
            }else
            {
                this.Add(key, value);
            }
        }
        public Map<K, V> withValue(K key, V value) {
            this.add(key, value);
            return this;
        }
        public V get(K key)
        {
            if (this.ContainsKey(key)) {
                V result;
                bool mayBe =  this.TryGetValue(key, out result);
                if (mayBe == false) return default(V);
                return result;
            }else
            {
                throw new MissingMemberException();
            }
        }
        // suggest only raw type
        public K findFirstKeyByValue(V value)
        {
            foreach (KeyValuePair<K, V> entry in this)
            { // find first
                if (entry.Value.Equals(value)) return entry.Key;
            }
            return default(K);
        }
        // suggest only raw type
        public List<K> findAllKeyByValue(V value)
        {
            List<K> result = new List<K>();
            foreach (KeyValuePair<K, V> entry in this)
            { 
                if (entry.Value.Equals(value)) result.Add(entry.Key);
            }
            return result;
        }
    }
}
