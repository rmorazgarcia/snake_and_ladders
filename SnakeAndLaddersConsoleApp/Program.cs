// See https://aka.ms/new-console-template for more information
using SnakeAndLaddersLibrary;

Console.WriteLine("Welcome to Snakes and Ladders!");

List<Player> players = new List<Player>();
Board board = new Board();
int numOfPlayers = 0;
bool gameOver = false;

Console.Write("Enter the number of players: ");
numOfPlayers = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < numOfPlayers; i++)
{
    var newPlayer = new Player();
    Console.Write($"Enter the player {i+1} name: ");
    newPlayer.Name = Console.ReadLine();
    players.Add(newPlayer);
}

int turn = 0; 
do
{
    var currentPlayer = players[turn % numOfPlayers];
    Console.WriteLine($"It's {currentPlayer.Name}'s turn");
    Console.WriteLine("Press R to Roll the dice or E to End the game.");

    var pressed = Char.ToUpper(Console.ReadKey().KeyChar);
    Console.WriteLine();

    switch (pressed)
    {
        case 'R':
            var previousPosition = currentPlayer.Token.Position;

            var diceResult = currentPlayer.Roll();
            Console.WriteLine($"Player {currentPlayer.Name} got a {diceResult} on the dice");
            currentPlayer.Move(diceResult);

            if (currentPlayer.Token.Position == previousPosition)
            {
                Console.WriteLine($"Player {currentPlayer.Name} can't move and stays on {currentPlayer.Token.Position}");
            }
            else
            {
                Console.WriteLine($"Player {currentPlayer.Name} moves from {previousPosition} to {currentPlayer.Token.Position}");
            }

            var newPosition = board.checkPosition(currentPlayer.Token.Position);

            if (newPosition != currentPlayer.Token.Position)
            {
                if (newPosition > currentPlayer.Token.Position)
                {
                    Console.WriteLine($"Player {currentPlayer.Name} lands on a ladder and moves from {currentPlayer.Token.Position} to {newPosition}");
                }
                else
                {
                    Console.WriteLine($"Player {currentPlayer.Name} lands on a snake and moves from {currentPlayer.Token.Position} to {newPosition}");
                }
                currentPlayer.Token.MoveTo(newPosition);
            }

            if (currentPlayer.Wins)
            {
                Console.WriteLine($"Player {currentPlayer.Name} wins the game!");
                gameOver = true;
            }

            turn++;

            Console.WriteLine("--------------------------------");

            break;
        case 'E':
            Console.WriteLine($"Player {currentPlayer.Name} decided to abort the game!");
            gameOver = true;
            break;
        default:
            break;
    }

} while (!gameOver);