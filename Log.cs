using Spectre.Console;

namespace diceGame;

public class Log
{
    public List<string> MessageLog = new List<string>();

    public void AddMessage(string Message)
    {
        MessageLog.Add(Message);
    }

    public void WriteTwoLatestMessage()
    {
        AnsiConsole.MarkupLine($"{MessageLog[MessageLog.Count - 2]}");
        AnsiConsole.MarkupLine($"{MessageLog[MessageLog.Count - 1]}");
    }
    
    public void WriteLatestMessage()
    {
        AnsiConsole.MarkupLine($"{MessageLog[MessageLog.Count - 1]}");
    }
    
        
    
}