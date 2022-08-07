// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int [] n= new int[12];
Random rnd = new Random();
int plus=0;
int minus=0;

for (int i=0;i<12;i++){
    n[i]=rnd.Next(-9,10);
}
Console.WriteLine(String.Join(", ",n));

for (int i=0;i<12;i++){
    if (n[i]>0){
        plus=plus+n[i];
    }
    else{
        minus=minus+n[i];
    }
}
Console.WriteLine($"Положительные = {plus}");
Console.WriteLine($"Положительные = {minus}");