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
    }

    public static void ShowXp(Player player)    //Skriver ut spelarens nuvarande level och xp
    {
        PrintColor.Magenta($"Level: {player.Level} ({player.CurrentXp}/{player.MaxXp})XP", "WriteLine");
    }
    
    public static void ShowStats(Player player)     //Visa spelarens stats
    {
        Console.SetCursorPosition(0, 5);
        PrintColor.Blue($"Health: {player.TotalHp}", "WriteLine");
        PrintColor.Blue($"Damage: {player.TotalDamage}", "WriteLine");
        PrintColor.Blue($"Resistance: {player.TotalResistance}", "WriteLine");
        PrintColor.Blue($"Agility: {player.TotalAgility}", "WriteLine");
        Console.WriteLine();
    }
}