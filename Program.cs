// написать программу, которая принимает 2 числа и определяет какое из них больше, а какое меньше.

int userFirstNumber = new int();
int userSecondNumber = new int();

Console. WriteLine ( "Введите первое число  ");
userFirstNumber = Convert.ToInt32(Console.ReadLine());

Console. WriteLine ( "Введите второе число  ");
userSecondNumber = Convert.ToInt32(Console.ReadLine());

if(userFirstNumber>userSecondNumber)
{
    Console.WriteLine ($"max = {userFirstNumber}");
    Console.WriteLine($"min = {userSecondNumber}");
}
else
{
    Console.WriteLine($"max = {userSecondNumber}");
    Console.WriteLine($"min = {userFirstNumber}");   
}

