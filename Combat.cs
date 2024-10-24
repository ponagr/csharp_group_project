using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public static class Combat
{



    public static void FightMode(Player player, Enemy enemy)
    {
        //Position.FightMode(player, enemy);
        // Console.Clear();
        // player.ShowHp();
        // enemy.ShowHp();
        string enemyDamage = "";
        string playerDamage = "";
        while (true)
        {
            Console.Clear();

            //HP
            Console.SetCursorPosition(0, 0);  //Rad, Kolumn
            HealthBar.PrintPlayerHealthBar(player);
            Console.SetCursorPosition(0, 1);
            player.ShowHp();    //Ska uppdateras

            Console.SetCursorPosition(30, 0);
            HealthBar.PrintEnemyHealthBar(enemy);
            Console.SetCursorPosition(30, 1);
            enemy.ShowHp();     //Ska uppdateras

            Console.WriteLine();

            //Damage
            Console.SetCursorPosition(16, 3);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(playerDamage);
            Console.SetCursorPosition(16, 4);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(enemyDamage);
            Console.ResetColor();

            //Gubben
            Console.SetCursorPosition(0, 2);
            Player.PrintPlayerCharacter();
            Console.SetCursorPosition(25, 2);
            Enemy.PrintEnemyCharacter();

            //Menyn
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("1. Attack");
            Console.SetCursorPosition(0, 9);
            Console.WriteLine("2. Heal");
            Console.SetCursorPosition(0, 10);
            Console.WriteLine("3. Fly");
            Console.SetCursorPosition(0, 12);
            Console.Write("Input: ");


            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    playerDamage = player.Attack(enemy);   //Skriver ut skadan // SPARAR den returnerade stringen i playerDamage
                    break;
                case "2":
                    //player.Heal();
                    break;
                case "3":
                    //player.Flee();
                    return;
                default:
                    break;

            }

            if (enemy.CurrentHp == 0)
            {
                Console.SetCursorPosition(30, 0); // VISAR HEALTHBAREN FÖR ATT KUNNA SE NÄR HAN E DÖD
                HealthBar.PrintEnemyHealthBar(enemy);
                Console.SetCursorPosition(30, 1);
                Console.Write("  ");
                enemy.ShowHp();
                Console.SetCursorPosition(0, 8);
                player.EnemyKilled(enemy);  //Skriver ut skadan
                Console.WriteLine("            ");
                Console.WriteLine("            "); // FÖR ATT DÖLJA TIDIGARE TEXT
                Console.WriteLine("            ");
                Console.ReadKey();
                return;
            }
            enemyDamage = enemy.Attack(player);


            // Console.Clear();
            // player.ShowHp();
            // enemy.ShowHp();


        }
    }

}