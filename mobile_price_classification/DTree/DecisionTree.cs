using mobile_price_classification.Dtree;
using System;
using System.Collections.Generic;

namespace mobile_price_classification.DTree
{
    class DecisionTree
    {
        public Datarow[] Data { get; private set; }
        public Node Root { get; private set; }
        public Stack<Node> NodesToBuild { get; private set; }

        public DecisionTree(Datarow[] data)
        {
            Data = data;
            NodesToBuild = new Stack<Node>();
        }

        private static void PrintNode(Node node, string spacing, bool status)
        {
            Console.Write(spacing);
            Console.ForegroundColor = (status) ? ConsoleColor.Green : ConsoleColor.Red;
            Console.Write("--> " + status.ToString());
            Console.ForegroundColor = ConsoleColor.Gray;
            if (node is DecisionNode)
            {
                Console.Write(" " + (node as DecisionNode).ToString());
                Console.Write("\n");
            }
            else
            {
                Console.Write(" " + (node as Leaf).ToString());
                Console.Write("\n");
            }
        }

        public void PrintTree()
        {
            string spacing = "";
            Stack<Tuple<Node, bool, string>> nodes_to_print = new Stack<Tuple<Node, bool, string>>();
            nodes_to_print.Push(new Tuple<Node, bool, string>(this.Root, true, spacing));
            while (nodes_to_print.Count > 0)
            {
                Tuple<Node, bool, string> tuple = nodes_to_print.Pop();
                PrintNode(tuple.Item1, tuple.Item3, tuple.Item2);
                if (tuple.Item1 is DecisionNode)
                {
                    spacing += "  ";
                    nodes_to_print.Push(new Tuple<Node, bool, string>((tuple.Item1 as DecisionNode).FalseBranch, false, spacing));
                    nodes_to_print.Push(new Tuple<Node, bool, string>((tuple.Item1 as DecisionNode).TrueBranch, true, spacing));
                }
            }
        }

        public Leaf Classify(Datarow row)
        {
            Node node;
            if (Root is DecisionNode) node = (Node)(Root as DecisionNode).Clone();
            else node = (Node)(Root as Leaf).Clone();

            while (!(node is Leaf))
            {
                if ((node as DecisionNode).Question.Match(row))
                    node = (node as DecisionNode).TrueBranch;
                else
                    node = (node as DecisionNode).FalseBranch;
            }
            return (Leaf)node;
        }

        public void ProcessStack()
        {
            Node node = NodesToBuild.Pop();
            if (node is DecisionNode decisionNode)
            {
                decisionNode.TrueBranch = BuildNode(decisionNode.TrueBranchData);
                decisionNode.FalseBranch = BuildNode(decisionNode.FalseBranchData);
                NodesToBuild.Push(decisionNode.TrueBranch);
                NodesToBuild.Push(decisionNode.FalseBranch);
            }
        }

        public void BuildTree()
        {
            Root = BuildNode(this.Data);
            NodesToBuild.Push(this.Root);
            while(NodesToBuild.Count > 0)
                ProcessStack();
        }

        public static Node BuildNode(Datarow[] data)
        {
            Tuple<double, Question> bestQuestionTuple = FindBestQuestion(data);
            if (bestQuestionTuple.Item1 == 0) return new Leaf(data);

            Tuple<Datarow[], Datarow[]> trueFalseRows = Partition(data, bestQuestionTuple.Item2);

            return new DecisionNode(bestQuestionTuple.Item2, trueFalseRows.Item1, trueFalseRows.Item2);
        }

        public static double Gini(Datarow[] rows)
        {
            Tuple<object, int>[] counts = GetClassCounts(rows);
            double impurity = 1.0;

            foreach(Tuple<object, int> count in counts)
            {
                double prop = (double)count.Item2 / (double)rows.Length;
                impurity -= (prop * prop);
            }

            return impurity;
        }

        public static Tuple<double, Question> FindBestQuestion(Datarow[] rows)
        {
            double bestGain = 0;
            Question bestQuestion = null;
            double uncertainty = Gini(rows);
            
            for(int i = 0; i < rows[0].Count - 1; i++)
            {
                for (int j = 0; j < rows.Length; j++)
                {
                    Question q = new Question(i, rows[j].Values[i]);

                    Tuple<Datarow[], Datarow[]> trueFalseRows = Partition(rows, q);

                    if (trueFalseRows.Item1.Length == 0 || trueFalseRows.Item2.Length == 0) continue;

                    double gain = InfoGain(trueFalseRows.Item1, trueFalseRows.Item2, uncertainty);

                    if (gain > bestGain)
                    {
                        bestGain = gain;
                        bestQuestion = q;
                    }
                }
            }
            return new Tuple<double, Question>(bestGain, bestQuestion);
        }

        public static double InfoGain(Datarow[] left, Datarow[] right, double currentUncertainty)
        {
            double p = (double)left.Length / ((double)left.Length + (double)right.Length);
            return currentUncertainty - p * Gini(left) - (1 - p) * Gini(right);
        }

        public static object[] FindUniqueValues(Datarow[] rows)
        {
            List<object> uniqueValues = new List<object>();
            for(int i = 0; i < rows.Length; i++)
            {
                object dat = rows[i].Values[rows[i].Count - 1];
                if (!uniqueValues.Contains(dat)) uniqueValues.Add(dat);
            }
            return uniqueValues.ToArray();
        }

        public static Tuple<Datarow[], Datarow[]> Partition(Datarow[] rows, Question q)
        {
            List<Datarow> trueRows = new List<Datarow>();
            List<Datarow> falseRows = new List<Datarow>();
            foreach (Datarow row in rows)
            {
                if (q.Match(row)) trueRows.Add(row);
                else falseRows.Add(row);
            }
            return new Tuple<Datarow[], Datarow[]>(trueRows.ToArray(), falseRows.ToArray());
        }

        public static Tuple<object, int>[] GetClassCounts(Datarow[] rows)
        {
            List<object> classes = new List<object>(FindUniqueValues(rows));
            int[] counts = new int[classes.Count];
            for (int i = 0; i < counts.Length; i++) counts[i] = 0;

            for (int i = 0; i < rows.Length; i++)
            {
                object dat = rows[i].Values[rows[i].Count - 1];
                if (classes.Contains(dat)) counts[classes.IndexOf(dat)] += 1;
            }
            Tuple<object, int>[] tuples = new Tuple<object, int>[classes.Count];
            for (int i = 0; i < tuples.Length; i++) tuples[i] = new Tuple<object, int>(classes[i], counts[i]);
            return tuples;
        }
    }
}
