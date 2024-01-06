// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

int num = 17;

if (num >= 10 && num <= 99)
{
	int first = num % 10;
	int second = num / 10;
	if (first > second)
	{
		Console.Write(first);
	}
	else if (second > first)
	{
		Console.Write(second);
	}
	else
	{
		Console.Write("Они равны");
	}
}
else
{
	Console.Write("Выходит за пределы отрезка");
}


