using mobile_price_classification.DTree;
using System;

namespace mobile_price_classification.Dtree
{
    class DecisionNode : Node, ICloneable
    {
        public Question Question { get; private set; }
        public Node TrueBranch { get; set; }
        public Node FalseBranch { get; set; }

        public Datarow[] TrueBranchData { get; private set; }
        public Datarow[] FalseBranchData { get; private set; }
        public DecisionNode(Question q, Node trueBranch, Node falseBranch)
        {
            Question = q;
            TrueBranch = trueBranch;
            FalseBranch = falseBranch;
        }

        public DecisionNode(Question q, Datarow[] trueBranchData, Datarow[] falseBranchData)
        {
            Question = q;
            TrueBranchData = trueBranchData;
            FalseBranchData = falseBranchData;
        }

        public object Clone()
        {
            return (object)new DecisionNode(Question, TrueBranch, FalseBranch);
        }
    }
}
