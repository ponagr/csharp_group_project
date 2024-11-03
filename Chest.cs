public class Chest
{
    public bool IsOpen { get; set; }
    public int Gold { get; set; }
    public List<Item> ChestLoot { get; set; } = new List<Item>();

    public Chest()
    {
        Random rnd = new Random();
        int itemsInChest = rnd.Next(1, 3);
        Random random = new Random();
        int itemIndex;
        List<Item> items = new List<Item>();
        for (int i = 0; i < itemsInChest; i++)
        {
            itemIndex = random.Next(0, Items.itemList.Count);
            items.Add(Items.itemList[itemIndex]);       //Lägger till random items från listan som innehåller alla items som finns i spelet
        }
        Random goldDrop = new Random();
        Gold = goldDrop.Next(0, 11);    //Random hur mycket guld en kista innehåller, om ens något guld alls
        ChestLoot = items;

    }

    public void PrintChest()    //Skriver ut alla items som finns i en kista, anropas via player.Loot-metod
    {
        foreach (Item item in ChestLoot)
        {
            if (item is Consumable)
            {
                PrintColor.Red($"{item.ItemName}, {item.ItemType}", "WriteLine");
            }
            else
            {
                PrintColor.Green($"{item.ItemName}, {item.ItemType}", "WriteLine");
            }  
        }
        if (Gold > 0)
        {
            PrintColor.Yellow($"+{Gold} Coins", "WriteLine");
        }
    }
}