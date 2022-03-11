/*-------------------------------------------------COIN FLIP-----------------------------------------------------------------------
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

/*--------------------------------------------------------LEAP YEAR------------------------------------------------------------------*/

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