void Zadacha64()
// Задайте значения M и N. Напишите рекурсивный метод, который 
// выведет все натуральные числа кратные 3-ём в промежутке от M до N.
// M = 1; N = 9. -> "3, 6, 9"
// M = 13; N = 20. -> "15, 18"
{
Console.WriteLine();
Console.WriteLine("Задача 64.");

Console.WriteLine("Введите число М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int k;

int counter = 3;

Console.Write($"Ответ: натуральные числа между M и N, кратные 3, это:\t");
    
    if ((m==n && n%3!=0) 
     || (m<counter && n<counter) 
     || ((m==n+1 || n==m+1) & (m%3!=0 & m%3!=0))) 
    {
        Console.Write("таких чисел нет");    
    }
    if (m>n) 
    {
        k=m;
        m=n;
        n=k;
    }
    if (m<=n)
    {
        while (counter<m)
        {
            counter+=3;
        }
        PrintNumbersDivisibleBy3(n, m, counter);
    }

}

void PrintNumbersDivisibleBy3(int n, int m, int counter)
{
    if (counter >n ) return;
    Console.WriteLine($"{counter}  ");
    counter+=3;
    PrintNumbersDivisibleBy3(n, m, counter);
}

void Zadacha66()
// Задайте значения M и N. Напишите рекурсивный метод, который 
// найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

{
Console.WriteLine();
Console.WriteLine("Задача 66.");

Console.WriteLine("Введите число М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int k;
int sum =0;
int counter = 1;

Console.Write($"Ответ: сумма натуральных чисел между M и N равна:\t");
    
    if (m<1 && n<1)  
    {
        Console.Write("между данных чисел M и N натуральных чисел нет");    
    }
    if (m>n) 
    {
        k=m;
        m=n;
        n=k;
    }
    if (m<=n)
    {
        if (counter>=m) 
        {
            counter=1;
            PrintSumNumbers(n, m, sum, counter);
        }
        else if (counter<m) 
        {
            counter=m;
            PrintSumNumbers(n, m, sum, counter);
        }
    }
    
}

void PrintSumNumbers(int n, int m, int sum, int counter)
{
    if (counter>n )
    {
        Console.WriteLine(sum);
        return;
    } 
    sum+=counter;
    counter++;
    PrintSumNumbers(n, m, sum, counter);
}

void Zadacha68()
// Напишите программу вычисления функции Аккермана с помощью 
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
{
    Console.WriteLine();
    Console.WriteLine("Задача 68.");
    Console.WriteLine();

    Random rand = new Random();
    int m=rand.Next(0,4);
    Console.WriteLine($"m = {m}");
    int n=rand.Next(0,4);
    Console.WriteLine($"n = {n}");

    Console.Write($"Ответ:\t");

    int import = FunctionAkkerman(m, n);

    Console.Write($"Функция Аккермана = {import}");

    int FunctionAkkerman(int m, int n)
    {
        if (m == 0) return n + 1;
        else if (n == 0) return FunctionAkkerman(m - 1, 1);
        else return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
    }

}

Zadacha64();
Zadacha66();
Zadacha68();
