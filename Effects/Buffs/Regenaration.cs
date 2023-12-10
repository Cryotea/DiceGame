using Spectre.Console;

namespace diceGame.Effects.Buffs;

public class Regenaration : IBuff
{
    public static void Buff(IFighter user, int Level, int duration)
    {
        double Healed = user.Health.Max * ( Level * 0.1);
        user.Health.Current = user.Health.Current + (user.Health.Max * ( Level * 0.1));
        if (user.Health.Current > user.Health.Max)
        {
            user.Health.Current = user.Health.Max;
        }
        AnsiConsole.MarkupLine($"{user.Name}'s Regenaration healed them for {Healed}!\n{user.Name} has {user.Health.Current}Hp now! \nThe duration is of Regenaration is {user.Effect.Regenaration.Item2}");
    }
}