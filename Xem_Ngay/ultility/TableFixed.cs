using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xem_Ngay.ultility
{
    public class TableFixed<R,C,V> // using when different name title
    {
        private Table<V> table;
        private Map<R, int> mappingRow;
        private Map<C, int> mappingCol;

        public TableFixed(List<R> titleRow, List<C> titleCol)
        {
            this.table = new Table<V>();
            this.mappingRow = new Map<R, int>();
            this.mappingCol = new Map<C, int>();
            // mapping title row
            int sizeTitleRow = titleRow.Count;
            int sizeTitleCol = titleCol.Count;

            for(int i = 0; i< sizeTitleRow; i++)
            {
                this.mappingRow.add(titleRow[i], i);
            }
            for(int i  = 0; i < sizeTitleCol; i++)
            {
                this.mappingCol.add(titleCol[i], i);
            }
        }
        public TableFixed(R[] titleRow, C[] titleCol)
        {
            this.table = new Table<V>();
            this.mappingRow = new Map<R, int>();
            this.mappingCol = new Map<C, int>();
            // mapping title row
            int sizeTitleRow = titleRow.Length;
            int sizeTitleCol = titleCol.Length;

            for (int i = 0; i < sizeTitleRow; i++)
            {
                this.mappingRow.add(titleRow[i], i);
            }
            for (int i = 0; i < sizeTitleCol; i++)
            {
                this.mappingCol.add(titleCol[i], i);
            }
        }
        public void add(R row, C col, V value)
        {
            if (this.mappingRow.ContainsKey(row) == false) return ;
            if (this.mappingCol.ContainsKey(col) == false) return ;
            int pRow = this.mappingRow.get(row);
            int pCol = this.mappingCol.get(col);
            this.table.add(pRow, pCol, value);
        }
        public TableFixed<R, C, V> with(R row, C col, V value)
        {
            this.add(row, col, value);
            return this;
        }
        public bool isContain(R row, C col)
        {
            if (this.mappingRow.ContainsKey(row) == false) return false;
            if (this.mappingCol.ContainsKey(col) == false) return false;
            int pRow = this.mappingRow.get(row);
            int pCol = this.mappingCol.get(col);
            return this.table.isContain(pRow,pCol);
        }
        public V getValue(R row, C col)
        {
            if (this.isContain(row, col)) {
                int pRow = this.mappingRow.get(row);
                int pCol = this.mappingCol.get(col);
                return this.table.get(pRow, pCol);
            }
            return default(V);
        }
    }
}
