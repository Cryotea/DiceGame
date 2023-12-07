namespace diceGame.Effects.Buffs;

public class Regenaration : IBuff
{
    public static void Buff(IFighter user, int Level, int duration)
    {
        double Healed = user.Health.MaxHealth * ( Level * 0.1);
        user.Health.HP = user.Health.HP + (user.Health.MaxHealth * ( Level * 0.1));
        if (user.Health.HP > user.Health.MaxHealth)
        {
            user.Health.HP = user.Health.MaxHealth;
        }
        Console.WriteLine($"{user.Name}'s Regenaration healed them for {Healed}!\n{user.Name} has {user.Health}Hp now! \nThe duration is of Regenaration is {user.Effect.Regenaration.Item2}");
    }
}