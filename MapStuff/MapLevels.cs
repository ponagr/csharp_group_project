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
            { '|', '@', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '¤', ' ', '|', '#', '|', '#', '|', ' ', ' ', ' ', ' ', 'B', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', '$', '|', '#', '|', ' ', ' ', ' ', ' ', '|', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', '£', '|', '_', '|', ' ', ' ', ' ', ' ', '|', ' ', '|' },
            { '|', '/', ' ', ' ', ' ', ' ', ' ', ' ', '|', '¤', ' ', '|', '£', ' ', ' ', ' ', ' ', ' ', ' ', '_', '|', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '£', ' ', '|', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', '¤', '|', ' ', ' ', '|', '$', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '\\' },
            { '|', ' ', '_', '_', '|', ' ', '|', '_', '_', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '/' },
            { '|', ' ', '#', '$', '|', ' ', '|', '$', ' ', ' ', ' ', '|', '£', '|', '_', '_', ' ', ' ', ' ', '_', '_', '_', '|' },
            { '|', ' ', ' ', ' ', '|', ' ', '|', ' ', '£', ' ', ' ', '|', '$', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', '|', ' ', '|', '$', ' ', ' ', ' ', '|', '$', '|', ' ', ' ', ' ', ' ', ' ', ' ', '£', ' ', '|' },
            { '|', '_', '_', '_', '_', '£', '_', '_', '_', '_', '_', '|', '_', '_', '_', '_', '_', '_', '_', '_', ' ', '_', '|' },
            { '|', ' ', ' ', ' ', '|', ' ', '|', ' ', ' ', ' ', ' ', '|', ' ', ' ', '$', ' ', ' ', ' ', ' ', '|', ' ', 'H', '|' },
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
        Archer archer = new Archer(1, "Lena-Långbåge");
        Mage mage = new Mage(1, "Magiska-Lars");
        Assassin assassin1 = new Assassin(1, "Assassinator");
        Mage mage1 = new Mage(1, "Gandalf");
        Archer archer1 = new Archer(1, "Legolas");
        Archer archer2 = new Archer(1, "RubenInTheHood");
        Archer archer3 = new Archer(1, "Fia-Falköga");
        Assassin assassin4 = new Assassin(1, "Kassassin");
        Mage mage2 = new Mage(2, "Moon Queen");
        Mage mage3 = new Mage(2, "Magic-Mike");
        Butcher butcher = new Butcher(1, "Butchie");
        Assassin assassin3 = new Assassin(1, "Asian");

        Assassin assassinInvisable = new Assassin(1, "Inge-visable");
        ArcherBoss archerBoss = new ArcherBoss(1, "PilIMagenAB");


        List<Enemy> enemiesLevel1 = new List<Enemy> {archer, archer3, mage, assassin, assassin1, archer1, archer2, mage1,
        assassin3, mage3, assassin4, mage2, butcher};
        List<Item> items = new List<Item>()
        {new Consumable(),
        new THelm("Plåthjälm", 5, 10, 10, 0, 1),
        new THelm("Tomteluva", 0, 5, 5, 15, 2),
        new TWeapon("Gimlis Yxa", 8, 5, 0, 6, 2),
        new TWeapon("Legolas Pilbåge", 8, 5, 5, 10, 1),
        new TWeapon("Slunger", 9, 0, 5, 7, 2),
        new TBoots("Foppatofflor", 5, 0, 5, -5, 1),
        new TBoots("Träskor", 8, 5, 5, 0, 2),
        new TGloves("Plåthandskar", 5, 10, 10, 5, 2),
        new TGloves("Trädgårdshandskar", 2, 7, 5, 8, 1),
        new TLegs("Läderbyxor", 0, 7, 5, 10, 1),
        new TLegs("Manchesterbrallor", 0, 8, 9, 7, 2),
        new TBreastPlate("Hoodie", 0, 8, 5, 10, 1),
        new TBreastPlate("Rostig rustning", 5, 10, 10, 0, 2) };
        List<Chest> chestsLevel1 = new List<Chest>() { new Chest(items), new Chest(items), new Chest(items), new Chest(items), new Chest(items), new Chest(items) };

        RegularMap level1 = new RegularMap(gameLevel1, enemiesLevel1, assassinInvisable, chestsLevel1, archerBoss, null);
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
            { '|', ' ', '|', '#', '|', 'H', '|', ' ', ' ', ' ', '¤', ' ', ' ', '£', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|' },
            { '|', ' ', '|', ' ', '|', ' ', '|', ' ', ' ', ' ', 'a', ' ', '$', ' ', '£', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|' },
            { '|', ' ', '|', ' ', '|', ' ', '|', '_', '_', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|', ' ', ' ', '|' },
            { '|', ' ', '/', '£', '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', '£', '|', '_', '_', ' ', '|', '_', '_', '_', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', '_', '|', ' ', '|', ' ', ' ', ' ', '|', '#', ' ', '£', ' ', '|' },
            { '|', '£', '|', ' ', ' ', ' ', '|', ' ', ' ', '£', ')', '|', '$', '|', '$', ' ', ' ', '|', ' ', ' ', '£', ' ', '|' },
            { '|', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '|', '_', '_', '_', '_', '_', '_', '_', '_', ' ', '_', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '$', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|' },
            { '|', ' ', ' ', '#', '|', '_', '|', '$', ' ', ' ', '£', '|', ' ', ' ', ' ', ' ', ' ', ' ', '$', '|', ' ', ' ', '|' },
            { '|', ' ', ' ', '#', '|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', '_', ' ', '|' },
            { '|', ' ', '_', '_', '|', ' ', '|', '_', '_', '_', '_', '_', ' ', ' ', '£', ' ', ' ', ' ', '$', '|', ' ', ' ', '|' },
            { '|', '£', ' ', ' ', '|', ' ', ' ', '£', '£', ' ', ' ', '|', ' ', '_', '_', '_', '_', '_', '_', '|', ' ', '_', '|' },
            { '|', ' ', ' ', ' ', '|', ' ', ' ', '£', '£', '#', '$', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|' },
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
            { '_', '$', ' ', ' ', ' ', '$', '_' },
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
        Mage mage2 = new Mage(2, "Maggie");
        Mage mage3 = new Mage(2, "LaserLasse");
        Butcher butcher2 = new Butcher(2, "SlaktarnFrånSkara");
        Assassin assassin3 = new Assassin(2, "Portuguisian");
        Sceletons sceletons = new Sceletons(2, "Ben-rangel");
        Sceletons sceletons2 = new Sceletons(2, "Knot-Kalle");
        Sceletons sceletons3 = new Sceletons(2, "Benny");

        Assassin invisibleAssassin = new Assassin(2, "Syns int");

        ButcherBoss butcherBoss = new ButcherBoss(2, "Boss Butcher");
        List<Enemy> enemies = new List<Enemy> {mage, butcher, archer, sceletons2, sceletons, sceletons3, assassin, assassin1, archer1, butcher3,
        assassin3, butcher2, assassin4, mage2, mage3, archer3, butcher1, mage1};

        List<Item> itemsLevel2 = new List<Item>() {
        new Consumable(),
        new THelm("Plåtsmula", 5, 20, 15, 0, 5),
        new THelm("Truckerkeps", 5, 10, 5, 20, 4),
        new TWeapon("SplitUIn2", 18, 5, 0, 10, 4),
        new TWeapon("Stomper", 20, 7, 0, 5, 5),
        new TBoots("Springskor", 0, 15, 5, 20, 4),
        new TBoots("AirMax", 0, 17, 10, 20, 5),
        new TGloves("G'Gloves", 10, 20, 15, 0, 5),
        new TGloves("Tummisar", 8, 15, 12, 5, 4),
        new TBreastPlate("Chainmail", 5, 20, 20, 0, 5),
        new TBreastPlate("GoreTex", 5, 17, 10, 20, 4),
        new TLegs("Kalasbyxor", 5, 20, 10, 15, 4),
        new TLegs("Adidas", 7, 15, 12, 20, 5)};

        List<Item> merchantItems = new List<Item>() {
        new THelm("Plåtsmula", 5, 20, 15, 0, 5),
        new THelm("Truckerkeps", 5, 10, 5, 20, 4),
        new TWeapon("SplitUIn2", 18, 5, 0, 10, 4),
        new TWeapon("Stomper", 20, 7, 0, 5, 5),
        new TBoots("Springskor", 0, 15, 5, 20, 4),
        new TBoots("AirMax", 0, 17, 10, 20, 5),
        new TGloves("G'Gloves", 10, 20, 15, 0, 5),
        new TGloves("Tummisar", 8, 15, 12, 5, 4),
        new TBreastPlate("Chainmail", 5, 20, 20, 0, 5),
        new TBreastPlate("GoreTex", 5, 17, 10, 20, 4),
        new TLegs("Kalasbyxor", 5, 20, 10, 15, 4),
        new TLegs("Adidas", 7, 15, 12, 20, 5)};

        List<Chest> chests = new List<Chest>() { new Chest(itemsLevel2), new Chest(itemsLevel2), new Chest(itemsLevel2), new Chest(itemsLevel2), new Chest(itemsLevel2), new Chest(itemsLevel2), new Chest(itemsLevel2), new Chest(itemsLevel2) };
        Merchant merchant = new Merchant("Merchant", 1000, merchantItems);

        CellarMap level2 = new CellarMap(gameLevel, cellarLevel, invisibleAssassin, enemies, chests, butcherBoss, merchant);
        return level2;

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
            { '|', ' ', '|', '#', ' ', ' ', ' ', ' ', ' ', 'H', '|', '£', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|' },
            { '|', ' ', '|', '_', '_', '_', '_', '_', '_', '_', '_', ' ', '|', ' ', '|', '_', '_', ' ', '_', '_', '|', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', '£', '|', '#', '|', ' ', ' ', ' ', '|', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|', ' ', '|', ' ', ' ', ' ', '|', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|', '_', '_', '_', '_', '_', '|', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', 'a', ' ', '£', ' ', ' ', ' ', ' ', ' ', ' ', '|', '$', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '/', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', '_', '_', '_', ' ', '_', '_', '_', '_', '|', ' ', ' ', '|', ' ', ' ', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', '|', '_', 'B', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '£', ' ', '|', '£', '|', ' ', ' ', '|', ' ', '/' },
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
        Archer archer4 = new Archer(3, "ArrowMax");
        Assassin assassin4 = new Assassin(3, "Ninja");
        Butcher butcher3 = new Butcher(3, "Berzerker");
        Mage mage2 = new Mage(3, "Moon Queen");
        Mage mage3 = new Mage(3, "Magic-Mike");
        Butcher butcher2 = new Butcher(3, "Butchie");
        Assassin assassin3 = new Assassin(3, "Asian");

        AssassinBoss assassinBoss = new AssassinBoss(3, "Smygehuk");
        Assassin assassinInvisable = new Assassin(3, "Inge-visable");
        List<Enemy> enemies = new List<Enemy> {archer4, butcher, archer, assassin, assassin1, archer1, archer2, butcher3,
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

        DarkMap level3 = new DarkMap(gameLevel, enemies, assassinInvisable, chests, assassinBoss, null);
        return level3;
    }
    #endregion
    #region LEVEL 4
    public static Map Level4()
    {

        char[,] gameLevel = new char[,]
        {  //  1    2    3    4    5    6    7    8    9   10   11   12   13   14   15   16   17   18   19   20   21   22   23
        { '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_' },
        { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
        { '|', ' ', ' ', ' ', ' ', '|', '_', '_', '_', '_', '_', '_', '_', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
        { '|', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', '£', '|' },
        { '|', '_', '£', '_', '_', '_', ' ', '_', '_', '_', '_', '_', '_', '_', '|', ' ', ' ', ' ', ' ', ' ', '_', ' ', '|' },
        { '|', ' ', ' ', '|', '$', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|' },
        { '|', ' ', ' ', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|' },
        { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '$', '|', 'M', ' ', '|', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|' },
        { '|', ' ', ' ', ' ', ' ', ' ', ' ', '$', '$', '|', ' ', ' ', '|', ' ', '|', '_', '_', '_', ' ', ' ', '|', ' ', '|' },
        { '|', ' ', ' ', ' ', ' ', ' ', ' ', '$', '$', '|', '$', '$', '|', ' ', '£', ' ', ' ', '|', ' ', ' ', '|', ' ', '|' },
        { '|', ' ', ' ', ' ', '£', ' ', ' ', ' ', '$', '|', '$', '$', '|', ' ', '£', ' ', '#', '|', ' ', '#', '|', '£', '|' },
        { '|', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', ' ', '|' },
        { '|', ' ', ' ', 'H', '|', ' ', ' ', '|', ' ', ' ', ' ', ' ', '|', '#', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
        { '|', ' ', ' ', ' ', '£', ' ', ' ', '|', ' ', ' ', ' ', ' ', '£', ' ', '|', ' ', ' ', '$', '$', ' ', ' ', ' ', '|' },
        { '|', ' ', ' ', ' ', '|', ' ', ' ', '|', 'a', ' ', ' ', ' ', '|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
        { '|', ' ', ' ', ' ', '£', ' ', ' ', '|', '_', '_', ' ', '_', '_', '_', '|', '_', '_', '_', '_', '_', '_', '_', '|' },
        { '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', '|', '£', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', '$', '|' },
        { '|', ' ', ' ', ' ', '£', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', '£', ' ', '$', '|' },
        { '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', '£', ' ', '$', '|' },
        { '|', ' ', ' ', ' ', '£', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', '£', 'B', '$', '|' },
        { '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', '£', ' ', '$', '|' },
        { '|', ' ', ' ', ' ', '£', ' ', ' ', ' ', ' ', '|', '@', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', '$', '|' },
        { '|', '_', '_', '_', '_', '_', '_', '_', '_', '_', '=', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '|' },//23
        };

        Assassin assassin = new Assassin(4, "Sassassin");
        Assassin assassin1 = new Assassin(4, "Brassassin");
        Assassin assassin2 = new Assassin(4, "Massassin");
        Assassin assassin3 = new Assassin(4, "Ninja");
        Mage mage = new Mage(4, "GlitterStoffE");
        Mage mage1 = new Mage(4, "Mirakel-Mats");
        Mage mage2 = new Mage(4, "Abbe-kadabra");
        Mage mage3 = new Mage(4, "Hokus-Pokus Henrik");
        Butcher butcher = new Butcher(4, "fromBronx");
        Butcher butcher1 = new Butcher(4, "Ove Hacka");
        Butcher butcher2 = new Butcher(4, "Sofia Snitzel");
        Butcher butcher3 = new Butcher(4, "Pelle Pölsa");
        Archer archer = new Archer(4, "Aim-Eva");
        Archer archer1 = new Archer(4, "Pil-Pelle");
        Archer archer2 = new Archer(4, "Fjäderfjärt");
        Archer archer3 = new Archer(4, "Pilback");
        Archer archer4 = new Archer(4, "SlutaPila"); // 17 st

        MageBoss mageBoss = new MageBoss(4, "IllusiUno");
        Assassin Massassin = new Assassin(4, "SerInga-Lill");

        List<Enemy> enemies1 = new List<Enemy> { assassin, assassin1 };
        List<Enemy> enemies2 = new List<Enemy> { assassin2, assassin3, mage, mage1, mage2 };
        List<Enemy> enemies3 = new List<Enemy> { mage3, archer, archer1, archer2 };
        List<Enemy> enemies4 = new List<Enemy> { archer3, archer4 };
        List<Enemy> enemiesBeforeBoss = new List<Enemy> { butcher, butcher1, butcher2, butcher3 };

        // List<Enemy> enemies1 = new List<Enemy> {archer1};
        // List<Enemy> enemies2 = new List<Enemy> {archer2};
        // List<Enemy> enemies3 = new List<Enemy> {archer3};
        // List<Enemy> enemies4 = new List<Enemy> {archer4 };
        // List<Enemy> enemiesBeforeBoss = new List<Enemy> {butcher};

        List<Item> itemsLevel4 = new List<Item>() {
        new Consumable(),
        new THelm("theHelm", 10, 40, 30, 10, 6),
        new THelm("Zulu-hjälm", 8, 35, 20, 15, 5),
        new TWeapon("Klyvyxa", 35, 10, 5, 10, 5),
        new TWeapon("theAxe", 40, 15, 5, 25, 6),
        new TBoots("theBoots", 10, 40, 20, 12, 6),
        new TBoots("Bagheera", 5, 34, 22, 25, 5),
        new TGloves("theGloves", 20, 40, 20, 15, 6),
        new TBreastPlate("thePlate", 15, 40, 30, 10, 6)};

        List<Item> merchantItemsLevel4 = new List<Item>() {
        new Consumable(),
        new THelm("theHelm", 10, 40, 30, 10, 6),
        new THelm("Zulu-hjälm", 8, 35, 20, 15, 5),
        new TWeapon("Klyvyxa", 35, 10, 5, 10, 5),
        new TWeapon("theAxe", 40, 15, 5, 25, 6),
        new TBoots("theBoots", 10, 40, 20, 12, 6),
        new TBoots("Bagheera", 5, 34, 22, 25, 5),
        new TGloves("theGloves", 20, 40, 20, 15, 6),
        new TBreastPlate("thePlate", 15, 40, 30, 10, 6)};

        List<Chest> chestsLevel4 = new List<Chest>() { new Chest(itemsLevel4), new Chest(itemsLevel4), new Chest(itemsLevel4), new Chest(itemsLevel4), new Chest(itemsLevel4), new Chest(itemsLevel4) };
        Merchant merchantLevel4 = new Merchant("KolleKöpman", 1000, merchantItemsLevel4);

        MapWithRooms level4 = new MapWithRooms(gameLevel, enemies1, enemies2, enemies3, enemies4, enemiesBeforeBoss, Massassin, chestsLevel4, mageBoss, merchantLevel4);
        return level4;
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