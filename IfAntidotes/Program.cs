namespace IfAntidotes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oirginal implementation");
            Console.WriteLine();

            var creditOriginal = new MoneyOriginal(100m);
            Console.WriteLine(creditOriginal);
            creditOriginal.Print();

            var debitOriginal = new MoneyOriginal(-200m);
            Console.WriteLine(debitOriginal);
            debitOriginal.Print();

            var zeroOriginal = new MoneyOriginal(0m);
            Console.WriteLine(zeroOriginal);
            zeroOriginal.Print();

            Console.WriteLine();
            Console.WriteLine("Branch on switch");
            Console.WriteLine();

            var creditBranch = new BranchOnSwitch(100m);
            Console.WriteLine(creditBranch);
            creditBranch.Print();

            var debitBranch = new BranchOnSwitch(-200m);
            Console.WriteLine(debitBranch);
            debitBranch.Print();

            var zeroBranch = new BranchOnSwitch(0m);
            Console.WriteLine(zeroBranch);
            zeroBranch.Print();

            Console.WriteLine();
            Console.WriteLine("Down converting factories");
            Console.WriteLine();

            var creditFactories = new DownConvertingFactories(100m).GetMoney();
            Console.WriteLine(creditFactories);
            creditFactories.Print();

            var debitFactories = new DownConvertingFactories(-200m).GetMoney();
            Console.WriteLine(debitFactories);
            debitFactories.Print();

            var zeroFactories = new DownConvertingFactories(0m).GetMoney();
            Console.WriteLine(zeroFactories);
            zeroFactories.Print();

            Console.ReadKey();
        }
    }
}
