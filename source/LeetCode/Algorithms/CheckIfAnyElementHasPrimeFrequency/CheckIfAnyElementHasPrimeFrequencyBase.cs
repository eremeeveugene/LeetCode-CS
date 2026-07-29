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

namespace LeetCode.Algorithms.CheckIfAnyElementHasPrimeFrequency;

/// <inheritdoc />
public abstract class CheckIfAnyElementHasPrimeFrequencyBase : ICheckIfAnyElementHasPrimeFrequency
{
    protected const int Count = 101;

    private static readonly bool[] Primes = GeneratePrimes(Count);

    public abstract bool CheckPrimeFrequency(int[] nums);

    protected static bool IsPrime(int number)
    {
        return Primes[number];
    }

    private static bool[] GeneratePrimes(int max)
    {
        var isPrime = new bool[max + 1];

        isPrime[2] = true;

        for (var i = 3; i <= max; i += 2)
        {
            isPrime[i] = true;
        }

        for (var p = 3; p * p <= max; p += 2)
        {
            if (!isPrime[p])
            {
                continue;
            }

            for (var multiple = p * p; multiple <= max; multiple += p * 2)
            {
                isPrime[multiple] = false;
            }
        }

        return isPrime;
    }
}