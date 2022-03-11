/*--------------------------------------------------------LEAP YEAR------------------------------------------------------------------*/

Console.WriteLine("Enter The Year : ");
int year = int.Parse(Console.ReadLine());
if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
{
    Console.WriteLine("It is leap year");
}
else
{
    Console.WriteLine("It is not leap year");
}

