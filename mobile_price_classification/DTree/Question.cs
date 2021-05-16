
namespace mobile_price_classification.DTree
{
    class Question
    {
        private readonly int Column;
        public object Value { get; private set; }
        public Question(int column, object value)
        {
            Column = column;
            Value = value;
        }

        private bool IsNumeric(object obj)
        {
            return (obj is double || obj is int);
        }

        public bool Match(Datarow row)
        {
            object rowValue = row[Column];
            if(IsNumeric(rowValue) && IsNumeric(Value))
            {
                return (double)rowValue >= (double)Value;
            }
            else
            {
                return (string)rowValue == (string)Value;
            }
        }
    }
}
