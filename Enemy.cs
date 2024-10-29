public class Enemy : GameObject
{
    public int XpDrop = 33;
    //Lägg till en AggroRange senare

    public Enemy()
    {
        Random random = new Random();
        Name = "Enemy";
        Description = "Enemy";
        BaseHp = 75 + random.Next(0, 25);
        CurrentHp = TotalHp;
        BaseDamage = 10 + random.Next(0, 10);
        BaseResistance = 0 + random.Next(0, 5);
        BaseAgility = 5 + random.Next(0, 5);
    }

    public string Attack(Player player)
    {

        Random random = new Random();
        double damageDone = TotalDamage + random.Next(0, 10) - player.TotalResistance;
        player.CurrentHp -= damageDone;
        return $"<-- {damageDone} DMG";
    }


    public void ShowHp()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{CurrentHp}/{TotalHp}({PercentHp:F0}%)");
        Console.ResetColor();
    }
}