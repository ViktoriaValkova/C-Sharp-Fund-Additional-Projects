# Rock - Paper - Scissors

![178bc014-a0c3-47e7-8e33-72e6f26909c4-rock-paper-scissors](https://github.com/ViktoriaValkova/CSharp-Fund-Additional-Projects/assets/132173101/cbd8eea9-de29-4f28-8d3c-d49081c38496)


With my first project outside of course exercises, I wanted to do a quick rock-paper-scissors console game.  
The player has the option to play a single game against the computer or continue and play best out of 3.

**A bit about the game itself**

In a traditional rock-paper scissors game, the two players have the option to choose either rock, paper or scissors.   
The winner is chosen with the following logic: rock crushes scissors, scissors cut paper and paper envelopes rock. 

**Gameplay**

1. The player is prompted to choose one of the three options by entering:

`p` or `paper` or `Paper` to choose paper  
`s` or `scissors` or `Scissors` to choose scissors   
`r` or `rock` or `Rock` to choose rock

2. The computer's choice is generated using the `Random` class. 

3. Choosing the winner: I have implemented the following possibilities in my version of the game: 

| Player's Choice | Computer's Choice | Result |
|      :---:     |      :-----:       |  :---: |
|       scissors  |        scissors   |  draw  |
|       scissors  |         rock      |  loss  |
|       scissors  |        paper      |  win   |
|       rock      |        rock       |  draw  |
|       rock      |        paper      |  loss  |
|       rock      |        scissors   |  win   |
|       paper     |        paper      |  draw  |
|       paper     |        scissors   |  loss  |
|       paper     |        rock       |  win   |

4. After getting the result (win, loss, draw) the player is prompted to either quit playing or try their luck in best out of three. 

* To quit the current game, the player can press either `n` or `N`.
* To continue playing, the player can press either `y` or `Y`.

5. If the player chooses 'y', steps 1-3 are repeated twice. 

6. After that the final winner and points won are printed on the console and the game finishes.
