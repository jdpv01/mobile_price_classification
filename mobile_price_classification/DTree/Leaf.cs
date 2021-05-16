using System;

namespace mobile_price_classification.DTree
{
    class Leaf : Node
    {
        public Datarow[] Rows { get; private set; }
        public Tuple<object, int>[] Predictions { get; private set; }
        public Leaf(Datarow[] rows)
        {
            Rows = rows;
            Predictions = DecisionTree.GetClassCounts(rows);
        }

        public override string ToString()
        {
            string message = "";
            foreach (Tuple<object, int> prediction in Predictions) 
                message += $"{prediction.Item1}";
            return message;
        }

        public object Clone()
        {
            return (object)new Leaf(Rows);
        }
    }
}
