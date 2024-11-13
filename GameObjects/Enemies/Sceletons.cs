public class Sceletons : Enemy
{
    public int bigHit;
    public bool specialAttack;
    public Sceletons(int level, string name) : base(level) 
    {
        double multiplier = level * 0.75;
        Random random = new Random();
        Name = name; 
        Description = "Sceletons";
        BaseHp = (45 + random.Next(0, 25)) * multiplier;
        CurrentHp = TotalHp;
        BaseDamage = (20 + random.Next(0, 10)) * multiplier;
        BaseResistance = (0 + random.Next(0, 5)) * multiplier;
        BaseAgility = 10 * multiplier;

        healthBar = new HealthBar();
        specialAttack = false;
        bigHit = 1;
    }

    // public override string TakeDdge(double damage, bool crit, out string attackMessage)
    // {
    //     if (isVisable)
    //     {
    //         return base.TakeDamage(damage, crit, out attackMessage);
    //     }
    //     else
    //     {
    //         attackMessage = $"Unhittable!";
    //         return "";
    //     }
    // }

    public override void PrintCharacter(Enemy enemy)
    {
        Textures.SceletonsAnimation();
    }
    public override void CharacterAttackAnimation(Enemy enemy)
    {
        if (specialAttack)
        {
            Textures.SceletonsAnimation();
           // Textures.SceletonsSpecialAttackAnimation();
        }
        else
        {
            Textures.SceletonsAnimation();
           // Textures.SceletonsAttackAnimation();
        }
    }

    public override string Attack(Player player, out string attackMessage) // Borde attackMessage heta typ fightmessage eller attackinfo?
    {
        bigHit++;
        double damageDone = CalculateDamage(player, out bool attackCrit);

        if (bigHit == 3)
        {
            specialAttack = true;
            damageDone = SpecialAttack(damageDone);
            bigHit = 0;
            player.CurrentHp -= damageDone;
            attackMessage = "MASSIVE HIT!";
            return $"<-- {damageDone:F0} DMG"; 
        }
        else // Vanlig attack
        {
            return base.Attack(player, out attackMessage);
        }
    }

     public double SpecialAttack(double damage)
    {
        damage = damage * 3;
        return damage;
    }
}