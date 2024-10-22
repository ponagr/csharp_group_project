public class Player : GameObject
{
    public int CurrentXp {get;set;}
    public int MaxXp {get;set;}

    public int Level {get;set;}
    public int Gold {get;set;}

    public Player(string name)
    {
        Name = name;
        Level = 1;
        Gold = 0;
        CurrentXp = 0;
        MaxXp = 100;
        BaseHp = 100;
        TotalHp = BaseHp;
        CurrentHp = TotalHp;
        BaseDamage = 15;
        TotalDamage = BaseDamage;
        BaseResistance = 0;
        TotalResistance = BaseResistance;   
        BaseAgility = 10;
        TotalAgility = BaseAgility;
        // InventoryArray
    }


}