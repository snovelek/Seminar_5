// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

void FA (int [] arr){
    for (int i=0;i<arr.Length;i++){
        arr[i]=new Random().Next(500);
    }
}
int FIND_NUM(int [] arr1){
    int c=0;
    for (int i=0;i<arr1.Length;i++){
        if (arr1[i]>9 && arr1[i]<100){
            c++;
        }
    }
    return c;
}

int [] mas = new int [123];
//int [] mas2={10,11,12,13,14};
FA(mas);
Console.WriteLine("Исходный массив: " + String.Join(", ",mas));
Console.WriteLine(FIND_NUM(mas));
