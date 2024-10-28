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

        AttackEnemyAnimation();
        player.CurrentHp -= damageDone;
        return $"<-- {damageDone} DMG";
    }


    public void AttackEnemyAnimation()
    {
        PrintEnemyHit1();
        Thread.Sleep(500);
        PrintEnemyHit2();
        Thread.Sleep(500);
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
        Console.SetCursorPosition(39, 2);
        Console.WriteLine(".        ");
        Console.SetCursorPosition(39, 3);
        Console.WriteLine("|  0    ");
        Console.SetCursorPosition(39, 4);
        Console.WriteLine("T--||-[E]  ");
        Console.SetCursorPosition(39, 5);
        Console.WriteLine("   /\\  	");
        Console.SetCursorPosition(39, 6);
        Console.WriteLine("  |  \\");
        Console.ResetColor();
        Console.WriteLine();
    }

    public static void PrintEnemyHit1()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(39, 2);
        Console.WriteLine("        ");
        Console.SetCursorPosition(39, 3);
        Console.WriteLine(" \\~  0  ");
        Console.SetCursorPosition(39, 4);
        Console.WriteLine("  T--||\\[]  ");
        Console.SetCursorPosition(39, 5);
        Console.WriteLine("     /\\  ");
        Console.SetCursorPosition(39, 6);
        Console.WriteLine("    |  \\ ");
        Console.WriteLine();
        Console.ResetColor();
    }

    public static void PrintEnemyHit2()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(39, 3);
        Console.WriteLine("      0  ");
        Console.SetCursorPosition(39, 4);
        Console.WriteLine("*--+--||\\    ");
        Console.SetCursorPosition(39, 5);
        Console.WriteLine("      /\\[]  ");
        Console.SetCursorPosition(39, 6);
        Console.WriteLine("     |  \\ ");
        Console.WriteLine();
        Console.ResetColor();
    }

    public void PrintDeadText() // Likadan fast grön eller liknande till vår gubbe?
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.SetCursorPosition(30, 2);
        Console.WriteLine("____  ____   _   ____  ");
        Console.SetCursorPosition(30, 3);
        Console.WriteLine("|| \\\\ ||    /\\\\  || \\\\ ");
        Console.SetCursorPosition(30, 4);
        Console.WriteLine("||  ||||-- //_\\\\ ||  ||");
        Console.SetCursorPosition(30, 5);
        Console.WriteLine("||_// ||__//   \\\\||_// ");

        Console.SetCursorPosition(30, 6);
        Console.WriteLine("                         "); // För att ta bort gammal text
        Console.SetCursorPosition(30, 7);
        Console.WriteLine("                         "); // --"--

        Thread.Sleep(300);
        Console.SetCursorPosition(30, 6);
        Console.WriteLine("        |          | ");

        Thread.Sleep(400);
        Console.SetCursorPosition(30, 6);
        Console.WriteLine("  |     |          | ");

        Thread.Sleep(500);
        Console.SetCursorPosition(30, 6);
        Console.WriteLine("  | |   | |        | ");

        Thread.Sleep(400);
        Console.SetCursorPosition(30, 7);
        Console.WriteLine("        |            ");

        Thread.Sleep(450);
        Console.SetCursorPosition(30, 7);
        Console.WriteLine("  |     |            ");

        Thread.Sleep(550);
        Console.SetCursorPosition(30, 7);
        Console.WriteLine("  |     |      |     ");

        Thread.Sleep(700);
        Console.SetCursorPosition(30, 8);
        Console.WriteLine("        |            ");
    }
}