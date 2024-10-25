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
        TotalHp = BaseHp;
        CurrentHp = TotalHp;
        BaseDamage = 20;
        TotalDamage = BaseDamage;
        BaseResistance = 5;
        TotalResistance = BaseResistance;
        BaseAgility = 10;
        TotalAgility = BaseAgility;
        // InventoryArray
    }


    public string Attack(Enemy enemy)
    {
        double damageDone = TotalDamage - enemy.TotalResistance;
        enemy.CurrentHp -= damageDone;
        //Console.WriteLine($"{enemy.Name} tog {damageDone} i skada");
        return $"DMG {damageDone} -->";
    }

    public void EnemyKilled(Enemy enemy)
    {
        CurrentXp += enemy.XpDrop;
        Console.WriteLine($"{enemy.Name} dog");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"+{enemy.XpDrop}XP  ");
        Console.ResetColor();
        if (CurrentXp >= MaxXp)
        {
            CurrentXp = 0;
            MaxXp += 50;
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
        Console.WriteLine($"+{BaseHpAdded} Hp");
        Console.WriteLine($"+{BaseDamageAdded} Damage");
        Console.WriteLine($"+{BaseResistanceAdded} Resistance");
        Console.WriteLine($"+{BaseAgilityAdded} Agility");
        Console.ResetColor();
    }
    public void ShowHp()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{CurrentHp}/{TotalHp}({PercentHp:F0}%)");
        Console.ResetColor();
    }

    public static void PrintPlayerCharacter()
    {

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("        .");
        Console.WriteLine("     0  | ");
        Console.WriteLine("[.]-||--T");
        Console.WriteLine("    /\\  	");
        Console.WriteLine("   /  \\");
        Console.ResetColor();
        Console.WriteLine();
    }

}