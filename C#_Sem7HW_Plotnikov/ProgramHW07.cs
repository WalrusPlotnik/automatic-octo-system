//######## C# ДЗ№7 Плотников ##########################################################
// ***********************************************************************************
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
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
*/
/*
// функция создания массива со случайными значениями элементов
double[,] MakeMe2dArray(int m, int n, int min, int max){
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i,j] = Math.Round(new Random().Next(min,max+1) * new Random().NextDouble(), 2); 
    return array;
}
*/
/*
// функция демонстрации массива
void ShowMy2dArray(double[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j] +" ");
        }
        Console.WriteLine();
    }
}
*/
/*
// вызов функции создания массива
MakeMe2dArray(m,n,min,max); 
// вызов функции демонстрации массива
ShowMy2dArray(array);
*/
/*
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// *массив берём из предыдущей задачи, а также функцию его демонcтрации//
// спрашиваем с пользователя индекс строки и индекс столбца 
Console.Write("Введите индекс строки, на которой лежит искомый элемент (внимание! индексы идут с 0, не с 1): ");
int userRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца, на которой лежит искомый элемент: ");
int userCol = Convert.ToInt32(Console.ReadLine());
// проверяем, не меньше ли число строк, столбцов у массива, чем индексы, которые предложил пользователь
if(userRow > m-1 || userCol > n-1) Console.WriteLine("Элемент с таким адресом за пределами массива.");
else { Console.Write("Значение элемента с такими адресом это: "+array[userRow,userCol] +".");}   
*/
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// *функцию демонстрации массива берём из первой задачи
/*
// функция создания массива со случайными значениями элементов
double[,] MakeMeAnother2dArray(int m, int n, int min, int max){
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i,j] = new Random().Next(min,max+1); 
    return array;
}
*/
/*
// вызов функции создания массива
MakeMeAnother2dArray(m,n,min,max); 
// вызов функции демонстрации массива
ShowMy2dArray(array);
// функция расчёта среднего арифметического по столбцам
void ArithMeanForCol(double[,] array){

 Console.WriteLine("Среднее арифметическое по столбцам: ");
// цикл для прохождения по длине массива
for (int j = 0; j < array.GetLength(1); j++){
// делаем переменную под результат
    double average = 0; // при переходе на новый столбец переменная должна быть обнулена
// и его подцикл, т.к. массив двумерный        
        for (int i = 0; i < array.GetLength(0); i++){
// cкладываем в переменную значения элементов
            average = average + array[i,j];
        }
// выводим значение переменной делённое на количество строк
        Console.Write(Math.Round(average/m, 2) + "|");
    }
}
// ёлочка, зажгись
ArithMeanForCol(array);

*/

