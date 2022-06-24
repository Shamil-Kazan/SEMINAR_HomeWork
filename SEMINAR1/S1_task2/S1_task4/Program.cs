
int num1, num2, num3;

Console.Write("Input a first number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
num3 = Convert.ToInt32(Console.ReadLine());

if(num1>num2 & num1>num3)
    Console.WriteLine("First number - max");
if(num2>num1 & num2>num3)
    Console.WriteLine("second number - max");
if(num3>num1 & num3>num2)
    Console.WriteLine("third number - max.");
