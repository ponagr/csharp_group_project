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

    public void Interact(Player player)         
    {
        bool isShopping = true;
        while (isShopping)
        {

            Console.Clear();
            Console.CursorVisible = false;
            Console.Write($"{Name}: ");
            PrintColor.Yellow($"{Gold} {'\u00A9'}", "WriteLine");
            Console.WriteLine();
            
            //MerchantTexture?

            for (int i = 0; i < MerchantInventory.inventory.Count; i++)
            {
                if (MerchantInventory.inventory[i] is Consumable)
                {
                    Console.Write($"[{i + 1}] {MerchantInventory.inventory[i].ItemType, -13} {MerchantInventory.inventory[i].ItemName,-16}");  
                    PrintColor.Yellow($"{MerchantInventory.inventory[i].Price, 5} {'\u00A9'}", "WriteLine"); 
                    Console.WriteLine();
                }
                else
                {
                    Console.Write($"[{i + 1}] {MerchantInventory.inventory[i].ItemType, -13} {MerchantInventory.inventory[i].ItemName,-16}");  
                    PrintColor.Yellow($"{MerchantInventory.inventory[i].Price, 5} {'\u00A9'}", "WriteLine"); 
                    PrintColor.Blue($"{MerchantInventory.inventory[i].Health, 6} Hp {MerchantInventory.inventory[i].Damage,3} Dmg {MerchantInventory.inventory[i].Resistance,3} Res {MerchantInventory.inventory[i].Agility,3} Agi", "WriteLine"); 
                    Console.WriteLine();
                }  
            }

            Console.SetCursorPosition(45, 0);
            Console.Write($"{player.Name}: ");
            PrintColor.Yellow($"{player.Gold} {'\u00A9'}", "WriteLine");
            Console.WriteLine();
            Console.SetCursorPosition(45, 2);
            Console.ForegroundColor = ConsoleColor.Red;
            player.HealingPot.ShowItem();
            Console.ResetColor();
            PlayerEquipment.ShowWornGear(player);

            //PlayerTexture?
            Console.SetCursorPosition(45, 16);
            Console.WriteLine("Vad vill du göra?");
            Console.WriteLine();
            Console.SetCursorPosition(45, 18);
            Console.WriteLine("[Q] Handla");
            Console.SetCursorPosition(45, 19);
            Console.WriteLine("[E] Sälja");
            Console.SetCursorPosition(45, 20);
            Console.WriteLine("[C] Lämna");

            var input = Console.ReadKey(true);
            if (input.Key == ConsoleKey.Q)
            {
                Buy(player);
            }
            else if (input.Key == ConsoleKey.E)
            {
                Sell(player);
            }
            else if (input.Key == ConsoleKey.C)
            {
                isShopping = false;
            }
        }
        
    }

    // public void ShowInventory(Player player)
    // {
    //     Console.Clear();
    //     Console.Write($"{Name}: ");
    //     PrintColor.Yellow($"{Gold}g", "WriteLine");
    //     Console.WriteLine();
    //     Console.WriteLine($"To buy:");
    //     Console.WriteLine();
    //     for (int i = 0; i < MerchantInventory.inventory.Count; i++)
    //     {
    //         if (MerchantInventory.inventory[i] is Consumable)
    //         {
    //             Console.Write($"[{i + 1}] {MerchantInventory.inventory[i].ItemType, -13} {MerchantInventory.inventory[i].ItemName,-16}");  
    //             PrintColor.Yellow($"{MerchantInventory.inventory[i].Price, 5}g", "WriteLine"); 
    //             Console.WriteLine();
    //         }
    //         else
    //         {
    //             Console.Write($"[{i + 1}] {MerchantInventory.inventory[i].ItemType, -13} {MerchantInventory.inventory[i].ItemName,-16}");  
    //             PrintColor.Yellow($"{MerchantInventory.inventory[i].Price, 5}g", "WriteLine"); 
    //             PrintColor.Blue($"{MerchantInventory.inventory[i].Health, 6} Hp {MerchantInventory.inventory[i].Damage,3} Dmg {MerchantInventory.inventory[i].Resistance,3} Res {MerchantInventory.inventory[i].Agility,3} Agi", "WriteLine"); 
    //             Console.WriteLine();
    //         }  
    //     }
    //     Console.WriteLine();
        
    //     Console.SetCursorPosition(45, 0);
    //     Console.Write($"{player.Name}: ");
    //     PrintColor.Yellow($"{player.Gold}g", "WriteLine");
    //     PlayerEquipment.ShowWornGear(player);

    //     Console.WriteLine("Vill du köpa eller sälja? Q/E");
    //     var input = Console.ReadKey(true);
    //     if (input.Key == ConsoleKey.Q)
    //     {
    //         //Be om input för att köpa
    //         //Buy(player);    //om vi köper nånting, player.Gold -= item.Price && Merchant.Gold += item.Price && ta bort från Merchant.inventory och lägg till i player.inventory
    //     }
    //     else if (input.Key == ConsoleKey.E)
    //     {
    //         //Hoppa till players inventory och be om input för att sälja
    //         //Sell(player); //om vi säljer nånting, player.Gold += item.Price/2 && Merchant.Gold -= item.Price/2 && ta bort från player.inventory och lägg till i Merchant.inventory
    //     }

    // }

    public void Buy(Player player)
    {
        Console.Clear();
        Console.CursorVisible = false;
        Console.Write($"{Name}: ");
        PrintColor.Yellow($"{Gold} {'\u00A9'}", "WriteLine");
        Console.WriteLine();
        Console.WriteLine($"To buy:");
        Console.WriteLine();
        for (int i = 0; i < MerchantInventory.inventory.Count; i++)
        {
            if (MerchantInventory.inventory[i] is Consumable)
            {
                Console.Write($"[{i + 1}] {MerchantInventory.inventory[i].ItemType, -13} {MerchantInventory.inventory[i].ItemName,-16}");  
                PrintColor.Yellow($"{MerchantInventory.inventory[i].Price, 5} {'\u00A9'}", "WriteLine"); 
                Console.WriteLine();
            }
            else
            {
                Console.Write($"[{i + 1}] {MerchantInventory.inventory[i].ItemType, -13} {MerchantInventory.inventory[i].ItemName,-16}");  
                PrintColor.Yellow($"{MerchantInventory.inventory[i].Price, 5} {'\u00A9'}", "WriteLine"); 
                PrintColor.Blue($"{MerchantInventory.inventory[i].Health, 6} Hp {MerchantInventory.inventory[i].Damage,3} Dmg {MerchantInventory.inventory[i].Resistance,3} Res {MerchantInventory.inventory[i].Agility,3} Agi", "WriteLine"); 
                Console.WriteLine();
            }  
        }
        Console.WriteLine();
        
        Console.SetCursorPosition(45, 0);
        Console.Write($"{player.Name}: ");
        PrintColor.Yellow($"{player.Gold} {'\u00A9'}", "WriteLine");
        Console.SetCursorPosition(45, 2);
        Console.ForegroundColor = ConsoleColor.Red;
        player.HealingPot.ShowItem();
        Console.ResetColor();
        PlayerEquipment.ShowWornGear(player);

        Console.SetCursorPosition(45, 16);
        Console.WriteLine("Vad vill du köpa? - [C] för att lämna");
        var input = Console.ReadKey(true);
        if (input.Key == ConsoleKey.C)
        {
            return;
        }
        int itemIndex = Convert.ToInt32(input.KeyChar.ToString()) - 1;
        var itemToBuy = MerchantInventory.inventory[itemIndex];
        if (player.Gold >= itemToBuy.Price)
        {
            if (itemToBuy is Consumable)
            {
                if (player.HealingPot.Ammount < player.HealingPot.MaxAmmount)
                {
                    player.Gold -= itemToBuy.Price;
                    player.HealingPot.Ammount++;
                    Gold += itemToBuy.Price;
                    Console.SetCursorPosition(45, 18);
                    Console.WriteLine("+1 Healing Potion");
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.SetCursorPosition(45, 18);
                    Console.WriteLine("Du har det maximala antalet Healing Potions redan");
                    Thread.Sleep(1000);
                }
            }
            else
            {
                player.Gold -= itemToBuy.Price;
                Gold += itemToBuy.Price;
                player.Inventory.inventory.Add(itemToBuy);
                Console.SetCursorPosition(45, 18);
                Console.WriteLine($"Du har köpt {itemToBuy.ItemName}");
                Thread.Sleep(1000);
                
                MerchantInventory.inventory.RemoveAt(itemIndex);
                
            }
        }
        else
        {
            Console.WriteLine("Du har inte råd");
            Thread.Sleep(1000);
        }
    }

    public void Sell(Player player)
    {
        Console.Clear();
        Console.CursorVisible = false;
        Console.Write($"{Name}: ");
        PrintColor.Yellow($"{Gold}g", "WriteLine");
        Console.WriteLine();
        Console.WriteLine($"To sell:");
        Console.WriteLine();
        player.Inventory.ShowInventorySortedByPrice();
    
        Console.WriteLine();

        Console.SetCursorPosition(45, 0);
        Console.Write($"{player.Name}: ");
        PrintColor.Yellow($"{player.Gold} {'\u00A9'}", "WriteLine");
        Console.SetCursorPosition(45, 2);
        Console.ForegroundColor = ConsoleColor.Red;
        player.HealingPot.ShowItem();
        Console.ResetColor();
        PlayerEquipment.ShowWornGear(player);

        Console.SetCursorPosition(45, 16);
        Console.WriteLine("Vad vill du sälja? - [C] för att lämna");
        var input = Console.ReadKey(true);
        if (input.Key == ConsoleKey.C)
        {
            return;
        }
        int itemIndex = Convert.ToInt32(input.KeyChar.ToString()) - 1;
        var itemToSell = player.Inventory.inventory[itemIndex];

        player.Gold += itemToSell.Price / 2;
        Gold -= itemToSell.Price / 2;
        MerchantInventory.inventory.Add(itemToSell);
        Console.SetCursorPosition(45, 18);
        Console.WriteLine($"Du har sålt {itemToSell.ItemName}");
        Thread.Sleep(1000);
        
        player.Inventory.inventory.RemoveAt(itemIndex);
     
    }
}