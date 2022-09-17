//######## C# ДЗ№8 Плотников ##########################################################
// ***********************************************************************************
// Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// получаем от пользователя характеристики массива
Console.Write("Введите количество строк в массиве (m): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве (n): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m,n];

// функция создания массива со случайными значениями элементов
int[,] MakeMe2dArray(int m, int n, int min, int max){
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i,j] = new Random().Next(min,max+1); 
    return array;
}
// функция демонстрации массива (подставить сюда массив)
void ShowMy2dArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j] +" ");
        }
        Console.WriteLine();
    }
}
// вызов функции создания массива 
MakeMe2dArray(m,n,min,max); 
// функция сортировки массива 
int[,] ConjugationArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        // переменная для хранения переносимого значения
        int temp = 0;    
        for (int j = 0; j < array.GetLength(1); j++){
            // третий цикл для перестановки значений     
            for (int h = 0; h < array.GetLength(1)-1; h++){
                // условие, что значение следующего элемента больше предыдущего
                if (array[i,h] < array[i,h+1]){
                    temp = array[i, h];
                    array[i, h] = array[i, h+1];
                    array[i, h+1] = temp;
                }
            }
        }
    }
    return array;
}
// вызов функции демонстрации массива несортированного
ShowMy2dArray(array);
// вызов функции сортировки массива
ConjugationArray(array);
//int[,] arrayConjugated = ConjugationArray(array);
Console.WriteLine(); // это отступ
// вызов функции демонстрации массива сортированного
//ShowMy2dArray(arrayConjugated);
ShowMy2dArray(array);

