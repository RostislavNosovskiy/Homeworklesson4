/*** Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */
Console.Clear();
int sum(int n){
    int s = 0;
    while (n>0)
    {
      s = s + n%10;
      n = n/10;
    }
    return s;
}
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
int a = n;
Console.WriteLine($"{a} -> {sum(n)}");