# Atividades Monitoria (01/10/2022)

1. Crie um programa que leia um número N e gere um arquivo com N nomes e idades aleatórios. Deverão ser criados manualmente 2 arquivos, um que contenha 20 nomes e outro que contenha 20 sobrenomes, devendo selecionar aleatoriamente 1 a 2 nomes inicias e o sobrenome desse arquivo. As idades devem ser geradas de forma aleatória. Cada linha deve conter um nome completo e a idade.
2. Crie um programa que leia o arquivo gerado anteriormente e gere dois novos arquivos, um ordenado por nome e o outro ordenado por idade
3. Crie um programa para controle das reservas de bilhetes de linha aérea. Deverá ser criado um menu com a opção de reserva, cancelamento, verificação e listagem. A informação de cadeiras não deve se repetir mas o nome do passageiro sim. Ao reservar, deverá ser selecionada uma assento de A ao F e uma fileira de 1 até 30, bem como o nome do passageiro. No cancelamento, deverá ser solicitado a poltrona da reserva e somente será cancelada se for reservada. Na verificação, deverá ser exibida se a poltrona está vazia ou reservada e na listagem deverão ser exibidas as poltronas vazias e reservadas.
4. Crie um programa que simule um controle aéreo de decolagem. O programa deverá permitir a listagem dos aviões aguardando para decolagem. A liberação do primeiro avião que estava aguardando para a decolagem. Adicionar um avisão para a decolagem. Para o controle do avião, poderá ser criado por String ou criar uma classe Avião contendo o número e a companhia.
5. Crie um programa que receba 15 números. Ao receber um número par ele deve ser inserido na lista e ao receber um número ímpar ele deve ser removido o último elemento adicionado a lista. Ao final, deverá ser impresso todos os número restantes. Exemplo: Se inserido o primeiro número 2, o segundo número 4 e o terceiro número 5, ao imprimir a lista deverá aparecer apenas o número 2.

**DESAFIO**
Crie um programa que simule o jogo campo minado. O programa deverá simular um campo de 10x10 com 10 bombas. O jogador deverá informar a coluna e a linha que deseja selecionar e o programa irá informar se há uma bomba ou não. Caso haja uma bomba o programa será encerrado com o jogador perdendo. Se restarem apenas as casas com bomba para selecionar o programa será encerrado com o jogador ganhando. As posições das bombas devem ser aleatorizadas a cada jogo.

``` 
Tabuleiro Inicial
   A B C D E F G H I J
  +-------------------+
1 | | | | | | | | | | |
2 | | | | | | | | | | |
3 | | | | | | | | | | |
4 | | | | | | | | | | |
5 | | | | | | | | | | |
6 | | | | | | | | | | |
7 | | | | | | | | | | |
8 | | | | | | | | | | |
9 | | | | | | | | | | |
10| | | | | | | | | | |
  +-------------------+

Jogada sem bomba
   A B C D E F G H I J
  +-------------------+
1 | | | | | | | | | | |
2 | | | | | | | | | | |
3 | | | | | | | | | | |
4 | | | | | | | | | | |
5 | | | |X| | | | | | |
6 | | | | | | | | | | |
7 | | | | | | | | | | |
8 | | | | | | | | | | |
9 | | | | | | | | | | |
10| | | | | | | | | | |
  +-------------------+

Jogada com bomba
   A B C D E F G H I J
  +-------------------+
1 | | | | | | | | | | |
2 | | | | | | | | | | |
3 | | | | | | | | | | |
4 | | | | | | | | | | |
5 | | | |X| | | | | | |
6 | | | | | | | | | | |
7 | | | | | | | | | | |
8 | | | | | | | | | | |
9 | | | | | | | | | | |
10| | | | | | |*| | | |
  +-------------------+



Quando vencer
   A B C D E F G H I J
  +-------------------+
1 |X|X|X|X|X|*|X|X|X|X|
2 |X|X|X|*|X|X|X|X|X|*|
3 |X|X|X|X|X|X|X|X|X|X|
4 |X|X|X|X|*|X|X|X|*|X|
5 |X|X|X|X|X|X|X|X|X|X|
6 |X|X|*|X|X|*|X|X|X|X|
7 |X|X|X|X|X|X|X|*|X|X|
8 |X|X|X|*|X|X|X|X|X|X|
9 |X|X|X|X|X|X|X|X|X|X|
10|X|X|X|X|X|*|X|X|X|X|
  +-------------------+
```