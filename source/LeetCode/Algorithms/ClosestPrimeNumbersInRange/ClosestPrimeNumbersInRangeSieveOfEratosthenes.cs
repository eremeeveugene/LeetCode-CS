// --------------------------------------------------------------------------------
// Copyright (C) 2026 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.ClosestPrimeNumbersInRange;

/// <inheritdoc />
public class ClosestPrimeNumbersInRangeSieveOfEratosthenes : IClosestPrimeNumbersInRange
{
    /// <summary>
    ///     Time complexity - O(R * log(log R))
    ///     Space complexity - O(R)
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public int[] ClosestPrimes(int left, int right)
    {
        var isPrime = SieveOfEratosthenes(right);
        var primes = new List<int>();

        for (var num = left; num <= right; num++)
        {
            if (isPrime[num])
            {
                primes.Add(num);
            }
        }

        if (primes.Count < 2)
        {
            return [-1, -1];
        }

        var minDiff = int.MaxValue;
        var minNum1 = -1;
        var minNum2 = -1;

        for (var i = 1; i < primes.Count; i++)
        {
            var diff = primes[i] - primes[i - 1];

            if (diff >= minDiff)
            {
                continue;
            }

            minDiff = diff;
            minNum1 = primes[i - 1];
            minNum2 = primes[i];

            if (minNum2 - minNum1 == 2)
            {
                break;
            }
        }

        return [minNum1, minNum2];
    }

    private static bool[] SieveOfEratosthenes(int n)
    {
        var isPrime = new bool[n + 1];

        Array.Fill(isPrime, true);

        isPrime[0] = isPrime[1] = false;

        for (var i = 2; i * i <= n; i++)
        {
            if (!isPrime[i])
            {
                continue;
            }

            for (var j = i * i; j <= n; j += i)
            {
                isPrime[j] = false;
            }
        }

        return isPrime;
    }
}