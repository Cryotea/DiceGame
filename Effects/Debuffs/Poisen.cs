namespace diceGame.Effects.Debuffs;

public class Poisen : IDebuff
{
    public static void Debuff(IFighter user , int Level, int duration)
    {
        double Poisen = user.Health.MaxHealth * ( Level * 0.1);
        user.Health.HP = user.Health.HP - (user.Health.MaxHealth * ( Level * 0.1));
        Console.WriteLine($"{user.Name} took Poisen Damage for {Poisen}!\nThe duration is {user.Effect.Poisen.Item2} ");
    }
}