public class Merchant
{
    public string Name { get; set; }
    public int Gold { get; set; }
    public Inventory MerchantInventory { get; set; }

    public Merchant(string name, int gold, List<Item> items)
    {
        Name = name;
        Gold = gold;
        MerchantInventory = new Inventory();
        MerchantInventory.inventory = items;
    }

    public void ShowInventory(Player player)
    {
        Console.Clear();
        Console.Write($"{Name}: ");
        PrintColor.Yellow($"{Gold}g", "WriteLine");
        Console.WriteLine();
        Console.WriteLine($"To buy:");
        Console.WriteLine();
        for (int i = 0; i < MerchantInventory.inventory.Count; i++)
        {
            if (MerchantInventory.inventory[i] is Consumable)
            {
                Console.Write($"[{i + 1}] {MerchantInventory.inventory[i].ItemType, -13} {MerchantInventory.inventory[i].ItemName,-16}");  
                PrintColor.Yellow($"{MerchantInventory.inventory[i].Price, 5}g", "WriteLine"); 
                Console.WriteLine();
            }
            else
            {
                Console.Write($"[{i + 1}] {MerchantInventory.inventory[i].ItemType, -13} {MerchantInventory.inventory[i].ItemName,-16}");  
                PrintColor.Yellow($"{MerchantInventory.inventory[i].Price, 5}g", "WriteLine"); 
                PrintColor.DarkGreen($"{MerchantInventory.inventory[i].Health, 6} Hp {MerchantInventory.inventory[i].Damage,3} Dmg {MerchantInventory.inventory[i].Resistance,3} Res {MerchantInventory.inventory[i].Agility,3} Agi", "WriteLine"); 
                Console.WriteLine();
            }
            
        }
        Console.WriteLine();
        
        Console.SetCursorPosition(45, 0);
        Console.Write($"{player.Name}: ");
        PrintColor.Yellow($"{player.Gold}g", "WriteLine");
        PlayerEquipment.ShowWornGear(player);

        Console.WriteLine("Vill du köpa eller sälja? K/S");
        var input = Console.ReadKey(true);
        if (input.Key == ConsoleKey.K)
        {
            //Be om input för att köpa
            //Buy(player);    //om vi köper nånting, player.Gold -= item.Price && Merchant.Gold += item.Price && ta bort från Merchant.inventory och lägg till i player.inventory
        }
        else if (input.Key == ConsoleKey.S)
        {
            //Hoppa till players inventory och be om input för att sälja
            //Sell(player); //om vi säljer nånting, player.Gold += item.Price/2 && Merchant.Gold -= item.Price/2 && ta bort från player.inventory och lägg till i Merchant.inventory
        }

    }
}