namespace diceGame;
using diceGame.Enemy;
using diceGame.Weapon;

// das hier war der versuch die enemy var zu aendern Edit#2 hab das zu IFighter gemacht funt jedoch trozdem nicht
public class Fight
{
    private static readonly IFighter[] Enemies =
    {
        new EnemySlime(),
        new EnemyKnight()

    };
    public static IFighter GetEnemy()
    {
        var random = new Random();
        int attackerNumber = random.Next(0,2);
        return Enemies[attackerNumber];
    }

}