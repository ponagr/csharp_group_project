public class Sceletons : Enemy
{
    public Sceletons(int level, string name)
    {
        double multiplier = level * 0.60;
        Random random = new Random();
        Name = name; 
        Description = "Sceletons";
        BaseHp = 1;
        CurrentHp = TotalHp;
        BaseDamage = (30 + random.Next(0, 30)) * multiplier; // Standard attackskada
        BaseResistance = 0;
        BaseAgility = 0;

        healthBar = new HealthBar();
        XpDrop = 15;
    }

    public override void PrintCharacter(Enemy enemy)
    {
        Textures.PrintSceletons();
    }

    public override string TakeDamage(double damage, bool crit, out string attackMessage)
    {
        attackMessage = "";
        return "";
    }

    public override string Attack(Player player, out string attackMessage) // Borde attackMessage heta typ fightmessage eller attackinfo?
    {
        player.CurrentHp -= BaseDamage;
        CurrentHp = 0;
        attackMessage = "SUICIDE";
        return $"{BaseDamage:F0}";
    }
}