using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public static class Combat
{

    public static void TestFightMode(Player player, Enemy enemy)
    {

        string enemyDamage = "";
        string playerDamage = "";
        string playerHealing = "";

        while (true)
        {
            enemyDamage = "";
            playerDamage = "";
            Console.CursorVisible = false;
            Console.Clear();

            //HP        Skriv ut Hp och "gubbar" i början av loopen
            Console.SetCursorPosition(0, 0);  //Rad, Kolumn
            HealthBar.PrintPlayerHealthBar(player);
            Console.SetCursorPosition(0, 1);
            player.ShowHp();    //Ska uppdateras

            Console.SetCursorPosition(30, 0);
            HealthBar.PrintEnemyHealthBar(enemy);
            Console.SetCursorPosition(30, 1);
            enemy.ShowHp();     //Ska uppdateras

            Console.WriteLine();

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
                    playerHealing = player.Heal();
                    break;
                case "3":
                    //player.Flee();
                    return;
                default:
                    break;

            }
            if (enemy.CurrentHp <= 0)   //Fixa så att enemy.CurrentHp inte kan bli lägre än 0
            {
                Clear.EnemyHp();
                Console.SetCursorPosition(30, 0); // VISAR HEALTHBAREN FÖR ATT KUNNA SE NÄR HAN E DÖD
                HealthBar.PrintEnemyHealthBar(enemy);
                Console.SetCursorPosition(30, 1);
                enemy.ShowHp();
                Console.SetCursorPosition(0, 8);
                player.EnemyKilled(enemy);  //Skriver ut skadan
                Console.WriteLine("            ");
                Console.WriteLine("            "); // FÖR ATT DÖLJA TIDIGARE TEXT
                Console.WriteLine("            ");
                Console.ReadKey();
                return;
            }
            

            if (input == "2")   //Om vi healar, uppdatera player.CurrentHp innan enemy attackerar
            {
                Clear.PlayerHp();
                Console.SetCursorPosition(0, 0);  //Rad, Kolumn
                HealthBar.PrintPlayerHealthBar(player);
                Console.SetCursorPosition(0, 1);
                player.ShowHp();

                Console.SetCursorPosition(16, 3);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(playerHealing);
                Console.ResetColor();
            }
            enemyDamage = enemy.Attack(player);

            if(input == "1")    //Vid attack
            {
                Clear.PlayerDamage();   //Rensa damagetext, och enemys hp
                Clear.EnemyHp();

                Console.SetCursorPosition(30, 0);   //Uppdatera sedan
                HealthBar.PrintEnemyHealthBar(enemy);
                Console.SetCursorPosition(30, 1);
                enemy.ShowHp();

                Console.SetCursorPosition(16, 3);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(playerDamage);
                Console.ResetColor();
            }

            //Vänta 1 sekund, och uppdatera sedan players hp och hpbar, samt enemys damage till player
            Thread.Sleep(1000);

            Clear.EnemyDamage();    //Rensa sedan damagetext och players hp
            Clear.PlayerHp();

            Console.SetCursorPosition(0, 0);       //Och uppdatera detta
            HealthBar.PrintPlayerHealthBar(player);
            Console.SetCursorPosition(0, 1);
            player.ShowHp();    


            Clear.PlayerDamage();
            Console.SetCursorPosition(16, 3);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(enemyDamage);
            Console.ResetColor();

            Thread.Sleep(1000);

        }
    }


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
                    player.CurrentHp = 100;
                    //player.Heal();
                    break;
                case "3":
                    //player.Flee();
                    return;
                default:
                    break;

            }
            if (enemy.CurrentHp <= 0)   //Fixa så att enemy.CurrentHp inte kan bli lägre än 0
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