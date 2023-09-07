using System;
using System.IO;
namespace Library;

public static class BoardGenerator
{
    public static bool [,] Tablero;
    
    public static bool[,] ReadBoard(string url)
    {
        string content = File.ReadAllText(url);
        string[] contentLines = content.Split('\n');
        bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
        for (int  x=0; x < contentLines.Length; x++)
        {
            for (int y=0; y < contentLines[x].Length; y++)
            {
                if(contentLines[x][y]=='1')
                {
                    board[x,y]=true;
                }
            }
        }
    Tablero=board;
    return Tablero;
    }
}