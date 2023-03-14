//Задача 7 HARD по желанию - идет за 2 необязательных Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает вторую цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
//456111 -> 5
//78 -> 8
//9146548 -> 1
//3 -> нет
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int b = a;
int size = 0;
while (b>0)
{
    b = b/10;
    size++;
}
b = a;
int[] array = new int[size];
int index = 0;
while (index<size)
{
    array[index] = b%10;
    b = b/10;
    index++;
}
if (size-2<0)
{
    Console.WriteLine("Второй цифры нет");
}
else
Console.WriteLine("Вторая цифра в числе - это " + array[size-2]);

