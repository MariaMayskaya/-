using System;

class MyClass
{
    static char[] gameBoard = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

    static int currentPlayerNumber = 1;

    static void Main()
    {
        int playerChoice; 
        bool isValidInput; 

        do
        {
            Console.Clear();
            DisplayBoard(); 
            Console.WriteLine($"Игрок {currentPlayerNumber}, введите номер ячейки:");
               
            isValidInput = int.TryParse(Console.ReadLine(), out playerChoice) &&
                            playerChoice >= 1 && playerChoice <= 9 &&
                            gameBoard[playerChoice - 1] != 'X' && gameBoard[playerChoice - 1] != 'O';

            if (isValidInput)
            {
                char playerSymbol = (currentPlayerNumber == 1) ? 'X' : 'O';
                gameBoard[playerChoice - 1] = playerSymbol;

                if (HasWinningCombination())
                {
                    Console.Clear(); 
                    DisplayBoard();
                    Console.WriteLine($"Победил игрок {currentPlayerNumber}!"); 
                    break; 
                }

                if (IsBoardFull())
                {
                    Console.Clear(); 
                    DisplayBoard(); 
                    Console.WriteLine("Ничья!"); 
                    break; 
                }

                currentPlayerNumber = (currentPlayerNumber == 1) ? 2 : 1;
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Попробуйте снова."); 
            }

        } while (true); 
    }
    static void DisplayBoard()
    {
        Console.WriteLine($" {gameBoard[0]} | {gameBoard[1]} | {gameBoard[2]} "); 
        Console.WriteLine("-----------"); // разделитель
        Console.WriteLine($" {gameBoard[3]} | {gameBoard[4]} | {gameBoard[5]} "); 
        Console.WriteLine("-----------"); // разделитель
        Console.WriteLine($" {gameBoard[6]} | {gameBoard[7]} | {gameBoard[8]} "); 
    }

    static bool HasWinningCombination()
    {
       
        return (gameBoard[0] == gameBoard[1] && gameBoard[1] == gameBoard[2]) ||
               (gameBoard[3] == gameBoard[4] && gameBoard[4] == gameBoard[5]) || 
               (gameBoard[6] == gameBoard[7] && gameBoard[7] == gameBoard[8]) || 
               (gameBoard[0] == gameBoard[3] && gameBoard[3] == gameBoard[6]) || 
               (gameBoard[1] == gameBoard[4] && gameBoard[4] == gameBoard[7]) || 
               (gameBoard[2] == gameBoard[5] && gameBoard[5] == gameBoard[8]) || 
               (gameBoard[0] == gameBoard[4] && gameBoard[4] == gameBoard[8]) || 
               (gameBoard[2] == gameBoard[4] && gameBoard[4] == gameBoard[6]);   
    }
 
    static bool IsBoardFull()
    {
 
        foreach (char cell in gameBoard)
        {
      
            if (cell != 'X' && cell != 'O')
                return false; 
        }
        return true;
    }
}