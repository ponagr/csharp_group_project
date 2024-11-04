public class Assassin : Enemy
{

    // ASSASSIN - Ta mycket skada, vara osynlig, snabb rörlighet
    // KLUMPEN - Mycket skada, mycket hp, långsam
    // PILBÅGSSKYTT - Attackerar från avstånd, lite hp & resistance

    public bool isVisable;

    public Assassin(Player player) : base(player)
    {
        double multiplier = player.Level * 0.5;
        Random random = new Random();
        Name = "Lönnmördaren";
        Description = "Assassin";
        BaseHp = 75 + random.Next(0, 25) * multiplier;
        CurrentHp = TotalHp;
        BaseDamage = 15 + random.Next(0, 10) * multiplier;
        BaseResistance = 0 + random.Next(0, 5) * multiplier;
        BaseAgility = 15 * multiplier;

        healthBar = new HealthBar();

        isVisable = false;
    }

    public double StealthAttack()
    {
        double damage;
        damage = TotalDamage * 1.5;

        return damage;
    }

    public override string TakeDamage(double damage, out bool hitable)
    {
        if (isVisable)
        {
            return base.TakeDamage(damage, out hitable);
        }
        else
        {
            hitable = false;
            return $"Miss!";
        }
    }


    public override string Attack(Player player, out string critical)
    {
        Random rndVisable = new Random();

        if (isVisable)
        {
            int magicNumber = rndVisable.Next(1, 3);

            if (magicNumber == 1)
            {
                isVisable = false;
            }
            return base.Attack(player, out critical);
        }
        else // När fienden är osynlig
        {

            isVisable = true;
            critical = "Kniv i ryggen";
            double damage = StealthAttack();
            player.CurrentHp -= damage;
            string message = $"<-- {damage:F0}";
            return message;
        }
    }
}