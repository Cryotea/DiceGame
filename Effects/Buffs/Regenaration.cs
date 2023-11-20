namespace diceGame.Effects.Buffs;

public class Regenaration : IBuff
{
    public static void Buff(IFighter user, int Level, int duration)
    {
        double Healed = user.MaxHealth * ( Level * 0.1);
        user.Health = user.Health + (user.MaxHealth * ( Level * 0.1));
        if (user.Health > user.MaxHealth)
        {
            user.Health = user.MaxHealth;
        }
        Console.WriteLine($"{user.Name}'s Regenaration healed them for {Healed}!\n{user.Name} has {user.Health}Hp now! \nThe duration is of Regenaration is {user.Effect.Regenaration.Item2}");
    }
}