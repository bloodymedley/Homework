﻿Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if ( a >  b) {
    Console.WriteLine("Максимальное число " + a );
}
else{
    Console.WriteLine("Максимальное число " + b);
}
if ( a == b) {Console.WriteLine($"Все числа равны {a} = {b}" );}