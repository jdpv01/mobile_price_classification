﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobile_price_classification.DTree
{
    [Serializable()]
    class Leaf : Node, ICloneable
    {
        public Datarow[] rows { get; private set; }
        public Tuple<object, int>[] predictions { get; private set; }
        public Leaf(Datarow[] rows)
        {
            this.rows = rows;
            this.predictions = DecisionTree.GetClassCounts(rows);
        }

        public override string ToString()
        {
            string message = "";
            foreach (Tuple<object, int> prediction in predictions) 
                message += $"{prediction.Item1.ToString()}";
            return message;
        }

        public object Clone()
        {
            return (object)new Leaf(this.rows);
        }
    }
}
