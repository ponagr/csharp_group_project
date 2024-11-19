public class Consumable : Item
{
    public double Healing { get; set; }
    public int Ammount { get; set; }
    public int MaxAmmount { get; set; }
    public Consumable()
    {
        ItemName = "Healing Potion";
        ItemType = "Consumable";
        Healing = 25;
        Ammount = 5;
        MaxAmmount = 5;
        Price = 20;
    }

    public override void ShowItem()
    {
        Console.WriteLine($"Health Potions: {Ammount}/{MaxAmmount}");
    }
    public override void ShowStats(int i, Player player)
    {
        Console.WriteLine("");
    }
}