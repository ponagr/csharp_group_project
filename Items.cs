
using System.Diagnostics.Contracts;
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
        PrintColor.Green($"{ItemType}: {ItemName,10}", "WriteLine");
    }

    public override void ShowStats()
    {
        PrintColor.Green($"{ItemType}: ({ItemName})  -    {Health} Hp, {Damage} Dmg, {Resistance} Res, {Agility} Agi", "WriteLine");
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
        foreach (Item item in itemList)
        {
            Console.WriteLine(item.ItemName);
        }
    }
}




