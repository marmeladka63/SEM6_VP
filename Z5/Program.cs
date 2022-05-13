// ПРограмма которая создает копию заданого массива поэлементо


using System;
Console.Clear();

int[] array=new int[5].Select(x=>x=new Random().Next(0,10)).ToArray();
Console.WriteLine(String.Join(" ",array));

int[] CopyAr(int[] ar)
{
    int[] newAr= new int[ar.Length];
    for(int i=0; i<newAr.Length; i++ )
    newAr[i]=ar[i];
    return newAr;
}
Console.WriteLine(String.Join(" ",CopyAr(array)));
