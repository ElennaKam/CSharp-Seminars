
// Task 18 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Palindrome(int num)
{
    int num = []arr;
    if(num[0]= num[4] && num[1]= num[3]) Console.Write("Yes");  
    else Console.Write("No")
}

Console.Write("Input 5 digit number");
int num = Convert.ToInt32(Console.ReadLine());

Palindrome(num);
*/

// Task 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double FindLength(double xA, double yA, double zA, double xB, double yB, double zB)
{
    return Math.Sqrt(Math.Pow((xB-xA-zA),2)+ Math.Pow((yB-yA-zB),2));
}

Console.WriteLine("Insert 2 points");
double num = Convert.ToDouble(Console.ReadLine());

*/

//Task 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cube(int num)
{
    int current = 1;
    while(current <= num)
    {
        Console.Write((current * current * current) + " ");
        current ++;
    }
}

Console.WriteLine("Insert number");
int num = Convert.ToInt32(Console.ReadLine());

Cube(num);
*/