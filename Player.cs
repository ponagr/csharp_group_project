public class Player : GameObject
{
    public int CurrentXp { get; set; }
    public int MaxXp { get; set; }
    public int Level { get; set; }
    public int Gold { get; set; }
    public Consumable HealingPot { get; set; }

    public Inventory Inventory { get; set; }
    public Weapon[] Weapon { get; set; } = new Weapon[1];
    public Helm[] Helm { get; set; } = new Helm[1];
    public Legs[] Legs { get; set; } = new Legs[1];
    public Gloves[] Gloves { get; set; } = new Gloves[1];
    public Boots[] Boots { get; set; } = new Boots[1];
    public BreastPlate[] BreastPlate { get; set; } = new BreastPlate[1];
    public Gear[] Gear { get; set; } = new Gear[6];

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
        HealingPot = new Consumable();
        Inventory = new Inventory();
    }

    public void InventoryInfo()
    {
        ShowStats();
        Console.WriteLine();
        HealingPot.ShowConsumable();
        Console.WriteLine();
        Inventory.ShowInventory();
        Console.WriteLine();
        ShowActiveGear();
        Console.WriteLine();

    }

    public void ShowActiveGear()
    {
        for (int i = 0; i < Gear.Length; i++)
        {
            if (Gear[i] != null)
            {
                Console.WriteLine($"{Gear[i].ShowGear}"); 
            }
            else
            {
                Console.WriteLine("Här var det tomt");
            }

        }
        
    }

    public void Loot(Item item)     //Lägg till Item till inventory
    {
        if (Inventory.inventory.Count < 15)
        {
            Console.WriteLine($"{Name} har lootat {item.ItemName},{item.ItemType}");
            if (item is Consumable)
            {
                if (HealingPot.Ammount < HealingPot.MaxAmmount)
                {
                    HealingPot.Ammount += 1;
                }
                else
                {
                    Console.WriteLine("Du har det maximala antalet Healing Potions redan");
                }
            }
            else
            {
                Inventory.inventory.Add(item);
            }
            
        }
        else
        {
            Console.WriteLine("Inventory är full");
        }
    }

    public void ShowXp()
    {
        Console.Write($"Level: {Level} ({CurrentXp}/{MaxXp})XP");
    }

    public string Heal()
    {
        double healAmmount;
        if (HealingPot.Ammount > 0)
        {
            double missingHealth = TotalHp - CurrentHp;     //Räkna ut hur mycket hp spelaren saknar
            // Random random = new Random();
            healAmmount = HealingPot.Healing; //50 + random.Next(0, 20);
            if (healAmmount > missingHealth)    //Om Heal är mer än spelarens saknade hp, heala till fullt, så att currentHealth inte kan bli mer än TotalHp
            {
                healAmmount = missingHealth;
            }
            CurrentHp += healAmmount;
            HealingPot.Ammount--;
            return $"+{healAmmount}HP";
        }
        else
        {
            return "Du har inga Healing Pots och kan därför inte heala dig";
        }
        
        
    }

    public string Attack(Enemy enemy)
    {
        Random random = new Random();

        double damageDone = TotalDamage + random.Next(0,15) - enemy.TotalResistance;
        enemy.CurrentHp -= damageDone;
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