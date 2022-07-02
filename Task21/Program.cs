/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите координаты числа A");
int numberAX = Convert.ToInt32(Console.ReadLine());
int numberAY = Convert.ToInt32(Console.ReadLine());
int numberAZ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты числа B");
int numberBX = Convert.ToInt32(Console.ReadLine());
int numberBY = Convert.ToInt32(Console.ReadLine());
int numberBZ = Convert.ToInt32(Console.ReadLine());

double Length = 0;
Length = Math.Sqrt(Math.Pow(numberAX-numberBX,2)+Math.Pow(numberAY-numberBY,2)+Math.Pow(numberAZ-numberBZ,2));
Console.WriteLine(Length);
