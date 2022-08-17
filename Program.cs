Console.Write("Введите число: ");
string number = Console.ReadLine();
int length = number.Length;
if (length == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
Console.WriteLine($"{number} является палидромом");
    }
    else {
        Console.WriteLine($"{number} не является палидромом");
    }
}
        else
    {
        Console.WriteLine($"{number} не является пятизначным числом");
    }