public static class PlayerEquipment
{
    public static void CheckGearType(Player player, Item itemToEquip)   //Kontrollerar av vilken typ vårat item är
    {
        if (itemToEquip is TWeapon)
        {
            EquipGear(player, itemToEquip, player.EquippedGear[0], 0);  //Skickar sedan in itemet för att jämföra stats och låta användaren göra val om den vill byta item eller inte
        }
        if (itemToEquip is THelm)
        {
            EquipGear(player, itemToEquip, player.EquippedGear[1], 1);
        }
        if (itemToEquip is TBreastPlate)
        {
            EquipGear(player, itemToEquip, player.EquippedGear[2], 2);
        }
        if (itemToEquip is TGloves)
        {
            EquipGear(player, itemToEquip, player.EquippedGear[3], 3);
        }
        if (itemToEquip is TLegs)
        {
            EquipGear(player, itemToEquip, player.EquippedGear[4], 4);
        }
        if (itemToEquip is TBoots)
        {
            EquipGear(player, itemToEquip, player.EquippedGear[5], 5);
        }
        CountStats(player); //Uppdaterar BonusStats varje gång vi byter gear
        return;
    }

    public static void CountStats(Player player)    //går igenom alla playerns equipped-items och räknar ihop totala bonusen för varje Stat 
    {
        double bonusDamage = 0;
        double bonusHp = 0;
        double bonusAgility = 0;
        double bonusResistance = 0;
        for (int i = 0; i < player.EquippedGear.Length; i++)
        {
            if (player.EquippedGear[i] != null)
            {
                bonusDamage += player.EquippedGear[i].Damage;
                bonusHp += player.EquippedGear[i].Health;
                bonusAgility += player.EquippedGear[i].Agility;
                bonusResistance += player.EquippedGear[i].Resistance;
            }
        }
        player.BonusAgility = bonusAgility;
        player.BonusHp = bonusHp;
        player.BonusDamage = bonusDamage;
        player.BonusResistance = bonusResistance;
        player.CurrentHp = player.TotalHp; // För att man ska få maxhp när man uppgraderar armor
    }

    public static void EquipGear(Player player, Item itemToEquip, Item equippedItem, int equippedGearIndex)  //Anropas från EquipGear-Metoden
    {
        if (equippedItem == null)
        {
            player.EquippedGear[equippedGearIndex] = itemToEquip; // Om itemToEquip är TWeapon, så är equippedGearIndex = 0, lägg in itemToEquip i EquippedGear[0], osv
            player.Inventory.inventory.Remove(itemToEquip);    //Om vi equippar, ta bort från inventory så vi inte får dublett
            Console.WriteLine($"Du tog på dig {itemToEquip.ItemName}, {itemToEquip.ItemType}");
        }
        else if (equippedItem != null)
        {
            Item item; // Skapar en tom referens
            GearChoice(itemToEquip, equippedItem, out item); // item är en av de 2 första

            player.Inventory.inventory.Add(equippedItem);
            player.EquippedGear[equippedGearIndex] = item;
            player.Inventory.inventory.Remove(item);
        }
    }

    public static void GearChoice(Item itemToEquip, Item equippedItem, out Item item)
    {
        item = equippedItem;
        CompareGearStats(itemToEquip.Health, equippedItem.Health, "Health");    //Skickar in en specifik stat att jämföra och skriva ut
        CompareGearStats(itemToEquip.Damage, equippedItem.Damage, "Damage");
        CompareGearStats(itemToEquip.Resistance, equippedItem.Resistance, "Resistance");
        CompareGearStats(itemToEquip.Agility, equippedItem.Agility, "Agility");

        Console.WriteLine("Vill du byta? J/N");     //avgör vilket item vi skickar tillbaka via 'out' som sedan equippas
        var input = Console.ReadKey(true);
        if (input.Key == ConsoleKey.J)
        {
            item = itemToEquip;     //Om "J", så byter vi item från equippedItem till itemToEquip
            return;
        }
        else if (input.Key == ConsoleKey.N)
        {
            return;
        }
    }

    public static void CompareGearStats(double itemToEquipStats, double equippedItemStats, string stat) // Räknar ut differensen och skriver ut text i grön eller rött beroende på + eller -
    {
        if (itemToEquipStats > equippedItemStats)
        {
            double diff = itemToEquipStats - equippedItemStats;
            PrintColor.Green($"+{diff} {stat}", "WriteLine");
        }
        else if (itemToEquipStats < equippedItemStats)
        {
            double diff = equippedItemStats - itemToEquipStats;
            PrintColor.Red($"-{diff} {stat}", "WriteLine");
        }
    }

    public static void ShowWornGear(Player player)  //Skriver ut items som är equippade, eller om en item-slot är tom
    {
        List<string> itemType = new List<string>() // Skapar en lista för att kunna loopa och få ut info om rätt index
        { "Weapon", "Helm", "Chest", "Gloves", "Legs", "Boots" };

        int row = 6;
        Console.SetCursorPosition(45, 4);
        Console.WriteLine("Worn Equipment:");
        Console.SetCursorPosition(45, 5);
        Console.WriteLine("------------------------");
        for (int i = 0; i < itemType.Count; i++)
        {
            Console.SetCursorPosition(45, row);
            if (player.EquippedGear[i] != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                player.EquippedGear[i].ShowStats();
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"{itemType[i]}: (Empty)");
                Console.ResetColor();
            }
            row++;
        }
    }
}