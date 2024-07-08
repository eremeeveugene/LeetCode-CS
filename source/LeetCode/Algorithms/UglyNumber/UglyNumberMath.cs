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

namespace LeetCode.Algorithms.UglyNumber;

/// <inheritdoc />
public class UglyNumberMath : IUglyNumber
{
    /// <summary>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public bool IsUgly(int n)
    {
        if (n == 0)
        {
            return false;
        }

        while (n % 2 == 0)
        {
            n /= 2;
        }

        while (n % 3 == 0)
        {
            n /= 3;
        }

        while (n % 5 == 0)
        {
            n /= 5;
        }

        return n == 1;
    }
}