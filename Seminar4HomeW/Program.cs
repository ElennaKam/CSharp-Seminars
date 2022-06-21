//Task 25 Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
double APowerB(int num)
{
    double num1, num2, power;
    Console.Write("Input first digit");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input second digit");
    num2 = Convert.ToInt32(Console.ReadLine());
    power = Math.Pow(num1,num2);
    return power;
}
int result = APowerB(num1, num2);
Console.WriteLine(result);

*/

//Task 29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

int size = 8;
int[] array = new int[size];

for(int i = 0; i < size; i++)
{
    array[i] = new Random().Next();
}

for(int i = 0; i < size; i++)
{
    Console.WriteLine(array[i]);
}

