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
        private List<R> listTitleRow;
        private Map<C, int> mappingCol;
        private List<C> listTitleCol;

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
            this.listTitleRow = titleRow;
            this.listTitleCol = titleCol;
        }
        public TableFixed(R[] titleRow, C[] titleCol)
        {
            this.table = new Table<V>();
            this.mappingRow = new Map<R, int>();
            this.mappingCol = new Map<C, int>();
            this.listTitleRow = new List<R>();
            this.listTitleCol = new List<C>();
            // mapping title row
            int sizeTitleRow = titleRow.Length;
            int sizeTitleCol = titleCol.Length;

            for (int i = 0; i < sizeTitleRow; i++)
            {
                this.mappingRow.add(titleRow[i], i);
                this.listTitleRow.Add(titleRow[i]);
            }
            for (int i = 0; i < sizeTitleCol; i++)
            {
                this.mappingCol.add(titleCol[i], i);
                this.listTitleCol.Add(titleCol[i]);
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
        public String toStringTableFixed()
        {
            StringBuilder builder = new StringBuilder();
            int n = this.listTitleRow.Count;
            int m = this.listTitleCol.Count;
            builder.Append(String.Format("{0,-10} ", "-"));
            for (int i = 0; i < n; i++)
            {
                // add title col
                builder.Append("\t" + String.Format("{0,-10} ", this.listTitleCol[i]));
                
            }
            builder.Append(Environment.NewLine);
            for (int i = 0; i < n;i++)
            {
                builder.Append( String.Format("{0,-10} ", this.listTitleRow[i]));
                for (int j = 0; j < m; j++)
                {
                    V value = this.table.get(i, j);
                    if(value == null)
                    {
                        builder.Append("\t" + String.Format("{0,-10} ", "-")); 
                        continue;
                    }
                    builder.Append("\t"+String.Format("{0,-10}", table.get(i, j)) );
                }
                builder.Append(Environment.NewLine);
            }

            return builder.ToString();
        }
    }
}
