#region ADD MAPS
public static class AddMaps     //Innehåller alla färdiga maplevels
{
    public static List<Map> maps = new List<Map>();
    static char C = '\u00A9';

    #region LEVEL 1
    public static Map Level1() // Första banan med chars som bygger upp väggar, fiender osv.
    {
        char[,] gameLevel1 = new char[,]
        {  //  1    2    3    4    5    6    7    8    9   10   11   12   13   14   15   16   17   18   19   20   21   22   23
            { '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_' },
            { '|', '@', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '¤', ' ', '|', '#', '|', ' ', ' ', ' ', ' ', ' ', ' ', 'B', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', '$', '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', '£', '|', '_', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|' },
            { '|', '/', ' ', ' ', ' ', ' ', ' ', ' ', '|', '¤', ' ', '|', '£', ' ', ' ', ' ', ' ', ' ', ' ', '_', '|', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '£', ' ', '|', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', '¤', '|', ' ', ' ', '|', '$', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '\\' },
            { '|', ' ', '_', '_', '|', ' ', '|', '_', '_', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '/' },
            { '|', ' ', ' ', '#', '|', ' ', '|', '$', ' ', ' ', ' ', '|', '£', '|', '_', '_', ' ', ' ', ' ', '_', '_', '_', '|' },
            { '|', ' ', ' ', ' ', '|', ' ', '|', ' ', '£', ' ', ' ', '|', '$', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', '|', ' ', '|', '$', ' ', ' ', ' ', '|', '$', '|', ' ', ' ', ' ', ' ', ' ', ' ', '£', ' ', '|' },
            { '|', '_', '_', '_', '_', '£', '_', '_', '_', '_', '_', '|', '_', '_', '_', '_', '_', '_', '_', '_', ' ', '_', '|' },
            { '|', ' ', ' ', ' ', '|', ' ', '|', ' ', ' ', ' ', ' ', '|', ' ', ' ', '$', ' ', ' ', ' ', ' ', '|', ' ', '\u2665', '|' },
            { '|', ' ', ' ', '#', '|', ' ', '|', '$', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', '|', ' ', '|', '#', ' ', '£', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|' },
            { '|', '£', '_', '_', '|', ' ', '|', '_', '_', '_', ' ', ' ', ' ', ' ', '£', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|' },
            { '|', '£', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', '_', '_', '_', '_', '_', '_', ' ', '|', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', '_', '_', ' ', '|', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', '|', ' ', '_', '_', '_', '_', '_', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', '£', ' ', '$', '|', ' ', ' ', '_', '_', '_', '_', '_', '|', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', '¤', ' ', '$', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', '£', ' ', '$', '|', ' ', ' ', 'a', ' ', ' ', '$', ' ', ' ', ' ', ' ', '|' },
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
        Mage mage2 = new Mage(2, "Moon Queen");
        Mage mage3 = new Mage(2, "Magic-Mike");
        Butcher butcher2 = new Butcher(1, "Butchie");
        Assassin assassin3 = new Assassin(1, "Asian");
        
        Assassin assassinInvisable = new Assassin(1, "Inge-visable");
        AssassinBoss assassinBoss = new AssassinBoss(1, "Smygehuk");


        List<Enemy> enemiesLevel1 = new List<Enemy> {archer, mage, butcher, assassin, assassin1, archer1, archer2, butcher3,
        assassin3, butcher2, assassin4, mage2, mage3};
        List<Item> items = new List<Item>() 
        {new Consumable(), 
        new THelm("Plåthjälm", 5, 10, 10, 0, 1),
        new THelm("Tomteluva", 0, 5, 5, 15, 2),
        new TWeapon("Gimlis Yxa", 10, 10, 0, 10, 2),
        new TWeapon("Legolas Pilbåge", 8, 5, 5, 10, 1),
        new TWeapon("Slunger", 9, 0, 5, 10, 2),
        new TBoots("Foppatofflor", 5, 0, 5, -5, 1),
        new TBoots("Träskor", 8, 5, 5, 0, 2), 
        new TGloves("Plåthandskar", 5, 10, 10, 5, 2), 
        new TGloves("Trädgårdshandskar", 2, 7, 5, 8, 1), 
        new TLegs("Läderbyxor", 0, 7, 5, 10, 1), 
        new TLegs("Manchesterbrallor", 0, 8, 9, 7, 2), 
        new TBreastPlate("Hoodie", 0, 8, 5, 10, 1),
        new TBreastPlate("Rostig rustning", 5, 10, 10, 0, 2) };
        List<Chest> chestsLevel1 = new List<Chest>() { new Chest(items), new Chest(items), new Chest(items), new Chest(items), new Chest(items), new Chest(items) };

        RegularMap level1 = new RegularMap(gameLevel1, enemiesLevel1, assassinInvisable, chestsLevel1, assassinBoss, null);
        return level1;
    }
    #endregion

    #region LEVEL 2
    public static Map Level2()
    {
        char[,] gameLevel = new char[,]
        {  //  1    2    3    4    5    6    7    8    9   10   11   12   13   14   15   16   17   18   19   20   21   22   23      
            { '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_' },
            { '=', '@', ' ', ' ', ' ', ' ', ' ', '|', '#', ' ', ' ', '|', '$', '|', '#', ' ', ' ', '|', ' ', ' ', ' ', ' ', '|' },
            { '|', '_', '_', '_', '_', '_', ' ', '|', ' ', ' ', ' ', '|', ' ', '|', '$', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', '|', ' ', '|', '_', '_', '_', '|', ' ', ' ', '|', ' ', '|' },
            { '|', ' ', '_', '_', '_', '_', '_', '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|', ' ', '_', '|', ' ', '|' },
            { '|', ' ', '|', '#', '|', ' ', '|', ' ', ' ', ' ', '¤', ' ', ' ', '£', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|' },
            { '|', ' ', '|', ' ', '|', ' ', '|', ' ', ' ', ' ', 'a', '\u2665', '$', ' ', '£', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|' },
            { '|', ' ', '|', ' ', '|', ' ', '|', '_', '_', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|', ' ', ' ', '|' },
            { '|', ' ', '/', ' ', '|', ' ', '£', ' ', ' ', ' ', ' ', '|', '£', '|', '_', '_', ' ', '|', '_', '_', '_', ' ', '|' },
            { '|', ' ', '£', ' ', ' ', ' ', '|', ' ', ' ', ' ', '_', '|', ' ', '|', ' ', ' ', ' ', '|', '#', ' ', '£', ' ', '|' },
            { '|', ' ', '|', ' ', ' ', ' ', '|', ' ', ' ', '£', ')', '|', '$', '|', '$', ' ', ' ', '|', ' ', ' ', '£', ' ', '|' },
            { '|', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '|', '_', '_', '_', '_', '_', '_', '_', '_', ' ', '_', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '$', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|' },
            { '|', ' ', ' ', '#', '|', '_', '|', '$', ' ', ' ', '£', '|', ' ', ' ', ' ', ' ', ' ', ' ', '$', '|', ' ', ' ', '|' },
            { '|', ' ', ' ', '#', '|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', '_', ' ', '|' },
            { '|', ' ', '_', '_', '|', ' ', '|', '_', '_', '_', '_', '_', ' ', ' ', '£', ' ', ' ', ' ', '$', '|', ' ', ' ', '|' },
            { '|', '£', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', '_', '_', '_', '_', '_', '_', '|', ' ', '_', '|' },
            { '|', ' ', ' ', ' ', '|', ' ', ' ', '£', '£', '£', '#', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', '|', ' ', '_', '_', '_', '_', '_', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', '£', '|' },
            { '\\', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', '£', '_', '_', '_', '_', '_', ' ', '|', '_', ' ', '|' },
            { '/', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', 'B', ' ', '|', ' ', ' ', ' ', '$', '|', ' ', ' ', ' ', ' ', '$', '|', ' ', ' ', ' ', ' ', '|' },
            { '|', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '|' },//23
        };
        char[,] cellarLevel = new char[,]
        {  //  1    2    3    4    5    6    7    8    9   10   11   12   13   14   15   16   17   18   19   20   21   22   23      // DISARMA MINOR?!
            { '_', '_', '_', '_', '_', '_', '_' },
            { ')', '@', ' ', ' ', '£', 'M', '_' },
            { '_', ' ', ' ', ' ', '_', '_', '_' },
            { '_', ' ', ' ', '¤', ' ', ' ', '_' },
            { '_', ' ', ' ', ' ', ' ', ' ', '_' },
            { '_', '$', ' ', ' ', ' ', '#', '_' },
            { '_', '_', '_', '_', '_', '_', '_' },
        };

        Assassin assassin = new Assassin(2, "Brassassin");
        Butcher butcher = new Butcher(2, "Stina Styckare");
        Archer archer = new Archer(2, "Pilgrimm");
        Mage mage = new Mage(2, "YoLaBero");
        Assassin assassin1 = new Assassin(2, "Knasassin");
        Butcher butcher1 = new Butcher(2, "Styck-Steffe");
        Mage mage1 = new Mage(2, "TrippTrappTroll");
        Archer archer1 = new Archer(2, "Fjäder-Fjodor");
        Archer archer3 = new Archer(2, "Benny-Båge");
        Assassin assassin4 = new Assassin(2, "Nino");
        Butcher butcher3 = new Butcher(2, "Mike-Muscels");
        Mage mage2 = new Mage(2,  "Maggie");
        Mage mage3 = new Mage(2,  "LaserLasse");
        Butcher butcher2 = new Butcher(2,  "SlaktarnFrånSkara");
        Assassin assassin3 = new Assassin(2, "Portuguisian");
        Sceletons sceletons = new Sceletons(1, "Ben-rangel");

        Assassin invisibleAssassin = new Assassin(2, "Syns int");

        ButcherBoss butcherBoss = new ButcherBoss(1, "Boss Butcher");
        List<Enemy> enemies = new List<Enemy> {mage, butcher, archer, sceletons, assassin, assassin1, archer1, butcher3,
        assassin3, butcher2, assassin4, mage2, mage3, archer3, butcher1, mage1};

        List<Item> itemsLevel2 = new List<Item>() {
        new Consumable(),
        new THelm("Greater Plåthjälm", 5, 20, 15, 0, 4),
        new THelm("Truckerkeps", 5, 10, 5, 20, 3),
        new TWeapon("SplitYouInTwo", 18, 5, 0, 10, 3),
        new TWeapon("Stomper", 20, 7, 0, 5, 4),
        new TBoots("Springskor", 0, 15, 5, 20, 3),
        new TBoots("AirMax", 0, 17, 10, 20, 4),
        new TGloves("GangsterGloves", 10, 20, 15, 0, 4),
        new TGloves("Tummisar", 8, 15, 12, 5, 3),
        new TBreastPlate("Chainmail", 5, 20, 20, 0, 4),
        new TBreastPlate("GoreTex-jacka", 5, 17, 10, 20, 3),
        new TLegs("Kalasbyxor", 5, 20, 10, 15, 3),
        new TLegs("Adidas", 7, 15, 12, 20, 4)};

        List<Chest> chests = new List<Chest>() { new Chest(itemsLevel2), new Chest(itemsLevel2), new Chest(itemsLevel2), new Chest(itemsLevel2), new Chest(itemsLevel2), new Chest(itemsLevel2), new Chest(itemsLevel2), new Chest(itemsLevel2) };
        Merchant merchant = new Merchant("Merchant", 1000, itemsLevel2);

        CellarMap level = new CellarMap(gameLevel, cellarLevel, invisibleAssassin, enemies, chests, butcherBoss, merchant);
        return level;

    }
    #endregion

    #region LEVEL 3
    public static Map Level3()
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
            { '|', ' ', ' ', ' ', ' ', ' ', 'a', ' ', '£', ' ', ' ', ' ', ' ', ' ', ' ', '|', '$', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', '_', '_', '_', ' ', '_', '_', '_', '_', '|', ' ', ' ', '|', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', '|', '_', 'B', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '£', ' ', '|', '£', '|', ' ', ' ', '|', '#', '/' },
            { '|', ' ', '_', '_', '_', '_', '_', '|', ' ', ' ', ' ', ' ', ' ', ' ', '#', '|', ' ', ' ', '|', ' ', ' ', '|', '|' },
            { '|', ' ', '|', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '$', '|', ' ', ' ', '#', '|', ' ', '@', '=' },
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
        Assassin assassinInvisable = new Assassin(1, "Inge-visable");
        List<Enemy> enemies = new List<Enemy> {mage, butcher, archer, assassin, assassin1, archer1, archer2, butcher3,
        assassin3, butcher2, assassin4, mage2, mage3, archer3, butcher1, mage1};

        List<Item> itemsLevel3 = new List<Item>() {
        new Consumable(),
        new THelm("Greatest Plåthjälm", 10, 25, 20, 0, 5),
        new THelm("Balaclava", 5, 12, 10, 30, 4),
        new TWeapon("Bra pinne", 25, 5, 0, 10, 4),
        new TWeapon("Stock", 30, 10, 5, 0, 5),
        new TBoots("Buffalos", 0, 24, 15, 10, 4),
        new TBoots("Bagheera", 0, 22, 10, 30, 4),
        new TGloves("Knogjärn", 20, 5, 5, 10, 4),
        new TBreastPlate("Canada Goose", 10, 25, 25, 0, 5)};

        List<Chest> chests = new List<Chest>() { new Chest(itemsLevel3), new Chest(itemsLevel3), new Chest(itemsLevel3), new Chest(itemsLevel3), new Chest(itemsLevel3), new Chest(itemsLevel3) };

        DarkMap level = new DarkMap(gameLevel, enemies, assassinInvisable, chests, assassinBoss, null);
        return level;
    }
    #endregion

    // #region LEVEL 4
    // public static Map Level4(Player player) // Tom bana
    // {
    //     char[,] gameLevel = new char[,]
    //     {  //  1    2    3    4    5    6    7    8    9   10   11   12   13   14   15   16   17   18   19   20   21   22   23     
    //         { '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_' },
    //         { '=', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '@', '|' },
    //         { '|', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '|' },//23
    //     };

    //     Assassin assassin = new Assassin(4, "Fegkräk");
    //     Butcher butcher = new Butcher(4, "Slaktarn");
    //     Archer archer = new Archer(4, "Lena-Långbåge");
    //     Mage mage = new Mage(4, "Magiska-Lars");
    //     Assassin assassin1 = new Assassin(4, "Assassinator");
    //     Butcher butcher1 = new Butcher(4, "Gimli");
    //     Mage mage1 = new Mage(4, "Gandalf");
    //     Archer archer1 = new Archer(4, "Legolas");
    //     Archer archer2 = new Archer(4, "Robin Hood");
    //     Archer archer3 = new Archer(4, "Hawkeye");
    //     Assassin assassin4 = new Assassin(4, "Ninja");
    //     Butcher butcher3 = new Butcher(4, "Berzerker");
    //     Mage mage2 = new Mage(4, "Moon Queen");
    //     Mage mage3 = new Mage(4, "Magic-Mike");
    //     Butcher butcher2 = new Butcher(4, "Butchie");
    //     Assassin assassin3 = new Assassin(4, "Asian");

    //     AssassinBoss assassinBoss = new AssassinBoss(4, "Smygehuk");
    //     List<Enemy> enemiesLevel1 = new List<Enemy> {mage, butcher, archer, assassin, assassin1, archer1, archer2, butcher3,
    //     assassin3, butcher2, assassin4, mage2, mage3, archer3, butcher1, mage1};
    //     List<Item> items = new List<Item>() {new Consumable(), new THelm("Plåthjälm", 5, 30, 20, 0),
    //     new TWeapon("Gimlis Yxa", "Yxa", 40, 10, 0, 20), new TWeapon("Legolas Pilbåge", "Pilbåge", 30, 15, 5, 15),
    //     new TBoots("Foppatofflor", 5, 0, 5, -5), new TGloves("Plåthandskar", 5, 30, 20, 5), new TLegs("Läderbyxor", 0, 20, 15, 20) };
    //     List<Chest> chestsLevel1 = new List<Chest>() { new Chest(items), new Chest(items), new Chest(items), new Chest(items), new Chest(items), new Chest(items) };

    //     Merchant merchant = new Merchant("Merchant", 1000, items);

    //     RegularMap level1 = new RegularMap(gameLevel, enemiesLevel1, chestsLevel1, assassinBoss, merchant);
    //     return level1;
    // }
    // #endregion

    // #region LEVEL 5
    // public static Map Level5(Player player)
    // {
    //     char[,] gameLevel = new char[,]
    //     {  //  1    2    3    4    5    6    7    8    9   10   11   12   13   14   15   16   17   18   19   20   21   22   23      
    //         { '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_' },
    //         { '=', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
    //         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '@', '|' },
    //         { '|', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '|' },//23
    //     };

    //     Assassin assassin = new Assassin(5, "Fegkräk");
    //     Butcher butcher = new Butcher(5, "Slaktarn");
    //     Archer archer = new Archer(5, "Lena-Långbåge");
    //     Mage mage = new Mage(5, "Magiska-Lars");
    //     Assassin assassin1 = new Assassin(5, "Assassinator");
    //     Butcher butcher1 = new Butcher(5, "Gimli");
    //     Mage mage1 = new Mage(5, "Gandalf");
    //     Archer archer1 = new Archer(5, "Legolas");
    //     Archer archer2 = new Archer(5, "Robin Hood");
    //     Archer archer3 = new Archer(5, "Hawkeye");
    //     Assassin assassin4 = new Assassin(5, "Ninja");
    //     Butcher butcher3 = new Butcher(5, "Berzerker");
    //     Mage mage2 = new Mage(5, "Moon Queen");
    //     Mage mage3 = new Mage(5, "Magic-Mike");
    //     Butcher butcher2 = new Butcher(5, "Butchie");
    //     Assassin assassin3 = new Assassin(5, "Asian");

    //     AssassinBoss assassinBoss = new AssassinBoss(5, "Smygehuk");
    //     List<Enemy> enemiesLevel1 = new List<Enemy> {mage, butcher, archer, assassin, assassin1, archer1, archer2, butcher3,
    //     assassin3, butcher2, assassin4, mage2, mage3, archer3, butcher1, mage1};
    //     List<Item> items = new List<Item>() {new Consumable(), new THelm("Plåthjälm", 5, 30, 20, 0),
    //     new TWeapon("Gimlis Yxa", "Yxa", 40, 10, 0, 20), new TWeapon("Legolas Pilbåge", "Pilbåge", 30, 15, 5, 15),
    //     new TBoots("Foppatofflor", 5, 0, 5, -5), new TGloves("Plåthandskar", 5, 30, 20, 5), new TLegs("Läderbyxor", 0, 20, 15, 20) };
    //     List<Chest> chestsLevel1 = new List<Chest>() { new Chest(items), new Chest(items), new Chest(items), new Chest(items), new Chest(items), new Chest(items) };

    //     Merchant merchant = new Merchant("Merchant", 1000, items);

    //     RegularMap level1 = new RegularMap(gameLevel, enemiesLevel1, chestsLevel1, assassinBoss, merchant);
    //     return level1;
    // }
    // #endregion
}
#endregion