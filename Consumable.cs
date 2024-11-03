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