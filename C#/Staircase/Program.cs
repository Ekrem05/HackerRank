static void staircase(int n)
{
	for (int i = 1; i <= n; i++)
	{
		Console.WriteLine(new string(' ', n - i) + new string('#',i));
	}
}
staircase(4);