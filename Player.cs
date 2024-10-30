using System.Formats.Asn1;
using System.Runtime.InteropServices;

public class Player : GameObject
{
    public int CurrentXp { get; set; }
    public int MaxXp { get; set; }
    public int Level { get; set; }
    public int Gold { get; set; }
    public Consumable HealingPot { get; set; }

    public Inventory Inventory { get; set; }
    public Item[] Weapon { get; set; } = new Item[1];
    public Item[] Helm { get; set; } = new Item[1];
    public Item[] Legs { get; set; } = new Item[1];
    public Item[] Gloves { get; set; } = new Item[1];
    public Item[] Boots { get; set; } = new Item[1];
    public Item[] BreastPlate { get; set; } = new Item[1];
    public Item[] Gear { get; set; } = new Item[6];

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

    public void InventoryInfo() // NÄR VI TRYCKER C
    {
        ShowStats();
        Console.WriteLine();
        HealingPot.ShowItem();
        Console.WriteLine();
        Inventory.ShowInventory();
        Console.WriteLine();
        ShowWornGear();
        Console.WriteLine("\nTryck 'E' för att hantera equipments");
        Console.WriteLine("Tryck 'C' för att gå tillbaka");
        var keyInput = Console.ReadKey();
        if (keyInput.Key == ConsoleKey.E)
        {
            InventoryMenu();
        }
        else if (keyInput.Key == ConsoleKey.C)
        {
            return;
        }
        Console.WriteLine();

    }
    public void InventoryMenu()
    {
        Console.Clear();
        ShowWornGear();
        Console.WriteLine();
        Inventory.ShowInventory();
        

        Console.WriteLine("Välj ett item för att interagera");
        int i = int.Parse(Console.ReadLine());
        if (Inventory.inventory[i] is Gear)
        {
            // Item gear = Inventory.inventory[i]
            EquipGear(Inventory.inventory[i]);
        }
        else
        {
            Console.WriteLine("Du kan inte sätta på dig en healingpotion");
        }
         
    }

    public void CompareGear(Item itemToEquip, Item equippedItem, out Item item)
    {
        item = equippedItem;
        if (itemToEquip.Damage == equippedItem.Damage)
        {
            
        }
        else if (itemToEquip.Damage < equippedItem.Damage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            double diff = equippedItem.Damage - itemToEquip.Damage;
            Console.WriteLine($"-{diff} Damage");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            double diff = equippedItem.Damage - itemToEquip.Damage;
            Console.WriteLine($"+{diff} Damage");
            Console.ResetColor();
        }
        if (itemToEquip.Resistance == equippedItem.Resistance)
        {
            
        }
        else if (itemToEquip.Resistance < equippedItem.Resistance)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            double diff = equippedItem.Resistance - itemToEquip.Resistance;
            Console.WriteLine($"-{diff} Resistance");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            double diff = equippedItem.Resistance - itemToEquip.Resistance;
            Console.WriteLine($"+{diff} Resistance");
            Console.ResetColor();
        }
        if (itemToEquip.Health == equippedItem.Health)
        {
            
        }
        else if (itemToEquip.Health < equippedItem.Health)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            double diff = equippedItem.Health - itemToEquip.Health;
            Console.WriteLine($"-{diff} Health");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            double diff = equippedItem.Health - itemToEquip.Health;
            Console.WriteLine($"+{diff} Health");
            Console.ResetColor();
        }
        if (itemToEquip.Agility == equippedItem.Agility)
        {
            
        }
        else if (itemToEquip.Agility < equippedItem.Agility)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            double diff = equippedItem.Agility - itemToEquip.Agility;
            Console.WriteLine($"-{diff} Agility");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            double diff = equippedItem.Agility - itemToEquip.Agility;
            Console.WriteLine($"+{diff} Agility");
            Console.ResetColor();
        }

        
        Console.WriteLine("Vill du byta? J/N");
        var input = Console.ReadKey();
        if ( input.Key == ConsoleKey.J)
        {
            item = itemToEquip;
            return;
        }
        else if (input.Key == ConsoleKey.N)
        {
            return;
        }
        
    }

    public void EquipGear(Item gear)
    {
        Item item;
        for (int i = 0; i < Gear.Length; i++)
        {
            if (gear is Weapon)
            {
                if (Weapon[0] == null)
                {
                    Weapon[0] = gear;
                    Inventory.inventory.Remove(gear);
                    Console.WriteLine($"Du tog på dig {gear.ItemName}, {gear.ItemType}");
                }
                else if (Weapon[0] != null)
                {
                    CompareGear(gear, Weapon[0], out item);
                    
                    Inventory.inventory.Add(Weapon[0]);
                    Weapon[0] = item;
                    Inventory.inventory.Remove(item);
                }
                break;
            }
            if (gear is BreastPlate)
            {
                if (BreastPlate[0] == null)
                {
                    BreastPlate[0] = gear;
                    Inventory.inventory.Remove(gear);
                    Console.WriteLine($"Du tog på dig {gear.ItemName}, {gear.ItemType}");
                }
                else if (BreastPlate[0] != null)
                {
                    CompareGear(gear, BreastPlate[0], out item);
                    Inventory.inventory.Add(BreastPlate[0]);
                    BreastPlate[0] = item;
                    Inventory.inventory.Remove(item);
                }
                break;
            }
            if (gear is Legs)
            {
                if (Legs[0] == null)
                {
                    Legs[0] = gear;
                    Inventory.inventory.Remove(gear);
                    Console.WriteLine($"Du tog på dig {gear.ItemName}, {gear.ItemType}");
                }
                else if (Legs[0] != null)
                {
                    CompareGear(gear, Legs[0], out item);
                    Inventory.inventory.Add(Legs[0]);
                    Legs[0] = item;
                    Inventory.inventory.Remove(item);
                }
                break;
            }
            if (gear is Boots)
            {
                if (Boots[0] == null)
                {
                    Boots[0] = gear;
                    Inventory.inventory.Remove(gear);
                    Console.WriteLine($"Du tog på dig {gear.ItemName}, {gear.ItemType}");
                }
                else if (Boots[0] != null)
                {
                    CompareGear(gear, Boots[0], out item);
                    Inventory.inventory.Add(Boots[0]);
                    Boots[0] = item;
                    Inventory.inventory.Remove(item);
                }
                break;
            }
            if (gear is Gloves)
            {
                if (Gloves[0] == null)
                {
                    Gloves[0] = gear;
                    Inventory.inventory.Remove(gear);
                    Console.WriteLine($"Du tog på dig {gear.ItemName}, {gear.ItemType}");
                }
                else if (Gloves[0] != null)
                {
                    CompareGear(gear, Gloves[0], out item);
                    Inventory.inventory.Add(Gloves[0]);
                    Gloves[0] = item;
                    Inventory.inventory.Remove(item);
                }
                break;
            }
            if (gear is Helm)
            {
                if (Helm[0] == null)
                {
                    Helm[0] = gear;
                    Inventory.inventory.Remove(gear);
                    Console.WriteLine($"Du tog på dig {gear.ItemName}, {gear.ItemType}");
                }
                else if (Helm[0] != null)
                {
                    CompareGear(gear, Helm[0], out item);
                    Inventory.inventory.Add(Helm[0]);
                    Helm[0] = item;
                    Inventory.inventory.Remove(item);
                }
                break;
            }
        }
        return;
    }

    public void ShowWornGear()
    {
        Console.WriteLine("Worn Equipment:");
        if (Weapon[0] != null)
        {
            Weapon[0].ShowItem();
        }
        else
        {
            Console.WriteLine("Weapon: (Empty)");
        }
        if (BreastPlate[0] != null)
        {
            BreastPlate[0].ShowItem();
        }
        else
        {
            Console.WriteLine("Chest: (Empty)");
        }
        if (Helm[0] != null)
        {
            Helm[0].ShowItem();
        }
        else
        {
            Console.WriteLine("Helm: (Empty)");
        }
        if (Boots[0] != null)
        {
            Boots[0].ShowItem();
        }
        else
        {
            Console.WriteLine("Boots: (Empty)");
        }
        if (Gloves[0] != null)
        {
            Gloves[0].ShowItem();
        }
        else
        {
            Console.WriteLine("Gloves: (Empty)");
        }
        if (Legs[0] != null)
        {
            Legs[0].ShowItem();
        }
        else
        {
            Console.WriteLine("Legs: (Empty)");
        }
        
    }

    public void Loot(Item item)     //Lägg till Item till inventory
    {
        Console.WriteLine();
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
            return " ";
        }
    }

public string Attack(Enemy enemy, out string critical)
    {
        Random rndCrit = new Random();
        double damageDone;
        int critChange = Convert.ToInt32(BaseAgility); // Om Agility är 10
        int crit = rndCrit.Next(0, 101); // 0 - 10
        double damage;
        bool attackCrit = false;

        if (crit <= critChange) 
        {
            damage = TotalDamage * 1.8;
            attackCrit = true;
        }
        else
        {
            damage = TotalDamage;
        }

        Random rndDamage = new Random();
        Random rndDodge = new Random();
        int dodgeChange = Convert.ToInt32(BaseAgility);
        int dodge = rndDodge.Next(0, 101);
        if (dodge <= dodgeChange)
        {
            critical = "";
            return $"{enemy.Name} DODGED";
        }
        else if (attackCrit)
        {
            damageDone = damage + rndDamage.Next(0, 10) - enemy.TotalResistance;
            enemy.CurrentHp -= damageDone;
            critical = "CRITICAL";
            return $"{damageDone:F0} DMG -->";
        }
        else
        {
            damageDone = damage + rndDamage.Next(0, 10) - enemy.TotalResistance;
            enemy.CurrentHp -= damageDone;
            critical = "";
            return $"{damageDone:F0} DMG -->";
        }
    }

    public void EnemyKilled(Enemy enemy)
    {

        Textures.PrintDeadText();

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
        Console.WriteLine($"{CurrentHp:F0}/{TotalHp:F0}({PercentHp:F0}%)");
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
        Console.WriteLine();
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



}