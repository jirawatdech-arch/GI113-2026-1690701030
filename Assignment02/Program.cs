/*
* Student ID :1690701030
* Name       :jirawat dechprom
* Section     :129A
* No.        :35
* Course     : GI113 Computer Programming (GI)
*/



namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double SmeltRate = 0.2500;
            const double SalvageRate = 0.3000;
            const double MaxBatch = 500;

            System.Console.WriteLine("-- Welcome to the Forge --");
            System.Console.WriteLine("Iron Smelting 0.25 / Salvage 0.3");
            System.Console.WriteLine("Key 'S' for Smelt (Ore -> Ingot)");
            System.Console.WriteLine("Key 'B' for Breakdown (Ingot -> Ore)");

            System.Console.Write("Choose menu: ");
            string menuInput = System.Console.ReadLine();
            char menu;

            if (!char.TryParse(menuInput, out menu))
            {
                System.Console.WriteLine("error: menu");
            }
            else if (menu == 'S' || menu == 's' ||
                     menu == 'B' || menu == 'b')
            {
                System.Console.Write("How much would you like: ");
                string amountInput = System.Console.ReadLine();
                double amount;

                if (!double.TryParse(amountInput,
                    System.Globalization.NumberStyles.Float,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out amount))
                {
                    System.Console.WriteLine("error: amount (parse failed)");
                }
                else if (amount <= 0 || amount > MaxBatch)
                {
                    System.Console.WriteLine("error: amount (out of range)");
                }
                else if (menu == 'S' || menu == 's')
                {
                    double result = amount * SmeltRate;
                    System.Console.WriteLine(
                        $"=> {amount:F2} Iron Ore = {result:F2} Iron Ingot");
                }
                else
                {
                    double result = amount / SalvageRate;
                    System.Console.WriteLine(
                        $"=> {amount:F2} Iron Ingot = {result:F2} Iron Ore");
                }
            }
            else
            {
                System.Console.WriteLine("-+-+-+-+error please enter an option-+-+-+-+-");
            }
        }
    }
}
