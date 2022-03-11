/*-----------------------------------------------------------PowerOfTWo-----------------------------------------------------------*/
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




