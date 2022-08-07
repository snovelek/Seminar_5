// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// ВЫВОДИТЬ СООБЩЕНИЕ О НАЛИЧИИ ЭЛЕМЕНТА В МАССИВЕ ТОЛЬКО ОДИН РАЗ!

 int [] n={6,7,19,345,3};


 void find(int [] arr, int f){
    int c=0;
    for (int i=0;i<arr.Length;i++){
        if (f==arr[i]){
            c++;
            break;
        }
    }
    if (c==0){
        Console.WriteLine("Нет");
    }
    else{
        Console.WriteLine("Да");
    }
 }
Console.Write("Введите число- ");
int ch = Convert.ToInt32(Console.ReadLine());
find(n,ch);