Console.Clear();
Console.Write("Сколько чисел Вы хотите ввести?  ");
int size = int.Parse(Console.ReadLine());

int i = 0;
string result = "";
string c = ", ";
int count = 0;

while (i < size)
{
    Console.Write("Введите число: ");
    int a = int.Parse(Console.ReadLine());
    result = a + c + result;
    i++;
    if (a > 0)
    {
        count++;
    }

}

Console.Write($"Чисел больше -0- среди чисел {result} -> {count} числа");


