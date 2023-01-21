// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите день:");
int n = Convert.ToInt32(Console.ReadLine());
if(n<6 && n>0)
{
    Console.WriteLine("будний день");
}
else if(n>5 && n<8)
{
    Console.WriteLine("Выходной день");
}
