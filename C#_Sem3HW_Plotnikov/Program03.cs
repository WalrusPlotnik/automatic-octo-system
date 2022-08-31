/*
//### C# Сем3 ДЗ Плотников ##########################
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// блок придумывания названия функции
void MakeMeAnCubes(int N){
   // блок цикла и вычислений и вывода
   int current = 1;
    while(current <= N){
    Console.Write(current*current*current + ", ");
    current++;}
   }
 // блок ввода
Console.Write("Введите число N ");
int num = Convert.ToInt32(Console.ReadLine());
// блок проверки входного данного
if(num <= 0) Console.Write("Данные некорректны");
// блок вызова функции
else MakeMeAnCubes(num);

*/
/*
///Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// блок придумывания названия функции
void PalindromOrNot(string fdig){

int size = fdig.Length;
// блок контроля входного данного
if (size != 5){
    Console.WriteLine("Введено не пятизначное число.");
}
else{
 // блок цикла  
    bool check = true;
    for(int i = 0; i <=(size-1) / 2; i++){
        if (fdig[i] != fdig[size - (i+1)]){
        check=false;
        break;
        }
    }
// блок вывода
    if (check){
    Console.WriteLine("Ваше число - настоящий палиндром");
    }
    else{
    Console.WriteLine("Ваше число не палиндром.");
    }
}  
} 
// блок ввода
Console.Write("Введите положительное пятизначное число: ");
string fdig = Console.ReadLine(); 
// блок вызова функции
PalindromOrNot(fdig);

*/
// Напишите программу, которая принимает на вход координаты двух точек (A и B: A(X, Y, Z) и B(X, Y, Z)) 
// и находит расстояние между ними в 3D пространстве
// (AB = квадратный корень из суммы квадрат(Хb-Xa) , квадрат(Yb-Ya) , квадрат(Zb-Za)).

/*
// блок придумывания названия функции
void Pathfinder(int Xa, int Ya, int Za, int Xb, int Yb, int Zb){


// блок вычисления по формуле
double Xab = Xb - Xa;
double Yab = Yb - Ya;
double Zab = Zb - Za;

double AB = Math.Sqrt(Xab * Xab + Yab * Yab + Zab * Zab);

// блок вывода
{
AB = Math.Round(AB, 2);
Console.WriteLine("Найдено расстояние между точками А и В, оно составляет: " + AB);
}

}
// блок ввода
Console.WriteLine("Начинаем ввод координат для точки А.");
Console.WriteLine("Введите Ха: ");
int Xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Yа: ");
int Ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Zа: ");
int Za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Начинаем ввод координат для точки B.");
Console.WriteLine("Введите Хb: ");
int Xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Yb: ");
int Yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Zb: ");
int Zb = Convert.ToInt32(Console.ReadLine());
// блок вызова функции
Pathfinder(Xa, Ya, Za, Xb, Yb, Zb);



*/
