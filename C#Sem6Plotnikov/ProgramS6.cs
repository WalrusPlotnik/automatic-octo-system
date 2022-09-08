// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
/*
int[] MirrorMe(int[] array){
    int temp = 0;
    for(int i = 0, j=array.Length -1; i<j; i++, j--){
       temp = array[i];
       array[i] = array[j];
       array[j] = temp;  
    }
    return array;
} 
int[] array = {1, 3, 6, 7, 2, 0};
int[] revArray = MirrorMe(array);
for (int i = 0; i < revArray.Length; i++){
    Console.Write(revArray[i] + " ");
}
*/

// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
/*
string DecToBin(int n){
    string result = string.Empty;
    while (n > 0){
        result =  n%2 + result;
        n /= 2;
    }
    return result;
}

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string res = DecToBin(n);
Console.WriteLine(res);
*/

// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
// (каждая сторона треугольника меньше суммы двух других сторон)
/*
void Triangle(int a, int b, int c){
    if (a < b + c && b < a + c & c < a + b) {Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} возможен");
    }
    else Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} НЕ возможен");
}
Console.WriteLine("Введите сторону треугольника А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону треугольника B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону треугольника C: ");
int c = Convert.ToInt32(Console.ReadLine());
Triangle(a, b, c);
*/

// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
/*
int[] Fibi(int n){
    int[] result = new int[n];
    result[0] = 0;
    result[1] = 1;
    for (int i = 2; i < n; i++){
        result[i] = result[i-2] + result[i-1];
    }
    result result
}
void ShowArray(int[] array){
    for(int i = 0; i<array.Length; i++){
        Console.Write($"{array[i]} ");
    }
}

Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = Fibi(n);
ShowArray(array);
*/