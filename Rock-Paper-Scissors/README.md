# Rock - Paper - Scissors

![178bc014-a0c3-47e7-8e33-72e6f26909c4-rock-paper-scissors](https://github.com/ViktoriaValkova/CSharp-Fund-Additional-Projects/assets/132173101/cbd8eea9-de29-4f28-8d3c-d49081c38496)


With my first project outside of course exercises, I wanted to do a quick rock-paper-scissors console game.  
The player has the option to play a single game against the computer or continue and play best out of 3.

[Here you can see the source code](https://github.com/ViktoriaValkova/CSharp-Fund-Additional-Projects/blob/main/Rock-Paper-Scissors/Rock-Paper-Scissors.cs)

**A bit about the game itself**

In a traditional rock-paper scissors game, the two players have the option to choose either rock, paper or scissors.   
The winner is chosen with the following logic: rock crushes scissors, scissors cut paper and paper envelopes rock. 

**Gameplay**

1. The player is prompted to choose one of the three options by entering:

`p` or `paper` or `Paper` to choose paper  
`s` or `scissors` or `Scissors` to choose scissors   
`r` or `rock` or `Rock` to choose rock

<img src="https://github.com/ViktoriaValkova/CSharp-Fund-Additional-Projects/assets/132173101/889b3bbf-3135-4c5d-9044-79aefad33764" width="550" />

2. If another, invalid symbol or word is entered, the message "Invalid input" is printed on the console and the player is prompted to makea choice again. 

<img src="https://github.com/ViktoriaValkova/CSharp-Fund-Additional-Projects/assets/132173101/1c0d9c39-0c32-46c8-88be-d2d4ca95018c" width="400" />

3. The computer's choice is generated using the `Random` class. 

4. Choosing the winner: I have implemented the following possibilities in my version of the game: 

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

5. After getting the result (win, loss, draw) the player is prompted to either quit playing or try their luck in best out of three. 

* To quit the current game, the player can press either `n` or `N`.
* To continue playing, the player can press either `y` or `Y`.

<img src="https://github.com/ViktoriaValkova/CSharp-Fund-Additional-Projects/assets/132173101/815d5f7c-6562-4289-8276-009d91c3444d" width="400" />

6. If the player chooses 'y', steps 1-3 are repeated twice. 

7. After that, the final winner and points won are printed on the console and the game finishes.

<img src="https://github.com/ViktoriaValkova/CSharp-Fund-Additional-Projects/assets/132173101/927b8e89-292c-470b-824a-8a8c14843813" width="500" />

**Game Demo**
You can try the game for yourself directly in your browser: 



