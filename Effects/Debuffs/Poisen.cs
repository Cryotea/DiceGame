using Spectre.Console;

namespace diceGame.Effects.Debuffs;

public class Poisen : IDebuff
{
    public static string Color = "[springgreen2_1]";
    public static void Debuff(IFighter user , int Level, int duration)
    {
        double Poisen = user.Health.Max * ( Level * 0.1);
        user.Health.Current = user.Health.Current - (user.Health.Max * ( Level * 0.1));
        AnsiConsole.MarkupLine($"{user.Name} took {Color}Poison[/] Damage for {Color}{Poisen}[/]!\nThe duration is {user.Effect.Poisen.Item2} ");
    }
}