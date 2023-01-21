// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2


int getIntFromUser(string message)
{
    Console.WriteLine(message);
    int userInt = int.Parse(Console.ReadLine());
    return userInt;
}

int count = getIntFromUser("Введите количество чисел ");
int[] numbers = new int[count];

for(int i = 0; i < count; i++)
{
    Console.WriteLine("Введите число: ");
    numbers[i] = int.Parse(Console.ReadLine());
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for(int i=0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int countpos = CountPositiveNumbers(numbers);

Console.WriteLine($"Количество положительных чисел равно {countpos}");
