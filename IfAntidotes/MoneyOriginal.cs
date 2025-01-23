namespace IfAntidotes
{
    internal class MoneyOriginal
    {
        private readonly decimal _amount;
        private readonly string _amountString;

        public MoneyOriginal(decimal amount)
        {
            _amount = amount;
            _amountString = Math.Abs(amount).ToString("C");
        }

        public override string ToString()
        {
            var formattedAmount = _amountString;
            // If logic here
            if (_amount > 0)
            {
                formattedAmount += " (credit)";
            }
            else if (_amount < 0)
            {
                formattedAmount += " (debit)";
            }
            return formattedAmount;
        }

        public void Print()
        {
            // And here
            if (_amount > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(_amountString);
                Console.ResetColor();
            }
            else if (_amount < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(_amountString);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine(_amountString);
            }
        }
    }
}
