//Вычисление ряда Фиббоначи. Первое и второе число вводим с клавиатуры А1,А2 И вывести ряд до  до N числа


Console.Write("Введите количество цифр в ряду = ");
int num = int.Parse(Console.ReadLine());

int[] fib = new int [num];
Console.Write("Введите первое число = ");
fib[0]=int.Parse(Console.ReadLine());
Console.Write("Введите второе число = ");
fib[1]=int.Parse(Console.ReadLine());


for (int i=2; i<fib.Length; i++)
{
    fib[i]=fib[i-1]+fib[i-2];

}
Console.WriteLine(string.Join(" ",fib));


