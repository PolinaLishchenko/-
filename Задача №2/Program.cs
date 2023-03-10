// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int a = -9;
int b = -3;
int max = a;
int min = a;

if(b > max) max = b;
else if(b < max) max = a;
Console.Write("max = ");
Console.WriteLine(max);

if(b > min) min = a;
else if(b < min) min = b;
Console.Write("min = ");
Console.WriteLine(min);