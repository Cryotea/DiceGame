namespace diceGame;
using diceGame.Enemy;
using diceGame.Weapon;
using diceGame.Enemy.Boss;
// das hier war der versuch die enemy var zu aendern Edit#2 hab das zu IFighter gemacht funt jedoch trozdem nicht
public class Fight
{
    private static readonly (int, IEnemy) [] Enemies =
    {
       (2, new EnemySlime()),
       (2, new EnemyKnight()),
       (2, new EnemyArcher()),
       (2, new EnemySkeletonArcher()) 

    };
    
    private static readonly (int, IBoss) [] BossEnemies =
    {
        (1, new BossSlime()),
        (1, new BossKnight()),
        (1, new BossArcher()),
        (1, new BossSkeletonArcher()) 

    };
    
    public static IEnemy GetEnemy()
    {
        var random = new Random();
        double encounters = 0;
        while (encounters == 0)
        { 
            int attackerNumber = random.Next(0, Enemies.Length);
            
            if (Enemies[attackerNumber].Item1 > 0)
            {
                encounters = Enemies[attackerNumber].Item1;
                Enemies[attackerNumber].Item1--;
                return Enemies[attackerNumber].Item2.Clone() as IEnemy;
            }

            if (Enemies[attackerNumber].Item1 == 0)
            {
                if (BossEnemies[attackerNumber].Item1 > 0)
                {
                    encounters = BossEnemies[attackerNumber].Item1;
                    BossEnemies[attackerNumber].Item1--;
                    return BossEnemies[attackerNumber].Item2.Clone() as IEnemy;
                }
                
            }
        }
        return null;
    }

    public static int GetEnemyEncounters()
    {
        int AllEnemyEncounters = 0;
        foreach(var entry in Enemies)
        {
            AllEnemyEncounters += entry.Item1;
        }
        
        foreach(var entry in BossEnemies)
        {
            AllEnemyEncounters += entry.Item1;
        }
        
    return AllEnemyEncounters;
    }
}