// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Clear();
System.Console.WriteLine();
System.Console.WriteLine("*Задача № 41. Поиск чисел больше 0*");
System.Console.WriteLine();

System.Console.WriteLine("Укажите количество чисел, с которым будем работать");
if (!int.TryParse(Console.ReadLine(), out int amount))
{
    System.Console.WriteLine("Ввод неверный. Пожалуйста, введите корректное число");
}

int[] num = CorrectInput("Введите число: ", "Ошибка ввода", amount);
System.Console.Write(String.Join(" ,", num));                                  
int res = GetResult(num);
System.Console.WriteLine($" -> {res}");
System.Console.WriteLine();

int[] CorrectInput(string number, string errMessage, int size)
{
    int[] a = new int[size];
    int q = 0;
    for (int i = 0; i < size; i++)
    {
        while (true)
        {
            System.Console.WriteLine(number);
            bool userNumber = int.TryParse(Console.ReadLine(), out int correctNumber);
            if (userNumber)
            {
                q = correctNumber;
                break;
            }
            else System.Console.WriteLine(errMessage);
        }
        a[i] = q;
    }
    return a;
}

int GetResult (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if(array[i] > 0)
            sum++;
    return sum;
}

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)