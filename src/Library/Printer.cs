using System.Threading;
using System.Text;
using System;

public static class Printer
{
    public static void Print(int width,int height,bool[,]Tablero)
    {
        Console.Clear();
        StringBuilder BoardPresentation = new StringBuilder();
    
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if(Tablero[x,y])
                {
                    BoardPresentation.Append("|X|");
                }
                else
                {   
                    BoardPresentation.Append("___");
                }
            }   
            BoardPresentation.Append("\n");
        }
        Console.WriteLine(BoardPresentation.ToString());
    Thread.Sleep(300);
    }
}