//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа
/*
int CutNumber(){
    int num = new Random().Next(100,1000);
    Console.WriteLine("Number is - " + num);
    int dec = num / 100;
    int ed = num % 10;
    int result = dec*10 + ed;
    return result;

}
int number  = CutNumber();
Console.WriteLine("Cut number is - " + number);  
*/
/*
void CutNumber (){
int num = new Random().Next(100,1000);
    Console.WriteLine("Number is - " + num);
    int dec = num / 100;
    int ed = num % 10;
    int result = dec*10 + ed;
    Console.WriteLine("Cut number is - " + result);    
}
CutNumber ();
*/
/*
int Factorial(int num){
    int current = 1;
    int fact = 1;
    while(current <= num){
        fact *= current;
        current++;

    }

    return fact;
}

int result = Factorial(5) * Factorial(3);
Console.WriteLine("Your result is - " + result);  
*/

//
/*
int Line(){
    int num = new Random().Next(10,100);
Console.WriteLine("Your number is: " + num);
int dec = num / 10;
int ed = num % 10;
if (dec > ed){
    return Console.WriteLine("First num is max" + dec);
}
else{
    return ed;
} 
} 
Console.WriteLine("Result -" + Line());
*/
/*
void Crat(int num){
    Console.WriteLine("Enter the number: ");
    int number = Convert.ToInt32(Console.Readline());
    if (number % 7 == 0 && number % 23 == 0){
      Console.WriteLine("Число кратно одновременно 7 и 23");  
    }
    else{
      Console.WriteLine("Число не кратно одновременно 7 и 23");   
    }
}
Crat();
*/
/*
void Square(int a, int b){
    if (a == b*b || b == a*a){
        Console.WriteLine("Условие выполняется");
     }
     else{
     Console.WriteLine("Условие не выполняется");   
     }
}
Console.WriteLine("Enter the number one: ");
int a = Convert.ToInt32(Console.Readline());
Console.WriteLine("Enter the number two: ");
int b = Convert.ToInt32(Console.Readline());
Square(a,b);*/

//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деление.
/*
int Square(int a, int b){
    
    if(b % a != 0){
        int result = b % a;
        return result;
    }
    else{
        return 0;
    }
}

Console.Write("Enter the number 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number 2: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a==0 || b==0){
    Console.WriteLine("На ноль делить нельзя!");
}
else{
    int result = Square(a,b);
    if(result == 0){
        Console.WriteLine("Второе число кратно первому");
    }
    else{
        Console.WriteLine("Второе число не кратно первому.Остаток от деления: " + result);
    }
}
*/
//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// void Square(int a, int b){
//     if(a == b*b || b == a*a){
//         Console.WriteLine("Условие выполняется");
//     }
//     else{
//         Console.WriteLine("Условие не выполняется");
//     }
// }

// Console.WriteLine("Enter the number 1: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the number 2: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Square(a,b);


// Семинар 2 C# ДЗ Плотников
/*// Напишите программу, которая принимает на вход 3-хзначное число
// и на выходе показывает вторую цифру числа

// блок придумывания названия функции
int ShowMeNumber(){
   // блок девелоперского клавиатурного ввода
 //Console.WriteLine("Введите тестовое число: ");
 //int threedig = Convert.ToInt32(Console.ReadLine());
   // блок генерации исходных данных
   int threedig = new Random().Next(100,1000);
   // блок вычислений
    threedig = threedig / 10;
    threedig = threedig % 10;
    return threedig;
}
// блок обращения к функции
int num2th = ShowMeNumber();
// блок вывода
Console.WriteLine ("Количество десятков в числе: " + num2th);


*/

// Напишите программу, которая выводит 3-ю цифру заданного числа,
// либо сообщает, что третьей цифры нет.

/*/ блок придумывания названия функции
string PrintMeNumberOrNot(){
// блок ввода    
  Console.WriteLine("Введите число: ");
  string dig = (Console.ReadLine());
// блок вычислений  
if (dig.Length > 2)
   Console.WriteLine ("Третья цифра вашего числа: " + dig[2]);
    else
    Console.WriteLine ("В вашем числе нет третьей цифры." );
   return dig; 
   }
// блок обращения к функции
string dig = PrintMeNumberOrNot();



// Напишите программу, на вход принимает одну цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

// блок придумывания названия функции
void RelaxOrWork (){
// блок ввода   
Console.WriteLine("Введите номер дня недели: ");
int daynumber = Convert.ToInt32(Console.ReadLine()); 
// блок контроля входного данного
if(daynumber < 1 || daynumber > 7){
   Console.WriteLine("Такой день недели в базе не обнаружен."); 
// блок сравнений и вывода
}
        else 
        if(daynumber > 5){
        Console.WriteLine("Ура! Это выходной день."); 
}
        else 
        Console.WriteLine("К сожалению, это не выходной день. Придётся поработать."); 
}
// блок обращения к функции
RelaxOrWork();


*/