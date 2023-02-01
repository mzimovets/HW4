//Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран. Сделать через функции
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int lenArray = ReadInt("Введите длинну массива: ");
Massive();

void Massive()
{
    int[] randomArray = new int[lenArray];
    for (int i = 0; i < randomArray.Length; i++)
    {
        if (i == 0)
        {
            System.Console.Write("[");
        }
        randomArray[i] = new Random().Next(1, 9);
        Console.Write(randomArray[i] + " ");
    }
    System.Console.WriteLine("]");
}


// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}