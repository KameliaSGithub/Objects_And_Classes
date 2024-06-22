
using System;
using System.Numerics;
using System.Numerics;
static BigInteger Big_Factorial(int num)
{
    BigInteger result = 1;

    for (int i = 1; i <= num; i++)
    {
        result *= i;
    }

    return result;
}

int input = int.Parse(Console.ReadLine());

BigInteger factorial = Big_Factorial(input);

Console.WriteLine(factorial);

