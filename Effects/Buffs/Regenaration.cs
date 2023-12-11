using diceGame.Stats;
using Spectre.Console;

namespace diceGame.Effects.Buffs;

public class Regenaration : IBuff
{
    public static string ColorHealth = "[lime]";
    
    public static string Color = "[mediumorchid1_1]";
    public static void Buff(IFighter user, int Level, int duration)
    {
        double Healed = user.Health.Max * ( Level * 0.1);
        user.Health.Current = user.Health.Current + (user.Health.Max * ( Level * 0.1));
        if (user.Health.Current > user.Health.Max)
        {
            user.Health.Current = user.Health.Max;
        }
        AnsiConsole.MarkupLine($"{user.Name}'s {Color}Regeneration[/] healed them for {Color}{Healed}[/]!\n{user.Name} has {ColorHealth}{user.Health.Current}Hp[/] now! \nThe duration is of{Color} Regeneration[/] is {user.Effect.Regenaration.Item2}");
    }
}