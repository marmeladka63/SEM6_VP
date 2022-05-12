// Реверс массива
using System;
using System.Linq;

//Пример 1 только в C#
/*int[] ar=new int[5].Select(x=>x=new Random().Next(0,10)).ToArray();
Console.WriteLine(String.Join("",ar));
Console.WriteLine(String.Join("",ar.Reverse()));*/

// Пример 2 разворот чисел в массиве
int length=10;
int[] ar=new int[10].Select(x=>x=new Random().Next(0,20)).ToArray();
Console.WriteLine(String.Join("",ar));

for(int i=0; i<length/2;i++)
{
    int k=ar[i];
    ar[i]=ar[length-i-1];
    ar[length-i-1]=k;
}

Console.WriteLine(String.Join("",ar));

//Пример 3 создание массива реверса

int [] ar1 = new int[length];
for(int i=0; i<length; i++)
{
    ar1[length-i-1]=ar[i];
}
Console.WriteLine(String.Join("",ar1));