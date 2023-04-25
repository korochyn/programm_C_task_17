// Урок 5. Функции и одномерные массивы
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int Promt (string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine()!;
    int result = int.Parse (ReadInput);
    return result;
}
// Метод для получения случайных значений массива
int[] GenerateArray (int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    Random random = new Random();
    for(int i=0; i < Length; i++)
    {
        array[i] = random.Next(minValue,maxValue+1);
    }
    return array;
}
// Метод вывода массива
void PrintArray (int [] array)
{
    Console.Write("[");
    for(int i=0; i<array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}");
    Console.WriteLine("]");
}

// Метод максимального числа в массиве
int Max_nun (int [] array)
{
    int max = array[0];
     for(int i=0; i<array.Length; i++)
     {
       if (array[i]>max) {max=array[i];}
     }
    return max;
}

// Метод минимального числа в массиве
int Mix_nun (int [] array)
{
    int min = array[0];
     for(int i=0; i<array.Length; i++)
     {
       if (array[i]<min) {min=array[i];}
     }
    return min;
}

int length = Promt("Длинна массива: ");
int min = Promt("Начальное значение для диапазона случайного числа: ");
int max = Promt("Конечное значение для диапазона случайного числа: ");
int[] array = GenerateArray (length, min, max);
PrintArray (array);
int result = Max_nun(array)-Mix_nun(array);
Console.WriteLine(result);