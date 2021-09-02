using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xem_Ngay.ultility
{

    // nested class ------------------
    public class Range
    {
        public double start;
        public double end;

        public Range(double start, double end)
        {
            this.start = start;
            this.end = end;
        }
    }
    class MapRangeDouble<K> // type key
    {
        public Map<K, Range> map;

        public MapRangeDouble()
        {
            this.map = new Map<K, Range>();
        }
        public void add(K key, double start, double end)
        {
            if (this.map.ContainsKey(key))
            {
                // replace
                this.map.get(key).start = start;
                this.map.get(key).end = end;
            }else
            {
                // new
                Range range = new Range(start, end);
                this.map.add(key, range);
            }
        }
        public MapRangeDouble<K> with(K key, double start, double end)
        {
            this.add(key, start, end);
            return this;
        }
    }
}
