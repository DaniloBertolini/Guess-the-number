using System.Security.Cryptography;


namespace guessing_number;


public class GuessNumber
{
    public GuessNumber() : this(new DefaultRandom()) { }
    public GuessNumber(IRandomGenerator obj)
    {
        userValue = 0;
        randomValue = 0;
        minRange = -100;
        maxRange = 100;
        currentAttempts = 0;
        maxAttempts = 0;
        difficultyLevel = 1;
        gameOver = false;
    }

    //user variables
    public int userValue;
    public int randomValue;

    public int minRange;

    public int maxRange;

    public int maxAttempts;
    public int currentAttempts;

    public int difficultyLevel;

    public bool gameOver;

    //1 - Imprima uma mensagem de saudação
    public static string Greet()
    {
        return "------Bem-vindo ao Guessing Game------";
        // Tente descobrir o número que eu pensei!
    }

    public bool ChooseNumber(int number)
    {
        if (minRange < number && number < maxRange)
        {
            userValue = number;
            currentAttempts++;
            return true;
        }
        // gameOver = true;
        return false;
    }

    public void RandomNumber()
    {
        randomValue = RandomNumberGenerator.GetInt32(minRange, maxRange);
    }

    public void NumberWithDifficult(int number)
    {
        switch (number)
        {
            case 2:
                minRange = -500;
                maxRange = 500;
                maxAttempts = 20;
                break;
            case 3:
                minRange = -1000;
                maxRange = 1000;
                maxAttempts = 30;
                break;
            default:
                minRange = -100;
                maxRange = 100;
                maxAttempts = 10;
                break;
        }
        RandomNumber();
    }

    public string AnalyzePlay()
    {
        if (userValue > randomValue) return $"Tente um número MENOR que {userValue}";
        if (userValue < randomValue) return $"Tente um número MAIOR que {userValue}";
        gameOver = true;
        return "ACERTOU";
    }

    public void RestartGame()
    {
        userValue = 0;
        randomValue = 0;
        minRange = -100;
        maxRange = 100;
        currentAttempts = 0;
        maxAttempts = 5;
        difficultyLevel = 1;
        gameOver = false;
    }

    static public void Clear()
    {
        Console.Clear();
    }

    static public void Log(string text)
    {
        Console.WriteLine(text);
    }

    static public void ColoringText(string text, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Log(text);
        Console.ResetColor();
    }
}
