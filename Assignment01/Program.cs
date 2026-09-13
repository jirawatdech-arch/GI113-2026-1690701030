/*
* Student ID :1690701030
* Name       :jirawat dechprom

*Section     :129A
* No.        :
 *Course     : GI113 Computer Programming (GI)
 */







    namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "=-=-=LARB SELLER=-=-="; 


            var sellerName    = "ninga";
            var sellerRank    = 'f';
            int sellerLevel   = 1;
            float sellerMoney = 1000.00f;
            double sellerExp  = 20.7;
            bool isPlayable   = true;

            

            Console.WriteLine($"=x=x=x=x={GameTitle}=x=x=x=x=");
            Console.WriteLine("|======CHARACTER======|");
            Console.WriteLine($"sellerName          : {sellerName}");
            Console.WriteLine($"Rank                : {sellerRank}");
            Console.WriteLine($"Level               : {sellerLevel}");
            Console.WriteLine($"Money               : {sellerMoney}");
            Console.WriteLine($"Exp                 : {sellerExp}");
            Console.WriteLine($"Playable            : {isPlayable}");
            Console.WriteLine();

            double sellerLevelAsDouble = sellerLevel; 
            Console.WriteLine($"Level as double (implicit): {sellerLevelAsDouble}");

            int ExpTruncated = (int)sellerExp;               
            int sellerExpRounded = Convert.ToInt32(sellerExp);     
            Console.WriteLine($"Exp cast (truncates)       : {ExpTruncated}");
            Console.WriteLine($"Exp Convert (rounds)       : {sellerExpRounded}");


            Console.WriteLine("==================================================");

            Console.Write("Enter save name: ");
            string saveName = Console.ReadLine();
            Console.Write("Choose save slot (1-3): ");
            bool slotOk = int.TryParse(Console.ReadLine(), out int slot);
            Console.WriteLine($"Save name: {saveName}");
            Console.WriteLine($"Valid input: {slotOk}");
            Console.WriteLine($"Slot: {slot}");


        }
            }
}
