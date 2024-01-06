// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

int num = 5365324;

if (num > 9)
{
	while (num % 10 == num)
	{
		int oct = num % 10;
		Console.Write($"{oct}");
		num /= 10;
	}
}
else
{
	Console.Write(num);
}