Console.WriteLine("Программа, которая на вход принимает число N, а на выходе выдает все четные числа от 1 до N");
Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
int index = 0;
for (index=0; index<N; index++)
{
    if (N==0) 
    {
        Console.WriteLine("Вы ввели 0");
        break;
    }
    if (index%2==0) Console.WriteLine("Четное число" + index);
}
