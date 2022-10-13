// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень: ");
int B = int.Parse(Console.ReadLine()!);

int stepen(int A, int B){
    int result = 1;
    for (int i = 0; i < B; i++){
        result *= A;
    }
    return result;
}
int res = stepen(A, B);
Console.WriteLine($"{A} в {B} степени = {res}");
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int sum(int num){
    int count = Convert.ToString(num).Length;
    int result = 0;
    int a = 0;
    for (int i = 0; i < count; i++){
        a = num % 10;
        result = result + a;
        num = num / 10;
    }
    return result;
}
int sumNumber = sum(num);
Console.WriteLine($"Сумма цифр в числе = {sumNumber}");
*/


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*
int[] array = NameMetod(8);
Console.WriteLine($"[{String.Join(",", array)}]");

int [] NameMetod(int size){
    int[] result = new int[size];
    for (int i = 0; i < size; i++){
        result[i] = new Random().Next(100);
    }
    return result;
}
*/