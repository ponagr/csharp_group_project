using System.Security.Cryptography.X509Certificates;

public static class Combat
{



    public static void FightMode(Player player, Enemy enemy)
    {
        bool isFighting = true;

        while (isFighting)
        {
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Heal");
            Console.WriteLine("3. Fly");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    player.Attack(enemy);
                    break;
                case "2":
                    //player.Heal();
                    break;
                case "3":
                    //player.Flee();
                    isFighting = false;
                    break;
                default:

                    break;

            }
            if (enemy.CurrentHp == 0)
            {
                player.EnemyKilled(enemy);
                isFighting = false;
            }
            enemy.Attack(player);



        }
    }

}