using System.ComponentModel;
using System.Formats.Asn1;
using System.Runtime.InteropServices;

public class Player : GameObject
{
    public bool isPlayer = true;
    public int CurrentXp { get; set; }
    public int MaxXp { get; set; }
    public int Level { get; set; }
    public int Gold { get; set; }
    public Consumable HealingPot { get; set; } // Vårat objekt för healingspotions
    private HealthBar healthBar;

    public double BonusAgility { get; set; }
    public double BonusHp { get; set; }
    public double BonusDamage { get; set; }
    public double BonusResistance { get; set; }
    public override double TotalHp
    {
        get { return BaseHp + BonusHp; }        //Något fel med CurrentHP efter vi har satt på oss gear, den visar rätt, men på nått sätt innehåller den mer hp än vad som skrivs
    }
    public override double TotalDamage
    {
        get { return BaseDamage + BonusDamage; }
    }
    public override double TotalAgility
    {
        get { return BaseAgility + BonusAgility; }
    }
    public override double TotalResistance
    {
        get { return BaseResistance + BonusResistance; }
    }

    public Inventory Inventory { get; set; }

    public Item[] EquippedGear { get; set; } = new Item[6];

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
        healthBar = new HealthBar();
    }

    #region HP
    public void ShowHp()    //Skriver ut en HealthBar och hp i text under
    {
        healthBar.PrintHealthBar(PercentHp, isPlayer);
        PrintColor.Green($"{CurrentHp:F0}/{TotalHp:F0}({PercentHp:F0}%)", "WriteLine");
    }
    #endregion

    #region INVENTORY
    public void OpenInventory(Player player)    //Anropar Inventory-klassens metoder
    {
        Inventory.InventoryUI(player);
    }
    #endregion

    #region LOOT
    public void Loot(Chest chest)     //Lägg till Item till inventory
    {
        Item item;
        Console.WriteLine();
        if (Inventory.inventory.Count < 15)
        {
            Console.WriteLine();
            Console.WriteLine($"{Name} har lootat:");
            chest.PrintChest();
            for (int i = 0; i < chest.ChestLoot.Count; i++)
            {
                item = chest.ChestLoot[i];
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
            Gold += chest.Gold;
        }
        else
        {
            Console.WriteLine("Inventory är full");
        }
    }
    #endregion

    #region HEAL
    public string Heal()
    {
        double healAmmount;
        if (HealingPot.Ammount > 0)
        {
            double missingHealth = TotalHp - CurrentHp;     //Räkna ut hur mycket hp spelaren saknar
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
    #endregion
    #region ATTACK
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
    #endregion
    #region XP OCH LEVELUP
    public void EnemyKilled(Enemy enemy)
    {
        CurrentXp += enemy.XpDrop;
        Console.SetCursorPosition(0, 8);
        PrintColor.DarkYellow($"+{enemy.XpDrop} XP        ", "WriteLine");

        Console.SetCursorPosition(0, 9);
        Clear.Row(9);
        Console.WriteLine("             \n            \n              \n          "); // För att input-text ska försvinna
        Console.ResetColor();
        Textures.PrintDeadText();

        if (CurrentXp >= MaxXp)
        {
            int transferXpToNextLevel = CurrentXp - MaxXp;  //Räkna ut hur mycket xp som ska överföras till nästa level
            CurrentXp = transferXpToNextLevel;
            MaxXp += 50;    //Öka xp som krävs för att gå upp till nästa level
            LevelUp();
        }
    }
    private void LevelUp()
    {
        Level++;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{Name} reached level: {Level}", "WriteLine");
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
    #endregion
}
    