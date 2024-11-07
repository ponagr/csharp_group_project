public class Map
{
    //EN MAP
    public char[,] Maplevel { get; set; }

    public char[,] CellarLevel { get; set; }

    //EN FIENDELISTA
    public List<Enemy> Enemies { get; set; }
    //EN KISTLISTA
    public List<Chest> Chests { get; set; }
    //EN BOSS
    public Enemy Boss { get; set; }

    // public Map(char[,] map, List<Enemy> enemies, List<Chest> chests, Enemy boss)
    // {
    //     Maplevel = map;
    //     Enemies = enemies;
    //     Chests = chests;
    //     Boss = boss;
    // }

}

public class RegularMap : Map
{
    public RegularMap(char[,] map, List<Enemy> enemies, List<Chest> chests, Enemy boss)
    {
        Maplevel = map;
        Enemies = enemies;
        Chests = chests;
        Boss = boss;
    }
}

public class CellarMap : Map
{
    public CellarMap(char[,] map, char[,] cellarMap, List<Enemy> enemies, List<Chest> chests, Enemy boss)
    {
        Maplevel = map;
        CellarLevel = cellarMap;
        Enemies = enemies;
        Chests = chests;
        Boss = boss;
    }
}

public class DarkMap : Map
{ 
    public DarkMap(char[,] map, List<Enemy> enemies, List<Chest> chests, Enemy boss)
    {
        Maplevel = map;
        Enemies = enemies;
        Chests = chests;
        Boss = boss;
    }

}

#region ADD MAPS
public static class AddMaps
{
    public static List<Map> maps = new List<Map>();

    
    #region LEVEL 1
    public static Map Level1(Player player)
    {
        char[,] gameLevel1 = new char[,]
        {  //  1    2    3    4    5    6    7    8    9   10   11   12   13   14   15   16   17   18   19   20   21   22   23
            { '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_' },
            { '|', '@', '£', ' ', ' ', ' ', ' ', ' ', '¤', ' ', ' ', '|', '#', '|', ' ', ' ', ' ', ' ', ' ', ' ', 'B', ' ', '|' },
            { '|', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', '$', '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|' },
            { '|', 'M', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', '£', '|', '_', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|' },
            { '|', '/', '#', ' ', ' ', '\u2665', ' ', ' ', '|', ' ', ' ', '|', '£', ' ', ' ', ' ', ' ', ' ', ' ', '_', '|', ' ', '|' },
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
        List<Enemy> enemiesLevel1 = new List<Enemy> {mage, butcher, archer, assassin, assassin1, archer1, archer2, butcher3, 
        assassin3, butcher2, assassin4, mage2, mage3, archer3, butcher1, mage1};
        List<Item> items = new List<Item>() {new Consumable(), new THelm("Plåthjälm", 5, 30, 20, 0),
        new TWeapon("Gimlis Yxa", "Yxa", 40, 10, 0, 20), new TWeapon("Legolas Pilbåge", "Pilbåge", 30, 15, 5, 15),
        new TBoots("Foppatofflor", 0, 0, 5, -5), new TGloves("Plåthandskar", 5, 30, 20, 5), new TLegs("Läderbyxor", 0, 20, 15, 20) };
        List<Chest> chestsLevel1 = new List<Chest>() {new Chest(items), new Chest(items), new Chest(items), new Chest(items), new Chest(items), new Chest(items) };


        RegularMap level1 = new RegularMap(gameLevel1, enemiesLevel1, chestsLevel1, assassinBoss);
        return level1;
    }
    #endregion

    #region LEVEL 2
    public static Map Level2(Player player)
    {
        char[,] gameLevel = new char[,]
        {  //  1    2    3    4    5    6    7    8    9   10   11   12   13   14   15   16   17   18   19   20   21   22   23      
            { '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_' },
            { '=', '@', ' ', ' ', ' ', ' ', ' ', '|', '#', ' ', ' ', '|', '$', '|', '#', ' ', ' ', '|', ' ', ' ', ' ', ' ', '|' },
            { '|', '_', '_', '_', '_', '_', ' ', '|', ' ', ' ', ' ', '|', ' ', '|', '$', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', '|', ' ', '|', '_', '_', '_', '|', ' ', ' ', '|', ' ', '|' },
            { '|', ' ', '_', '_', '_', '_', '_', '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|', ' ', '_', '|', ' ', '|' },
            { '|', ' ', '|', '#', '|', ' ', '|', ' ', ' ', ' ', '¤', ' ', ' ', '£', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|' },
            { '|', ' ', '|', ' ', '|', ' ', '|', ' ', ' ', ' ', '¤', ' ', '$', ' ', '£', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|' },
            { '|', ' ', '|', ' ', '|', ' ', '|', '_', '_', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', '£', '|', '_', '_', ' ', '|', '_', '_', '_', ' ', '|' },
            { '|', ' ', ' ', ' ', '|', '£', ' ', ' ', '£', ' ', '_', '|', ' ', '|', ' ', ' ', ' ', '|', '#', ' ', '£', ' ', '|' },
            { '|', '£', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ')', '|', '$', '|', '$', ' ', ' ', '|', ' ', ' ', '£', ' ', '|' },
            { '|', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '|', '_', '_', '_', '_', '_', '_', '_', '_', ' ', '_', '|' },
            { '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '$', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|' },
            { '|', ' ', ' ', '#', '|', '_', '|', '$', ' ', ' ', '£', '|', ' ', ' ', ' ', ' ', ' ', ' ', '$', '|', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', '|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', '_', ' ', '|' },
            { '|', ' ', '_', '_', '|', ' ', '|', '_', '_', '_', '_', '_', ' ', ' ', '£', ' ', ' ', ' ', '$', '|', ' ', ' ', '|' },
            { '|', '£', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', '_', '_', '_', '_', '_', '_', '|', ' ', '_', '|' },
            { '|', ' ', ' ', ' ', '|', ' ', ' ', '£', '£', '£', '#', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', '|', ' ', '_', '_', '_', '_', '_', '|', ' ', ' ', ' ', ' ', ' ', '£', ' ', '|', ' ', '£', '|' },
            { '\\', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', '_', '_', '_', '_', '_', ' ', '|', '_', ' ', '|' },
            { '/', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', '$', '|', ' ', ' ', ' ', ' ', '$', '|', ' ', ' ', ' ', ' ', '|' },
            { '|', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '|' },//23
        };
        char[,] cellarLevel = new char[,]
        {  //  1    2    3    4    5    6    7    8    9   10   11   12   13   14   15   16   17   18   19   20   21   22   23      // DISARMA MINOR?!
            { '_', '_', '_', '_', '_', '_', '_' },
            { ')', '@', ' ', ' ', ' ', ' ', '_' },
            { '_', ' ', ' ', ' ', ' ', ' ', '_' },
            { '_', ' ', ' ', '¤', ' ', '£', '_' },
            { '_', ' ', ' ', ' ', ' ', ' ', '_' },
            { '_', '$', ' ', ' ', ' ', '#', '_' },
            { '_', '_', '_', '_', '_', '_', '_' },
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
        List<Enemy> enemies = new List<Enemy> {mage, butcher, archer, assassin, assassin1, archer1, archer2, butcher3, 
        assassin3, butcher2, assassin4, mage2, mage3, archer3, butcher1, mage1};

        List<Item> items = new List<Item>() {new Consumable(), new THelm("Plåthjälm", 5, 30, 20, 0),
        new TWeapon("Gimlis Yxa", "Yxa", 40, 10, 0, 20), new TWeapon("Legolas Pilbåge", "Pilbåge", 30, 15, 5, 15),
        new TBoots("Foppatofflor", 0, 0, 5, -5), new TGloves("Plåthandskar", 5, 30, 20, 5), new TLegs("Läderbyxor", 0, 20, 15, 20) };

        List<Chest> chests = new List<Chest>() {new Chest(items), new Chest(items), new Chest(items), new Chest(items), new Chest(items), new Chest(items) };


        CellarMap level = new CellarMap(gameLevel, cellarLevel, enemies, chests, assassinBoss);
        return level;

    }
    #endregion

    #region LEVEL 3
    public static Map Level3(Player player)
    {
        char[,] gameLevel = new char[,]
        {  //  1    2    3    4    5    6    7    8    9   10   11   12   13   14   15   16   17   18   19   20   21   22   23      
            { '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', '|', ' ', ' ', '|', ' ', ' ', ' ', '$', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', '_', '_', '_', '|', ' ', '|', ' ', '|', ' ', '£', ' ', ' ', ' ', ' ', '$', '|' },
            { '|', ' ', ' ', ' ', ' ', '$', '$', '|', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', '|', '_', '_', ' ', '_', '_', ' ', ' ', '|', '_', '|', ' ', ' ', ' ', '|', ' ', '_', '_', '_', '_', '|' },
            { '|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', '$', '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', '$', '|', '_', '_', '_', '_', '_', '_', '_', '_', ' ', '|' },
            { '|', '£', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', '$', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|' },
            { '|', ' ', '|', '#', ' ', ' ', ' ', ' ', ' ', ' ', '|', '£', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|' },
            { '|', ' ', '|', '_', '_', '_', '_', '_', '_', '_', '_', ' ', '|', ' ', '|', '_', '_', ' ', '_', '_', '|', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', '£', '|', '#', '|', ' ', ' ', ' ', '|', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|', ' ', '|', ' ', ' ', ' ', '|', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|', '_', '_', '_', '_', '_', '|', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '£', ' ', ' ', ' ', ' ', ' ', ' ', '|', '$', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', '_', '_', '_', ' ', '_', '_', '_', '_', '|', ' ', ' ', '|', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', '|', '_', 'B', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '£', ' ', '|', '£', '|', ' ', ' ', '|', '#', '/' },
            { '|', ' ', '_', '_', '_', '_', '_', '|', ' ', ' ', ' ', ' ', ' ', ' ', '#', '|', ' ', ' ', '|', ' ', ' ', '|', '|' },
            { '|', ' ', '|', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '$', '|', ' ', ' ', '#', '|', ' ', '@', '|' },
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
        List<Enemy> enemies = new List<Enemy> {mage, butcher, archer, assassin, assassin1, archer1, archer2, butcher3, 
        assassin3, butcher2, assassin4, mage2, mage3, archer3, butcher1, mage1};

        List<Item> items = new List<Item>() {new Consumable(), new THelm("Plåthjälm", 5, 30, 20, 0),
        new TWeapon("Gimlis Yxa", "Yxa", 40, 10, 0, 20), new TWeapon("Legolas Pilbåge", "Pilbåge", 30, 15, 5, 15),
        new TBoots("Foppatofflor", 0, 0, 5, -5), new TGloves("Plåthandskar", 5, 30, 20, 5), new TLegs("Läderbyxor", 0, 20, 15, 20) };

        List<Chest> chests = new List<Chest>() {new Chest(items), new Chest(items), new Chest(items), new Chest(items), new Chest(items), new Chest(items) };

        DarkMap level = new DarkMap(gameLevel, enemies, chests, assassinBoss);
        return level;
    }
    #endregion

    #region LEVEL 4
    public static Map Level4(Player player)
    {
        char[,] gameLevel = new char[,]
        {  //  1    2    3    4    5    6    7    8    9   10   11   12   13   14   15   16   17   18   19   20   21   22   23     
            { '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_' },
            { '=', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '@', '|' },
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
        List<Enemy> enemiesLevel1 = new List<Enemy> {mage, butcher, archer, assassin, assassin1, archer1, archer2, butcher3, 
        assassin3, butcher2, assassin4, mage2, mage3, archer3, butcher1, mage1};
        List<Item> items = new List<Item>() {new Consumable(), new THelm("Plåthjälm", 5, 30, 20, 0),
        new TWeapon("Gimlis Yxa", "Yxa", 40, 10, 0, 20), new TWeapon("Legolas Pilbåge", "Pilbåge", 30, 15, 5, 15),
        new TBoots("Foppatofflor", 0, 0, 5, -5), new TGloves("Plåthandskar", 5, 30, 20, 5), new TLegs("Läderbyxor", 0, 20, 15, 20) };
        List<Chest> chestsLevel1 = new List<Chest>() {new Chest(items), new Chest(items), new Chest(items), new Chest(items), new Chest(items), new Chest(items) };


        RegularMap level1 = new RegularMap(gameLevel, enemiesLevel1, chestsLevel1, assassinBoss);
        return level1;
    }
    #endregion

    #region LEVEL 5
    public static Map Level5(Player player)
    {
        char[,] gameLevel = new char[,]
        {  //  1    2    3    4    5    6    7    8    9   10   11   12   13   14   15   16   17   18   19   20   21   22   23      
            { '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_' },
            { '=', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '@', '|' },
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
        List<Enemy> enemiesLevel1 = new List<Enemy> {mage, butcher, archer, assassin, assassin1, archer1, archer2, butcher3, 
        assassin3, butcher2, assassin4, mage2, mage3, archer3, butcher1, mage1};
        List<Item> items = new List<Item>() {new Consumable(), new THelm("Plåthjälm", 5, 30, 20, 0),
        new TWeapon("Gimlis Yxa", "Yxa", 40, 10, 0, 20), new TWeapon("Legolas Pilbåge", "Pilbåge", 30, 15, 5, 15),
        new TBoots("Foppatofflor", 0, 0, 5, -5), new TGloves("Plåthandskar", 5, 30, 20, 5), new TLegs("Läderbyxor", 0, 20, 15, 20) };
        List<Chest> chestsLevel1 = new List<Chest>() {new Chest(items), new Chest(items), new Chest(items), new Chest(items), new Chest(items), new Chest(items) };


        RegularMap level1 = new RegularMap(gameLevel, enemiesLevel1, chestsLevel1, assassinBoss);
        return level1;
    }
    #endregion
}
#endregion


