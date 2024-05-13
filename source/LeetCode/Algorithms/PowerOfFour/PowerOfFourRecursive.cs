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

namespace LeetCode.Algorithms.PowerOfFour;

/// <inheritdoc />
public class PowerOfFourRecursive : IPowerOfFour
{
    /// <summary>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(log n)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public bool IsPowerOfFour(int n)
    {
        return n > 0 && GetIsPowerOfFour(n);
    }

    private static bool GetIsPowerOfFour(int n)
    {
        if (n == 1)
        {
            return true;
        }

        return n % 4 == 0 && GetIsPowerOfFour(n / 4);
    }
}