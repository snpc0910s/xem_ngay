using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xem_Ngay.ultility
{
    public class MapRangeCircle<T> // map biểu diễn các cung hình tròn 360 độ
    {
        private MapRangeDouble<int> circle;
        private Map<int, T> mapSavePosition; // tránh trùng lặp giá trị ở key circle
        private int rangeMapSavePosition;

        public MapRangeCircle()
        {
            this.rangeMapSavePosition = 0;
            this.mapSavePosition = new Map<int, T>();
            this.circle = new MapRangeDouble<int>();
        }
        public void add(T value, double toaDo1, double toaDo2)
        {
            this.rangeMapSavePosition++;
            // save key 
            this.mapSavePosition.add(this.rangeMapSavePosition, value);
            // value là duy nhất
            this.circle.add(this.rangeMapSavePosition, toaDo1,toaDo2);
        }
        public void addRemoveEpsilon(T value, double toaDo1, double toaDo2, double epsilon)
        {
            this.rangeMapSavePosition++;
            // save key 
            this.mapSavePosition.add(this.rangeMapSavePosition, value);
            if ((toaDo1 + epsilon) > 360) toaDo1 = (toaDo1 + epsilon) - 360;
            if ((toaDo2 - epsilon) < 0) toaDo2 = 360 + (toaDo2 - epsilon);
            // value là duy nhất
            this.circle.add(this.rangeMapSavePosition, toaDo1 + epsilon, toaDo2 - epsilon);
        }
        public MapRangeCircle<T> with(T value, double toaDo1, double toaDo2)
        {
            this.add(value, toaDo1, toaDo2);
            return this;
        }
        public MapRangeCircle<T> withRemoveEpsilon(T value, double toaDo1, double toaDo2, double epsilon)
        {
            this.addRemoveEpsilon(value, toaDo1, toaDo2,epsilon);
            return this;
        }
        public MapRangeCircle<T> withListKey(List<T> listKey, double pointStart)
        {
            int allkey = listKey.Count;
            double range = 360*1.0 / allkey; // vd 24 son huong thi co 15 do 1 cung
            for (int i = 0; i < allkey; i++)
            {
                T value = listKey[i];
                double toaDo1 = pointStart;
                double toaDo2 = pointStart + range;
                if (toaDo2 > 360) toaDo2 = toaDo2 - 360;
                this.add(value, toaDo1, toaDo2);
                pointStart = toaDo2;
            }
            return this;
        }
        public MapRangeCircle<T> withListKeyRemoveEpsilon(List<T> listKey, double pointStart, double epsilon)
        {
            int allkey = listKey.Count;
            double range = 360*1.0 / allkey; // vd 24 son huong thi co 15 do 1 cung
            for(int i = 0; i < allkey; i++)
            {
                T value = listKey[i];
                double toaDo1 = pointStart;
                double toaDo2 = pointStart + range;
                if (toaDo2 > 360) toaDo2 = toaDo2 - 360;
                this.addRemoveEpsilon(value, toaDo1, toaDo2, epsilon);
                pointStart = toaDo2;
            }

            return this;
        }
        public T getSingleValueByPosition(double toaDoCanTim)
        {
            foreach(KeyValuePair<int,Range> positonAndRange in this.circle.map)
            {
                double start = positonAndRange.Value.start;
                double end = positonAndRange.Value.end;
                if (end >= start)
                {
                    if (end >= toaDoCanTim && toaDoCanTim >= start) return mapSavePosition.get(positonAndRange.Key);
                }
                if (end < start)
                {
                    if(toaDoCanTim >= start && toaDoCanTim <= 360) return mapSavePosition.get(positonAndRange.Key);
                    if(toaDoCanTim >= 0 && toaDoCanTim <= end ) return mapSavePosition.get(positonAndRange.Key);
                }
            }
            return default(T);
        }
        public List<T> getAllValueByPosition(double toaDoCanTim)
        {
            List<T> result = new List<T>();
            foreach (KeyValuePair<int, Range> positonAndRange in this.circle.map)
            {
                double start = positonAndRange.Value.start;
                double end = positonAndRange.Value.end;
                if (end >= start)
                {
                    if (end >= toaDoCanTim && toaDoCanTim >= start) result.Add(mapSavePosition.get(positonAndRange.Key));
                }
                if (end < start)
                {
                    if (toaDoCanTim >= start && toaDoCanTim <= 360) result.Add(mapSavePosition.get(positonAndRange.Key));
                    if (toaDoCanTim >= 0 && toaDoCanTim <= end) result.Add(mapSavePosition.get(positonAndRange.Key));
                }
            }
            return result;
        }
    }
}
