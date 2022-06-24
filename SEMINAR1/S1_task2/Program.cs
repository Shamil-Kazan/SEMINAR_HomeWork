
int num1, num2;

Console.Write("Input a first number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

if(num1>num2)
    Console.WriteLine("First number - max, second number - min.");
else
    Console.WriteLine("First number - min, second number - max.");
