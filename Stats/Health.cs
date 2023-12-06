namespace diceGame.Stats;

public class Health : IStat
{
    public double MaxHealth;
    public double HP;

    public Health(double maxHealth)
    {
        MaxHealth = maxHealth;
    }
    
    public double GetStat(IFighter fighter)
    {
        double Health = HP;

        return Health;
    }
    
}

