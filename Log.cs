using diceGame.Enemy;
using diceGame.Enemy.Boss;
using Spectre.Console;

namespace diceGame;

public class Log
{
    public int Rounds { get; set; } = 0;

    public int Fights { get; set; } = 0;
    
    public List<string> MessageLog = new List<string>();

    public (IEnemy, int)[] DefeatedEnemies =
    {
        (new EnemySlime(),0),
        (new EnemyKnight(),0),
        (new EnemyArcher(),0),
        (new EnemySkeletonArcher(),0),
        
        //Bosses
        (new BossSlime(),0),
        (new BossKnight(),0),
        (new BossArcher(),0),
        (new BossSkeletonArcher(),0)
        
    };
    public void AddMessage(string Message)
    {
        MessageLog.Add(Message);
    }
    //TODO Rename Methode
    public void WriteTwoLatestMessage()
    {
        AnsiConsole.MarkupLine($"{MessageLog[MessageLog.Count - 2]}");
        AnsiConsole.MarkupLine($"{MessageLog[MessageLog.Count - 1]}");
    }
    
    public void WriteLatestMessage()
    {
        AnsiConsole.MarkupLine($"{MessageLog[MessageLog.Count - 1]}");
    }

    public void AddDefeatedEnemy(IEnemy enemy)
    {
        int index = Array.FindIndex(DefeatedEnemies, item => item.Item1.Id == enemy.Id);

        if (index != -1)
        {
            
            DefeatedEnemies[index].Item2++;
        }
    }

    public void FinishedRound()
    {
        Rounds++;
    }

    public void FinishedFight()
    {
        Fights++;
    }
    
}