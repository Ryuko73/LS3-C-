//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void Zadacha1(){
Console.WriteLine("Введите пятизначное число для проверки");
string num = Console.ReadLine();
if (num.Length == 5){
    Proverka();
}
else Console.WriteLine("Введите правильное число");{}

void Proverka(){
if (num[0] == num[4] || num[1] == num[3])
{
Console.WriteLine("Ваше число палиндром");
}
else Console.WriteLine("Ваше число не палиндром");
}
}
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
void Zadacha2(){
Console.WriteLine("Введите координаты точки А");
Console.WriteLine("Y");
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("X");
int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z");
int az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
Console.WriteLine("Y");
int by = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("X");
int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z");
int bz = Convert.ToInt32(Console.ReadLine());
int k = ay - by;
int l = ax - bx;
int m = az - bz;
double Length = Math.Sqrt(k * k + l * l + m * m);
Length = Math.Round(Length, 2);
Console.WriteLine($"Длинна {Length}");
}
//Zadacha2();
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Zadacha3(){
Console.WriteLine("Введите число");
int cub = Convert.ToInt32(Console.ReadLine());
int num = 0;
for(int i = 1; i <= cub; i++)
{
num = i*i*i;
Console.WriteLine(num);
}
}
Zadacha3();