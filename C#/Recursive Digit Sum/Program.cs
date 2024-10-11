
using System.Text;

static int recursion(long n)
{
    if (n< 10) { return (int)n; }

    long sum = 0;
    while (n > 0)
    {
        sum += n % 10;
        n /= 10;
    }
    return recursion(sum);
}
static int superDigit(string n, int k)
{
    long sum = 0;

    for (int i = 0; i < n.Length; i++)
    {
        sum += n[i] - '0';
    }
    sum *= k;
    return recursion(sum);
}

Console.WriteLine(superDigit("9875", 4));