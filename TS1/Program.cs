//Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B. 
//Не использовать Math.Pow
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Message(string message)
{
    Console.Write(message + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    System.Console.WriteLine(result);
}

int numA = Message("Введите число A");
int numB = Message("Введите число B");

ToDegree(numA, numB);