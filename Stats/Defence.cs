namespace diceGame.Stats;

public class Defence : IStat
{
    public double MaxDefence;

    public Defence(double maxDefence)
    {
        MaxDefence = maxDefence;
    }

    public double GetStat(IFighter fighter)
    {
        double Defence = MaxDefence;

        return Defence;
    }
}

