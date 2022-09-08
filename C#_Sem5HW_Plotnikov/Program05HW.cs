//**********************************************************************************************************************************
//############## C# ДЗ№5 Плотников ###############################################################################################
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
int[] MakeMeArray(int size){
// блок цикла и ввода cлучайных в массив    
    int[] array = new int[size];
    for(int i=0; i<size; i++){
       array[i] = new Random().Next(100,1000);;
    }
    return array;
    
} 
// блок придумывания названия второй функции
void ShowMyArray(int[] array){
// блок цикла вывода массива
    for(int i = 0; i<array.Length; i++){
        Console.Write($"{array[i]} ");
    }
}
// блок придумывания названия третьей функции
void CountOdd(int[] array){
// блок цикла складывания в счётчик единицы при остатке от деления не равном нулю
int counter = 0;
for (int i = 0; i < array.Length; i++){
    if(array[i]%2==0) counter++;
}
// блок вывода результата
Console.Write("В нём: " + counter + " чётных чисел.");
}
// блок ввода размера массива
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(); // просто отступ
int[] array = MakeMeArray(size);

// блок пояснительной надписи
Console.Write("Вот ваш сгенерированный массив: ");
// блок вызова функции вывода массива на экран
ShowMyArray(array);
Console.WriteLine(); // просто отступ
// блок вызова функции показа содержимого счётчика
CountOdd(array);

*/
//*******************************************************************************************************************************
//Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
int[] MakeMeArray(int size){
// блок цикла и ввода cлучайных в массив    
    int[] array = new int[size];
    for(int i=0; i<size; i++){
       array[i] = new Random().Next(-9,99);;
    }
    return array;
    
} 
// блок придумывания названия второй функции
void ShowMyArray(int[] array){
// блок цикла вывода массива
    for(int i = 0; i<array.Length; i++){
        Console.Write($"{array[i]} ");
    }
}
// блок придумывания названия третьей функции
void SumEven(int[] array){
// блок цикла суммирования в счётчик значений элементов при остатке от деления равном нулю
int counter = 0;
for (int i = 0; i < array.Length; i++){
    if(i%2!=0) counter = counter + array[i];
}
// блок вывода результата
Console.Write("Сумма элементов с нечётным индексом: " + counter +".");
}
// блок ввода размера массива
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(); // просто отступ
int[] array = MakeMeArray(size);

// блок пояснительной надписи
Console.Write("Вот ваш сгенерированный массив: ");
// блок вызова функции вывода массива на экран
ShowMyArray(array);
Console.WriteLine(); // просто отступ
SumEven(array);

*/
/*
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
int[] MakeMeArray(int size){
// блок цикла и ввода cлучайных в массив    
    int[] array = new int[size];
    for(int i=0; i<size; i++){
       array[i] = new Random().Next(-9,99);;
    }
    return array;
    
} 
// блок придумывания названия второй функции
void ShowMyArray(int[] array){
// блок цикла вывода массива
    for(int i = 0; i<array.Length; i++){
        Console.Write($"{array[i]} ");
    }
}
// блок придумывания названия третьей функции
void SearchMaxAndMin(int[] array){
// блок цикла сравнения с сохранением в переменные
int Max = array[0];
int Min = array[0];
int counter = 0;
for (int i = 0; i < array.Length; i++){
    if(Max < array[i]) Max = array[i];
    if(Min > array[i]) Min = array[i];
}
    counter = Max - Min;
// блок вывода результата
Console.Write($"Разница значений максимального ({Max}) и минимального ({Min}) элементов составляет: " + counter +".");
}
// блок ввода размера массива
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(); // просто отступ
int[] array = MakeMeArray(size);

// блок пояснительной надписи
Console.Write("Вот ваш сгенерированный массив: ");
// блок вызова функции вывода массива на экран
ShowMyArray(array);
Console.WriteLine(); // просто отступ
SearchMaxAndMin(array);

*/
