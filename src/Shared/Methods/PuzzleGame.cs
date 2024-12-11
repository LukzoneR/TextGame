
using Utilities;

namespace Methods;

public class PuzzleGame
{
    private int[,] board;

    public PuzzleGame()
    {
        board = InitializeBoard();
        ShuffleBoard();
    }

    public void Play()
    {
        while (!IsSolved())
        {
            Console.Clear();
            DisplayBoard();
            Console.WriteLine("Use W/A/S/D to move the empty space: ");
            char move = Console.ReadKey().KeyChar;

            if (IsValidMove(move))
            {
                MakeMove(move);
            }
            else
            {
                Writing.Print("\nInvalid move! Press any key to try again...");
                Console.ReadKey();
            }
        }

        Console.Clear();
        DisplayBoard();
        Writing.Print("Congratulations! You've solved the puzzle!");
        Console.ReadKey();
    }

    private int[,] InitializeBoard()
    {
        return new int[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 0 } 
        };
    }

    private void ShuffleBoard()
    {
        Random rand = new Random();
        for (int i = 0; i < 100; i++)
        {
            char[] moves = { 'w', 'a', 's', 'd' };
            char move = moves[rand.Next(moves.Length)];
            if (IsValidMove(move))
            {
                MakeMove(move);
            }
        }
    }

    private void DisplayBoard()
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                Console.Write(board[i, j] == 0 ? "   " : $"{board[i, j],2} ");
            }
            Console.WriteLine();
        }
    }

    private (int, int) FindEmptyTile()
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (board[i, j] == 0)
                    return (i, j);
            }
        }
        throw new Exception("Empty tile not found");
    }

    private bool IsValidMove(char move)
    {
        (int emptyRow, int emptyCol) = FindEmptyTile();
        return move switch
        {
            'w' => emptyRow > 0,
            'a' => emptyCol > 0,
            's' => emptyRow < board.GetLength(0) - 1,
            'd' => emptyCol < board.GetLength(1) - 1,
            _ => false
        };
    }

    private void MakeMove(char move)
    {
        (int emptyRow, int emptyCol) = FindEmptyTile();

        switch (move)
        {
            case 'w':
                Swap(emptyRow, emptyCol, emptyRow - 1, emptyCol);
                break;
            case 'a':
                Swap(emptyRow, emptyCol, emptyRow, emptyCol - 1);
                break;
            case 's':
                Swap(emptyRow, emptyCol, emptyRow + 1, emptyCol);
                break;
            case 'd':
                Swap(emptyRow, emptyCol, emptyRow, emptyCol + 1);
                break;
        }
    }

    private void Swap(int row1, int col1, int row2, int col2)
    {
        int temp = board[row1, col1];
        board[row1, col1] = board[row2, col2];
        board[row2, col2] = temp;
    }

    private bool IsSolved()
    {
        int correctValue = 1;
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (i == board.GetLength(0) - 1 && j == board.GetLength(1) - 1)
                    return board[i, j] == 0;

                if (board[i, j] != correctValue)
                    return false;

                correctValue++;
            }
        }
        return true;
    }
}
