namespace lab003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            // output แสดงตัวแปร
            Console.WriteLine("===== KIRIN SAVE CONVERTER ====="); 
            Console.WriteLine($"\nName: {bossName}\nRank: {rank}\nLevel: {level} / {MaxLevel}\nHP: {currentHp} / {maxHp}" +
                $"\nAttack Power: {attackPower}\nCrit Multiplier: {critMultiplier}\nIs Boss: {isBoss}");
      
            //   ทำ Implicit int -> double
            Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
            double currentHpDouble = currentHp; // Int ->> double แปลงแบบไม่ cast ได้เลย
            Console.WriteLine($"HP (double) : {currentHpDouble}");

            // ทำ  Implicit หลังการคำนานเปอรืเซ็นค์ ที่มีผลลัพธ์ทศนิยม
            Console.WriteLine("\n----- Exact HP Percent (no integer truncation)----");
            double hpPercentExact = currentHpDouble * 100 / maxHp; 
            Console.WriteLine($"HP Percent (exact) : {hpPercentExact}%");
            

        }
    }
}
