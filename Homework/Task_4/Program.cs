// Задача 38: Задайте с клавиатуры массив вещественных (double) чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Задать размер (int) массива с клавиатуры
// [3 7 22 2 78] -> 76

void diff(double [] arr){
    double max=arr[0];
    double min=arr[0];
    double dif=0;
    for (int i=1;i<arr.Length;i++){
        if (arr[i]>max)
            max=arr[i];
        if (arr[i]<min)
            min=arr[i];
    }
    dif=max-min;
    //Console.WriteLine(max);
    //Console.WriteLine(min);
    Console.WriteLine(dif);
}

Console.Write("Введитите длину масива- ");
int n= Convert.ToInt32(Console.ReadLine());
double [] mas=new double[n];
for (int i=0;i<mas.Length;i++){

    Console.Write($"Заполните элемент №{i} - ");
    mas[i]=Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine("Исходный массив- "+String.Join(",", mas));
diff(mas);