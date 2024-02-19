# Adivinhe o Número

Boas-vindas ao repositório do exercício `Adivinhe o Número`

Para realizar o exercício, atente-se a cada passo descrito a seguir e se tiver **qualquer dúvida**, nos envie no _Slack_ da turma! #vqv 🚀

Aqui, você vai encontrar os detalhes de como estruturar o desenvolvimento do seu exercício a partir desse repositório, utilizando uma branch específica e um _Pull Request_ para colocar seus códigos.

## Termos e acordos

Ao iniciar este exercício, você concorda com as diretrizes do [Código de Conduta e do Manual da Pessoa Estudante da Trybe](https://app.betrybe.com/learn/student-manual/codigo-de-conduta-da-pessoa-estudante).

## Entregáveis

<details>
<summary><strong>🤷🏽‍♀️ Como entregar</strong></summary>

Para entregar o seu exercício, você deverá criar um _Pull Request_ neste repositório.

Lembre-se que você pode consultar nosso conteúdo sobre [Git & GitHub](https://app.betrybe.com/learn/course/5e938f69-6e32-43b3-9685-c936530fd326/module/fc998c60-386e-46bc-83ca-4269beb17e17/section/fe827a71-3222-4b4d-a66f-ed98e09961af/day/1a530297-e176-4c79-8ed9-291ae2950540/lesson/2b2edce7-9c49-4907-92a2-aa571f823b79) e nosso [Blog - Git & GitHub](https://blog.betrybe.com/tecnologia/git-e-github/) sempre que precisar!

</details>

<details>
<summary><strong>🧑‍💻 O que deverá ser desenvolvido</strong></summary>

Neste exercício você vai desenvolver uma aplicação Console que irá simular um jogo de adivinhar um número. Você irá praticar as estruturas de controle que você aprendeu até aqui.

</details>
  
<details>
  <summary><strong>:memo: Habilidades a serem trabalhadas</strong></summary>

Neste exercício, verificamos se você é capaz de:

- Entender a estrutura de um projeto C#.
- Fazer uso das estruturas condicionais.
- Emitir mensagens de retorno para diversas funções.
- Converter variáveis.

</details>

# Orientações

<details>
  <summary><strong>‼️ Antes de começar a desenvolver</strong></summary><br />

  1. Clone o repositório

  - Use o comando: `git clone git@github.com:tryber/csharp-0x-exercicio-adivinhe-o-numero.git`.
  - Entre na pasta do repositório que você acabou de clonar:
    - `cd csharp-0x-exercicio-adivinhe-o-numero`

  2. Instale as dependências

  - `dotnet restore`.
  
  3. Crie uma branch a partir da branch `master`

  - Verifique que você está na branch `master`
    - Exemplo: `git branch`
  - Se não estiver, mude para a branch `master`
    - Exemplo: `git checkout master`
  - Agora, crie uma branch à qual você vai submeter os `commits` do seu projeto
    - Você deve criar uma branch no seguinte formato: `nome-de-usuario-nome-do-projeto`
    - Exemplo: `git checkout -b joaozinho-csharp-0x-exercicio-adivinhe-o-numero`

  4. Adicione as mudanças ao _stage_ do Git e faça um `commit`

  - Verifique que as mudanças ainda não estão no _stage_
    - Exemplo: `git status` (deve aparecer listada a pasta _joaozinho_ em vermelho)
  - Adicione o novo arquivo ao _stage_ do Git
    - Exemplo:
      - `git add .` (adicionando todas as mudanças - _que estavam em vermelho_ - ao stage do Git)
      - `git status` (deve aparecer listado o arquivo _joaozinho/README.md_ em verde)
  - Faça o `commit` inicial
    - Exemplo:
      - `git commit -m 'iniciando o projeto x'` (fazendo o primeiro commit)
      - `git status` (deve aparecer uma mensagem tipo _nothing to commit_ )

  5. Adicione a sua branch com o novo `commit` ao repositório remoto

  - Usando o exemplo anterior: `git push -u origin joaozinho-csharp-0x-exercicio-adivinhe-o-numero`

  6. Crie um novo `Pull Request` _(PR)_

  - Vá até a página de _Pull Requests_ do [repositório no GitHub](https://github.com/tryber/csharp-0x-exercicio-adivinhe-o-numero`/pulls)
  - Clique no botão verde _"New pull request"_
  - Clique na caixa de seleção _"Compare"_ e escolha a sua branch **com atenção**
  - Coloque um título para a sua _Pull Request_
    - Exemplo: _"Cria tela de busca"_
  - Clique no botão verde _"Create pull request"_
  - Adicione uma descrição para o _Pull Request_ e clique no botão verde _"Create pull request"_
  - **Não se preocupe em preencher mais nada por enquanto!**
  - Volte até a [página de _Pull Requests_ do repositório](https://github.com/tryber/csharp-0x-exercicio-adivinhe-o-numero`/pulls) e confira que o seu _Pull Request_ está criado

</details>

<details>
  <summary><strong>⌨️ Durante o desenvolvimento</strong></summary><br/>

  - Faça `commits` das alterações que você fizer no código regularmente

  - Lembre-se sempre, após um (ou alguns) `commits`, de atualizar o repositório remoto

  - Os comandos que você utilizará com mais frequência são:
    1. `git status` _(para verificar o que está em vermelho - fora do stage - e o que está em verde - no stage)_
    2. `git add` _(para adicionar arquivos ao stage do Git)_
    3. `git commit` _(para criar um commit com os arquivos que estão no stage do Git)_
    4. `git push -u origin nome-da-branch` _(para enviar o commit para o repositório remoto na primeira vez que fizer o `push` de uma nova branch)_
    5. `git push` _(para enviar o commit para o repositório remoto após o passo anterior)_

</details>

<details>
  <summary><strong>🎛 Linter</strong></summary><br />

  Usaremos o [NetAnalyzer](https://docs.microsoft.com/pt-br/dotnet/fundamentals/code-analysis/overview) para fazer a análise estática do seu código.

  Este projeto já vem com as dependências relacionadas ao _linter_ configuradas no arquivo `main.yml`.

  O analisador já é instalado pelo plugin da `Microsoft C#` no `VSCode`. Para isso, basta fazer o download do [plugin](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) e instalá-lo.
</details>

<details>
  <summary><strong>🛠 Testes</strong></summary><br />

  O .NET já possui sua própria plataforma de testes.
  
  Este projeto já vem configurado e com suas dependências.

  ### Executando todos os testes

  Para executar os testes com o .NET, execute o comando dentro do diretório do seu projeto `src/<project>`!

  ```
  dotnet test
  ```

  ### Executando um teste específico

  Para executar um teste expecífico, basta executar o comando `dotnet test --filter Name~TestMethod1`.

  :warning: **Importante:** o comando irá executar testes cujo nome contêm `TestMethod1`.

  :warning: **O avaliador automático não necessariamente avalia seu projeto na ordem em que os requisitos aparecem no readme. Isso acontece para deixar o processo de avaliação mais rápido. Então, não se assuste se isso acontecer, ok?**

  ### Outras opções para testes
  - Algumas opções que podem lhe ajudar são:
    -  `-?|-h|--help`: exibem a descrição completa de como utilizar o comando.
    -  `-t|--list-tests`: lista todos os testes ao invés de executá-los.
    -  `-v|--verbosity <LEVEL>`: define o nível de detalhe na resposta dos testes.
      - `q | quiet`
      - `m | minimal`
      - `n | normal`
      - `d | detailed`
      - `diag | diagnostic`
      - Exemplo de uso: 
         ```
           dotnet test -v diag
         ```
         ou
         ```            
           dotnet test --verbosity=diagnostic
         ``` 
</details>

# Requisitos

Uma empresa que desenvolve aplicações de console contatou você com uma problemática: `Todos os sistemas desta empresa têm filas longas e as pessoas clientes ficam entediadas enquanto esperam`.

  - Você, então, proativamente, propõe a solução de implementar um jogo para os clientes se divertirem enquanto esperam sua vez na fila.
  - A empresa gostou e aceitou, o jogo escolhido então foi o `Adivinhe o Número!`

Então você recebeu a tarefa de implementar esse jogo clássico!

As regras do jogo são bem simples:
- O jogador 1 escolhe um número aleatório;
- O jogador 2 tenta adivinhar esse número;
- O jogador 1 responde se a tentativa do jogador 2 foi correta, abaixo ou acima do número escolhido.
-Essa sequência se repete até que o jogador 2 acerte o número.

>> **⚠️Importante⚠️:** Para cada requisito do README, você verá dois requisitos associados no avaliador. Isso acontece porque para avaliar os testes deste projeto, o avaliador irá realizar dois testes: um de sucesso e um de falha. Você deve desenvolver o requisito e o seu teste para ter a aprovação em ambos.

Seguindo os requisitos desse projeto, vamos construir nosso adversário, o jogador 1:

## 1. Imprima uma mensagem de saudação

<details>
  <summary>Implemente a função Greet() que retorna uma string de saudação</summary><br/>

> _Crie a lógica do seu requisito no arquivo src/`guessing-number/GuessingGame.cs`._

 A mensagem deverá ser exatamente:
 ```
 "---Bem-vindo ao Guessing Game---
 Para começar, tente adivinhar o número que eu pensei, entre -100 e 100!"
 ```

 > Crie essa lógica na função `Greet()`

 **O que será testado:**

Será testado que realizando diversas requisições à função implementada, a mesma retornará a mensagem de boas-vindas ao game.

</details>

## 2. Receba a entrada da pessoa usuária e converta para Int

<details>
  <summary>Implemente a função `ChooseNumber()` que recebe uma string e tenta converter para int</summary><br />

> _Crie a lógica do seu requisito no arquivo src/`guessing-number/GuessingGame.cs`._

> Se a string passada por parâmetro não for um número **inteiro**, a função deve retornar `"Entrada inválida! Não é um número."`

>  Se a string passada por parâmetro for um número **fora do range** (-100, 100), a função deve retornar `"Entrada inválida! Valor não está no range."` e definir a variável userValue para 0 novamente.

> Caso a string passada por parâmetro for válida, a função deve definir a variável `userValue para` o valor convertido e retornar a mensagem `"Número escolhido!"`;

**O que será testado:**

Será testado que a função implementada consegue converter a entrada da pessoa jogadora, que esteja em um range correto e retorne a mensagem adequada.

</details>

## 3. Gere um número aleatório

<details>
  <summary>Implemente a função `RandomNumber()` que usa o gerador aleátorio</summary><br />

> _Crie a lógica do seu requisito no arquivo src/`guessing-number/GuessingGame.cs`._

> A função deve usar a variável `random` com o método `GetInt` no range de -100 à 100 e definir o resultado para a variável randomValue

>  A função deve retornar a string `"A máquina escolheu um número de -100 à 100!"`

**O que será testado:**

Será testado que realizando diversas requisições à função implementada, a mesma retornará um número aleatório dentro do range esperado.

</details>

## 4. Verifique a resposta da jogada

<details>
  <summary>Implemente a função `AnalyzePlay()` que analizará se a jogada está correta, menor ou maior</summary><br />

> _Crie a lógica do seu requisito no arquivo src/`guessing-number/GuessingGame.cs`._
> A função deve comparar a variável userValue com a randomValue
  > Se o userValue for menor, você deve retornar a string `"Tente um número MAIOR"`
  > Se o userValue for maior, você deve retornar a string `"Tente um número MENOR"`
  > Se o userValue for igual, você deve retornar a string `"ACERTOU!"`

**O que será testado:**

Será testado que realizando diversas requisições à função implementada, a mesma retornará uma mensagem adequada da comparação do número escolhido pela pessoa jogadora e o número aleatório gerado pelo código.

</details>

## 5. Adicione um limite de tentativas

<details>
  <summary>Use a variável `maxAttempts` para definir que o usuário tem 5 tentativas máximas.</summary><br />

  <summary>Defina o valor inicial para a variavel `currentAttempts`.</summary><br />

  <summary>Altere a função `ChooseNumber()` para não permitir mais tentativas que o máximo.</summary><br />

> _Crie a lógica do seu requisito no arquivo src/`guessing-number/GuessingGame.cs`._

> Caso o usuário exceda o limite de tentativas a função deve retornar "Você excedeu o número máximo de tentativas! Tente novamente."

**O que será testado:**

Será testado que o software permite verificar o limite de tentativas que a pessoa jogadora teve de acertar o número e emita a mensagem solicitada caso esse número se alcance.

</details>

## 6. Adicione níveis de dificuldade

<details>
  <summary>Use a variável `difficultyLevel` para definir o nível inicial como 1.</summary><br />

  <summary>Crie a função `RandomNumberWithDifficult()` que usa o gerador aleátorio com níveis de dificuldade.</summary><br />

> _Crie a lógica do seu requisito no arquivo src/`guessing-number/GuessingGame.cs`._

> A função deve usar a variável `difficultyLevel` para definir qual range de número passar para o gerador.

> Caso a dificuldade seja igual à 1: o número sorteado deverá ser entre -100 e 100
> Caso a dificuldade seja igual à 2: o número sorteado deverá ser entre -500 e 500
> Caso a dificuldade seja igual à 3: o número sorteado deverá ser entre -1000 e 1000

>  A função deve retornar a string `"A máquina escolheu um número de {-x} à {x}!"` sendo x o range respectivo.

**O que será testado:**

Será testado que o software terá os limites dos números gerados aleatoriamente e os números escolhidos pela pessoa jogadora alterados de acordo com a mudança do nível de dificuldade.

</details>

## 7. Adicione uma opção para reiniciar o jogo
_Crie a lógica do seu requisito no arquivo src/`guessing-number/GuessingGame.cs`._

<details>
  <summary>Use a variável `gameOver` para controlar se o jogo terminou.</summary><br />

  <summary>Crie a função `RestartGame()` que reseta as variáveis do jogo.</summary><br />
  <summary>Altere as funções `AnalyzePlay()` e `ChooseNumber()` para controlar o fim de jogo.</summary><br />

> Depois que o usuário acerta o número ou atinge o limite máximo de tentativas, você deve adicionar uma opção para reiniciar o jogo. Isso permitirá que o usuário jogue novamente sem precisar sair do programa.

> Caso o usuário tenha excedido o número de tentativas, a variável `gameOver` deve ser alterada.
> Caso o usuário acerte, a variável gameOver deve ser alterada.

> Caso o jogo tenha encerrado, a função AnalyzePlay deve retornar a string `"O jogo terminou. Deseja jogar novamente?"`

**O que será testado:**

Será testado que realizando diversas requisições à função implementada, a mesma irá reiniciar o jogo e colocar todas as variáveis em seus estados iniciais.

</details>

<details>
<summary><strong>🗣 Nos dê feedbacks sobre o projeto!</strong></summary>

Ao finalizar e submeter o projeto, não se esqueça de avaliar sua experiência preenchendo o formulário.
**Leva menos de 3 minutos!**

[Formulário de avaliação do projeto](https://be-trybe.typeform.com/to/ZTeR4IbH)

</details>