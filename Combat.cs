using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public static class Combat
{

    public static void FightMode(Player player, Enemy enemy)
    {
        string criticalPlayer = "";
        string criticalEnemy = "";
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

            Console.SetCursorPosition(40, 0);
            HealthBar.PrintEnemyHealthBar(enemy);
            Console.SetCursorPosition(40, 1);
            enemy.ShowHp();     //Ska uppdateras

            Console.WriteLine();

            //Gubben
            Console.SetCursorPosition(0, 2);

            Textures.PrintPlayerCharacter();
            Console.SetCursorPosition(25, 2);
            Textures.PrintEnemyCharacter();




            //Menyn
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("1. Attack");
            if (player.HealingPot.Ammount == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(0, 9);
                Console.Write($"2. Heal - "); player.HealingPot.ShowItem();
                Console.ResetColor();
            }
            else
            {
                Console.SetCursorPosition(0, 9);
                Console.Write($"2. Heal - "); player.HealingPot.ShowItem();
            }
            Console.SetCursorPosition(0, 10);
            Console.WriteLine("3. Fly");
            Console.SetCursorPosition(0, 12);
            Console.Write("Input: ");


            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    playerDamage = player.Attack(enemy, out criticalPlayer);   //Skriver ut skadan // SPARAR den returnerade stringen i playerDamage
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
                Console.SetCursorPosition(40, 0); // VISAR HEALTHBAREN FÖR ATT KUNNA SE NÄR HAN E DÖD
                HealthBar.PrintEnemyHealthBar(enemy);
                Console.SetCursorPosition(40, 1);
                enemy.ShowHp();
                Console.SetCursorPosition(0, 8);
                player.EnemyKilled(enemy);  //Skriver ut skadan
                Console.WriteLine("            ");
                Console.WriteLine("            "); // FÖR ATT DÖLJA TIDIGARE TEXT
                Console.WriteLine("            ");
                Console.ReadKey(true);
                return;
            }


            if (input == "2")   //Om vi healar, uppdatera player.CurrentHp innan enemy attackerar
            {
                Clear.PlayerHp();
                Console.SetCursorPosition(0, 0);  //Rad, Kolumn
                HealthBar.PrintPlayerHealthBar(player);
                Console.SetCursorPosition(0, 1);
                player.ShowHp();

                Console.SetCursorPosition(20, 3);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(playerHealing);
                Console.ResetColor();
            }
            enemyDamage = enemy.Attack(player, out criticalEnemy);


            if (input == "1")    //Vid attack
            {
                Textures.AttackPlayerAnimation();
                Clear.PlayerDamage();   //Rensa damagetext, och enemys hp
                Clear.EnemyHp();

                Console.SetCursorPosition(40, 0);   //Uppdatera sedan
                HealthBar.PrintEnemyHealthBar(enemy);
                Console.SetCursorPosition(40, 1);
                enemy.ShowHp();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(20, 3);
                Console.WriteLine(criticalPlayer);
                Console.SetCursorPosition(20, 4);
                Console.WriteLine(playerDamage);
                Console.ResetColor();
            }

            //Vänta 1 sekund, och uppdatera sedan players hp och hpbar, samt enemys damage till player

            Thread.Sleep(500);
            Textures.AttackEnemyAnimation();
            Clear.EnemyDamage();    //Rensa sedan damagetext och players hp
            Clear.PlayerHp();

            Console.SetCursorPosition(0, 0);       //Och uppdatera detta
            HealthBar.PrintPlayerHealthBar(player);
            Console.SetCursorPosition(0, 1);
            player.ShowHp();

            Clear.PlayerDamage();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(20, 3);
            Console.WriteLine(criticalEnemy);
            Console.SetCursorPosition(20, 4);
            Console.WriteLine(enemyDamage);
            Console.ResetColor();

            Thread.Sleep(700);
        }
    }
}