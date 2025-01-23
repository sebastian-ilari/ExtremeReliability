namespace IfAntidotes
{
    internal class DownConvertingFactories
    {
        private readonly decimal _amount;
        private readonly string _amountString;

        public DownConvertingFactories(decimal amount)
        {
            _amount = amount;
            _amountString = Math.Abs(amount).ToString("C");
        }

        public DownConvertingFactories GetMoney()
        {
            // If logic centralized here
            if (_amount > 0)
            {
                return new Credit(_amount);
            }
            else if (_amount < 0)
            {
                return new Debit(_amount);
            }

            return new Zero(_amount);
        }

        public virtual void Print()
        {
        }

        private class Credit(decimal amount) : DownConvertingFactories(amount)
        {
            public override string ToString()
            {
                var formattedAmount = _amountString;
                formattedAmount += " (credit)";
                return formattedAmount;
            }

            public override void Print()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(_amountString);
                Console.ResetColor();
            }
        }

        private class Debit(decimal amount) : DownConvertingFactories(amount)
        {
            public override string ToString()
            {
                var formattedAmount = _amountString;
                formattedAmount += " (debit)";
                return formattedAmount;
            }

            public override void Print()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(_amountString);
                Console.ResetColor();
            }
        }

        private class Zero(decimal amount) : DownConvertingFactories(amount)
        {
            public override string ToString()
            {
                return _amountString;
            }

            public override void Print()
            {
                Console.WriteLine(_amountString);
            }
        }
    }
}
