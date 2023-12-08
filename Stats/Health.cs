using diceGame.Effects;

namespace diceGame.Stats;

public class Health : BaseStat, IStat
{

    public Health(double maxHealth)
    {
        Max = maxHealth;
        Current = maxHealth;
    }
    
    public double GetStat(Effect effect)
    {
        double Health = Current;

        return Health;
    }
    
}

