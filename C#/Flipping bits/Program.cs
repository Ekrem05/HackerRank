Console.WriteLine(flippingBits(2147483647)); // Output: 4294967294

static long flippingBits(long n)
{
    uint num = (uint)~n;
    long result = num;
    return result;
}