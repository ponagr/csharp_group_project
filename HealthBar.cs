public class HealthBar
{
    static string[] healthBar = new string[10];

    public static void UpdateHealthBar(GameObject gameobject)
    {
        int percentHealth = Convert.ToInt32(gameobject.PercentHp);
        int healthBarAmount = percentHealth / 10 ;

        for (int i = 0; i < healthBar.Length; i++) // Loopa 10 gånger
        {
            healthBar[i] = " ";
        }

        for (int i = 0; i < healthBarAmount; i++) // Loopa 10 gånger
        {
            healthBar[i] = "|";
        }
    }

    public static void PrintPlayerHealthBar(Player player)
    {
        UpdateHealthBar(player);
        Console.Write("[");

        for (int i = 0; i < healthBar.Length; i++) // Loopa 10 gånger
        {
            if (healthBar[i] == "|")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write(healthBar[i]);
                Console.ResetColor();
            }
            else
            {
                Console.ResetColor();
                Console.Write(healthBar[i]); // Skrivs ut tomma för samma längd
            }
        }
        Console.Write("]");
        Console.WriteLine();
        // Console.ResetColor();
        // Console.ForegroundColor = ConsoleColor.Green;
        // Console.WriteLine($"HP: {player.CurrentHp}/{player.TotalHp}({player.PercentHp:F0}%)");
        // Console.ResetColor();
    }

    public static void PrintEnemyHealthBar(Enemy enemy)
    {
        UpdateHealthBar(enemy);
        Console.Write("[");

        for (int i = 0; i < healthBar.Length; i++) // Loopa 10 gånger
        {
            if (healthBar[i] == "|")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(healthBar[i]);
                Console.ResetColor();
            }
            else
            {
                Console.ResetColor();
                Console.Write(healthBar[i]); // Skrivs ut tomma för samma längd
            }
        }
        Console.Write("]");
        Console.WriteLine();
        // Console.ResetColor();
        // Console.ForegroundColor = ConsoleColor.Red;
        // Console.WriteLine($"HP: {enemy.CurrentHp}/{enemy.TotalHp}({enemy.PercentHp:F0}%)");
        // Console.ResetColor();

    }



}