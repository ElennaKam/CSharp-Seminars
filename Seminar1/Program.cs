/*
int num1, num2, quad;

Console.Write("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());

quad = num2 * num2;

if(num1 == quad)
{
    Console.WriteLine("True");
}

else
{
   Console.WriteLine("False");  
}

*/

/*
int num;

Console.Write("Input integer number: ");
num = Convert.ToInt32(Console.ReadLine());

int current = num * (-1);

while(current <= num)
{
    Console.Write(current + " ");
    current ++;
}

*/

//Task2
/*
int num1, num2;

Console.Write("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("max = " + num1);
}
else
{
    Console.WriteLine("max = " + num2);
}
*/

//Task4

/*
int num1, num2, num3;

Console.Write("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input third integer number: ");
num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 & num1 > num3)
{
    Console.WriteLine(num1);
}
if (num2 > num1 & num2 > num3)
{
    Console.WriteLine(num2);
}
if (num3 > num2 & num3 > num1)
{
    Console.WriteLine(num3);
}
*/

//Task6

/*
int num;

Console.Write("Input integer number: ");
num = Convert.ToInt32(Console.ReadLine());

if(num%2 == 0 )
{
 Console.WriteLine("yes");   
}
else
{
 Console.WriteLine("no");   
}
*/

// Task8

int num;
Console.Write("Input integer number: ");
num = Convert.ToInt32(Console.ReadLine());

int current = ((num/num) +1);
while(current < num & current%2 == 0)
{
  Console.WriteLine(current + " ,"); 
  current ++;
}


