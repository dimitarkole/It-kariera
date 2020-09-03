using System;

namespace Horse
{
    class Program
    {
        static int maxN = 10;
        static int maxD = 10;
        const int n = 6;
        const int startX= 1;
        const int startY = 1;
        const int maxDiff = 8;
        static int[] diffX = {1,1,-1,-1,2,-2,2,-2};
        static int[] diffY = {2,-2,2,-2,1,1,-1,-1};
        static int[,] board=new int[maxN,maxN];
        static int newX, newY;
        static void Main(string[] args)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    board[i, j] = 0;
                }
            }
            nextMove(startX - 1, startY - 1, 1);
        }
        static void printBoard()
        {
            for (int i = n; i > 0; i--)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(board[i-1,j]+"  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Variant");
        }
        static void nextMove(int x, int y, int i)
        {
           
            board[x, y] = i;
            if (i==n*n)
            {
                printBoard();
            }
            for (int k = 0; k < maxDiff; k++)
            {
                newX = x + diffX[k];
                newY = y + diffY[k];
                if ((newX>=0&&newX<n&&newY>=0&&newY<n)&&
                    (0==board[newX,newY]))
                {
                    nextMove(newX, newY, i + 1);
                }
            }
            board[x, y] = 0;
        }
    }
}
