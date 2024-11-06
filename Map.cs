public class Map
{
    //EN MAP
    public char[,] Maplevel { get; set; } = new char[50, 50];
    //EN FIENDELISTA
    public List<Enemy> Enemies { get; set; } = new List<Enemy>();
    //EN KISTLISTA
    public List<Chest> Chests { get; set; } = new List<Chest>();
    //EN BOSS
    public Enemy Boss { get; set; }
    //EN LISTA MED ITEMS
    //public List<Item> Items { get; set; } = new List<Item>();




    public Map(char[,] map, List<Enemy> enemies, List<Chest> chests, Enemy boss)
    {
        Maplevel = map;
        Enemies = enemies;
        Chests = chests;
        Boss = boss;
        //Items = items;
    }




}

public static class AddMaps
{
    public static List<Map> maps = new List<Map>();
    public static void AddMap(Player player)
    {
        char[,] gameLevel1 = new char[,]
        {  //  1    2    3    4    5    6    7    8    9   10   11   12   13   14   15   16   17   18   19   20   21   22   23
        { '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_' },
        { '|', '@', '£', ' ', ' ', ' ', ' ', ' ', '¤', ' ', ' ', '|', '#', '|', ' ', ' ', ' ', ' ', ' ', ' ', 'B', ' ', '|' },
        { '|', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', '$', '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|' },
        { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', '£', '|', '_', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|' },
        { '|', ' ', '#', ' ', ' ', '\u2665', ' ', ' ', '|', ' ', ' ', '|', '£', ' ', ' ', ' ', ' ', ' ', ' ', '_', '|', ' ', '|' },
        { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '£', ' ', '|', ' ', ' ', '|' },
        { '|', '#', ' ', ' ', ' ', ' ', ' ', '¤', '|', ' ', ' ', '|', '$', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '\\' },
        { '|', ' ', '_', '_', '|', ' ', '|', '_', '_', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '/' },
        { '|', ' ', ' ', '#', '|', '£', '|', '$', ' ', ' ', ' ', '|', '£', '|', '_', '_', ' ', ' ', ' ', '_', '_', '_', '|' },
        { '|', ' ', ' ', ' ', '|', ' ', '|', ' ', '£', ' ', '¤', '|', '$', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
        { '|', ' ', ' ', ' ', '|', ' ', '|', '$', ' ', ' ', ' ', '|', '$', '|', ' ', ' ', ' ', ' ', ' ', ' ', '£', ' ', '|' },
        { '|', '_', '_', '_', '_', '£', '_', '_', '_', '_', '_', '|', '_', '_', '_', '_', '_', '_', '_', '_', ' ', '_', '|' },
        { '|', ' ', ' ', ' ', '|', ' ', '|', ' ', ' ', ' ', ' ', '|', ' ', ' ', '$', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|' },
        { '|', ' ', ' ', '#', '|', ' ', '|', '$', ' ', ' ', '£', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|' },
        { '|', ' ', ' ', ' ', '|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|' },
        { '|', '£', '_', '_', '|', ' ', '|', '_', '_', ' ', ' ', ' ', ' ', ' ', '£', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|' },
        { '|', '£', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', '_', '_', '_', '_', '_', '_', ' ', '|', ' ', ' ', '|' },
        { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|' },
        { '|', ' ', ' ', ' ', '|', ' ', '_', '_', '_', '_', '_', '|', ' ', ' ', ' ', ' ', ' ', '£', ' ', '|', ' ', ' ', '|' },
        { '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '_', '_', '_', '_', '_', '|', ' ', ' ', '|' },
        { '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
        { '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '$', '|', ' ', ' ', ' ', ' ', ' ', '$', ' ', ' ', ' ', ' ', '|' },
        { '|', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '|' },//23
        };
        
        Assassin assassin = new Assassin(player, "Fegkräk");
        Butcher butcher = new Butcher(player, "Slaktarn");
        Archer archer = new Archer(player, "Lena-Långbåge");
        Mage mage = new Mage(player, "Magiska-Lars");
        Assassin assassin1 = new Assassin(player, "Assassinator");
        Butcher butcher1 = new Butcher(player, "Gimli");
        Mage mage1 = new Mage(player, "Gandalf");
        Archer archer1 = new Archer(player, "Legolas");
        Archer archer2 = new Archer(player, "Robin Hood");
        Archer archer3 = new Archer(player, "Hawkeye");
        Assassin assassin4 = new Assassin(player, "Ninja");
        Butcher butcher3 = new Butcher(player, "Berzerker");
        Mage mage2 = new Mage(player, "Moon Queen");
        Mage mage3 = new Mage(player, "Magic-Mike");
        Butcher butcher2 = new Butcher(player, "Butchie");
        Assassin assassin3 = new Assassin(player, "Asian");

        AssassinBoss assassinBoss = new AssassinBoss(player, "Smygehuk");
        List<Enemy> enemiesLevel1 = new List<Enemy> {mage, butcher, archer, butcher, assassin, assassin1, archer1, archer2, butcher3, 
        assassin3, butcher2, assassin4, assassin3, mage2, mage3, archer3, butcher1, mage1};

        List<Chest> chestsLevel1 = new List<Chest> {new Chest(), new Chest(), new Chest(), new Chest(), new Chest()};

        foreach(var enemy in enemiesLevel1)
        {
            Console.WriteLine(enemy.Name);
        }

        Map level1 = new Map(gameLevel1, enemiesLevel1, chestsLevel1, assassinBoss);
        maps.Add(level1);
    }
}


