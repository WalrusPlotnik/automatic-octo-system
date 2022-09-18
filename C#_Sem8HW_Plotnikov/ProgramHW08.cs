//######## C# ДЗ№8 Плотников ##########################################################
// ***********************************************************************************
// Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
int[,] array = new int[m,n];

// функция создания массива со случайными значениями элементов
int[,] MakeMe2dArray(int m, int n, int min, int max){
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i,j] = new Random().Next(min,max+1); 
    return array;
}
*/
/*
// функция демонстрации массива (подставить сюда массив)
void ShowMy2dArray(int[,] array){
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
*/
/*
// вызов функции демонстрации массива несортированного
ShowMy2dArray(array);
// вызов функции сортировки массива
ConjugationArray(array);
Console.WriteLine(); // это отступ
// снова вызов функции демонстрации массива, уже сортированного
ShowMy2dArray(array);
*/

// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// * пользовательский массив с случайными элементами берём из первой задачи
// ** функцию демонстрации массива берём из первой задачи
/*
// функция показа номера строки, где значения элементов в сумме меньше
void MinimumString(int[,] array, int m){
    // объявляем одномерный массив, в котором будем сравнивать суммы значений массивов
    int[] sumArray = new int[m]; // размер этого массива - число строк в основном массиве
    sumArray[0] = 0; // зададим, что первый элемент нового массива ноль
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            sumArray[i] +=array[i,j];    
        }
    }  
int min = sumArray[0];
int minIndex = 0;
for (int i = 1; i < sumArray.Length; i++){
   // сравниваем элементы массива (они суммы значений строк в основном массиве)
    if (sumArray[i] < min){
        min = sumArray[i];
        // вот что мы ищем - индекс минимального элемента (суммы строк)
        minIndex = i;
    }
}
// выводим требуемое задачей
Console.WriteLine($"Наименьшая сумма элементов в строке {minIndex+1} (c индексом {minIndex})");
}
if (m == n) // проверка на квадратность массива
    Console.Write("Количество строк и столбцов не должно быть равно."); // массив квадратный, не вызываем функции 
else{ 
    // массив не квадратный, вызываем функции 
    ShowMy2dArray(array);
    MinimumString(array, m);  
}

*/

// Напишите программу, которая заполнит спирально массив 4 на 4.
/*
// тело функции генерации массива 
int[,] MakeMe2dSpiralRandomArray(){
// зададим размер массивa 4х4 
    int m = 4;  
    int[,] array = new int[m,m];
// индексы начальной ячейки
    int i = 0;
    int j = 0;
// цикл с условиями смещения
    for(int h = 1; h <= array.GetLength(0) * array.GetLength(1); h++){
        array[i,j] = h;
        if(i <= j+1 && i+j < array.GetLength(1) -1) j++;
        else if(i < j && i+j >= array.GetLength(0) -1) i++;
        else if(i >= j && i+j > array.GetLength(1) -1) j--;
        else i--;
    }
    return array;
}

// функция демонстрации массива (подставить сюда массив)
void ShowMy2dSpiralArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            if (array[i,j] < 10){
            Console.Write($"0{array[i,j]} "); // знак 0 для формата недвузначным значениям
            }
            else{
            Console.Write(array[i,j] +" ");    
            }
        }
        Console.WriteLine();
    }
}

// вы3ов функции генерации
int[,] array = MakeMe2dSpiralRandomArray();
// вызов функции демонстрации массива
ShowMy2dSpiralArray(array);

*/
