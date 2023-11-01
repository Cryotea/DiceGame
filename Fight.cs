namespace diceGame;
using diceGame.Enemy;
using diceGame.Weapon;

// das hier war der versuch die enemy var zu aendern Edit#2 hab das zu IFighter gemacht funt jedoch trozdem nicht
public class Fight
{
    public static void GetEnemy(out IFighter enemy)
    {
        var random = new Random();
        int attackerNumber = random.Next(1,3);
        if (attackerNumber == 1)
        {
            enemy = new EnemySlime();
        } 
        else
        {
            enemy = new EnemyKnight();
        }
    }

}