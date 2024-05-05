// Задача1. Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа
// в промежутке от M до N.

// void FromToMandN (int m, int n)
// {
//     if (m>n)
//     {
//         FromToMandN(m-1,n);
//         System.Console.Write(m + " ");
//     }
//     else if (n>m)
//     {
//         FromToMandN(n-1,m);
//         System.Console.Write(n + " ");
//     }
//     else System.Console.Write(m + " ");
// }

// FromToMandN(6,2);


// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// int Akkerman(int m, int n)
// {
//     if(m == 0)
//     {
//         return n + 1;
//     }
//     else if(n == 0)
//     {
//         return Akkerman(m-1, 1);
//     }
//     else
//     {
//         return Akkerman(m-1, Akkerman(m, n-1));
//     }
// }

// System.Console.WriteLine("Введите первое неотрицательное число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе неотрицательное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int result = Akkerman(m,n);
// System.Console.WriteLine($"Результат функции Аккермана: {result}");


// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1); 
    }
    return array;
}

void NumMassive (int[] array, int i)
{
    if(i < array.Length)
    {
        NumMassive(array, i+1);
        System.Console.Write(array[i] + " ");
    }
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " "); 
    }
    System.Console.WriteLine();
}

System.Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal value of arr element: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal value of arr element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(size, min, max);
PrintArray(array);
NumMassive(array, 0);