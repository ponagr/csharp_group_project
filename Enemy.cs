public class Enemy : GameObject
{
    public int XpDrop = 33;
    //Lägg till en AggroRange senare

    public Enemy()
    {
        Random random = new Random();
        Name = "Enemy";
        Description = "Enemy";
        BaseHp = 75 + random.Next(0, 25);
        CurrentHp = TotalHp;
        BaseDamage = 10 + random.Next(0, 10);
        BaseResistance = 0 + random.Next(0, 5);
        BaseAgility = 5 + random.Next(0, 5);
    }

    public string Attack(Player player)
    {
        Random random = new Random();
        double damageDone = TotalDamage + random.Next(0,10) - player.TotalResistance;
        player.CurrentHp -= damageDone;
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