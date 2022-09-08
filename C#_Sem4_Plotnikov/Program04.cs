/*// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
void Numbers(int num){
    int result = 0;
    for (int curr = 1; curr <= num; curr++){
        result += curr;
    }
    Console.WriteLine($"Сумма чисел от 1 до {num} равна {result}");
} 
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Numbers(number);
*/

/*//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N
void Numbers(int num){
int result = 1;
for(int curr=1; curr<num+1; curr++){
result = result * curr;
}
Console.WriteLine($"Произведение чисел от 1 до {num} равна {result}");
}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Numbers(num);
*/
/*
//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе
// no string
int Program(int a){
    int result = 1;
    for(int i=a; i/10==0; i=i/10){
    result = result +1;
    }
    return result;
Console.WriteLine($"количество цифр равно {result}");   
}
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

Program(a);
*/
/*
// Напишите программу, которая находит все нечетные числа в последовательности от 1 до N
void Numbers(int number){
    for (int i = 1; i <= number ; i+=2){
        Console.Write(i+" ");
    }
} 
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Numbers(number);
*/
/*
// Напишите программу, которая выводит массив на 8 элементов, заполненный нулями и единицами 
// в случайном порядке [1.0.1.0.1.0.1.1]
int[] CreateRandomArray(int size){
int[] array = new int [size];
for (int i = 0; i < size ; i++){ 
    array[i] = new Random().Next(0,2);
    }
    return array; 
}
void ShowArray(int[] array){
    Console.Write("[ "); 
    for (int i = 0; i < array.Length; i++){
        Console.Write(array[i]+" ");
    }
   Console.Write(" ]"); 
}
Console.Write("введите кол-во элементов массива ");
int size = Convert.ToInt32(Console.ReadLine());
ShowArray(CreateRandomArray(size));

*/