var random = new Random();

double dice = random.Next(1,7);

double playerHealth = 20;

double enemyHealth = 20;

bool gameEnd = false;

double end = 0;

while (!gameEnd)
{
    Console.WriteLine("press enter to throw the dice");
    Console.ReadLine();
    dice = random.Next(1,7);
    enemyHealth -= dice;
    Console.WriteLine($"you attacked for {dice} DMG. The Enemy has {enemyHealth} HP left. ");

    dice = random.Next(1,7);
    playerHealth -= dice;
    Console.WriteLine($"you recieved {dice} DMG. You have {playerHealth} HP left.");

    if (playerHealth <= 0)
    {
        gameEnd = true;
    }
    
    if (enemyHealth <= 0)
    {
        gameEnd = true;
        end = 1;
    }

}


if (end ==1)
{
    Console.WriteLine("You won the fight! Good job!");
    Console.WriteLine("Press enter to exit");
    Console.ReadLine();
}
else
{
    Console.WriteLine("You lost! The enemy has killed you D:");
    Console.WriteLine("Press enter to exit");
    Console.ReadLine();
}