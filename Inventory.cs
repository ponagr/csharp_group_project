public class Inventory
{
    public List<Item> inventory { get; set; } = new List<Item>();

    public void InventoryUI(Player player) // NÄR VI TRYCKER C
    {
        while (true)    //Anropar en massa olika metoder för att ge oss en sammanställd inventoryUI 
        {
            Console.Clear();
            PlayerUI.UI(player);    //visar guld, hp, xp högst upp
            Console.WriteLine();
            Textures.PrintPlayerCharacter(4, 21);       //Skriver ut players streckgubbe i mitten av inventoryn
            PlayerUI.ShowStats(player);             //Skriver ut players totala stats
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine();
            ShowInventory();        //Skriver ut items som vi har lootat, om den inte är tom
            Console.ResetColor();
            Console.WriteLine();
            PlayerEquipment.ShowWornGear(player);       //Skriver ut items som vi har equippat
            Console.ResetColor();
            Console.SetCursorPosition(39, 13);
            Console.WriteLine("Tryck 'E' för att hantera equipments");
            Console.SetCursorPosition(39, 14);
            Console.WriteLine("Tryck 'C' för att gå tillbaka");
            var keyInput = Console.ReadKey(true);
            if (keyInput.Key == ConsoleKey.E)
            {
                EquipmentMenu(player);  //Om användaren tycker 'E' så går vi in i denna metod, som låter användaren välja ett item i inventoryn för att equippa det
            }
            else if (keyInput.Key == ConsoleKey.C)
            {
                return;
            }
            Console.WriteLine();
        }
    }
    private void ShowInventory()        //Skriver ut alla items i inventoryn
    {
        Console.WriteLine($"Inventory - Space: {inventory.Count}/10");
        Console.WriteLine("---------------------");
        if (inventory.Count > 0)
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"[{i+1}] {inventory[i].ItemName}, {inventory[i].ItemType}");
            }
        }
        else
        {
            Console.WriteLine("Din inventory är tom");
        }
    }
    private void EquipmentMenu(Player player)
    {
        Console.Clear();
        PlayerEquipment.ShowWornGear(player);   //Skriver ut gear som player har equippat
        Console.WriteLine();
        player.Inventory.ShowEquipmentInventory();  //skriver ut gear som player har i inventory tillsammas med gearens stats

        Console.WriteLine("Välj ett item för att interagera ([C] - tillbaka)");
        var input = Console.ReadKey(true);
        if (input.Key == ConsoleKey.C)      //om användaren trycker 'C', gå tillbaka till InventoryUI
        {
            return;
        }
        string strInput = input.KeyChar.ToString();     //Annars skriver användaren in sitt val och vi anropar CheckGearType 
        int i = int.Parse(strInput);                    //för att kontrollera av vilken typ det item som vi valt är
        PlayerEquipment.CheckGearType(player, player.Inventory.inventory[i-1]);     //Och jämför sedan det valda itemets stats med players equipped item stats

    }
    private void ShowEquipmentInventory() // För att visa inventory MED stats
    {
        Console.WriteLine($"Inventory - Space: {inventory.Count}/10");
        if (inventory.Count > 0)
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.Write($"[{i+1}] ");
                inventory[i].ShowStats();
            }
        }
        else
        {
            Console.WriteLine("Din inventory är tom");
        }
        Console.WriteLine();
    }

}