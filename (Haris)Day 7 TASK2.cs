using System;
class tables
{
public static void Main()
{
Console.WriteLine("Enter the number that you want to multiple with:");
 
int num=Convert.ToInt32(Console.ReadLine());
for(int i=1;i<=20;i++)
{
Console.WriteLine(num*i);
}
}
}
