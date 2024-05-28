<!-- 🤔 ⚠️ Mudar o nome do arquivo para readme.md ao colocá-lo no repo do projeto -->
<!-- 🤔 ⚠️ Leia as diretrizes de uso de templates em https://github.com/betrybe/curriculo-system/#diretrizes-de-uso-dos-templates -->

# Trybe Games

Boas-vindas ao repositório do projeto `Trybe Games`

Para realizar o projeto, atente-se a cada passo descrito a seguir, e se tiver **qualquer dúvida**, nos envie no _Slack_ da turma! #vqv 🚀

Aqui, você vai encontrar os detalhes de como estruturar o desenvolvimento do seu projeto a partir desse repositório, utilizando uma branch específica e um _Pull Request_ para colocar seus códigos.

## Termos e acordos

Ao iniciar este projeto, você concorda com as diretrizes do [Código de Conduta e do Manual da Pessoa Estudante da Trybe](https://app.betrybe.com/learn/student-manual/codigo-de-conduta-da-pessoa-estudante).

## Entregáveis

<details>
<summary><strong>🤷🏽‍♀️ Como entregar</strong></summary>

Para entregar o seu projeto você deverá criar um _Pull Request_ neste repositório.

Lembre-se que você pode consultar nosso conteúdo sobre [Git & GitHub](https://app.betrybe.com/learn/course/5e938f69-6e32-43b3-9685-c936530fd326/module/fc998c60-386e-46bc-83ca-4269beb17e17/section/fe827a71-3222-4b4d-a66f-ed98e09961af/day/1a530297-e176-4c79-8ed9-291ae2950540/lesson/2b2edce7-9c49-4907-92a2-aa571f823b79) e nosso [Blog - Git & GitHub](https://blog.betrybe.com/tecnologia/git-e-github/) sempre que precisar!

</details>
  
<details>
<summary><strong>🧑‍💻 O que deverá ser desenvolvido</strong></summary>

<!-- 🤔 Explicar brevemente o que será realizado ao longo do projeto. Aqui, é a porta de entrada para a realização do projeto.
Exemplo: Você vai desenvolver um site que contenha uma série de informações sobre o que você aprendeu aqui na Trybe ao longo das últimas duas seções. O seu site deverá estar com elementos posicionados e estilizados e, além disso, deverá conter semântica apropriada para que seja acessível e melhor ranqueado.-->
Você irá desenvolver diversos métodos que implementarão manipulações a coleções existentes em um software que já teve o seu desenvolvimento iniciado. Além disso, você desenvolverá diversas consultas LINQ para determinadas aplicações e desenvolverá uma aplicação de testes.

</details>
  
<details>
  <summary><strong>:memo: Habilidades a serem trabalhadas </strong></summary>

Neste projeto, verificamos se você é capaz de:

- Desenvolver habilidades com relação a manipulação de coleções
- Desenvolver consultas LINQ para determinadas operações
- Aplicar um método de testes sobre coleções.
- Interpretar as coleções de dados já existentes em um software.
- Interpretar o funcionamento de um código já implementado.

</details>

## Orientações

<details>
  <summary><strong>‼️ Antes de começar a desenvolver</strong></summary><br />

  1. Clone o repositório

  - Use o comando: `git clone git@github.com:tryber/acc-elective-csharp-0x-project-trybe-games.git`.
  - Entre na pasta do repositório que você acabou de clonar:
    - `cd acc-elective-csharp-0x-project-trybe-games`

  2. Instale as dependências
  
  - Entre na pasta `src/`.
  - Execute o comando: `dotnet restore`.
  
  3. Crie uma branch a partir da branch `master`

  - Verifique se você está na branch `master`.
    - Exemplo: `git branch`
  - Se não estiver, mude para a branch `master`.
    - Exemplo: `git checkout master`
  - Agora crie uma branch à qual você vai submeter os `commits` do seu projeto.
    - Você deve criar uma branch no seguinte formato: `nome-de-usuario-nome-do-projeto`
    - Exemplo: `git checkout -b joaozinho-acc-0x-project-trybe-games`

  4. Adicione as mudanças ao _stage_ do Git e faça um `commit`

  - Verifique que as mudanças ainda não estão no _stage_.
    - Exemplo: `git status` (deve aparecer listada a pasta _joaozinho_ em vermelho)
  - Adicione o novo arquivo ao _stage_ do Git.
    - Exemplo:
      - `git add .` (adicionando todas as mudanças - _que estavam em vermelho_ - ao stage do Git)
      - `git status` (deve aparecer listado o arquivo _joaozinho/README.md_ em verde)
  - Faça o `commit` inicial.
    - Exemplo:
      - `git commit -m 'iniciando o projeto x'` (fazendo o primeiro commit)
      - `git status` (deve aparecer uma mensagem tipo essa: _nothing to commit_ )

  5. Adicione a sua branch com o novo `commit` ao repositório remoto

  - Usando o exemplo anterior: `git push -u origin joaozinho-acc-0x-project-trybe-games`.

  6. Crie um novo `Pull Request` _(PR)_

  - Vá até a página de _Pull Requests_ do [repositório no GitHub](https://github.com/tryber/acc-elective-csharp-0x-project-trybe-games/pulls).
  - Clique no botão verde _"New pull request"_.
  - Clique na caixa de seleção _"Compare"_ e escolha a sua branch **com atenção**.
  - Coloque um título para a sua _Pull Request_.
    - Exemplo: _"Cria tela de busca"_
  - Clique no botão verde _"Create pull request"_.
  - Adicione uma descrição para o _Pull Request_ e clique no botão verde _"Create pull request"_.
  - **Não se preocupe em preencher mais nada por enquanto!**.
  - Volte até a [página de _Pull Requests_ do repositório](https://github.com/tryber/acc-elective-csharp-0x-project-trybe-games/pulls) e confira que o seu _Pull Request_ está criado.

</details>

<details>
  <summary><strong>⌨️ Durante o desenvolvimento</strong></summary><br/>

  - Faça `commits` das alterações que você fizer no código regularmente.

  - Lembre-se sempre, após um (ou alguns) `commits`, de atualizar o repositório remoto.

  - Os comandos que você utilizará com mais frequência são:
    1. `git status` _(para verificar o que está em vermelho - fora do stage - e o que está em verde - no stage)_
    2. `git add` _(para adicionar arquivos ao stage do Git)_
    3. `git commit` _(para criar um commit com os arquivos que estão no stage do Git)_
    4. `git push -u origin nome-da-branch` _(para enviar o commit para o repositório remoto na primeira vez que fizer o `push` de uma nova branch)_
    5. `git push` _(para enviar o commit para o repositório remoto após o passo anterior)_

</details>

<details>
  <summary><strong>🤝 Depois de terminar o desenvolvimento (opcional)</strong></summary><br/>

  Para sinalizar que o seu projeto está pronto para o _"Code Review"_, faça o seguinte:

  - Vá até a página **DO SEU** _Pull Request_, adicione a label de _"code-review"_ e marque seus colegas:

    - No menu à direita, clique no _link_ **"Labels"** e escolha a _label_ **code-review**;

    - No menu à direita, clique no _link_ **"Assignees"** e escolha **o seu usuário**;

    - No menu à direita, clique no _link_ **"Reviewers"** e digite `students`, selecione o time `tryber/students-sd-034-csharp`.

  Caso tenha alguma dúvida, [aqui tem um video explicativo](https://vimeo.com/362189205).

</details>

<details>
  <summary><strong>🕵🏿 Revisando um pull request</strong></summary><br />

  Use o conteúdo sobre [Code Review](https://app.betrybe.com/course/real-life-engineer/code-review) para te ajudar a revisar os _Pull Requests_.

</details>

<details>
  <summary><strong>🎛 Linter</strong></summary><br />

  Usaremos o [NetAnalyzer](https://docs.microsoft.com/pt-br/dotnet/fundamentals/code-analysis/overview) para fazer a análise estática do seu código.

  Este projeto já vem com as dependências relacionadas ao _linter_ configuradas no arquivo `.csproj`.

  O analisador já é instalado pelo plugin da `Microsoft C#` no `VSCode`. Para isso, basta fazer o download do [plugin](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) e instalá-lo.
</details>

<details>
  <summary><strong>🛠 Testes</strong></summary><br />

  O .NET já possui sua própria plataforma de testes.
  
  Este projeto já vem configurado e com suas dependências.

  ### Executando todos os testes

  Para executar os testes com o .NET, execute o comando dentro do diretório do seu projeto `src/TrybeGames` ou de seus testes `src/TrybeGames.Test`!

  ```
  dotnet test
  ```

  ### Executando um teste específico

  Para executar um teste expecífico, basta executar o comando `dotnet test --filter TestReq01` para o requisito 01 ou `dotnet test --filter TestReq10` para o requisito 10.

  :warning: **Importante:** o comando irá executar testes cujo nome contém `TestReq01`.

  :warning: **O avaliador automático não necessariamente avalia seu projeto na ordem em que os requisitos aparecem no readme. Isso acontece para deixar o processo de avaliação mais rápido. Então, não se assuste se isso acontecer, ok?**

  ### Outras opções para testes
  - Algumas opções que podem lhe ajudar são:
    -  `-?|-h|--help`: exibem a descrição completa de como utilizar o comando.
    -  `-t|--list-tests`: lista todos os testes, ao invés de executá-los.
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

<details>
  <summary><strong>🗣 Nos dê feedbacks sobre o projeto!</strong></summary><br />

Ao finalizar e submeter o projeto, não se esqueça de avaliar sua experiência preenchendo o formulário. 
**Leva menos de 3 minutos!**

[FORMULÁRIO DE AVALIAÇÃO DE PROJETO](https://be-trybe.typeform.com/to/PsefzL2e)

</details>

<details>
  <summary><strong>🗂 Compartilhe seu portfólio!</strong></summary><br />

  Você sabia que o LinkedIn é a principal rede social profissional e que compartilhar aprendizados lá é muito importante para quem deseja construir uma carreira de sucesso? Compartilhe este projeto no seu LinkedIn, marque o perfil da Trybe (@trybe) e mostre para a sua rede toda a sua evolução.

</details>

## Requisitos do projeto


A Trybe começou a desenvolver um sistema para gerenciar e armazenar dados de jogos jogados por Trybers, e você foi contratado para continuar esse desenvolvimento. 

Neste projeto você vai desenvolver a estrutura básica de consultas para que o sistema funcione corretamente. Algumas estruturas já estão desenvolvidas, e o seu trabalho será terminar de desenvolver algumas funcionalidades.

Este sistema está dividido em diretórios específicos, para que fique mais fácil de entender e separar as entidades.
 - `Contracts/` Estão armazenadas as `interfaces` que uma classe pode implementar.
 - `Controller/` Estão armazenados os controllers responsáveis por realizar alguma ação que interage com a pessoa usuária e o banco de dados. No nosso caso há apenas um _controller_.
 - `Database/` Está armazenada a classe que representa o banco de dados do sistema. Essa classe contém uma lista de cada um dos modelos presentes no sistema e alguns métodos que podem ser utilizados para fazer consultas a essas listas e a relações entre elas.
 - `Models/` Contém os Modelos do sistema, no caso três: `Game`, `Player`, `GameStudio`.

O arquivo `Program.cs` utiliza a classe `TrybeGamesController` para executar as ações com a pessoa usuária, então é possível ver o sistema em funcionamento ao executar o projeto em `src/TrybeGames` com o comando `dotnet test`. Porém algumas funcionalidades ainda não foram implementadas, e é para isso que você foi contratado.

Entretando, para entender melhor como todas essas classes se relacionam entre si, vamos utilizar um diagrama. Primeiro, vamos entender qual a relação entre os Models `Game`, `Player` e `GameStudio` no diagrama abaixo:

![diagrama apenas com os models](img/diagram-only-models.png)

Perceba que cada `Game` possui duas relações com `Player`:
 1. Um jogo `Game` pode ter várias pessoas jogadoras `Player` utilizando para isso o membro `Game.Players`, que é uma lista do tipo inteiro e armazena os Ids das pessoas jogadoras.
 2. Uma pessoa jogadora `Player` pode ter vários jogos `Game` comprados utilizando para isso o membro `Player.GamesOwned`, que é uma lista do tipo inteiro e armazena os Ids dos jogos comprados.

`GameStudio`, por sua vez, se relaciona apenas com `Game`. Cada `Game` é desenvolvido por um `GameStudio` e é utilizado o campo `Game.DeveloperStudio`, que é do tipo inteiro e armazena o Id do studio desenvolvedor do jogo.

`Player` também pode ter uma lista de estúdios favoritos. Para isso é utilizado o seu membro `Player.FavoriteGameStudios`, que é uma lista do tipo inteiro que armazena os Ids dos estúdios favoritos.

Esses Models, por sua vez, são utilizados na classe `TrybeGamesDatabse` para compor o nosso banco de dados. E `TrybeGamesDatabase` é utilizado em `TrybeGamesController` para realizar as consultas e operações requisitadas pela pessoa usuária. Veja no diagrama completo abaixo todas as relações entre cada entidade do sistema.

![diagrama completo](img/complete-diagram.png)

Não é necessário entender esse diagrama por completo para cumprir os requisitos do sistema. Para cumprir os requisitos, é importante entender como os Models se relacionam e onde os dados estão armazenados.

De olho na dica👀: Este projeto pode ser executado com `dotnet run` na pasta `src/TrybeGames/`,  várias funcionalidades de interação com a pessoa usuária já estão implementadas e, para as que não estão, será exibida uma mensagem. Utilize isso para guiar o seu desenvolvimento.


### 1. Crie a funcionalidde para adicionar uma nova pessoa jogadora ao banco de dados

_Implemente o método `AddPlayer()` no arquivo `src/TrybeGames/TrybeGamesController.cs`_

<details>
  <summary>Este método deve utilizar as entradas da pessoa usuária pelo <code>Console</code> para criar uma nova pessoa jogadora e adicionar ao banco de dados</summary><br />

  Desenvolva uma lógica para receber da pessoa usuária o nome da nova pessoa jogadora pelo `Console` e assim criar uma nova instância de `Player` e inserir este no banco de dados `database`, que é um atributo da classe `TrybeGamesController`.

  > **🚨Importante:🚨** O atributo Id precisa ser incrementado a cada nova pessoa jogadora que entrar no banco de dados começando de **1**.

  **O que será testado:**

  - Será testado se o método implementado, ao ser chamado, adiciona uma nova pessoa jogadora no banco de dados existente na classe `TrybeGamesDatabase`, acessível pelo atributo `database` da classe `TrybeGamesController`.


</details>



### 2. Crie a funcionalidade de adicionar um novo estúdio de jogos ao banco de dados

_Implemente o método `AddGameStudio()` no arquivo `src/TrybeGames/TrybeGamesController.cs`_

<details>
  <summary>Este método deve utilizar as entradas da pessoa usuária pelo <code>Console</code> para criar um novo Estúdio de Jogos e adicionar ao banco de dados</summary><br />

  Desenvolva uma lógica para receber da pessoa usuária o nome do novo Estúdio de Jogos pelo `Console` e assim criar uma nova instância de `GameStudio` e inserir este no banco de dados `database`, que é um atributo da classe `TrybeGamesController`.

  > **🚨Importante:🚨** O atributo Id precisa ser incrementado a cada novo estúdio que entrar no banco de dados, começando de **1**.

  **O que será testado:**

  - Será testado se o método implementado, ao ser chamado, adiciona um novo estúdio de jogos no banco de dados existente na classe `TrybeGamesDatabase`, acessível pelo atributo `database` da classe `TrybeGamesController`.
  
</details>



### 3. Crie a funcionalidade de adicionar novo Jogo ao Banco de dados

_Implemente o método `AddGame()` no arquivo `src/TrybeGames/TrybeGamesController.cs`_

<details>
  <summary>Este método deve utilizar as entradas da pessoa usuária pelo <code>Console</code> para criar um novo Jogo e adicionar ao banco de dados</summary><br />

  Desenvolva uma lógica para receber da pessoa usuária os seguintes dados de um jogo:
   1. Nome (`Name`).
   2. Data de lançamento (`ReleaseDate`).
   3. Tipo de jogo (`GameType`).
  Lembre-se de que cada um desses atributos possui um tipo específico, e este método deve ser capaz de fazer as conversões necessárias para criar uma nova instância de `Game` corretamente e inseri-la no banco de dados `database`, que é um atributo da classe `TrybeGamesController`.

  > **🚨Importante:🚨** O atributo Id precisa ser incrementado a cada novo jogo que entrar no banco de dados começando de **1**.

  **O que será testado:**

  - Será testado se o método implementado, ao ser chamado, adiciona um novo jogo no banco de dados existente na classe `TrybeGamesDatabase`, acessível pelo atributo `database` da classe `TrybeGamesController`.

</details>



### 4. Crie a funcionalidade de buscar jogos desenvolvidos por um estúdio de jogos

_Implemente o método `GetGamesDevelopedBy()` no arquivo `src/TrybeGames/Database/TrybeGamesDatabase.cs`_

<details>
  <summary>Este método deve receber por parâmetro um estúdio de jogos e retornar todos os jogos que aquele estúdio desenvolveu</summary><br />

  Por se tratar de um método da classe `TrybeGamesDatabase`, este não lida com entradas e interações com a pessoa usuária. Porém ele será utilizado pelo método `QueryGamesFromStudio` para buscar os jogos desenvolvidos pelo estúdio selecionado neste método. Como o método `GetGamesDevelopedBy` sempre retorna uma lista vazia, essa funcionalidade está imcompleta.

  No método `GetGamesDevelopedBy`, utilize as listas de `Game`, `Player` e `GameStudio` presentes em `TrybeGamesDatabase` e suas relações para buscar e retornar uma lista de jogos `List<Game>`.

  De olho na dica👀: Consultas LINQ são uma ótima forma de realizar essa busca. Utilize o método `ToList()` para converter do tipo `IEnumerable` para `List`.

  **O que será testado:**

  - Será testado se o método implementado, ao ser chamado, retorna a lista do tipo `Game` com os dados solicitados.
  
</details>




### 5. Crie a funcionalidade de buscar jogos jogados por uma pessoa jogadora

_Implemente o método `GetGamesPlayedBy()` no arquivo `src/TrybeGames/Database/TrybeGamesDatabase.cs`_

<details>
  <summary>Este método deve receber por parâmetro uma pessoa jogadora e retornar todos os jogos jogados por aquela pessoa jogadora</summary><br />

  Por se tratar de um método da classe `TrybeGamesDatabase`, este não lida com entradas e interações com a pessoa usuária. Porém ele será utilizado pelo método `QueryGamesPlayedByPlayer` para buscar os jogos jogados pela pessoa jogadora selecionada neste método. Como o método `GetGamesPlayedBy` sempre retorna uma lista vazia, essa funcionalidade está imcompleta.

  No método `GetGamesPlayedBy`, utilize as listas de `Game`, `Player` e `GameStudio` presentes em `TrybeGamesDatabase` e suas relações para buscar e retornar uma lista de jogos `List<Game>`.

  De olho na dica👀: Consultas LINQ são uma ótima forma de realizar essa busca. Utilize o método `ToList()` para converter do tipo `IEnumerable` para `List`.

   **O que será testado:**

  - Será testado se o método implementado, ao ser chamado, retorna a lista do tipo `Game` com os dados solicitados.

</details>



### 6. Crie a funcionalidade de buscar jogos comprados por uma pessoa jogadora

_Implemente o método `GetGamesOwnedBy()` no arquivo `src/TrybeGames/Database/TrybeGamesDatabase.cs`_

<details>
  <summary>Este método deve receber por parâmetro uma pessoa jogadora e retornar todos os jogos que aquela pessoa jogadora possui</summary><br />

  Por se tratar de um método da classe `TrybeGamesDatabase`, este não lida com entradas e interações com a pessoa usuária. Porém ele será utilizado pelo método `QueryGamesBoughtByPlayer` para buscar os jogos comprados pela pessoa jogadora selecionada neste método. Como o método `GetGamesOwnedBy` sempre retorna uma lista vazia, essa funcionalidade está imcompleta.

  No método `GetGamesOwnedBy`, utilize as listas de `Game`, `Player` e `GameStudio` presentes em `TrybeGamesDatabase` e suas relações para buscar e retornar uma lista de jogos `List<Game>`.

  De olho na dica👀: Consultas LINQ são uma ótima forma de realizar essa busca. Utilize o método `ToList()` para converter do tipo `IEnumerable` para `List`.

   **O que será testado:**

  - Será testado se o método implementado, ao ser chamado, retorna a lista do tipo `Game` com os dados solicitados.

</details>



### 7. Crie a funcionalidade de buscar todos os jogos junto do nome do estúdio desenvolvedor

_Implemente o método `GetGamesWithStudio()` no arquivo `src/TrybeGames/Database/TrybeGamesDatabase.cs`_

<details>
  <summary>Este método não recebe parâmetros e deve retornar as informações de jogos e seus estúdios de acordo com o DTO GameWithStudio</summary><br />

  No método `GetGamesOwnedBy`, utilize as listas de `Game`, `Player` e `GameStudio` presentes em `TrybeGamesDatabase` e suas relações para buscar e retornar uma lista de jogos de acordo com o DTO `List<GameWithStudio>`.
  
  O DTO `GameWithStudio` está presente no arquivo `src/TrybeGames/DTO/GameWithStudio.cs` e segue a seguinte estrutura

  ```csharp
  public class GameWithStudio
  {
      public string? GameName { get; set; } // nome do jogo
      public string? StudioName { get; set; } // nome do estúdio que desenvolveu o jogo
      public int NumberOfPlayers { get; set; } // número de pessoas jogadoras do jogo
  }
  ```

  De olho na dica👀: Consultas LINQ são uma ótima forma de realizar essa busca. Utilize o método `ToList()` para converter do tipo `IEnumerable` para `List`.

  **O que será testado:**

  - Será testado se o método implementado, ao ser chamado, retorna a lista do tipo `GameWithStudio` com os dados solicitados.

</details>



### 8. Crie a funcionalidade de buscar todos os diferentes Tipos de jogos dentre os jogos cadastrados

_Implemente o método `GetGameTypes()` no arquivo `src/TrybeGames/Database/TrybeGamesDatabase.cs`_

<details>
  <summary>Este método não recebe parâmetros e deve retornar as informações dos tipos de jogos dentre os jogos cadastrados</summary><br />

  No método `GetGameTypes()`, utilize a lista de `Game` presente em `TrybeGamesDatabase` para retornar uma lista de tipos de jogos `List<GameType>`.

  De olho na dica👀: Consultas LINQ são uma ótima forma de realizar essa busca. Utilize o método `ToList()` para converter do tipo `IEnumerable` para `List`.

   **O que será testado:**

  - Será testado se o método implementado, ao ser chamado, retorna a lista do tipo `GameType` com os dados solicitados.

</details>



### 9. Crie a funcionalidade de buscar todos os estúdios de jogos junto dos seus jogos desenvolvidos com suas pessoas jogadoras

_Implemente o método `GetStudiosWithGamesAndPlayers()` no arquivo `src/TrybeGames/Database/TrybeGamesDatabase.cs`_

<details>
  <summary>Este método não recebe parâmetros e deve retornar as informações dos estúdios de jogos, seus jogos e para cada jogo, suas pessoas jogadoras de acordo com os DTOs StudioGamesPlayers e GamePlayer</summary><br />

  No método `GetStudiosWithGamesAndPlayers()`, utilize as listas de `Game`, `Player` e `GameStudio` presentes em `TrybeGamesDatabase` e suas relações para buscar e retornar uma lista de jogos de acordo com o DTO `List<StudioGamesPlayers>`.
  
  Os DTOs `StudioGamesPlayers` e `GamePlayer` estão presentes no arquivo `src/TrybeGames/DTO/StudioGamesPlayers.cs` e segue a seguinte estrutura

  ```csharp
  public class GamePlayer
  {
      public string GameName = ""; // nome do jogo
      public List<Player>? Players { get; set; } // lista das pessoas jogadoras que jogam este jogo.
  }
  public class StudioGamesPlayers
  {
      public string? GameStudioName { get; set; } // nome do estúdio de jogos
      public List<GamePlayer>? Games { get; set; } // lista das informações de jogos e pessoas jogadoras baseada no DTO GamePlayer
  }
  ```

  De olho na dica👀: Consultas LINQ são uma ótima forma de realizar essa busca. Utilize o método `ToList()` para converter do tipo `IEnumerable` para `List`.

  **O que será testado:**

  - Será testado se o método implementado, ao ser chamado, retorna a lista do tipo `StudioGamesPlayers` com os dados solicitados.

</details>



### 10. Implemente os testes da funcionalidade de buscar jogos jogados por uma pessoa jogadora

_Implemente o método `TestGetGamesPlayedBy()` no arquivo `src/TrybeGames.Test/TestTrybeGamesDatabase.cs`_

<details>
  <summary>Este método deve implementar os testes do método indicado</summary><br />

  No método `TestGetGamesPlayedBy()` crie o arrange, act e assert para testar a funcionalidade de buscar os jogos jogados por uma pessoa jogadora implementada no método `GetGamesPlayedBy` do arquivo `src/TrybeGames/Database/TrybeGamesDatabase.cs`.

  O método possui como parâmetros de entrada o database da classe `TrybeGamesDatabase`, o id do player do tipo `Int` e uma lista de games `List<Game>` com a lista esperada no retorno do método a ser testado.

  Os dados a serem utilizados no teste estão no atributo `DataTestGetGamesPlayedBy` do tipo `TheoryData`, presente no mesmo arquivo `src/TrybeGames.Test/TestTrybeGamesDatabase.cs`.

  **O que será testado:**

  - Será testado se o método implementado testa com sucesso a funcionalidade.

</details>




<details>
<summary><strong>🗣 Nos dê feedbacks sobre o projeto!</strong></summary>

Ao finalizar e submeter o projeto, não se esqueça de avaliar sua experiência preenchendo o formulário.
**Leva menos de 3 minutos!**

[Formulário de avaliação do projeto](https://be-trybe.typeform.com/to/ZTeR4IbH#cohort_hidden=CH34-CSHARP&template=betrybe/csharp-0x-projeto-trybe-games)

</details>
  
<details>
<summary><strong>🗂 Compartilhe seu portfólio!</strong></summary>

Você sabia que o LinkedIn é a principal rede social profissional e compartilhar o seu aprendizado lá é muito importante para quem deseja construir uma carreira de sucesso? Compartilhe esse projeto no seu LinkedIn, marque o perfil da Trybe (@trybe) e mostre para a sua rede toda a sua evolução.

</details>

---

<!-- mdi versão 1.1 projeto ⚠️ não exclua esse comentário -->
