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

    public double StealthAttack(double damage)
    {
        damage = damage * 1.5;

        return damage;
    }

    public override string TakeDamage(double damage, bool crit, out string attackMessage)
    {
        if (isVisable)
        {
            return base.TakeDamage(damage, crit, out attackMessage);
        }
        else
        {
            attackMessage = $"Unhittable!";
            return "";
        }
    }

    public override void PrintCharacter(Enemy enemy)
    {
        if (isVisable)
        {
            Textures.PrintAssassin();
        }
        else
        {
            Textures.PrintInvisibleAssassin();
        }
    }
    public override void CharacterAttackAnimation(Enemy enemy)
    {
        Textures.AssassinAttackAnimation();
    }

    public override string Attack(Player player, out string attackMessage) // Borde attackMessage heta typ fightmessage eller attackinfo?
    {
        Random rndVisable = new Random();
        double damage = CalculateDamage(player, out bool attackCrit);
        if (isVisable)
        {
            int magicNumber = rndVisable.Next(1, 3);

            if (magicNumber == 1)
            {
                isVisable = false;
            }
            return base.Attack(player, out attackMessage);
        }
        else // När fienden är synlig
        {
            isVisable = true;
            attackMessage = "Kniv i ryggen";
            damage = StealthAttack(damage);
            player.CurrentHp -= damage;
            string message = $"<-- {damage:F0}";
            return message;
        }
    }
}