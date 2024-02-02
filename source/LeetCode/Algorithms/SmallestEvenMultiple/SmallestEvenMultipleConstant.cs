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

namespace LeetCode.Algorithms.SmallestEvenMultiple;

/// <inheritdoc />
public class SmallestEvenMultipleConstant : ISmallestEvenMultiple
{
    /// <summary>
    ///     Time complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int SmallestEvenMultiple(int n)
    {
        if (n % 2 == 0)
        {
            return n;
        }

        return n * 2;
    }
}