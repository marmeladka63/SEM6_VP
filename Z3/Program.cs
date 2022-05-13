// Преобразование из десятичной в двоичную систему 


using System;
Console.Clear();
// Математический метод

 /*int N= int.Parse(Console.ReadLine());
 string s=string.Empty;
 while(N>0)
 {
     s=N%2+s;
     N=N/2;
 }
Console.WriteLine(s);*/
// Стандартный метод
/*Console.WriteLine("Введите число: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Convert.ToString(i,2));*/

// Метод как на олимпиадах

Console.WriteLine(DecToNum(10,2));

string DecToNum(int decNumber, int otherSystem)
{
    string res="";
    string nums="0123456789ABCDEF";
    while(decNumber>0)
    {
        int ost=decNumber/otherSystem;
        res=nums[decNumber-otherSystem*ost]+res;
        decNumber/=otherSystem;
    }
    return res;
}

