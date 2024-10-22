public class Enemy : GameObject
{
    

    public Enemy()
    {
        Name = "Krister";
        Description = "Enemy";
        BaseHp = 75;
        TotalHp = BaseHp;
        CurrentHp = TotalHp;
        BaseDamage = 15;
        TotalDamage = BaseDamage;
        BaseResistance = 0;
        TotalResistance = BaseResistance;   
        BaseAgility = 10;
        TotalAgility = BaseAgility;
        //Aggro-range
    }
}