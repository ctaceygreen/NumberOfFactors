using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int N)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int rootN = (int)Math.Sqrt(N);
        int numberOfFactors = 0;

        for(int i = 1; i <= rootN; i++)
        {
            if(N % i == 0)
            {
                if (i * i == N)
                {
                    numberOfFactors++;
                }
                else
                {
                    numberOfFactors += 2;
                }
            }
        }
        return numberOfFactors;
    }
}