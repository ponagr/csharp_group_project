#region Assassinboss
public class AssassinBoss : Assassin
{
    bool specialAttack;
    public AssassinBoss(int level, string name) : base(level, name)
    { 
        Name = "Smygehuk";
        Description = "Assassin BOSS";
        BaseHp = base.BaseHp * 2.2; 
        CurrentHp = TotalHp;
        BaseDamage = base.BaseDamage * 2;
        BaseResistance = base.BaseResistance * 1.75;
        BaseAgility = base.BaseAgility * 1.2;

        healthBar = new HealthBar();

        isVisable = false;
        XpDrop = 50;
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
        damage = damage * 1.5;
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
#endregion
#region  Butcherboss
public class ButcherBoss : Butcher
{
    bool specialAttack;

    public ButcherBoss(int level, string name) : base(level, name)
    { 
        base.BaseHp = base.BaseHp * 2.5;
        base.BaseDamage = base.BaseDamage * 1.5;
        CurrentHp = TotalHp;
        base.BaseResistance = base.BaseResistance * 1.5;
        base.BaseAgility = base.BaseAgility * 1.5;
        specialAttack = false;
        XpDrop = 50;
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
        damage = damage * 2;
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
#endregion


#region ArcherBoss
public class ArcherBoss : Archer
{
    bool specialAttack;
    public ArcherBoss(int level, string name) : base(level, name)
    { 
        base.BaseHp = (base.BaseHp) * 5;
        CurrentHp = TotalHp;
        base.BaseDamage = (base.BaseDamage) * 0.75;
        base.BaseResistance = (base.BaseResistance) * 2;
        base.BaseAgility = (base.BaseAgility) * 2;
        XpDrop = 100;
    }

    double SpecialAttack(double damage, out string attackMessage)
    {
        damage = damage * 3.5;
        attackMessage = "5 ARROWS!!!";
        return damage;
    }

    public override string Attack(Player player, out string attackMessage)
    {
        double damage;
        damage = CalculateDamage(player, out bool attackCrit);
        Random random = new Random();
        if (random.Next(0,3) == 1)
        {
            specialAttack = true; // Sätts på true för textures, false nästa runda
            damage = SpecialAttack(damage, out attackMessage);
            if (attackCrit)
            {
                attackMessage = "CRIT " + attackMessage; 
            }
            player.CurrentHp -= damage;
            return $"{damage:F0}";
        }
        else
        {
            specialAttack = false;
            return base.Attack(player, out attackMessage);
        }
    } 
 
      public override void CharacterAttackAnimation(Enemy enemy)
    {
        if (!specialAttack)
        {
            Textures.ArcherAttackAnimation();
        }
        else 
        {
            Textures.ArcherBossSpecialAttackAnimation();
        }   
    }
}
#endregion
#region MageBoss

public class MageBoss : Mage
{
    public MageBoss(int level, string name) : base(level, name)
    { 
        base.BaseHp = base.BaseHp * 3;
        CurrentHp = BaseHp;
        base.BaseDamage = base.BaseDamage * 3;
        base.BaseResistance = base.BaseResistance * 2;
        base.BaseAgility = base.BaseAgility * 1.5;
        XpDrop = 150;
    }

    public override string Attack(Player player, out string attackMessage)
    {
        return base.Attack(player, out attackMessage);
        
    }
}
#endregion
