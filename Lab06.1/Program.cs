using System;

namespace Lab06._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
* Student ID :1690701030
* Name       :jirawat dechprom
* Section     :129A
* No.        :35
* Course     : GI113 Computer Programming (GI)
*/

            string name = "Larb-hunter";
            char rank = 'B';
            int level = 5;
            int hp = 115;
            float attackPower = 30f;

            Console.WriteLine("=-=-=-=-=-Character Status=-=-=-=-=");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {hp}");
            Console.WriteLine($"Attack: {attackPower}");
            Console.WriteLine("=-=-=-=-=-=--=-=-=-=-=-=--=-=-=-=-");
            Console.WriteLine();

            string enemyName = "Dog monster";
            char enemyRank = 'c';
            int enemyLevel = 5;
            int enemyHP = 50;
            float enemyAttackPower = 10f;

            Console.WriteLine("=-=-=-=-=-Enemy Status=-=-=-=-=");
            Console.WriteLine($"Name: {enemyName}");
            Console.WriteLine($"Rank: {enemyRank}");
            Console.WriteLine($"Level: {enemyLevel}");
            Console.WriteLine($"HP: {enemyHP}");
            Console.WriteLine($"Attack: {enemyAttackPower}");
            Console.WriteLine("=-=-=-=-=-=--=-=-=-=-=-=--=-=-=-=-");
            Console.WriteLine();

            Console.WriteLine("=-=-=-=-=-Character Turn=-=-=-=-=");
            Console.WriteLine("[1] Attack");
            Console.WriteLine("[2] Heal");
            Console.WriteLine("[3] Flee");
            Console.Write("Choose your action: ");

            bool validChoice = int.TryParse(Console.ReadLine(), out int choice);

            if (!validChoice || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid input!");
            }
            else if (choice == 1)
            {
                Console.WriteLine($"You attack the {enemyName}!");
                enemyHP -= (int)attackPower;

                if (enemyHP < 0)
                    enemyHP = 0;

                Console.WriteLine($"Damage dealt: {attackPower}");
                Console.WriteLine($"Enemy HP: {enemyHP}");

                if (enemyHP == 0)
                    Console.WriteLine("You defeated the enemy!");
                else
                    Console.WriteLine("The enemy is still alive!");
            }
            else if (choice == 2)
            {
                Console.Write("Enter heal amount: ");

                bool validHeal = int.TryParse(Console.ReadLine(), out int heal);

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
                        hp = 120;

                    Console.WriteLine("You healed yourself!");
                    Console.WriteLine($"Current HP: {hp}");
                }
            }
            else // choice == 3
            {
                Console.WriteLine("You escaped from the battle!");
            }

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            if (validChoice && choice != 3 && (choice == 1 || choice == 2))
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
                    Console.WriteLine($"{enemyName} attacks you!");

                    hp -= (int)enemyAttackPower;

                    if (hp < 0)
                        hp = 0;

                    Console.WriteLine($"Damage received: {enemyAttackPower}");
                    Console.WriteLine($"Your HP: {hp}");

                    if (hp <= 0)
                        Console.WriteLine("You have been defeated!");
                    else
                        Console.WriteLine("You survived the attack!");
                }

            }

            Console.WriteLine();
            Console.WriteLine("=-=-=-=-=-=--=-=-=-=-=-=--=-=-=-=-");
            Console.WriteLine("=-= BATTLE STATUS =-=");
            Console.WriteLine($"Player HP: {hp}");
            Console.WriteLine($"Enemy HP: {enemyHP}");
            Console.WriteLine("=-=-=-=-=-=--=-=-=-=-=-=--=-=-=-=-");
        }
    }
}
