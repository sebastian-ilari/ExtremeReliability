namespace IfAntidotes
{
    internal class BranchOnSwitch
    {
        private readonly decimal _amount;
        private readonly string _amountString;

        public BranchOnSwitch(decimal amount)
        {
            _amount = amount;
            _amountString = Math.Abs(amount).ToString("C");
        }

        public override string ToString()
        {
            var formattedAmount = _amountString;
            
            switch (GetSign(_amount))
            {
                case Sign.Positive:
                    formattedAmount += " (credit)";
                    break;
                case Sign.Negative:
                    formattedAmount += " (debit)";
                    break;
                case Sign.Zero:
                    break;
            }
            
            return formattedAmount;
        }

        public void Print()
        {
            switch (GetSign(_amount))
            {
                case Sign.Positive:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(_amountString);
                    Console.ResetColor();
                    break;
                case Sign.Negative:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(_amountString);
                    Console.ResetColor();
                    break;
                case Sign.Zero:
                    Console.WriteLine(_amountString);
                    break;
            }
        }

        private static Sign GetSign(decimal amount)
        {
            // If logic centralized here
            if (amount > 0)
            {
                return Sign.Positive;
            }
            else if (amount < 0)
            {
                return Sign.Negative;
            }
            
            return Sign.Zero;
        }

        private enum Sign
        {
            Positive,
            Negative,
            Zero
        }
    }
}
