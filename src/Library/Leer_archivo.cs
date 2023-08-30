using System;
using System.IO;

namespace Conwaygame
{
    public class LeerArchivo
    {
        public static bool[,] LeerTablero(string filePath)
        {
            string content = File.ReadAllText(filePath);
            string[] contentLines = content.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            int height = contentLines.Length;
            int width = contentLines[0].Length;
            
            bool[,] board = new bool[width, height];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (contentLines[y][x] == '1')
                    {
                        board[x, y] = true;
                    }
                }
            }
            
            return board;
        }
    }
}
