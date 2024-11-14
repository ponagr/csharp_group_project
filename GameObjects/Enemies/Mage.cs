public class Mage : Enemy
{

    private bool isReadyForThunder;
    private int chargeCounter;

    public Mage(int level, string name) : base(level)
    {
        double multiplier = level * 0.75;
        Random random = new Random();
        Name = name;
        Description = "Mage";
        BaseHp = (70 + random.Next(0, 15)) * multiplier;
        CurrentHp = TotalHp;
        BaseDamage = (15 + random.Next(0, 10)) * multiplier;
        BaseResistance = (5 + random.Next(0, 5)) * multiplier;
        BaseAgility = 10 * multiplier;
        chargeCounter = 0;
        isReadyForThunder = false;
        healthBar = new HealthBar();
    }

    public override void PrintCharacter(Enemy enemy)
    {
        Textures.PrintMage();
    }
    public override void CharacterAttackAnimation(Enemy enemy)
    {
        if (isReadyForThunder)
        {
            Textures.MageThunderStrike();
        }
        else
        {
            Textures.MageAttackAnimation();
        }
    }

    public override string Attack(Player player, out string attackMessage)
    {
        double damageDone = CalculateDamage(player, out bool attackCrit);
        if (chargeCounter == 1)
        {
            damageDone = MakeThunder(damageDone);
            chargeCounter = 0;
            isReadyForThunder = true;
            player.CurrentHp -= damageDone;
            attackMessage = "THUNDERSTORM!!!";
            return $"<-- {damageDone:F0} DMG";
        }
        else // Vanlig attack
        {
            isReadyForThunder = false;
            chargeCounter++;
            return base.Attack(player, out attackMessage);
        }
    }

    private double MakeThunder(double damage)
    {
        // Loada en texture med blixtar över hela skiten
        damage = damage * 2;
        return damage;
    }

    public override string TakeDamage(double damage, bool crit, out string attackMessage)
    {
        return base.TakeDamage(damage, crit, out attackMessage);
    }

}
