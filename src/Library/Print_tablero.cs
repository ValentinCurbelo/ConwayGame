using System;
using System.Text;
using System.Threading;

namespace Conwaygame
{
    public class PrintTablero
    {
        public static void ImprimirTablero(bool[,] board, int maxGenerations)
        {
            int width = board.GetLength(0);
            int height = board.GetLength(1);
            
            for (int generation = 0; generation < maxGenerations; generation++)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        if (board[x, y])
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                    s.Append("\n");
                }
                Console.WriteLine(s.ToString());

                //=================================================
                // Calcular siguiente generación
                //=================================================
                board = Logica.CalcularSiguienteGeneracion(board);
                Thread.Sleep(300);
            }
        }
    }
}
