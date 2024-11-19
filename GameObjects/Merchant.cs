public class Merchant
{
    public string Name { get; set; }
    public int Gold { get; set; }
    private bool FirstEncounter { get; set; }
    public Inventory MerchantInventory { get; set; }
    public Consumable HealingPot { get; set; }

    public Merchant(string name, int gold, List<Item> items)
    {
        Name = name;
        Gold = gold;
        MerchantInventory = new Inventory();
        Random randomItem = new Random();
        HealingPot = new Consumable();
        for (int i = 0; i < 10; i++)
        {
            MerchantInventory.inventory.Add(items[randomItem.Next(0, items.Count)]);
        }
        FirstEncounter = true;
    }

    public void ShowMerchantInventory(Player player)
    {
        Console.Write("[Q] ");
        PrintColor.Green($"{"Health Potion",-20}", "Write");
        PrintColor.Yellow($"{HealingPot.Price,13} {'\u00A9'}", "WriteLine");
        Console.WriteLine();
        for (int i = 0; i < MerchantInventory.inventory.Count; i++)
        {
            if (MerchantInventory.inventory[i].LevelCap > player.Level)
            {
                Console.Write($"[{i}] ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{MerchantInventory.inventory[i].ItemType,-7} {MerchantInventory.inventory[i].ItemName,-15}");
                Console.WriteLine($"Needs lvl: {MerchantInventory.inventory[i].LevelCap}");
                Console.ResetColor();
                Console.Write($"{MerchantInventory.inventory[i].Health,6} Hp {MerchantInventory.inventory[i].Damage,3} Dmg {MerchantInventory.inventory[i].Resistance,3} Res {MerchantInventory.inventory[i].Agility,3} Agi");
                PrintColor.Yellow($"{MerchantInventory.inventory[i].Price,4} {'\u00A9',1}", "WriteLine");
            }
            else
            {
                Console.Write($"[{i}] ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{MerchantInventory.inventory[i].ItemType,-7} {MerchantInventory.inventory[i].ItemName,-15}");
                Console.WriteLine($"Needs lvl: {MerchantInventory.inventory[i].LevelCap}");
                Console.ResetColor();
                Console.Write($"{MerchantInventory.inventory[i].Health,6} Hp {MerchantInventory.inventory[i].Damage,3} Dmg {MerchantInventory.inventory[i].Resistance,3} Res {MerchantInventory.inventory[i].Agility,3} Agi");
                PrintColor.Yellow($"{MerchantInventory.inventory[i].Price,4} {'\u00A9',1}", "WriteLine"); 
            }
        }
    }

    public void Interact(Player player)     // Interaktion med merchant, loopar hans inventory, visar stats och pris och låter player köpa eller sälja    
    {
        // Lägg till textures där merchant säger tack för att vi räddat honom från fienden
        if (FirstEncounter)
        {
            //Textures.PrintSavedMerchant();
            FirstEncounter = false;

            var choice = Console.ReadKey(true); // För att slippa trycka enter
            Console.CursorVisible = false;

            if (choice.Key == ConsoleKey.Y)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Clear.Row(10, 33, 31);
                Clear.Row(11, 33, 31);
                Clear.Row(12, 33, 31);
                Clear.Row(14, 23, 12);
                Console.SetCursorPosition(33, 10);
                Write.OneLetterAtATime("Ok, please enter my shop!    \n");

                Thread.Sleep(2000);
            }
            else if (choice.Key == ConsoleKey.N)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Clear.Row(10, 33, 31);
                Clear.Row(11, 33, 31);
                Clear.Row(12, 33, 31);
                Clear.Row(14, 23, 12);
                Console.SetCursorPosition(33, 10);
                Write.OneLetterAtATime("Ok, thanks again for helping me! \n");

                Thread.Sleep(2000);
                return;
            }
        }
        else
        {
            Textures.PrintMerchantAgain();
        }
        bool isShopping = true;
        while (isShopping)
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.Write($"{Name}: ");
            PrintColor.Yellow($"{Gold} {'\u00A9'}", "WriteLine");
            Console.WriteLine();

            ShowMerchantInventory(player);

            Console.SetCursorPosition(45, 0);
            Console.Write($"{player.Name}: ");
            PrintColor.Yellow($"{player.Gold} {'\u00A9'}", "WriteLine");
            Console.WriteLine();
            Console.SetCursorPosition(45, 2);
            Console.ForegroundColor = ConsoleColor.Red;
            player.HealingPot.ShowItem();
            Console.ResetColor();
            PlayerEquipment.ShowWornGear(player);

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

    public void Buy(Player player) //Låter player köpa, flyttar pengar från player till merch, visar stats om det är gear, 
    {
        Console.Clear();
        Console.CursorVisible = false;
        Console.Write($"{Name}: ");
        PrintColor.Yellow($"{Gold} {'\u00A9'}", "WriteLine");
        Console.WriteLine();
        Console.WriteLine($"To buy:");
        Console.WriteLine();

        ShowMerchantInventory(player);

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
        if (input.Key == ConsoleKey.Q)
        {
            if (player.Gold >= HealingPot.Price)
            {
                if (player.HealingPot.Ammount < player.HealingPot.MaxAmmount)
                {
                    player.Gold -= HealingPot.Price;
                    player.HealingPot.Ammount++;
                    Gold += HealingPot.Price;
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
                Console.SetCursorPosition(45, 18);
                Console.WriteLine("Du har inte råd");
                Thread.Sleep(1000);
            }
            return;
        }
        int itemIndex = Convert.ToInt32(input.KeyChar.ToString());
        var itemToBuy = MerchantInventory.inventory[itemIndex];
        if (player.Gold >= itemToBuy.Price) // Kontrollerar om player har råd
        {
            player.Gold -= itemToBuy.Price;
            Gold += itemToBuy.Price;
            player.Inventory.inventory.Add(itemToBuy);
            Console.SetCursorPosition(45, 18);
            Console.WriteLine($"Du har köpt {itemToBuy.ItemName}");
            Thread.Sleep(1000);

            MerchantInventory.inventory.RemoveAt(itemIndex);
        }
        else
        {
            Console.SetCursorPosition(45, 18);
            Console.WriteLine("Du har inte råd");
            Thread.Sleep(1000);
        }
    }

    public void Sell(Player player) // Säljmetod som fungerar likt ovan med bakvänt
    {
        Console.Clear();
        Console.CursorVisible = false;
        Console.Write($"{Name}: ");
        PrintColor.Yellow($"{Gold}g", "WriteLine");
        Console.WriteLine();
        Console.WriteLine($"To sell:");
        Console.WriteLine();
        player.Inventory.ShowInventorySortedByPrice(player);

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
        Console.WriteLine("Vad vill du sälja? - [Y] för att sälja allt");
        Console.SetCursorPosition(45, 17);
        Console.WriteLine("[C] för att lämna");
        var input = Console.ReadKey(true);
        if (input.Key == ConsoleKey.C)
        {
            return;
        }
        if (input.Key == ConsoleKey.Y)
        {
            int total = 0;
            for (int i = 0; i < player.Inventory.inventory.Count; i++)
            {
                total += player.Inventory.inventory[i].Price / 3;
                player.Gold += player.Inventory.inventory[i].Price / 3;
                Gold -= player.Inventory.inventory[i].Price / 3;
            }
            player.Inventory.inventory.Clear();
            Console.SetCursorPosition(45, 18);
            Console.WriteLine($"Du fick {total} guld");
            Thread.Sleep(1000);
        }

        else if (int.TryParse(input.KeyChar.ToString(), out int itemIndex))
        {
            var itemToSell = player.Inventory.inventory[itemIndex];

            player.Gold += itemToSell.Price / 3;
            Gold -= itemToSell.Price / 3;
            Console.SetCursorPosition(45, 18);
            Console.WriteLine($"Du har sålt {itemToSell.ItemName}");
            Thread.Sleep(1000);

            player.Inventory.inventory.RemoveAt(itemIndex);
        }
        else
        {
            Console.WriteLine("Wrong inmatning");
        }
    }
}