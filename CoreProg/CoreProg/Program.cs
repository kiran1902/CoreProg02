﻿/*-------------------------------------------------COIN FLIP-----------------------------------------------------------------------
Console.WriteLine("Flip the Coin");
const int ishead = 1;
const int istail = 2;


Random rand = new Random();
int Tail = 0,
    Head = 0,
    Result = 0;

int isCoinFlip = rand.Next(2);
Console.WriteLine("isCoinFlip : " + isCoinFlip);

if (isCoinFlip == 1)
{
    Console.WriteLine("It is Head");
}
else
{
    Console.WriteLine("It is Tail");
}

------------------------------------------------------~~~~~~~~--------------------------------------------------------------------*/

/*--------------------------------------------------------LEAP YEAR------------------------------------------------------------------

Console.WriteLine("Enter The Year : ");
int year = int.Parse(Console.ReadLine());
if ((year %4 == 0) && (year %100 != 0) || (year % 400 == 0))
{
    Console.WriteLine("It is leap year");
}
else
{
    Console.WriteLine("It is not leap year");
}
-----------------------------------------------------------------------------------------------------------------------------------*/
/*-----------------------------------------------------------PowerOfTWo-----------------------------------------------------------
Console.WriteLine("Enter the Power of 2 :");
int n = int.Parse(Console.ReadLine());
int i = 0;
int powerofTwo = 1;
while (i <= n)
{
    Console.WriteLine(i + " " + powerofTwo);
    powerofTwo = 2 * powerofTwo;
    i = i + 1;
}
-----------------------------------------------------------------------------------------------------------------------------------*/

/*---------------------------------------------Harmonic Number-------------------------------------------------------------------*/

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

