using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public static class Combat
{
    private static string criticalPlayer;
    private static string criticalEnemy;
    private static string enemyDamage;
    private static string playerDamage;
    private static string playerHealing;

    private static void CombatMenu(Player player, Enemy enemy)
    {
        //Menyn
        Console.SetCursorPosition(0, 11);
        Console.WriteLine("1. Attack");
        if (player.HealingPot.Ammount == 0)
        {
            Console.SetCursorPosition(0, 12);
            Console.Write($"2. Heal - ");
            Console.ForegroundColor = ConsoleColor.Red;
            player.HealingPot.ShowItem();
            Console.ResetColor();
        }
        else
        {
            Console.SetCursorPosition(0, 12);
            Console.Write($"2. Heal - ");
            Console.ForegroundColor = ConsoleColor.Green;
            player.HealingPot.ShowItem();
            Console.ResetColor();
            
        }
        Console.SetCursorPosition(0, 13);
        Console.WriteLine("3. Fly");
        Console.SetCursorPosition(0, 14);
    }

    private static void EnemyKilled(Player player, Enemy enemy)
    {
        Textures.AttackPlayerAnimation();
        Clear.Damage();
        Clear.EnemyHp();
        enemy.ShowHp();
        Console.SetCursorPosition(20, 6);
        PrintColor.Green($"{criticalPlayer}", "WriteLine");
        Console.SetCursorPosition(20, 7);
        PrintColor.Green($"{playerDamage}", "WriteLine");
        Console.SetCursorPosition(0, 11);
        player.EnemyKilled(enemy);  //Skriver ut skadan
        Console.WriteLine("            ");
        Console.WriteLine("            "); // FÖR ATT DÖLJA TIDIGARE TEXT
        Console.WriteLine("            ");
        Console.ReadKey(true);
    }

    private static void PlayerAttack(Enemy enemy)
    {
        Textures.AttackPlayerAnimation();
        Clear.Damage();   //Rensa damagetext, och enemys hp
        Clear.EnemyHp();
        enemy.ShowHp();

        Console.SetCursorPosition(20, 6);
        PrintColor.Green($"{criticalPlayer}", "WriteLine");
        Console.SetCursorPosition(20, 7);
        PrintColor.Green($"{playerDamage}", "WriteLine");
    }

    private static void EnemyAttack(Player player)
    {
        Textures.AttackEnemyAnimation();
        Clear.Damage();    //Rensa sedan damagetext och players hp
        Clear.PlayerHp();

        Console.SetCursorPosition(0, 2);       //Och uppdatera detta
        player.ShowHp();

        Clear.Damage();

        Console.SetCursorPosition(20, 6);
        PrintColor.Red($"{criticalEnemy}", "WriteLine");
        Console.SetCursorPosition(20, 7);
        PrintColor.Red(enemyDamage, "WriteLine");
    }

    private static void PlayerHeal(Player player)
    {
        Clear.PlayerHp();
        Console.SetCursorPosition(0, 2);  //Rad, Kolumn
        player.ShowHp();

        Console.SetCursorPosition(20, 7);

        PrintColor.Green($"{playerHealing}", "WriteLine");
    }

    private static void StartPosition(Player player, Enemy enemy)
    {
        Console.SetCursorPosition(0, 0);
            PrintColor.Green($"{player.Name}                   ", "Write");
            Console.Write("VS");
            PrintColor.Red($"             {enemy.Name}({enemy.Description})", "Write");
            //HP        Skriv ut Hp och "gubbar" i början av loopen
            Console.SetCursorPosition(0, 2);
            player.ShowHp();    //Ska uppdateras
            enemy.ShowHp();     //Ska uppdateras
            Console.WriteLine();

            //Gubben
            Textures.PrintPlayerCharacter(5,0);
            Console.SetCursorPosition(25, 5);
            Textures.PrintEnemyCharacter(enemy);
    }

    public static void FightMode(Player player, Enemy enemy)
    {
        criticalPlayer = "";
        criticalEnemy = "";
        enemyDamage = "";
        playerDamage = "";
        playerHealing = "";

        while (true)
        {
            Console.CursorVisible = false;
            Console.Clear();

            StartPosition(player, enemy);
            // Console.SetCursorPosition(0, 0);
            // PrintColor.Green($"{player.Name}                   ", "Write");
            // Console.Write("VS");
            // PrintColor.Red($"             {enemy.Name}({enemy.Description})", "Write");
            // //HP        Skriv ut Hp och "gubbar" i början av loopen
            // Console.SetCursorPosition(0, 2);
            // player.ShowHp();    //Ska uppdateras
            // enemy.ShowHp();     //Ska uppdateras
            // Console.WriteLine();

            // //Gubben
            // Textures.PrintPlayerCharacter(5,0);
            // Console.SetCursorPosition(25, 5);
            // Textures.PrintEnemyCharacter(enemy);

            CombatMenu(player, enemy);

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
                    return;
                default:
                    break;
            }
            if (enemy.CurrentHp < 1)   //Fixa så att enemy.CurrentHp inte kan bli lägre än 0
            {
                EnemyKilled(player, enemy);
                return;
            }

            if (input == "2")   //Om vi healar, uppdatera player.CurrentHp innan enemy attackerar
            {
                PlayerHeal(player);
            }

            enemyDamage = enemy.Attack(player, out criticalEnemy);

            if (input == "1")    //Vid attack
            {
                PlayerAttack(enemy);
            }

            Thread.Sleep(500);

            EnemyAttack(player);

            Thread.Sleep(700);

            if (player.CurrentHp < 1)
            {
                return;
            }
        }
    }
}