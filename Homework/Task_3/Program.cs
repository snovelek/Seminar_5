// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

void FA (int [] arr){
    for (int i=0;i<arr.Length;i++){
        arr[i]=new Random().Next(200);
    }
}

int FIND_SUM(int [] arr1){
    int sum=0;
    for (int i=1;i<arr1.Length;i+=2){
        sum=sum+arr1[i];   
    } 
    return sum;   
}
int [] mas={-4,-6,89,6};
int [] mas1=new int [10];
FA(mas1);
Console.WriteLine("Исходный массив "+ String.Join(", ",mas1));
Console.WriteLine($"Сумма элементов расположенных на нечётных позициях равна - {FIND_SUM(mas1)}");