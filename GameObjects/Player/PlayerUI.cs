public static class PlayerUI
{
    public static void UI(Player player)   //Skriv ut spelarens Hp, Guld och Xp
    {
        Console.WriteLine();
        int currentLine = Console.CursorTop;
        player.ShowHp();

        Console.SetCursorPosition(15, currentLine);
        Console.ForegroundColor = ConsoleColor.Red;
        player.HealingPot.ShowItem();
        Console.ResetColor();

        Console.SetCursorPosition(40, currentLine);
        PrintColor.Yellow($"{player.Gold} {'\u00A9'}", "WriteLine");

        Console.SetCursorPosition(50, currentLine);
        ShowXp(player);

        HelpText();
    }

    public static void HelpText()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.SetCursorPosition(71, 2);
        Console.WriteLine("H - HELP  ");

        Console.SetCursorPosition(71, 4);
        Console.WriteLine("      ");
        Console.SetCursorPosition(71, 5);
        Console.WriteLine("        ");
        Console.SetCursorPosition(71, 6);
        Console.WriteLine("        ");
        Console.SetCursorPosition(71, 7);
        Console.WriteLine("         ");
        Console.SetCursorPosition(71, 8);
        Console.WriteLine("");
        Console.SetCursorPosition(71, 9);
        Console.WriteLine("             ");
        Console.SetCursorPosition(71, 10);
        Console.WriteLine("        ");

        Console.SetCursorPosition(71, 12);
        Console.WriteLine("          ");
        Console.ResetColor();
    }

    public static void ShowXp(Player player)    //Skriver ut spelarens nuvarande level och xp
    {
        PrintColor.Magenta($"Level: {player.Level} ({player.CurrentXp}/{player.MaxXp})XP", "WriteLine");
    }
    
    public static void ShowStats(Player player)     //Visa spelarens stats
    {
        Console.SetCursorPosition(0, 5);
        PrintColor.Blue($"Health: {player.TotalHp:F0}", "WriteLine");
        PrintColor.Blue($"Damage: {player.TotalDamage:F0}", "WriteLine");
        PrintColor.Blue($"Resistance: {player.TotalResistance:F0}", "WriteLine");
        PrintColor.Blue($"Agility: {player.TotalAgility:F0}", "WriteLine");
        Console.WriteLine();
    }
}