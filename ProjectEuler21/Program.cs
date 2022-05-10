using ProjectEuler21;
//Project Euler 21
//Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
//If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.
//For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284. The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.
//Evaluate the sum of all the amicable numbers under 10000.

List<int> sumOfAmicableNumbers = new List<int>();
for (int x = 1; x <= 10000; x++)
{
    FactorNumber y = new FactorNumber();
    y.reset();
    y.Number = x;
    y.GetDivisors();
    if (y.IsAmicable)
    {
        Console.WriteLine(y.Number + "'s proper divisor's sum is " + y.SumOfDivisors);
        Console.WriteLine(y.Number + " has an amicable pair with " + y.AmicablePair.Number);
        sumOfAmicableNumbers.Add(y.Number);
        Console.WriteLine("Current sum of amicable numbers: " + sumOfAmicableNumbers.Sum());
        Console.WriteLine();
    }
}
Console.WriteLine("Answer: "+ sumOfAmicableNumbers.Sum());