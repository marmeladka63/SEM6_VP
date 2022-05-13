// Проверить теорему треугольника. Ввводим 3 длины отрезка. Задача существует ли треугольник с такими сторонами

using System;
Console.Clear();

Console.Write("Введите первую cторону треугольника А=");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите вторую сторону треугольника B=");
int B = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третью сторону треугольника С=");
int C = Convert.ToInt32(Console.ReadLine());

if ((A+B>C &&(A+C)>B&&(B+C)>A))
{
    Console.Write( "Треугольник существует");

}
else 
{
Console.Write( "Треугольник НЕ существует");

}
