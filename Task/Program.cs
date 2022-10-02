// Написать программу, которая из имеющегося массива
// строк формирует массив из строк, длина которых 
// меньше либо равна 3 символам. Первоначальный массив 
// можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.

int N;

Console.WriteLine("Введите элементы массива через пробел, после ввода нажмите Enter");

string arr = Console.ReadLine();

string[] arrayOld = arr.Split(" ");

arrayOld = arrayOld.Where(val => val != "").ToArray();

int count = arrayOld.Length;

for (int i = 0; i < count; i++)
{
    arrayOld[i] = $"\"{arrayOld[i]}\"";
}

string strOld = string.Join(", ", arrayOld);
Console.Write($"[{strOld}] -> ");

Random rand = new Random();

if(count > 3)
    N = rand.Next(4);
else
    N = rand.Next(count + 1);

string[] arrayNew = new string[N];
int[] number = new int[N];

    if(N == 0)
    Console.Write($"[]");
else
{
    number[0] = rand.Next(0, 4);

    for (int i = 1; i < N;)
{
    int tmp = rand.Next(0, N);
    int j;
    for (j = 0; j < i; j++)
    {
        if (tmp == number[j])
        break;
    }
    if (j == i)
    { 
        number[i] = tmp;
        i++; 
    }
}

    for (int i = 0; i < N; i++)
    {
        arrayNew[i] = arrayOld[number[i]]; 
    }
    string strNew = string.Join(", ", arrayNew);
    Console.Write($"[{strNew}]");
}
