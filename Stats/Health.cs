using diceGame.Effects;

namespace diceGame.Stats;

public class Health : BaseStat, IStat
{
    public string Color = ColorManager.HealthColor;
    public Health(double maxHealth)
    {
        Id = "Health";
        Max = maxHealth;
        Current = maxHealth;
    }
    
    public double GetStat(Effect effect)
    {
        double Health = Current;

        return Health;
    }

    public override string ToString()
    {
        return $"{Color}Health[/]";
    }
}

