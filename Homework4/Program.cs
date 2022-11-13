// Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
// Задаем входящие переменные: 
 int a = 6;
 int b = -15;
 int c = 54;
 int max = 0;

 //Решение:

if (a > b) {
    if (a > c) {
    max = a;
 } else { 
    max = c; 
    }
} else {
    if (b > c) {
        max = b;
    } else {
        max = c;
    }
}
Console.WriteLine(max);