//Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetNum(string message)
{
    System.Console.Write(message + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

int LenNum(int a)
{
    int i = 0;
    while (a > 0)
    {
        a = a / 10;
        i++;
    }
    return i;
}

void SumNum(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n = n / 10;
    }
    System.Console.WriteLine(sum);
}   

int number = GetNum("Введите число");
int len = LenNum(number);
SumNum(number, len);