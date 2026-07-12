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

namespace LeetCode.Algorithms.ReorderedPowerOfTwo;

/// <inheritdoc />
public sealed class ReorderedPowerOfTwoFrequencyArray : IReorderedPowerOfTwo
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool ReorderedPowerOf2(int n)
    {
        var targetDigitsFrequency = GetDigitsFrequency(n);

        for (var i = 0; i < 31; i++)
        {
            var currentDigitsFrequency = GetDigitsFrequency(1 << i);

            if (AreEqual(targetDigitsFrequency, currentDigitsFrequency))
            {
                return true;
            }
        }

        return false;
    }

    private static int[] GetDigitsFrequency(int num)
    {
        var digitsFrequency = new int[10];

        while (num > 0)
        {
            digitsFrequency[num % 10]++;

            num /= 10;
        }

        return digitsFrequency;
    }

    private static bool AreEqual(int[] a, int[] b)
    {
        for (var i = 0; i < 10; i++)
        {
            if (a[i] != b[i])
            {
                return false;
            }
        }

        return true;
    }
}