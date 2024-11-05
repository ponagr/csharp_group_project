public class Butcher : Enemy
{

    // ASSASSIN - Ta mycket skada, vara osynlig, snabb rörlighet
    // KLUMPEN - Mycket skada, mycket hp, långsam
    // PILBÅGSSKYTT - Attackerar från avstånd, lite hp & resistance

    public bool hasShield;
    private int bigHit;
    private bool needsRest;

    public Butcher(Player player) : base(player)
    {
        double multiplier = player.Level * 0.5;
        Random random = new Random();
        Name = "Slaktar-Sluggo";
        Description = "Butcher";
        BaseHp = 100 + random.Next(0, 25) * multiplier;
        CurrentHp = TotalHp;
        BaseDamage = 20 + random.Next(0, 10) * multiplier;
        BaseResistance = 10 + random.Next(0, 5) * multiplier;
        BaseAgility = 5 * multiplier;
        bigHit = 2;
        needsRest = false;
        healthBar = new HealthBar();

        hasShield = false;
    }

    public override string Attack(Player player, out string attackMessage)
    {
        bigHit++;
        if (bigHit == 3) // BIGHIT
        {
            double damageDone = BigHit();
            bigHit = 0;
            needsRest = true;
            player.CurrentHp -= damageDone;
            attackMessage = "MASSIVE HIT!";
            return $"<-- {damageDone:F0} DMG";
        }
        else if (needsRest) // Behöver vila
        {
            needsRest = false;
            attackMessage = "Butcher needs";
            return "to rest!";
        }   
        else // Vanlig attack
        {
            return base.Attack(player, out attackMessage);
        }    
    }

    public double BigHit()
    {
        double damage;
        damage = TotalDamage * 2;

        return damage;
    }

    public double BlockedAttack()
    {
        double damage;
        damage = TotalDamage * 0.5;

        return damage;
    }



    public override string TakeDamage(double damage, bool crit, out string attackMessage)
    {
        Random rndShield = new Random();
        int magicNumber = rndShield.Next(1, 3);

        bool hasShield = (magicNumber == 1) ? hasShield = true : hasShield = false;

        if (!hasShield || needsRest)
        {
            return base.TakeDamage(damage, crit, out attackMessage);
        }
        else
        {
            damage = BlockedAttack();
            CurrentHp -= damage;
            attackMessage = "Blocked!";
            return $"DMG {damage:F0} -->";
        }
    }
}