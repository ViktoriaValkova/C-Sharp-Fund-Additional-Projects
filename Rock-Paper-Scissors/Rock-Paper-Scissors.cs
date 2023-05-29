namespace Rock_Paper_Scissors
{
    internal class Rock_Paper_Scissors
    {
        static void Main()
        {
            Console.WriteLine("Welcome to our Rock-Paper-Scissors game!");
            Console.WriteLine("Choose your move, hit [enter] and see if you can beat the mighty computer!");
            Thread.Sleep(2000);

            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";
            int computerWinsCnt = 0;
            int playerWinsCnt = 0;
            int points = 0;
            string winner = string.Empty;
            bool giveUp = false;
            
            for (int i = 0; i < 3; i++)
            {
                if (giveUp)
                {
                    break;
                }
                Console.WriteLine("Will it be [r]ock, [p]aper or [s]cissors?");
                Thread.Sleep(1000);
                Console.WriteLine("3...");
                Thread.Sleep(1000);
                Console.WriteLine("2...");
                Thread.Sleep(1000);
                Console.WriteLine("1...");

                string playerMove = Console.ReadLine();
                bool invalidInput = false;
                switch (playerMove)
                {
                    case "r":
                    case "rock":
                    case "Rock":
                        playerMove = Rock; break;
                    case "p":
                    case "paper":
                    case "Paper":
                        playerMove = Paper; break;
                    case "s":
                    case "scissors":
                    case "Scissors":
                        playerMove = Scissors; break;
                    default:
                        Console.WriteLine("Invalid Input. Try Again...");
                        invalidInput = true ; break;
                }
                if (invalidInput)
                {
                    i--; 
                    continue;
                }
                Random random = new Random();
                int computerMove = random.Next(1, 4);
                string computerMoveText = string.Empty;
                switch (computerMove)
                {
                    case 1: computerMoveText = Rock; break;
                    case 2: computerMoveText = Paper; break;
                    case 3: computerMoveText = Scissors; break;
                }
                Console.WriteLine("The computer chose... ");
                Thread.Sleep(1000);
                Console.WriteLine(computerMoveText);

                if (playerMove == Rock && computerMoveText == Rock ||
                    playerMove == Paper && computerMoveText == Paper ||
                    playerMove == Scissors && computerMoveText == Scissors)
                {
                    Console.WriteLine("This game was a draw");
                }
                else if (playerMove == Rock && computerMoveText == Scissors ||
                    playerMove == Scissors && computerMoveText == Paper ||
                    playerMove == Paper && computerMoveText == Rock)
                {
                    Console.WriteLine("Congratulations! You won this one!");
                    playerWinsCnt++;
                }
                else
                {
                    computerWinsCnt++;
                    if (i != 2)
                    {
                    Console.WriteLine("Oh no.. You lost, maybe next time :)");
                    }
                    else
                    {
                        Console.WriteLine("Oh no.. You lost this one :(");
                    }
                }
                if (i == 0)
                {
                    Console.WriteLine("Do you want to try again? Best out of three?");
                    Console.WriteLine("Press [y]es or [n]o and then hit [enter]");
                    char decision = char.Parse(Console.ReadLine());
                    if (decision == 'n' || decision == 'N')
                    {
                        giveUp = true;
                    }
                }
            }

            if (!giveUp)
            {
                Thread.Sleep(2000);
                if (computerWinsCnt == playerWinsCnt && computerWinsCnt == 0)
                {
                    Console.WriteLine("Geniuses think alike - the game is draw.");
                }
                else if (computerWinsCnt == playerWinsCnt)
                {
                    Console.WriteLine("A loss, a win and a draw.. Neither could defeat the other!");
                }
                else
                {
                    if (computerWinsCnt > playerWinsCnt)
                    {
                        winner = "the Computer";
                        points = computerWinsCnt;
                    }
                    else if (computerWinsCnt < playerWinsCnt)
                    {
                        winner = "you";
                        points = playerWinsCnt;
                    }
                    Console.WriteLine($"The final winner is: {winner}! With {points} points!");
                }
            }
        }
    }
}