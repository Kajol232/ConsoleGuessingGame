// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Random random = new Random();
int randomNum = random.Next(100);
int maxAttempt = 1;
while(maxAttempt <= 10)
{
    Console.WriteLine("Guess a number between 0 and 100");
    if(int.TryParse(Console.ReadLine(), out int attempt))
    {
        Check(attempt, randomNum, maxAttempt);

    }
    maxAttempt++;
    if(maxAttempt > 10)
    {
        Console.WriteLine("You lost; you've exceeded your attempt limit");
    }
}

static void Check(int attempt, int randomNum, int maxAttempt)
{
    if(attempt == randomNum)
    {
        Console.WriteLine("You're correct");
        Console.WriteLine("Congrats, You won; You guessed right at attempt: {0}", maxAttempt);
        Environment.Exit(0);
    }else if(attempt < randomNum) {
        Console.WriteLine("Your guess is lower than the expected number, Kindly retry");
    }
    else
    {
        Console.WriteLine("Your guess is higher than the expected number, kindly retry ");
    }
}