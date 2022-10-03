// Написать программу, которая из имеющегося массива
// строк формирует массив из строк, длина которых 
// меньше либо равна 3 символам. Первоначальный массив 
// можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.

int N = 3;

Console.WriteLine("Введите элементы массива через пробел, после ввода нажмите Enter");

string oldStr = Console.ReadLine();
string[] arrayOld = oldStr.Split(" ");

arrayOld = arrayOld.Where(val => val != "").ToArray();

int count1 = arrayOld.Length;

string newStr = "";

for (int i = 0; i < count1; i++)
{
    if( arrayOld[i].Length <= N)
        newStr += arrayOld[i] + " ";
}

for (int i = 0; i < count1; i++)
{
    arrayOld[i] = $"\"{arrayOld[i]}\"";
}

string strOld = string.Join(", ", arrayOld);
Console.Write($"[{strOld}] -> ");

if(newStr == "")
    Console.Write($"[]");
else
{
    newStr = newStr.Remove(newStr.Length - 1, 1);

    string[] arrayNew = newStr.Split(" ");

    int count2 = arrayNew.Length;

    for (int i = 0; i < count2; i++)
    {
        arrayNew[i] = $"\"{arrayNew[i]}\"";
    }

    string strNew = string.Join(", ", arrayNew);
    Console.Write($"[{strNew}]");
}
