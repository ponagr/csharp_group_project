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
        BaseAgility = base.BaseAgility * 2;

        healthBar = new HealthBar();

        isVisable = false;

    }

    // Olika animationer beroende på attack
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
        if (attackCrit)     //Special attack i stället för CRIT
        {
            specialAttack = true;
            damage = ThrowingKnives(damage, out attackMessage);
            player.CurrentHp -= damage;
            return $"{damage:F0}";
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
    bool specialAttack;

    public ButcherBoss(int level, string name) : base(level, name)
    { 
        base.BaseHp = base.BaseHp * 1.5;
        base.BaseDamage = base.BaseDamage * 1.5;
        CurrentHp = TotalHp;
        base.BaseResistance = base.BaseResistance * 1.5;
        base.BaseAgility = base.BaseAgility * 1.5;
        specialAttack = false;
    }   

    public override void CharacterAttackAnimation(Enemy enemy)
    {
        if (specialAttack)
        {
            Textures.ButcherBossAttackAnimation();
        }
        else
        {
            base.CharacterAttackAnimation(enemy); // Lägg till animationer för detta
        }
    }

    double SpecialAttack(double damage, out string attackMessage)
    {
        damage = damage * 1.75;
        attackMessage = "MEAT CLEAVER!";
        return damage;
    }

    public override string Attack(Player player, out string attackMessage)
    {
        double damage;
        damage = CalculateDamage(player, out bool attackCrit);
        Random random = new Random();
        if (random.Next(0,5) == 3 && !needsRest)
        {
            damage = SpecialAttack(damage, out attackMessage);
            if (attackCrit)
            {
                attackMessage = "CRIT " + attackMessage; 
            }
            player.CurrentHp -= damage;
            specialAttack = true; // Sätts på true för textures, false nästa runda
            return $"{damage:F0}";
        }
        else if (random.Next(0,3) == 1 && !needsRest)
        {
            specialAttack = false;
            attackMessage = "STUNNED";
            player.CurrentHp -= damage;
            return $"{damage:F0}";
        }
        else
        {
            specialAttack = false;
            return base.Attack(player, out attackMessage);
        }
    } 
}



public class ArcherBoss : Archer
{
    public ArcherBoss(int level, string name) : base(level, name)
    { 
        base.BaseHp = (base.BaseHp) * 1.5;
        CurrentHp = TotalHp;
        base.BaseDamage = (base.BaseDamage) * 1.5;
        base.BaseResistance = (base.BaseResistance) * 1.5;
        base.BaseAgility = (base.BaseAgility) * 1.5;
    }

    public override string Attack(Player player, out string attackMessage)
    {
        return base.Attack(player, out attackMessage);
        
    }
}

public class MageBoss : Mage
{
    public MageBoss(int level, string name) : base(level, name)
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