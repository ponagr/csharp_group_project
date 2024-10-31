
using System.Diagnostics.Contracts;

public static class Items 
{
    public static List<Item> itemList = new List<Item>();
    public static void AddItem(Item item) // Varför en metod för att lägga till och inte göra det direkt i ItemstoAdd?
    {
        itemList.Add(item);
    }

    public static void ItemsToAdd()
    {
        Consumable consumable = new Consumable();   //HP Pot
        THelm helm = new THelm("Plåthjälm", 5, 30, 20, 0);    //Plåthjälm
        TWeapon weapon = new TWeapon("Gimlis Yxa", "Yxa", 40, 10, 0, 20);
        TWeapon weapon1 = new TWeapon("Legolas Pilbåge", "Pilbåge", 30, 15, 5, 15);
        TLegs legs = new TLegs("Läderbyxor", 0, 20, 15, 20);
        TGloves gloves = new TGloves("Plåthandskar", 5, 30, 20, 5);
        TBoots boots = new TBoots("Foppatofflor", 0, 0, 5, -5);

        AddItem(boots);
        AddItem(helm);
        AddItem(weapon1);
        AddItem(weapon);
        AddItem(legs);
        AddItem(gloves);
        AddItem(consumable);

    }

    public static void ShowAllItems()
    {
        foreach(Item item in itemList)
        {
            Console.WriteLine(item.ItemName);
        }
    }
}
public class Inventory
{
    public List<Item> inventory { get; set; } = new List<Item>();

    public void Loot(Item item)     //Lägg till Item till inventory
    {
        if (inventory.Count < 15)
        {
            inventory.Add(item);
        }
        else
        {
            Console.WriteLine("Inventory är full");
        }
    }

    public void ShowInventory()
    {
        Console.WriteLine($"Inventory - Space: {inventory.Count}/15\n------------------------");
        if (inventory.Count > 0)
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"[{i}] {inventory[i].ItemName}, {inventory[i].ItemType}");             
            }
        }
        else
        {
            Console.WriteLine("Din inventory är tom");
        }
        
    }
    public void ShowEquipmentInventory() // Fär att visas inventory MED stats
    {
        Console.WriteLine($"Inventory - Space: {inventory.Count}/15");
        if (inventory.Count > 0)
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.Write($"[{i}] ");
                inventory[i].ShowStats();
            }
        }
        else
        {
            Console.WriteLine("Din inventory är tom");
        }
        Console.WriteLine();
    }

    public void InventoryMenu()
    {
        Console.Clear();
        ShowInventory();

        Console.WriteLine("Välj ett item för att interagera");
        int i = int.Parse(Console.ReadLine());
        
    }
}


public abstract class Item
{
    public string ItemType { get; set; }
    public string ItemName { get; set; }
    public double Damage { get; set; }
    public double Health { get; set; }
    public double Resistance { get; set; }
    public double Agility { get; set; }

    public abstract void ShowItem();
    public abstract void ShowStats();

}

public class Consumable : Item
{
    public double Healing { get; set; }
    public int Ammount { get; set; }
    public int MaxAmmount { get; set; }
    public Consumable()
    {
        ItemName = "Healing Potion";
        ItemType = "Consumable";
        Healing = 50;
        Ammount = 3;
        MaxAmmount = 5;   
    }

    public override void ShowItem()
    {
        Console.WriteLine($"Health Potions: {Ammount}/{MaxAmmount}");
    }
    public override void ShowStats()
    {
        Console.WriteLine("");
    }
}

public class Gear : Item
{
    public Gear(string name, double damage, double health, double resistance, double agility)
    {
        ItemName = name;
        Damage = damage;
        Health = health;
        Resistance = resistance;
        Agility = agility;
    }

    public override void ShowItem()
    {
        Console.WriteLine($"{ItemType}: {ItemName, 10}");
    }

    public override void ShowStats()
    {
        Console.WriteLine($"{ItemType}: ({ItemName})  -     {Health} Health, {Damage} Damage, {Resistance} Resistance, {Agility} Agility");
    }
}
public class THelm : Gear
{
    public THelm(string name, double damage, double health, double resistance, double agility)
    : base(name, damage, health, resistance, agility)
    {
        ItemType = "Helm";
    }
}
public class TBreastPlate : Gear
{
    public TBreastPlate(string name, double damage, double health, double resistance, double agility)
    : base(name, damage, health, resistance, agility)
    {
        ItemType = "Breastplate";
    }
}
public class TLegs : Gear
{
    public TLegs(string name, double damage, double health, double resistance, double agility)
    : base(name, damage, health, resistance, agility)
    {
        ItemType = "Legs";
    }
}
public class TBoots : Gear
{
    public TBoots(string name, double damage, double health, double resistance, double agility)
    : base(name, damage, health, resistance, agility)
    {
        ItemType = "Boots";
    }
}
public class TGloves : Gear
{
    public TGloves(string name, double damage, double health, double resistance, double agility)
    : base(name, damage, health, resistance, agility)
    {
        ItemType = "Gloves";
    }
}
public class TWeapon : Gear
{
    public string WeaponType { get; set; }
    public TWeapon(string name, string weaponType, double damage, double health, double resistance, double agility)
    : base(name, damage, health, resistance, agility)
    {
        WeaponType = weaponType;
        ItemType = "Weapon";
    }
}

public class Chest
{
    public List<Item> ChestLoot { get; set; } = new List<Item>();

    public Chest()
    {
        // ChestLoot = new List<Item>();
        Random rnd = new Random();
        int itemsInChest = 2; //rnd.Next(1, 3);
        Random random = new Random();
        int itemIndex;
        List<Item> items = new List<Item>();
        for (int i = 0; i < itemsInChest; i++)
        {
            itemIndex = random.Next(0, Items.itemList.Count);
            items.Add(Items.itemList[itemIndex]);
        }
        ChestLoot = items;
        
    }

    public void PrintChest()
    {
        foreach (Item item in ChestLoot)
        {
            Console.WriteLine(item.ItemName, item.ItemType);
        }
    }
}

