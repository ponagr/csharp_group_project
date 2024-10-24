public class Player : GameObject
{
    public int CurrentXp { get; set; }
    public int MaxXp { get; set; }

    public int Level { get; set; }
    public int Gold { get; set; }

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
        BaseDamage = 20;
        TotalDamage = BaseDamage;
        BaseResistance = 0;
        TotalResistance = BaseResistance;
        BaseAgility = 10;
        TotalAgility = BaseAgility;
        // InventoryArray
    }

    public void Attack(Enemy enemy)
    {
        double damageDone = TotalDamage - enemy.TotalResistance;
        enemy.CurrentHp -= damageDone;
        Console.WriteLine($"{enemy.Name} tog {damageDone} i skada");
    }

    public void EnemyKilled(Enemy enemy)
    {
        CurrentXp += enemy.XpDrop;
        Console.WriteLine($"{Name} fick +{enemy.XpDrop}XP");
        if (CurrentXp >= MaxXp)
        {
            LevelUp();
        }
    }
    public void LevelUp()
    {
        Level++;
        Console.WriteLine($"{Name} are now level: {Level}!");
        MaxXp = MaxXp * 2;
        BaseHp = BaseHp * 1.1;
        BaseDamage = BaseDamage * 1.2;
        BaseResistance = BaseResistance * 1.1;
        BaseAgility = BaseAgility * 1.1;
    }

}