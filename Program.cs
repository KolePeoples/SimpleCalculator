// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Enter your first number: ");
double firstNum = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the operator (+, -, x/*, /):");
string myOp = Console.ReadLine();
if (myOp.Length > 1)
{
    Console.WriteLine("Enter a valid operator: ");
    myOp = Console.ReadLine();
}

Console.WriteLine("Enter your second number: ");
double secondNum = Convert.ToDouble(Console.ReadLine());

if(myOp == "+")
{
    Console.WriteLine($"{firstNum} + {secondNum} = ", firstNum + secondNum);
}

if (myOp == "x" || myOp == "*")
{
    Console.WriteLine($"{firstNum} * {secondNum} = ", firstNum * secondNum);
}
if (myOp == "-")
{
    Console.WriteLine($"{firstNum} - {secondNum} = ", firstNum - secondNum);
}
if (myOp == "/")
{
    Console.WriteLine($"{firstNum} / {secondNum} = ", firstNum / secondNum);
}





