namespace diceGame;
using diceGame.Enemy;
using diceGame.Weapon;

// das hier war der versuch die enemy var zu aendern 
public class Fight
{
    public void GetEnemy()
    {
        var random = new Random();
        int attackerNumber = random.Next(1,3);
        if (attackerNumber == 1)
        {
            var enemy = new EnemySlime();
        } 
        if (attackerNumber == 2)
        {
            var enemy = new EnemyKnight();
        }
    }

}