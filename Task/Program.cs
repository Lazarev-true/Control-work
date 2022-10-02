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
