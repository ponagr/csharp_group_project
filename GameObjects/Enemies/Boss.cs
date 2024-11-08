public class AssassinBoss : Assassin
{
    bool specialAttack;
    public AssassinBoss(int level, string name) : base(level, name)
    { 
        Name = "Smygehuk";
        Description = "Assassin BOSS";
        BaseHp = base.BaseHp * 1.5; 
        CurrentHp = TotalHp;
        BaseDamage = base.BaseDamage * 1.5;
        BaseResistance = base.BaseResistance * 1.5;
        BaseAgility = base.BaseAgility * 1.5;

        healthBar = new HealthBar();

        isVisable = false;

    }

    public override void CharacterAttackAnimation(Enemy enemy)
    {
        if (specialAttack)
        {
            Textures.BossAssassinStealthAnimation();
        }
        else
        {
            base.CharacterAttackAnimation(enemy);
        }
    }

    public double ThrowingKnives(double damage, out string attackMessage) 
    {
        damage = damage * 1.2;
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
        damage = CalculateDamage(player, out bool attackCrit);
        if (attackCrit)     //Special attack
        {
            specialAttack = true;
            damage = ThrowingKnives(damage, out attackMessage);
            player.CurrentHp -= damage;
            return $"<-- {damage:F0} DMG";
        }
        else
        {  
            specialAttack = false;
            return base.Attack(player, out attackMessage);
        }    
    }
}
public class ButcherBoss : Butcher
{
    public ButcherBoss(int level, string name) : base(level, name)
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
    public ArcherBoss(int level, string name) : base(level, name)
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