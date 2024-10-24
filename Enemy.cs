public class Enemy : GameObject
{
    public int XpDrop = 25;
    Random random = new Random();
    public Enemy()
    {
        Name = "Enemy";
        Description = "Enemy";
        BaseHp = 75 + (random.Next(0, 25));
        TotalHp = BaseHp;
        CurrentHp = TotalHp;
        BaseDamage = 10 + (random.Next(0, 10));
        TotalDamage = BaseDamage;
        BaseResistance = 0 + (random.Next(0, 5));
        TotalResistance = BaseResistance;
        BaseAgility = 5 + (random.Next(0, 5));
        TotalAgility = BaseAgility;
        //Aggro-range
    }
    public string Attack(Player player)
    {
        double damageDone = TotalDamage - player.TotalResistance;
        player.CurrentHp -= damageDone;
        // Console.WriteLine($"{player.Name} tog {damageDone} i skada");
        return $"<-- {damageDone} DMG";
    }
    public void ShowHp()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{CurrentHp}/{TotalHp}({PercentHp:F0}%)");
        Console.ResetColor();
    }

    public static void PrintEnemyCharacter()
    {

        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(32, 2);
        Console.WriteLine(".        ");
        Console.SetCursorPosition(32, 3);
        Console.WriteLine("|  0    ");
        Console.SetCursorPosition(32, 4);
        Console.WriteLine("T--||-[E]  ");
        Console.SetCursorPosition(32, 5);
        Console.WriteLine("   /\\  	");
        Console.SetCursorPosition(32, 6);
        Console.WriteLine("  |  \\");
        Console.ResetColor();
        Console.WriteLine();

    }
}