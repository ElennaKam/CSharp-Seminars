// Task 10
/*
int FindMiddle(int num);
*/

/*
Random rnd = new Random();
int number = rnd.Next(100,999);
Console.WriteLine(number);

int num1, num2;

num1 = number / 10;

num2 = num1  % 10;

Console.WriteLine(num2);
*/

// Task 13

/*
Random rnd = new Random();
int number = rnd.Next();
Console.WriteLine(number);

int num1, num2, result;

if(number % 1000 == 0)
{
    Console.WriteLine("No third digit");
}
else
{
   num1 = number / 10;
    while(num1 > 999);
    {
        num2 = num1 / 10;
        num1  = num2; 
    }
   result = num1 % 10;
   Console.WriteLine(result);
}

*/

// Task 15

int num;
Console.WriteLine("Please input weekday number: ");
num = Convert.ToInt32(Console.ReadLine());

if (num >= 1 && num <= 5)
{
    Console.WriteLine("no");
}
else
{
    Console.WriteLine("yes");
}