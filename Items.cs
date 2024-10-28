public static class Items 
{
    public static List<Item> itemList = new List<Item>();
    public static void AddItem(Item item)
    {
        itemList.Add(item);
    }

    public static void ItemsToAdd()
    {
        Consumable consumable = new Consumable();   //HP Pot
        Helm helm = new Helm("Plåthjälm", 5, 30, 20, 0);    //Plåthjälm
        Weapon weapon = new Weapon("Gimlis Yxa", "Yxa", 40, 10, 0, 20);
        Weapon weapon1 = new Weapon("Legolas Pilbåge", "Pilbåge", 30, 15, 5, 15);
        Legs legs = new Legs("Läderbyxor", 0, 20, 15, 20);
        Gloves gloves = new Gloves("Plåthandskar", 5, 30, 20, 5);
        Boots boots = new Boots("Foppatofflor", 0, 0, 5, -5);

        AddItem(boots);

    }
}


public abstract class Item
{
    public string ItemType { get; set; }
    public string ItemName { get; set; }

}

public class Consumable : Item
{
    public double Healing { get; set; }
    public Consumable()
    {
        ItemName = "Healing Potion";
        ItemType = "Consumable";
        Healing = 50;
        
    }
}

public class Gear : Item
{
    public double Damage { get; set; }
    public double Health { get; set; }
    public double Resistance { get; set; }
    public double Agility { get; set; }

    public Gear(string name, double damage, double health, double resistance, double agility)
    {
        ItemName = name;
        Damage = damage;
        Health = health;
        Resistance = resistance;
        Agility = agility;
    }
}
public class Helm : Gear
{
    public Helm(string name, double damage, double health, double resistance, double agility)
    : base(name, damage, health, resistance, agility)
    {
        ItemType = "Helm";
    }
}
public class Chest : Gear
{
    public Chest(string name, double damage, double health, double resistance, double agility)
    : base(name, damage, health, resistance, agility)
    {
        ItemType = "Chest";
    }
}
public class Legs : Gear
{
    public Legs(string name, double damage, double health, double resistance, double agility)
    : base(name, damage, health, resistance, agility)
    {
        ItemType = "Legs";
    }
}
public class Boots : Gear
{
    public Boots(string name, double damage, double health, double resistance, double agility)
    : base(name, damage, health, resistance, agility)
    {
        ItemType = "Boots";
    }
}
public class Gloves : Gear
{
    public Gloves(string name, double damage, double health, double resistance, double agility)
    : base(name, damage, health, resistance, agility)
    {
        ItemType = "Gloves";
    }
}
public class Weapon : Gear
{
    public string WeaponType { get; set; }
    public Weapon(string name, string weaponType, double damage, double health, double resistance, double agility)
    : base(name, damage, health, resistance, agility)
    {
        WeaponType = weaponType;
        ItemType = "Weapon";
    }
}

