using System;

namespace guessing_number;

public class GuessNumber
{
    //In this way we are passing the random number generator by dependency injection!
    private IRandomGenerator random;
    public GuessNumber() : this(new DefaultRandom()){}
    public GuessNumber(IRandomGenerator obj)
    {
        this.random = obj;

        userValue = 0;
        randomValue = 0;
        minRange = -100;
        maxRange = 100;
        currentAttempts = 0;
        maxAttempts = 5;
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
    public string Greet()
    {
        return "---Bem-vindo ao Guessing Game--- /n Para começar, tente adivinhar o número que eu pensei, entre -100 e 100!";
    }

    //2 - Receba a entrada da pessoa usuária e converta para Int
    //5 - Adicione um limite de tentativas
    public string ChooseNumber(string userEntry)
    {
        bool canConvert = Int32.TryParse(userEntry, out int chosenNumber);

        if (!canConvert) return "Entrada inválida! Não é um número.";
        if (currentAttempts >= maxAttempts) return "Você excedeu o número máximo de tentativas! Tente novamente.";
        if (chosenNumber < minRange || chosenNumber > maxRange) return "Entrada inválida! Valor não está no range.";
        userValue = chosenNumber;
        currentAttempts++;
        return "Número escolhido!";
    }

    //3 - Gere um número aleatório
    public string RandomNumber()
    {
        randomValue = random.GetInt(minRange, maxRange);
        return "A máquina escolheu um número de -100 à 100!";
    }

    //6 - Adicione níveis de dificuldade
    public string RandomNumberWithDifficult()
    {
        throw new NotImplementedException();
    }

    //4 - Verifique a resposta da jogada
    public string AnalyzePlay()
    {
        if (userValue > randomValue) return "Tente um número MENOR";
        if (userValue < randomValue) return "Tente um número MAIOR";
        return "ACERTOU!";
    }

    //7 - Adicione uma opção para reiniciar o jogo
    public void RestartGame()
    {
        throw new NotImplementedException();
    }
}