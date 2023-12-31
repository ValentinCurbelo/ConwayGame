using System;

namespace Conwaygame
{
    public class Logica
    {
        public static bool[,] CalcularSiguienteGeneracion(bool[,] gameBoard)
        {
            int boardWidth = gameBoard.GetLength(0);
            int boardHeight = gameBoard.GetLength(1);
            bool[,] cloneBoard = new bool[boardWidth, boardHeight];

            for (int x = 0; x < boardWidth; x++)
            {
                for (int y = 0; y < boardHeight; y++)
                {
                    int aliveNeighbors = 0;
                    for (int i = x - 1; i <= x + 1; i++)
                    {
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            if (i >= 0 && i < boardWidth && j >= 0 && j < boardHeight && gameBoard[i, j])
                            {
                                aliveNeighbors++;
                            }
                        }
                    }
                    if (gameBoard[x, y])
                    {
                        aliveNeighbors--;
                    }
                    if (gameBoard[x, y] && aliveNeighbors < 2)
                    {
                        // Celula muere por baja población
                        cloneBoard[x, y] = false;
                    }
                    else if (gameBoard[x, y] && aliveNeighbors > 3)
                    {
                        // Celula muere por sobrepoblación
                        cloneBoard[x, y] = false;
                    }
                    else if (!gameBoard[x, y] && aliveNeighbors == 3)
                    {
                        // Celula nace por reproducción
                        cloneBoard[x, y] = true;
                    }
                    else
                    {
                        // Celula mantiene el estado que tenía
                        cloneBoard[x, y] = gameBoard[x, y];
                    }
                }
            }

            // Actualizar la matriz original gameBoard con los valores de cloneBoard
            gameBoard = cloneBoard;

            return gameBoard; // Devuelve la matriz actualizada
        }
    }
}
