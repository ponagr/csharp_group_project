#region ADD MAPS
public static class AddMaps
{
    public static List<Map> maps = new List<Map>();
    static char C = '\u00A9';

    #region LEVEL 1
    public static Map Level1(Player player)
    {
        char[,] gameLevel1 = new char[,]
        {  //  1    2    3    4    5    6    7    8    9   10   11   12   13   14   15   16   17   18   19   20   21   22   23
            { '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_' },
            { '|', '@', '£', ' ', ' ', ' ', ' ', ' ', '¤', ' ', ' ', '|', '#', '|', '\u2665', ' ', ' ', ' ', ' ', ' ', 'B', ' ', '|' },
            { '|', ' ', ' ', '#', ' ', 'B', ' ', ' ', ' ', ' ', ' ', '|', '$', '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', '£', '|', '_', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|' },
            { '|', '/', '#', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|', '£', ' ', ' ', ' ', ' ', ' ', ' ', '_', '|', ' ', '|' },
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

        Assassin assassin = new Assassin(1, "Fegkräk");
        Butcher butcher = new Butcher(1, "Slaktarn");
        Archer archer = new Archer(1, "Lena-Långbåge");
        Mage mage = new Mage(1, "Magiska-Lars");
        Assassin assassin1 = new Assassin(1, "Assassinator");
        Butcher butcher1 = new Butcher(1, "Gimli");
        Mage mage1 = new Mage(1, "Gandalf");
        Archer archer1 = new Archer(1, "Legolas");
        Archer archer2 = new Archer(1, "Robin Hood");
        Archer archer3 = new Archer(1, "Hawkeye");
        Assassin assassin4 = new Assassin(1, "Ninja");
        Butcher butcher3 = new Butcher(1, "Berzerker");
        Mage mage2 = new Mage(1, "Moon Queen");
        Mage mage3 = new Mage(1, "Magic-Mike");
        Butcher butcher2 = new Butcher(1, "Butchie");
        Assassin assassin3 = new Assassin(1, "Asian");
        Sceletons sceletons = new Sceletons(1, "Ben-jamin");

        ButcherBoss boss = new ButcherBoss(1, "The Butcher");
        //AssassinBoss assassinBoss = new AssassinBoss(1, "Smygehuk");


        List<Enemy> enemiesLevel1 = new List<Enemy> {sceletons, mage, butcher, archer, assassin, assassin1, archer1, archer2, butcher3,
        assassin3, butcher2, assassin4, mage2, mage3, archer3, butcher1, mage1};
        List<Item> items = new List<Item>() {new Consumable(), new THelm("Plåthjälm", 5, 30, 20, 0),
        new TWeapon("Gimlis Yxa", "Yxa", 40, 10, 0, 20), new TWeapon("Legolas Pilbåge", "Pilbåge", 30, 15, 5, 15),
        new TBoots("Foppatofflor", 5, 0, 5, -5), new TGloves("Plåthandskar", 5, 30, 20, 5), new TLegs("Läderbyxor", 0, 20, 15, 20) };
        List<Chest> chestsLevel1 = new List<Chest>() { new Chest(items), new Chest(items), new Chest(items), new Chest(items), new Chest(items), new Chest(items) };


        RegularMap level1 = new RegularMap(gameLevel1, enemiesLevel1, chestsLevel1, boss, null);
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
            { '|', ' ', '/', ' ', '|', '£', ' ', ' ', ' ', ' ', ' ', '|', '£', '|', '_', '_', ' ', '|', '_', '_', '_', ' ', '|' },
            { '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', '£', ' ', '_', '|', ' ', '|', ' ', ' ', ' ', '|', '#', ' ', '£', ' ', '|' },
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
            { ')', '@', ' ', ' ', ' ', 'M', '_' },
            { '_', ' ', ' ', ' ', ' ', ' ', '_' },
            { '_', ' ', ' ', '¤', ' ', '£', '_' },
            { '_', ' ', ' ', ' ', ' ', ' ', '_' },
            { '_', '$', ' ', ' ', ' ', '#', '_' },
            { '_', '_', '_', '_', '_', '_', '_' },
        };

        Assassin assassin = new Assassin(2, "Fegkräk");
        Butcher butcher = new Butcher(2, "Slaktarn");
        Archer archer = new Archer(2, "Lena-Långbåge");
        Mage mage = new Mage(2, "Magiska-Lars");
        Assassin assassin1 = new Assassin(2, "Assassinator");
        Butcher butcher1 = new Butcher(2, "Gimli");
        Mage mage1 = new Mage(2, "Gandalf");
        Archer archer1 = new Archer(2, "Legolas");
        Archer archer2 = new Archer(2, "Robin Hood");
        Archer archer3 = new Archer(2, "Hawkeye");
        Assassin assassin4 = new Assassin(2, "Ninja");
        Butcher butcher3 = new Butcher(2, "Berzerker");
        Mage mage2 = new Mage(2,  "Moon Queen");
        Mage mage3 = new Mage(2,  "Magic-Mike");
        Butcher butcher2 = new Butcher(2,  "Butchie");
        Assassin assassin3 = new Assassin(2, "Asian");

        AssassinBoss assassinBoss = new AssassinBoss(2, "Smygehuk");
        List<Enemy> enemies = new List<Enemy> {mage, butcher, archer, assassin, assassin1, archer1, archer2, butcher3,
        assassin3, butcher2, assassin4, mage2, mage3, archer3, butcher1, mage1};

        List<Item> items = new List<Item>() {new Consumable(), new THelm("Plåthjälm", 5, 30, 20, 0),
        new TWeapon("Gimlis Yxa", "Yxa", 40, 10, 0, 20), new TWeapon("Legolas Pilbåge", "Pilbåge", 30, 15, 5, 15),
        new TBoots("Foppatofflor", 5, 0, 5, -5), new TGloves("Plåthandskar", 5, 30, 20, 5), new TLegs("Läderbyxor", 0, 20, 15, 20) };

        List<Chest> chests = new List<Chest>() { new Chest(items), new Chest(items), new Chest(items), new Chest(items), new Chest(items), new Chest(items) };

        Merchant merchant = new Merchant("Merchant", 1000, items);

        CellarMap level = new CellarMap(gameLevel, cellarLevel, enemies, chests, assassinBoss, merchant);
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

        Assassin assassin = new Assassin(3, "Fegkräk");
        Butcher butcher = new Butcher(3, "Slaktarn");
        Archer archer = new Archer(3, "Lena-Långbåge");
        Mage mage = new Mage(3, "Magiska-Lars");
        Assassin assassin1 = new Assassin(3, "Assassinator");
        Butcher butcher1 = new Butcher(3, "Gimli");
        Mage mage1 = new Mage(3, "Gandalf");
        Archer archer1 = new Archer(3, "Legolas");
        Archer archer2 = new Archer(3, "Robin Hood");
        Archer archer3 = new Archer(3, "Hawkeye");
        Assassin assassin4 = new Assassin(3, "Ninja");
        Butcher butcher3 = new Butcher(3, "Berzerker");
        Mage mage2 = new Mage(3, "Moon Queen");
        Mage mage3 = new Mage(3, "Magic-Mike");
        Butcher butcher2 = new Butcher(3, "Butchie");
        Assassin assassin3 = new Assassin(3, "Asian");

        AssassinBoss assassinBoss = new AssassinBoss(3, "Smygehuk");
        List<Enemy> enemies = new List<Enemy> {mage, butcher, archer, assassin, assassin1, archer1, archer2, butcher3,
        assassin3, butcher2, assassin4, mage2, mage3, archer3, butcher1, mage1};

        List<Item> items = new List<Item>() {new Consumable(), new THelm("Plåthjälm", 5, 30, 20, 0),
        new TWeapon("Gimlis Yxa", "Yxa", 40, 10, 0, 20), new TWeapon("Legolas Pilbåge", "Pilbåge", 30, 15, 5, 15),
        new TBoots("Foppatofflor", 5, 0, 5, -5), new TGloves("Plåthandskar", 5, 30, 20, 5), new TLegs("Läderbyxor", 0, 20, 15, 20) };

        List<Chest> chests = new List<Chest>() { new Chest(items), new Chest(items), new Chest(items), new Chest(items), new Chest(items), new Chest(items) };

        DarkMap level = new DarkMap(gameLevel, enemies, chests, assassinBoss, null);
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

        Assassin assassin = new Assassin(4, "Fegkräk");
        Butcher butcher = new Butcher(4, "Slaktarn");
        Archer archer = new Archer(4, "Lena-Långbåge");
        Mage mage = new Mage(4, "Magiska-Lars");
        Assassin assassin1 = new Assassin(4, "Assassinator");
        Butcher butcher1 = new Butcher(4, "Gimli");
        Mage mage1 = new Mage(4, "Gandalf");
        Archer archer1 = new Archer(4, "Legolas");
        Archer archer2 = new Archer(4, "Robin Hood");
        Archer archer3 = new Archer(4, "Hawkeye");
        Assassin assassin4 = new Assassin(4, "Ninja");
        Butcher butcher3 = new Butcher(4, "Berzerker");
        Mage mage2 = new Mage(4, "Moon Queen");
        Mage mage3 = new Mage(4, "Magic-Mike");
        Butcher butcher2 = new Butcher(4, "Butchie");
        Assassin assassin3 = new Assassin(4, "Asian");

        AssassinBoss assassinBoss = new AssassinBoss(4, "Smygehuk");
        List<Enemy> enemiesLevel1 = new List<Enemy> {mage, butcher, archer, assassin, assassin1, archer1, archer2, butcher3,
        assassin3, butcher2, assassin4, mage2, mage3, archer3, butcher1, mage1};
        List<Item> items = new List<Item>() {new Consumable(), new THelm("Plåthjälm", 5, 30, 20, 0),
        new TWeapon("Gimlis Yxa", "Yxa", 40, 10, 0, 20), new TWeapon("Legolas Pilbåge", "Pilbåge", 30, 15, 5, 15),
        new TBoots("Foppatofflor", 5, 0, 5, -5), new TGloves("Plåthandskar", 5, 30, 20, 5), new TLegs("Läderbyxor", 0, 20, 15, 20) };
        List<Chest> chestsLevel1 = new List<Chest>() { new Chest(items), new Chest(items), new Chest(items), new Chest(items), new Chest(items), new Chest(items) };

        Merchant merchant = new Merchant("Merchant", 1000, items);

        RegularMap level1 = new RegularMap(gameLevel, enemiesLevel1, chestsLevel1, assassinBoss, merchant);
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

        Assassin assassin = new Assassin(5, "Fegkräk");
        Butcher butcher = new Butcher(5, "Slaktarn");
        Archer archer = new Archer(5, "Lena-Långbåge");
        Mage mage = new Mage(5, "Magiska-Lars");
        Assassin assassin1 = new Assassin(5, "Assassinator");
        Butcher butcher1 = new Butcher(5, "Gimli");
        Mage mage1 = new Mage(5, "Gandalf");
        Archer archer1 = new Archer(5, "Legolas");
        Archer archer2 = new Archer(5, "Robin Hood");
        Archer archer3 = new Archer(5, "Hawkeye");
        Assassin assassin4 = new Assassin(5, "Ninja");
        Butcher butcher3 = new Butcher(5, "Berzerker");
        Mage mage2 = new Mage(5, "Moon Queen");
        Mage mage3 = new Mage(5, "Magic-Mike");
        Butcher butcher2 = new Butcher(5, "Butchie");
        Assassin assassin3 = new Assassin(5, "Asian");

        AssassinBoss assassinBoss = new AssassinBoss(5, "Smygehuk");
        List<Enemy> enemiesLevel1 = new List<Enemy> {mage, butcher, archer, assassin, assassin1, archer1, archer2, butcher3,
        assassin3, butcher2, assassin4, mage2, mage3, archer3, butcher1, mage1};
        List<Item> items = new List<Item>() {new Consumable(), new THelm("Plåthjälm", 5, 30, 20, 0),
        new TWeapon("Gimlis Yxa", "Yxa", 40, 10, 0, 20), new TWeapon("Legolas Pilbåge", "Pilbåge", 30, 15, 5, 15),
        new TBoots("Foppatofflor", 5, 0, 5, -5), new TGloves("Plåthandskar", 5, 30, 20, 5), new TLegs("Läderbyxor", 0, 20, 15, 20) };
        List<Chest> chestsLevel1 = new List<Chest>() { new Chest(items), new Chest(items), new Chest(items), new Chest(items), new Chest(items), new Chest(items) };

        Merchant merchant = new Merchant("Merchant", 1000, items);

        RegularMap level1 = new RegularMap(gameLevel, enemiesLevel1, chestsLevel1, assassinBoss, merchant);
        return level1;
    }
    #endregion
}
#endregion