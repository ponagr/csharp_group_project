public abstract class Map
{
    //EN MAP, innehåller massa olika fiender och items osv specifikt för mappen
    public char[,] Maplevel { get; set; }
    public char[,] CellarLevel { get; set; }
    public Merchant? Merchant { get; set; }
    public Assassin? Assassin { get; set; }
    public List<Enemy> Enemies { get; set; }
    public List<Chest> Chests { get; set; }
    public Enemy Boss { get; set; }

}

public class RegularMap : Map
{
    public RegularMap(char[,] map, List<Enemy> enemies, Assassin assassin, List<Chest> chests, Enemy boss, Merchant merchant)
    {
        Maplevel = map;
        Enemies = enemies;
        Chests = chests;
        Boss = boss;
        Merchant = merchant;
        Assassin = assassin;
    }
}

public class CellarMap : Map
{
    public CellarMap(char[,] map, char[,] cellarMap, Assassin assassin, List<Enemy> enemies, List<Chest> chests, Enemy boss, Merchant merchant)
    {
        Maplevel = map;
        CellarLevel = cellarMap;
        Enemies = enemies;
        Chests = chests;
        Boss = boss;
        Merchant = merchant;
        Assassin = assassin;
    }
}

//Används för att skriva ut mappen med dålig sikt
public class DarkMap : Map 
{ 
    public DarkMap(char[,] map, List<Enemy> enemies, Assassin assassin, List<Chest> chests, Enemy boss, Merchant merchant)
    {
        Maplevel = map;
        Enemies = enemies;
        Chests = chests;
        Boss = boss;
        Merchant = merchant;
        Assassin = assassin;
    }

}
