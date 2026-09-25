/*
* Student ID :1690701030
* Name       :jirawat dechprom

*Section     :129A
* No.        :35
*Course     : GI113 Computer Programming (GI)
*/


namespace Lab006
//{
//  internal class Program
// {
//  static void Main(string[] args)
// {
//    int lives = 0;

// if (lives <= 0)  //ด้านในวงเล็บ ต้องมีค่าเป็น boolean
// {
//     Console.WriteLine("Game Over"); //โค้ดจะรันต่อเมื่อ if เป็นจริงเท่านั้น
// }

//2
// int coins = 110;
// int price = 100;

//  if (coins >= price)
//  {
//      Console.WriteLine("Purchased"); //รันเมื่อเป็นจริง
//   }
//   else
//   {
//     Console.WriteLine("Not enough coins"); //รันเมื่อเป็นเท็จ
//}

//3
// int score = 75;

// if (score >= 90) //ลำดับ 1 เช็ค = เท็จ
// {
//     Console.WriteLine("Rank S"); //โค๊ดไม่รัน ไม่อ่าน
// }
// else if (score >= 60) //ลำดับ 2 เช็ค = จริง
// {
//     Console.WriteLine("Rank A"); //โค๊ดรัน
// }
// else // เป็นกรณีที่ไม่ตรงกับทั้งสอง ลำดับด้านบน มีเป็นจริงแล้ว ส่วนนี้ไม่รัน
// {
//     Console.WriteLine("Rank B");
// }

//4
// bool hasKey = true; //เผู้เล่นมีกุญแจ หรือไม่

//  Console.WriteLine("your Level (1-99): ");
//  bool ok = int.TryParse(Console.ReadLine(), out int level);

// if (!ok || level < 1 || level > 99) //เช็คกรณี user  ใส่ผิด
//  {
//     Console.WriteLine("Invalid Level, please try again.");
// }
// else if (level >= 10 && hasKey) //ใส่เงื่อนไข 
// {
//     Console.WriteLine("Boss floor unlocked");
// }
// else if (level >= 5)
// {
//     Console.WriteLine("The door opens");
// }
// else
// {
//    Console.WriteLine("The door stays shut");
// }

//Console.WriteLine();

=============================================================================================================
string name = "Larb-unter";
            char rank = 'B';
            int level = 5;
            int hp = 115
            float attackPower = 30;

            Console.WriteLine("=-=-==-=-Character Status=-=-==-=-");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {hp}");
            Console.WriteLine($"Attack: {attackPower}");
            Console.WriteLine("=-=-=-==-=-=-=-=--=-=-==-=-=-=-");
            Console.WriteLine();
 
            string enemyName = "Dog monster";
            char enemyRank = 'c';
            int enemyLevel = 5;
            int enemyHP = 50;
            float enemyAttackPower = 10;

            Console.WriteLine("=-=-==-=-Enemy Status=-=-==-=-");
            Console.WriteLine($"Name: {enemyName}");
            Console.WriteLine($"Rank: {enemyRank}");
            Console.WriteLine($"Level: {enemyLevel}");
            Console.WriteLine($"HP: {enemyHP}");
            Console.WriteLine($"Attack: {enemyAttackPower}");
            Console.WriteLine("=-=-=-==-=-=-=-=--=-=-==-=-=-=-");
            Console.WriteLine();

            Console.WriteLine("=-=-==-=-Character Turn=-=-==-=-");
            Console.WriteLine("[1] Attack");
            Console.WriteLine("[2] Heal");
            Console.WriteLine("[3] Flee");
                       Console.Write("Choose your action: ");

            bool validChoice = int.TryParse(
                Console.ReadLine(), out int choice);

            if (!validChoice || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid input!");
            }
            else if (choice == 1)
            {
                Console.WriteLine("You attack the Dog monster!");
                enemyHP -= (int)attackPower;

                if (enemyHP < 0)
                {
                    enemyHP = 0;
                }

                Console.WriteLine($"Damage dealt: {attackPower}");
                Console.WriteLine($"Enemy HP: {enemyHP}");

                if (enemyHP == 0)
                {
                    Console.WriteLine("You defeated the enemy!");
                }
                else
                {
                    Console.WriteLine("The enemy is still alive!");
                }
            }
            else if (choice == 2)
            {
                Console.Write("Enter heal amount: ");

                bool validHeal = int.TryParse(
                    Console.ReadLine(), out int heal);

                if (!validHeal || heal <= 0)
                {
                    Console.WriteLine("Invalid heal amount!");
                }
                else if (hp >= 120)
                {
                    Console.WriteLine("HP is already full!");
                }
                else
                {
                    hp += heal;

                    if (hp > 120)
                    {
                        hp = 120;
                    }

                    Console.WriteLine("You healed yourself!");
                    Console.WriteLine($"Current HP: {hp}");
                }
            }
            else if (choice == 3)
            {
                Console.WriteLine("You escaped from the battle!");
            }

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            if (validChoice && choice != 3 && choice >= 1 && choice <= 2)
            {
                if (enemyHP <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("You defeated the enemy!");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("===== ENEMY TURN =====");
                    Console.WriteLine("Dark Slime attacks you!");

                    hp -= (int)enemyAttackPower;

                    if (hp < 0)
                    {
                        hp = 0;
                    }

                    Console.WriteLine($"Damage received: {enemyAttackPower}");
                    Console.WriteLine($"Your HP: {hp}");

                    if (hp <= 0)
                    {
                        Console.WriteLine("You have been defeated!");
                    }
                    else
                    {
                        Console.WriteLine("You survived the attack!");
                    }
                }

            }


            Console.WriteLine();
            Console.WriteLine("=-=-=-==-=-=-=-=--=-=-==-=-=-=-");
            Console.WriteLine("=-= BATTLE STATUS =-=");
            Console.WriteLine($"Player HP: {hp}");
            Console.WriteLine($"Enemy HP: {enemyHP}");
            Console.WriteLine("=-=-=-==-=-=-=-=--=-=-==-=-=-=-");





        }
    }
}


