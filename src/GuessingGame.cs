// using guessing_number.Game;

namespace guessing_number;


class Program
{
    public static bool play = true;
    static void Main()
    {
        GuessNumber game = new();
        GuessNumber.Clear();
        GuessNumber.ColoringText(GuessNumber.Greet(), ConsoleColor.Green);

        while (play)
        {
            GuessNumber.ColoringText("\nDigite 1 para jogar ou 0 para encerrar", ConsoleColor.White);
            string? choise = Console.ReadLine();

            bool canConvertPlay = int.TryParse(choise, out int chosenNumber);

            if (!canConvertPlay)
            {
                GuessNumber.Clear();
                GuessNumber.ColoringText("Não é um número! Precisa ser 0 ou 1!", ConsoleColor.Red);
                continue;
            }

            game.RestartGame();
            switch (chosenNumber)
            {
                case 1:
                    GuessNumber.Clear();
                    GuessNumber.ColoringText("Escolha a dificuldade: (1, 2, 3)", ConsoleColor.Green);
                    string? dificultChoise = Console.ReadLine();

                    bool canConvertDificult = int.TryParse(dificultChoise, out int chosenDificult);

                    if (!canConvertDificult) continue;

                    game.NumberWithDifficult(chosenDificult);

                    GuessNumber.Clear();
                    GuessNumber.ColoringText($"Tente descobrir o número que eu pensei com {game.maxAttempts - game.currentAttempts} tentativas!", ConsoleColor.Yellow);

                    while (game.currentAttempts < game.maxAttempts)
                    {
                        GuessNumber.ColoringText($"\nDica: O número estará entre {game.minRange} e {game.maxRange}!", ConsoleColor.Yellow);
                        GuessNumber.ColoringText($"{game.maxAttempts - game.currentAttempts} tentativas restantes", ConsoleColor.Yellow);

                        string? attempt = Console.ReadLine();
                        bool canConvertAttempt = Int32.TryParse(attempt, out int attemptNumber);

                        if (!canConvertAttempt)
                        {
                            GuessNumber.Clear();
                            GuessNumber.ColoringText("Entrada inválida! Não é um número.", ConsoleColor.Red);
                            continue;
                        }

                        bool withinTheRange = game.ChooseNumber(attemptNumber);

                        if (!withinTheRange)
                        {
                            GuessNumber.Clear();
                            GuessNumber.ColoringText("Entrada inválida! Valor não está no range.", ConsoleColor.Red);
                            continue;
                        }

                        string hitMessage = game.AnalyzePlay();

                        if (game.gameOver) break;

                        GuessNumber.Clear();
                        GuessNumber.ColoringText(hitMessage, ConsoleColor.Red);
                    }

                    GuessNumber.Clear();
                    if (game.gameOver)
                    {
                        GuessNumber.ColoringText($"Parabéns! Você achou o número secreto!", ConsoleColor.Blue);
                        break;
                    }
                    GuessNumber.ColoringText("Você excedeu o número máximo de tentativas! Tente novamente.", ConsoleColor.Red);
                    break;

                case 0:
                    play = false;
                    break;
                default:
                    GuessNumber.Clear();
                    GuessNumber.ColoringText("Opção não encontrada! Precisa ser 0 ou 1", ConsoleColor.Red);
                    continue;
            }
        }
        GuessNumber.Clear();
        GuessNumber.ColoringText("Obrigado por jogar Guessing Game!", ConsoleColor.DarkCyan);
    }
}
