using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conway.equipo20;

public class Leer_archivo
{
    string url = "ConwayGame\src\Library\archivo.txt";
    string content = File.ReadAllText(url);
    string[] contentLines = content.Split('\n');
    bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
    for (int  y=0; y<contentLines.Length;y++)
        {
            for (int x=0; x<contentLines[y].Length; x++)
                {
                    if(contentLines[y][x]=='1')
                {
                board[x,y]=true;
                }
        }
}
}
