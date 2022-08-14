/*Задача 50. Напишите программу, которая на вход принимает позиции элемента либо значение элемента в двумерном массиве,
и возвращает значение либо индекс этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
4 -> такой элемент есть и его индекс 0, 1 (идеально было б найти все вхождения этого элемента)
2, 3 -> такой элемент есть и равен 4
5, 5 -> такой элемент отсутствует*/

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

Console.Write("Введите позицию элемента (через запятую) или значение элемента: ");
string text = Console.ReadLine();
string[] arrayText = text.Split(',');
int[] mas = new int[arrayText.Length];
string result = string.Empty;

for (int i = 0; i < arrayText.Length; i++)
{
    mas[i] = Convert.ToInt32(arrayText[i]);
}

void PrintArrayRazm(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");

        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }

}

void FindElement(int[,] array, int[] mas)
{
    bool flag = false;
    if (mas.Length == 1)
    {
        for (int k = 0; k < mas.Length; k++)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == mas[k])
                    {
                        result += $"{i}, {j}\n";
                        flag = true;
                    }
                }
            }
        }
        if (flag) Console.WriteLine($"Присутствует(ют) элемент(ы) в массиве с индексом(ами):\n{result}");
        else Console.WriteLine("Такого числа в массиве нет");
    }
    else if (mas.Length > 1 && mas.Length < 3)
    {
        try
        {
            Console.WriteLine($"Такой элемент есть и равен: {array[mas[0], mas[1]]}");
        }
        catch (System.Exception)
        {
            Console.WriteLine("Такой элемент отсутствует");
        }
    }
    else Console.WriteLine("Введены не корректные данные!");
}

FillArray(array);
PrintArrayRazm(array);
Console.WriteLine();
FindElement(array, mas);