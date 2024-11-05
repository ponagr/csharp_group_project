public class AssassinBoss : Assassin
{

    public AssassinBoss(Player player) : base(player)
    { 
        double multiplier = player.Level * 0.5;
        Random random = new Random();
        Name = "Smygehuk";
        Description = "Assassin BOSS";
        BaseHp = base.BaseHp * 1.5; //75 + random.Next(0, 25) * multiplier;
        CurrentHp = TotalHp;
        BaseDamage = base.BaseDamage * 1.5;//15 + random.Next(0, 10) * multiplier;
        BaseResistance = base.BaseResistance * 1.5;//0 + random.Next(0, 5) * multiplier;
        BaseAgility = base.BaseAgility * 1.5;//15 * multiplier;

        healthBar = new HealthBar();

        isVisable = false;

        // base.BaseHp = base.BaseHp * 1.5;
        // base.BaseDamage = base.BaseDamage * 1.5;
        // base.BaseResistance = base.BaseResistance * 1.5;
        // base.BaseAgility = base.BaseAgility * 1.5;
    }

    public double ThrowingKnives(out string attackMessage) 
    {
        double damage = TotalDamage * 2.5;
        attackMessage = "Triple attack!";
        return damage;
    }
    public override string TakeDamage(double damage, bool crit, out string attackMessage)
    {
        return base.TakeDamage(damage, crit, out attackMessage);
    }
    public override string Attack(Player player, out string attackMessage)
    {
        double damage;
        base.Attack(player, out attackMessage);
        if (attackMessage == "CRITICAL")
        {
            Textures.BossAssassinStealthAnimation();
            damage = ThrowingKnives(out attackMessage);
            player.CurrentHp -= damage;
            return $"<-- {damage} DMG";
        }
        else
        {
            return base.Attack(player, out attackMessage);
        }    
    }
}
public class ButcherBoss : Butcher
{
    public ButcherBoss(Player player) : base(player)
    { 
        base.BaseHp = base.BaseHp * 1.5;
        base.BaseDamage = base.BaseDamage * 1.5;
        base.BaseResistance = base.BaseResistance * 1.5;
        base.BaseAgility = base.BaseAgility * 1.5;
    }   

    public override string Attack(Player player, out string attackMessage)
    {
        return base.Attack(player, out attackMessage);
        
    } 
}
public class ArcherBoss : Archer
{
    public ArcherBoss(Player player) : base(player)
    { 
        base.BaseHp = base.BaseHp * 1.5;
        base.BaseDamage = base.BaseDamage * 1.5;
        base.BaseResistance = base.BaseResistance * 1.5;
        base.BaseAgility = base.BaseAgility * 1.5;
    }

    public override string Attack(Player player, out string attackMessage)
    {
        return base.Attack(player, out attackMessage);
        
    }
}