using System;
class agename
{
public static void Main()
{
Console.WriteLine("Enter your name:");
string name=Console.ReadLine();
Console.WriteLine("Enter your age:");
int age=Convert.ToInt32(Console.ReadLine());
for(int i=0;i<age;i++)
{
Console.WriteLine(name);
Console.WriteLine(age);
}
}
}