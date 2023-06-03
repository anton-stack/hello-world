// Задача 1

// Console.WriteLine("input A");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input B");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Math.Pow(a, b));

// Задача 2

// Console.WriteLine("input number");
// int number = Convert.ToInt32(Console.ReadLine());


// int sum(int number)
// {
//     int result = 0;
//     while (number > 0)
//     {
//         result += number % 10;
//         number = number / 10;
//     }

//     return result;
// }

// Console.WriteLine($"Сумма всех цифр в числе {number} = {sum(number)}");

// Задача 3

System.Console.WriteLine("Введите длинну массива");
int length = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Начальное значение для диапазона чисел");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Конечное значение для диапазона чисел");
int max = Convert.ToInt32(Console.ReadLine());

int [] GenerateRandomNumbers(int Len, int maxNum, int minNum)
{
    int [] array = new int [Len];
    Random rnd = new Random();
    for (int i = 0; i < Len; i++)
    {
        array[i] = rnd.Next(minNum, maxNum + 1);
    }

    return array;
}

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Len - 1; i++ )
// }
int[] array = GenerateRandomNumbers(lenght, maxNum, minNum);
print array;
