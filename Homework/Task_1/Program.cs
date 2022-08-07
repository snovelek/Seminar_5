// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void FA(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
}
int chet (int [] arr1){
    int c=0;
    for (int i=1;i<arr1.Length;i++){
        if (arr1[i]%2==0){
            c++;
        }
    }
    return c;
}

Console.Write("Введите длину массива - ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[n];
FA(mas);
int cc= chet(mas);
Console.WriteLine(String.Join(", ",mas));
Console.WriteLine(cc);