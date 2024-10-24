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
    public string Attack(Player player)
    {
        double damageDone = TotalDamage - player.TotalResistance;
        player.CurrentHp -= damageDone;
        // Console.WriteLine($"{player.Name} tog {damageDone} i skada");
        return $"{player.Name} tog {damageDone} i skada";
    }
    public void ShowHp()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"HP: {CurrentHp}/{TotalHp}({PercentHp:F0}%)");
        Console.ResetColor();
    }
}