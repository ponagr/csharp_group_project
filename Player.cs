public class Player : GameObject
{
    public int CurrentXp { get; set; }
    public int MaxXp { get; set; }
    public int Level { get; set; }
    public int Gold { get; set; }

    public Player(string name)
    {
        Name = name;
        Level = 1;
        Gold = 0;
        CurrentXp = 0;
        MaxXp = 100;
        BaseHp = 100;
        CurrentHp = BaseHp;
        BaseDamage = 20;
        BaseResistance = 5;
        BaseAgility = 10;

    }

    public void ShowXp()
    {
        Console.Write($"Level: {Level} ({CurrentXp}/{MaxXp})XP");
    }

    public string Heal()
    {
        double missingHealth = TotalHp - CurrentHp;     //Räkna ut hur mycket hp spelaren saknar
        Random random = new Random();
        double healAmmount = 50 + random.Next(0, 20);
        if (healAmmount > missingHealth)    //Om Heal är mer än spelarens saknade hp, heala till fullt, så att currentHealth inte kan bli mer än TotalHp
        {
            healAmmount = missingHealth;
        }
        CurrentHp += healAmmount;
        return $"+{healAmmount}HP";
    }

    public string Attack(Enemy enemy)
    {
        Random random = new Random();

        double damageDone = TotalDamage + random.Next(0,15) - enemy.TotalResistance;
        AttackPlayerAnimation();
        Thread.Sleep(200);

        enemy.CurrentHp -= damageDone;
        return $"DMG {damageDone} -->";
    }

    public void EnemyKilled(Enemy enemy)
    {

        enemy.PrintDeadText();

        CurrentXp += enemy.XpDrop;
        Console.SetCursorPosition(0, 8);
        // Console.WriteLine($"{enemy.Name} dog");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"+{enemy.XpDrop} XP        ");

        Console.SetCursorPosition(0, 9);
        Console.WriteLine("             \n            \n              \n          "); // För att input-text ska försvinna
        Console.ResetColor();

        if (CurrentXp >= MaxXp)
        {
            int transferXpToNextLevel = CurrentXp - MaxXp;  //Räkna ut hur mycket xp som ska överföras till nästa level
            CurrentXp = transferXpToNextLevel;
            MaxXp += 50;    //Öka xp som krävs för att gå upp till nästa level
            LevelUp();
        }
    }
    public void LevelUp()
    {
        Level++;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{Name} reached level: {Level}");
        double BaseHpAdded = BaseHp * 0.2;
        double BaseDamageAdded = BaseDamage * 0.2;
        double BaseResistanceAdded = BaseResistance * 0.2;
        double BaseAgilityAdded = BaseAgility * 0.2;
        BaseHp = BaseHp + BaseHpAdded;
        BaseDamage = BaseDamage + BaseDamageAdded;
        BaseResistance = BaseResistance + BaseResistanceAdded;
        BaseAgility = BaseAgility + BaseAgilityAdded;
        CurrentHp = BaseHp;
        Console.WriteLine($"+{BaseHpAdded:F0} Hp");
        Console.WriteLine($"+{BaseDamageAdded:F0} Damage");
        Console.WriteLine($"+{BaseResistanceAdded:F0} Resistance");
        Console.WriteLine($"+{BaseAgilityAdded:F0} Agility");
        Console.ResetColor();
    }
    public void ShowHp()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{CurrentHp}/{TotalHp}({PercentHp:F0}%)");
        Console.ResetColor();
    }

    public void ShowStats()     //Visa spelarens stats
    {   
        Console.WriteLine("\n\n");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Health: {TotalHp}");
        Console.WriteLine($"Damage: {TotalDamage}");
        Console.WriteLine($"Resistance: {TotalResistance}");
        Console.WriteLine($"Agility: {TotalAgility}");
        Console.ResetColor();
    }

    public void UI(Player player)   //Skriv ut spelarens Hp, Guld och Xp
    {
        Console.WriteLine();
        int curretLine = Console.CursorTop;
        HealthBar.PrintPlayerHealthBar(player);
        ShowHp();
        Console.SetCursorPosition(29, curretLine);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Coins: {Gold}");
        Console.SetCursorPosition(50, curretLine);
        Console.ForegroundColor = ConsoleColor.Magenta;
        ShowXp();
        Console.ResetColor();
    }

    public void AttackPlayerAnimation()
    {
        PrintPlayerHit1();
        Thread.Sleep(500);
        PrintPlayerHit2();
        Thread.Sleep(500);
    }

    public static void PrintPlayerCharacter()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("       .");
        Console.WriteLine("    0  | ");
        Console.WriteLine("[]-||--T");
        Console.WriteLine("   /\\  	");
        Console.WriteLine("  /  \\");
        Console.ResetColor();
        Console.WriteLine();
    }

    public static void PrintPlayerHit1()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(0, 2);
        Console.WriteLine("            .     ");
        Console.SetCursorPosition(0, 3);
        Console.WriteLine("     0  ~ /       ");
        Console.SetCursorPosition(0, 4);
        Console.WriteLine(" []/||--T         ");
        Console.SetCursorPosition(0, 5);
        Console.WriteLine("    /\\  	     ");
        Console.SetCursorPosition(0, 6);
        Console.WriteLine("   /  \\          ");
        Console.ResetColor();
        Console.WriteLine();
    }

    public static void PrintPlayerHit2()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(0, 2);
        Console.WriteLine("                   ");
        Console.SetCursorPosition(0, 3);
        Console.WriteLine("      0            ");
        Console.SetCursorPosition(0, 4);
        Console.WriteLine("    /||--+--*      ");
        Console.SetCursorPosition(0, 5);
        Console.WriteLine("   []/\\  	     ");
        Console.SetCursorPosition(0, 6);
        Console.WriteLine("    /  \\          ");
        Console.ResetColor();
        Console.WriteLine();
    }

}