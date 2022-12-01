Console.WriteLine("Введите число 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num1 > num2)
{
    max = num1;
    Console.WriteLine("max = " + max);
}
else 
{
    max = num2;
    Console.WriteLine("max = " + max);
}

