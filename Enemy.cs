public class Enemy : GameObject
{
    public int XpDrop = 25;

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
    public void Attack(Player player)
    {
        double damageDone = TotalDamage - player.TotalResistance;
        player.CurrentHp -= damageDone;
        Console.WriteLine($"{player.Name} tog {damageDone} i skada");
    }
}