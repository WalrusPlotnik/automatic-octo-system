//######## C# ДЗ№7 Плотников ##########################################################
// ***********************************************************************************
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// получаем от пользователя характеристики массива
Console.Write("Введите количество строк в массиве (m): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве (n): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m,n];

// функция создания массива со случайными значениями элементов
double[,] MakeMe2dArray(int m, int n, int min, int max){
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i,j] = Math.Round(new Random().Next(min,max+1) * new Random().NextDouble(), 2); 
    return array;
}
// функция демонстрации массива
void ShowMy2dArray(double[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j] +" ");
        }
        Console.WriteLine();
    }
}

// вызов функции создания массива
MakeMe2dArray(m,n,min,max); 
// вызов функции демонстрации массива
ShowMy2dArray(array);
