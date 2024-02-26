# :1234: Adivinhe o Número

![bemvindo](https://github.com/DaniloBertolini/Guess-the-number/assets/49735033/94ddccf4-6611-4511-9808-4b266e80cf49)

As regras do jogo são bem simples:
- A máquina escolhe um número aleatório;
- O jogador tenta adivinhar esse número;
- A máquina responde se a tentativa do jogador foi correta, abaixo ou acima do número escolhido.
- Essa sequência se repete até que o jogador acerte o número, ou acabe as tentativas.

## :bomb: Tecnologias
- [C#](https://learn.microsoft.com/pt-br/dotnet/csharp/)

## :bulb: Funcionalidades
- Validação se o parâmetro é um número
- Validação se o parâmetro está nas opções descritas
- Caso ganhe, o jogo é finalizado e volta no começo
- Caso não acerte, o jogo dará dicas

## :books: Como acessar
Para acessar o jogo, siga os passos a passos abaixo.
  - Abra o terminal e faça o clone.
  ```bash
    git clone https://github.com/DaniloBertolini/Guess-the-number.git
  ```
  - Entre na pasta `src`
  ```bash
    cd Guess-the-number/src
  ```
  - Restaure as dependências e ferramentas de um projeto 
  ```bash
    dotnet restore
  ```
  - Execute o jogo. 
  ```bash
    dotnet run --project src/guessing-number.csproj
  ```

  - Se divita! :sunglasses:
