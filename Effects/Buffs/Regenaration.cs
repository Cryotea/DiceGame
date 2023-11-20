namespace diceGame.Effects.Buffs;

public class Regenaration : IBuff
{
    public static void Buff(IFighter user, int Level, int duration)
    {
        double Healed = user.Health * ( Level * 0.1);
        user.Health = user.Health + (user.Health * ( Level * 0.1));
        Console.WriteLine($"{user.Name} got healed for {Healed}! ");
    }
}