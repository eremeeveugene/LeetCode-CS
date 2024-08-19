// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.TwoKeysKeyboard;

/// <inheritdoc />
public class TwoKeysKeyboardPrimeFactorization : ITwoKeysKeyboard
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int MinSteps(int n)
    {
        var minSteps = 0;

        for (var i = 2; i <= n; i++)
        {
            while (n % i == 0)
            {
                minSteps += i;

                n /= i;
            }
        }

        return minSteps;
    }
}