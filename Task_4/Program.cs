// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void FA(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
}


Console.Write("Введите длину массива - ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[n];
FA(mas);
Console.WriteLine("Обычный массив = " + String.Join(", ", mas));
//RAZ(mas);
Console.WriteLine("Новый массив = " + String.Join(", ", RAZ(mas)));

int[] RAZ(int[] arr)
{
    int L = arr.Length - 1;
    int L2 = 0;
    if (arr.Length % 2 == 0)
    {
        L2 = arr.Length / 2; Console.WriteLine(L2);
    }
    else
    {
        L2 = arr.Length / 2 + 1;Console.WriteLine(L2);
    }
    int[] narr = new int[L2];
    for (int i = 0; i <= L; i++)
    {
        if (i == L)
        {
            narr[i] = arr[i];
        }
        else
        {
            narr[i] = arr[i] * arr[L];
            L = L - 1;
        }
    }
    return narr;
}