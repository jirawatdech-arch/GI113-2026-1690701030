/*
* Student ID :1690701030
* Name       :jirawat dechprom

*Section     :129A
* No.        :
 *Course     : GI113 Computer Programming (GI)
 */





namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<SIGMA NINGA>");
            Console.WriteLine("Sigma vs. Larbmonster -- Fight Calculator");

            //User input of Sigma statats
            Console.Write("Sigma HP: ");
            bool isSigmaHp = int.TryParse(Console.ReadLine(), out int SigmaHp);
            Console.Write("SigmaAttack");
            bool isSigmaAttack = int.TryParse(Console.ReadLine(), out int SigmaAttack);
            Console.Write("SigmaDef");
            bool isSigmaDef = int.TryParse(Console.ReadLine(), out int SigmaDef);

            //User input of Larbmonster statats
            Console.Write("Larbmonster HP: ");
            bool isLarbmonsterHp = int.TryParse(Console.ReadLine(), out int LarbmonsterHp);
            Console.Write("LarbmonsterAttack");
            bool isLarbmonsterAttack = int.TryParse(Console.ReadLine(), out int LarbmonsterAttack);
            Console.Write("LarbmonsterDef");
            bool isLarbmonsterDef = int.TryParse(Console.ReadLine(), out int LarbmonsterDef);

            //Check if player input is valid
            bool allSigmaValid = isSigmaHp && isSigmaAttack && isSigmaDef;
            bool allLarbmonsterValid = isLarbmonsterHp && isLarbmonsterAttack && isLarbmonsterDef;
            Console.WriteLine($"Stat Validation : Sigma: {allSigmaValid}, Larbmonster: {allLarbmonsterValid}");
            Console.WriteLine($"[Sigma]       HP: {SigmaHp},       Attack: {SigmaAttack},       Defense: {SigmaDef}");
            Console.WriteLine($"[Larbmonster] HP: {LarbmonsterHp}, Attack: {LarbmonsterAttack}, Defense: {LarbmonsterDef}");

            //Before fighgting: Hero drink a potion (Compound assignment)
            int potionHeal = 10;
            // 1. วิธีทำที่1
            //SigmaHp = SigmaHp + potion;

            // 2. วิธีทำที่2(แนะนำ)
            SigmaHp += potionHeal;
            Console.WriteLine($"\n=> Sigma drink a potion, Healing {potionHeal} HP, Now Sigma HP: {SigmaHp}");

            //คำนวน damage normal attack (Arithmetic + Math)
            int normalDamage = Math.Max(0, SigmaAttack - LarbmonsterDef);
            Console.WriteLine($"Normal Attack deal: {normalDamage} damage");

            // คำนวน power attack(Predence ลำดับการคำนวณ คูณ ก่อนที่จะลบ)
            int powerDamage = Math.Max(0, (SigmaAttack * 2) - LarbmonsterDef);
            Console.WriteLine($"Power Attack deal: {powerDamage} damage");

            //คำนวณ Larbmonster Attack 
            int LarbmonsterDamage = Math.Max(0, LarbmonsterAttack - SigmaDef);
            Console.WriteLine($"Larbmonster Attack deal: {LarbmonsterDamage} damage");
            
            //คำนวร Cri Chance
            Random rng = new Random();
            int roll = rng.Next(1, 101); // สุ่ม cri chance 1-100
            bool isCritical = roll <= 20; // 20%
            int criDamage = normalDamage + Convert.ToInt32(isCritical) * normalDamage; // โอกาส 20% ติดคริ เลขได้1 ไม่ติดได้0
            Console.WriteLine($"Critical hit roll: {roll} (Critical: {isCritical})");
            Console.WriteLine($"Normal Attack would deal Critical: {criDamage} damage");
            








        }
    }
}
