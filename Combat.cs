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
            Console.SetCursorPosition(0, 0);  //Rad, Kolumn
            HealthBar.PrintPlayerHealthBar(player);
            Console.SetCursorPosition(0, 1);
            player.ShowHp();    //Ska uppdateras
            
            Console.SetCursorPosition(30, 0);
            HealthBar.PrintEnemyHealthBar(enemy);
            Console.SetCursorPosition(30, 1);
            enemy.ShowHp();     //Ska uppdateras
            
            Console.WriteLine();

            Console.SetCursorPosition(30, 2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(playerDamage);
            Console.SetCursorPosition(30, 3);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(enemyDamage);
            Console.ResetColor();
            

            Console.SetCursorPosition(0, 2);
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Heal");
            Console.WriteLine("3. Fly");
            Console.SetCursorPosition(0, 6);
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
                player.EnemyKilled(enemy);  //Skriver ut skadan
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