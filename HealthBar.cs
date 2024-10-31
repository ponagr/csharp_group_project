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

    }



}