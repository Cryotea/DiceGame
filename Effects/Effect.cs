using diceGame.Effects.Buffs;
using diceGame.Effects.Debuffs;
namespace diceGame.Effects;

public class Effect
{
    
    //Buffs
    /// <summary>
    /// Level, Duration used for <see cref="Buffs.Regenaration">Regenaration</see>
    /// </summary>
    public (int, int) Regenaration = (0, 0);

    //Debuffs
    /// <summary>
    /// Level, Duration used for <see cref="Debuffs.Poisen">Poisen</see>
    /// </summary>
    public (int, int) Poisen = (0, 0);
    /// <summary>
    /// runs Buff Methode on a Buff if the Duration is atleast 1 , and decreases it by one.
    /// </summary>
    /// <param name="fighter"></param>
    public void GetBuffed(IFighter fighter)
    {
        if(fighter.Effect.Regenaration.Item2 > 0)
        {
            Buffs.Regenaration.Buff(fighter, Regenaration.Item1, Regenaration.Item2 );
            Regenaration.Item2--;
        }
    }
    public void GetDebuffed(IFighter fighter)
    {
        if(fighter.Effect.Poisen.Item2 > 0)
        {
            Debuffs.Poisen.Debuff(fighter, Poisen.Item1 , Poisen.Item2);
            Poisen.Item2--;
        }
    }
}