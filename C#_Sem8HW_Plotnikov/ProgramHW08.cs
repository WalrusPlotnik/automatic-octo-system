﻿//######## C# ДЗ№8 Плотников ##########################################################
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
double[,] array = new double[m,n];
