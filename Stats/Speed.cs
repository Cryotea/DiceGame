namespace diceGame.Stats;

public class Speed : IStat
{
    public double MaxSpeed;

    public Speed (double maxSpeed)
    {
        MaxSpeed = maxSpeed;
    }

    public double GetStat(IFighter fighter)
    {
        double Speed = MaxSpeed;

        return Speed;
    }
}