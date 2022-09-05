// ###### C# ДЗ №4 Плотников ############
/*
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// блок придумывания названия функции
void Exponent (int A, int B){
int C = 1;
// блок цикла
for(int i = 0; i < B; i++){
    C = C * A;}
// блок вывода
Console.WriteLine("Выполняется возведение в степень...");
Console.WriteLine("Ваше число " + A + " в степени "+ B  + " это " + C + ".");
}
// блок ввода
Console.Write("Введите число А, которое нужно возвести в степень В: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В (степень): ");
int B = Convert.ToInt32(Console.ReadLine());
// блок вызова функции
Exponent (A, B);

*/

// Напишите программу, которая задаёт массив из произвольных элементов и выводит их на экран.
// (пользовательский размер, пользовательские данные)
/*
// блок придумывания названия функции
int[] MakeMeArray(int size){
// блок цикла и ввода пользовательских чисел в массив    
    int[] array = new int[size];
    for(int i=0; i<size; i++){
        Console.Write("Введите число - элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
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
// блок ввода размера массива
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(); // просто отступ
int[] array = MakeMeArray(size);
// блок вызова функции вывода массива на экран
ShowMyArray(array);

*/
/*
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// блок придумывания названия функции
void SumMyDigits(int number){
// блок цикла суммирования остатков     
    int sum = 0;
    for(int i = number; i != 0; i /= 10 ){
        sum += i % 10;
    }
    // блок вывода    
    Console.WriteLine("При сложении цифр вашего числа получается число " + sum + ".");
}
// блок ввода
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
// блок вызова функции
SumMyDigits(number);

*/