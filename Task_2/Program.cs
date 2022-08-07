// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int [] n= new int[4];
Random rnd = new Random();

for (int i=0;i<4;i++){
    n[i]=rnd.Next(-10,10);
}
Console.WriteLine("Обычный массив = "+ String.Join(", ",n));

void revers (int [] arr){
    for (int i=0;i<4;i++){
        arr[i]=arr[i]*(-1);
    //return arr;
    }
}

revers(n);
Console.WriteLine("Реверсный массив = "+ String.Join(", ",n));