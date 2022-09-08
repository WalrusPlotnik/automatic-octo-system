/*
int[] MakeRandomArray(int size, int min, int max){
    for (int i = 0; i < size; i++){
        int[] array = new int[size];
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}
    void ShowMyArray(int[]array){
        for (int i = 0; i < array.length; i++){
        Concole.Write($"{array[i]} ");
    }
     }
     
     int CounterPositive(int[] array){
        int count = 0;
        for (int i = 0; i < array.Length; i++){
           if(array[i]<0) count+=array[i]; 
        }
        return count;
     } 
        int CounterNegative(int[] array){
        int count = 0;
        for (int i = 0; i < array.Length; i++){
           if(array[i]<0) count+=array[i]; 
        }
        return count;
     } 
Concole.WriteLine("Введите размер массива ");
int size = Convert.ToInt32(Concole.ReadLine());
Concole.WriteLine("Введите наименьшее массива ");
int min = Convert.ToInt32(Concole.ReadLine());
Concole.WriteLine("Введите наибольшее массива ");
int max = Convert.ToInt32(Concole.ReadLine());
int[] array = MakeRandomArray(size, max, min);
ShowMyArray(array);

int PosSum = CounterPositive(array);
*/
// Задайте массив из 12 элементов, заполненный случайными числами
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
/*
int[] CreateRandomArray(int size, int min, int max){
    int[] array = new int[size];
    for(int i=0; i<size; i++){
        array[i] = new Random().Next(min, max+1);
    }
    return array;
} 

void ShowArray(int[] array){
    for(int i = 0; i<array.Length; i++){
        Console.Write($"{array[i]} ");
    }
}
Console.WriteLine("Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите наименьшее массива ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите наибольшее массива ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
Console.WriteLine();
int[] NegativeArray(int[] array){
    for (int i = 0; i < array.Length; i++){
        array[i] *= -1;
        }
        return array
    }

*/
//Задача 1 - Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.

//Задача 2 - Задайте одномерный массив из произвольно кол-ва случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

/*
int[] CreateRandomArray(int size, int min, int max){
    int[] array = new int[size];
    for(int i=0; i<size; i++){
        array[i] = new Random().Next(min, max+1);
    }
    return array;
} 

void ShowArray(int[] array){
    for(int i = 0; i<array.Length; i++){
        Console.Write($"{array[i]} ");
    }
}

int Choise(int[] array){
    int sum = 0;
    for (int i = 0; i < array.Length; i++){
        if(array[i] > 10 &&)
    }
    {
        
    }
}

Console.WriteLine("Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите наименьшее массива ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите наибольшее массива ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
Console.WriteLine();
int sum = Choise(array);
Console.WriteLine

  */  

  // Задача 3- Задайте массив. Напишите программу, которая определяет,
  // присутствует ли заданное число в массиве.
/*
int[] CreateRandomArray(int size, int min, int max){
    int[] array = new int[size];
    for(int i=0; i<size; i++){
        array[i] = new Random().Next(min, max+1);
    }
    return array;
} 

void ShowArray(int[] array){
    for(int i = 0; i<array.Length; i++){
        Console.Write($"{array[i]} ");
    }
}

void Finder(int[] array, int x){
    bool check = false;
    for (int i = 0; i < array.Length; i++){
      if(array[i] == x){
        check = true;
        }
    }
    if(check = true) Console.WriteLine("Искомое в массиве");
    else Console.WriteLine("Искомое не в массиве");
    
}

Console.WriteLine("Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите наименьшее массива ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите наибольшее массива ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомое число ");
int x = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
Finder(array, x);
*/

// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний...
// Результат запишите в новом массиве.

/*

int[] CreateRandomArray(int size, int min, int max){
    int[] array = new int[size];
    for(int i=0; i<size; i++){
        array[i] = new Random().Next(min, max+1);
    }
    return array;
} 

void ShowArray(int[] array){
    for(int i = 0; i<array.Length; i++){
        Console.Write($"{array[i]} ");
    }
}

int[] Multi(int[] array){
    int length1 = array.Length;
    if(array.Length %2 == 0){
        int[] array2 = new int[array.Length/2];
        int length = array.Length/2;
        for (int i = 0; i < length; i++){
            array2[i] = array[i]*array[length1 - 1];
        }
        return array2;
    }
    else{
    }
}
    


Console.WriteLine("Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите наименьшее массива ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите наибольшее массива ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомое число ");
int x = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
Multi(array);

*/