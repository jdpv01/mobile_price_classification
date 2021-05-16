using System;
using System.IO;

namespace mobile_price_classification.DTree
{
    class Datarow
    {
        public object[] Values { get; private set; }
        public int Count { get
            {
                return this.Values.Length;
            } }
        public Datarow(string line)
        {
            string[] lineSplit = line.Split(';');
            Values = new object[lineSplit.Length];
            for(int i = 0; i < Values.Length; i++)
            {
                if (double.TryParse(lineSplit[i], out double doubleVal))
                {
                    Values[i] = (object)doubleVal;
                }
                else if (int.TryParse(lineSplit[i], out int intVal))
                {
                    Values[i] = (object)intVal;
                }
                else
                {
                    Values[i] = (object)lineSplit[i];
                }
            }
        }


        public object this[int column]
        {
            get
            {
                if (column < Count - 1) return this.Values[column];
                else throw new IndexOutOfRangeException();
            }
            set
            {
                if (column < Count - 1) this.Values[column] = value;
                else throw new IndexOutOfRangeException();
            }
        }

        public static Datarow[] GetDatarowsFromStringArray(string[] data)
        {
            Datarow[] datarows = new Datarow[data.Length];
            for(int i = 0; i < data.Length; i++)
            {
                datarows[i] = new Datarow(data[i]);
            }
            return datarows;
        }

        public override string ToString()
        {
            string str = "";
            for(int i = 0; i < this.Values.Length; i++)
            {
                str += Values[i].ToString() + " ";
            }
            return str;
        }
    }
}
