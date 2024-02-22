using System.Security.Cryptography;


using System;

namespace guessing_number;

public class GuessNumber
{
    public GuessNumber() : this(new DefaultRandom()){}
    public GuessNumber(IRandomGenerator obj)
    {
        userValue = 0;
        randomValue = 0;
        minRange = -100;
        maxRange = 100;
        currentAttempts = 0;
        maxAttempts = 15;
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
        return "------Bem-vindo ao Guessing Game------\nTente descobrir o número que eu pensei!";
    }

    public string ChooseNumber(string userEntry)
    {
        bool canConvert = Int32.TryParse(userEntry, out int chosenNumber);
        if (canConvert)
        {
            if (currentAttempts < maxAttempts)
            {
                if (minRange < chosenNumber && chosenNumber < maxRange)
                {
                    userValue = chosenNumber;
                    currentAttempts++;
                    return "Número escolhido!";
                }
                return "Entrada inválida! Valor não está no range.";
            };
            gameOver = true;
            return "Você excedeu o número máximo de tentativas! Tente novamente.";
        }
        return "Entrada inválida! Não é um número.";
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
                break;
            case 3:
                minRange = -1000;
                maxRange = 1000;
                break;
            default:
                minRange = -100;
                maxRange = 100;
                break;
        }
        RandomNumber();

        Console.WriteLine($"O número estará entre {minRange} e {maxRange}!");
    }

    public string AnalyzePlay()
    {
        if (gameOver) return "O jogo terminou. Deseja jogar novamente?";
        if (userValue > randomValue) return "Tente um número MENOR";
        if (userValue < randomValue) return "Tente um número MAIOR";
        return "ACERTOU!";
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
}

class Program
{
    public static bool play = true;
    static void Main()
    {
        GuessNumber game = new();
        Console.WriteLine(GuessNumber.Greet());

        while (play)
        {
            Console.WriteLine("\nDigite 1 para jogar ou 0 para encerrar");
            string? choise = Console.ReadLine();
            bool canConvert = Int32.TryParse(choise, out int chosenNumber);

            if (!canConvert) {
                Console.WriteLine("Não é um número! Precisa ser 0 ou 1!");
                continue;
            }

            switch (chosenNumber)
            {
                case 1:
                    Console.WriteLine("Escolha a dificuldade: (1, 2, 3)");
                    string? dificultChoise = Console.ReadLine();
                    bool canConvert1 = Int32.TryParse(dificultChoise, out int chosenDificult);

                    if (!canConvert1) {
                        Console.WriteLine("Precisa ser um número!");
                        break;
                    }

                    game.NumberWithDifficult(chosenDificult);
                    while (game.currentAttempts < game.maxAttempts) {}
                    break;
                    
                case 0:
                    play = false;
                    break;
                default:
                    Console.WriteLine("Opção não encontrada! Precisa ser 0 ou 1");
                    continue;
            }
        }

        Console.WriteLine("Obrigado por jogar!");
    }
}

