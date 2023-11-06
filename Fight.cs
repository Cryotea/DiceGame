namespace diceGame;
using diceGame.Enemy;
using diceGame.Weapon;

// das hier war der versuch die enemy var zu aendern Edit#2 hab das zu IFighter gemacht funt jedoch trozdem nicht
public class Fight
{
    private static readonly (int, IEnemy) [] Enemies =
    {
       (0, new EnemySlime()),
       (0, new EnemyKnight())

    };
    public static IFighter GetEnemy()
    {
        var random = new Random();
        int attackerNumber = random.Next(0,2);
        (int, IEnemy) currentEnemy = Enemies[attackerNumber];
        if (currentEnemy.Item1 > 0)
        {
            currentEnemy.Item1--;
            return currentEnemy.Item2.Clone() as IEnemy;
        }
    }

}