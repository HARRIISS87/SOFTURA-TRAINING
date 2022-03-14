using System;
class task5
{
public static void Main()
{
int amount,units;
Console.WriteLine("Enter consumed unit:");
units = Convert.ToInt32(Console.ReadLine());
if (units<=200)
{
amount = units *2;
Console.WriteLine(amount);
}
 else if((units>200) && (units<=350))
{
units = units-200;
amount =units*3;
Console.WriteLine(amount+400);
}
else if((units>350) && (units<=500))
{
units = units-350;
amount = units *5;
Console.WriteLine(amount+450+400);
}
else if(units>500)
{
units = units-500;
amount = units *7;
Console.WriteLine(amount+750+450+400);
}
}
}
