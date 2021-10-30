using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xem_Ngay.ultility
{
    public class Table<V> // table fix name col and name row when init, suggess value String
    {
        private Map<int, Map<int, V>> table;
        private bool[,] matrixSaver;
        private int sizeRow;
        private int sizeCol;
        
        public Table()
        {
            this.table = new Map<int, Map<int, V>>();
            this.sizeRow = 100;
            this.sizeCol = 100;
            this.matrixSaver = new bool[sizeRow, sizeCol]; // default size 100*100
        }
        public void add(int pRow, int pCol , V value)
        {
            if(pRow > (this.sizeRow - 2) || pCol > (this.sizeCol -2))
            {
                this.sizeRow = pRow * 2 + 10;
                this.sizeCol = pCol * 2 + 10;
                bool[,] newMatrix = new bool[this.sizeRow, this.sizeCol];
                for (int i = 0; i < this.sizeRow; i++)
                    for (int j = 0; j < this.sizeCol; j++)
                        newMatrix[i, j] = this.matrixSaver[i, j];
                this.matrixSaver = null;
                this.matrixSaver = newMatrix;
            }

            if (this.table.ContainsKey(pRow))
            {
                // new or replace
                this.table.get(pRow).add(pCol, value);
            }
            else
            {
                // not contain row
                Map<int, V> cols = new Map<int, V>();
                cols.add(pCol, value);
                this.table.add(pRow, cols);
            }
            this.matrixSaver[pRow, pCol] = true;
        }
        public Table<V> with(int pRow, int pCol, V value)
        {
            this.add(pRow, pCol, value);
            return this;
        }
        public bool isContain(int pRow, int pCol)
        {
            return this.matrixSaver[pRow,pCol];
        }
        public V get(int pRow, int pCol)
        {
            if (this.isContain(pRow, pCol)) return this.table.get(pRow).get(pCol);
            return default(V);
        }
        public List<V> getListValueByRow(int row){
            List<V> result = new List<V>();
            if (table.ContainsKey(row))
            {
                Map<int, V> multiValues = table.get(row);
                foreach(KeyValuePair<int,V> keypair in multiValues)
                {
                    result.Add(keypair.Value);
                }
            }
            return result;
        }
    }
}
