﻿/*---------------------------------------------Harmonic Number-------------------------------------------------------------------*/

int i, n;
double s = 0.0;
Console.Write("Calculate the harmonic series and their sum:\n");
Console.Write("Input the number of terms : ");
n = Convert.ToInt32(Console.ReadLine());
Console.Write("\n\n");
for (i = 1; i <= n; i++)
{
    Console.Write("1/{0} + ", i);
    s += 1 / (float)i;
}
Console.Write("Sum of Series upto {0} terms : {1} ", n, s);

