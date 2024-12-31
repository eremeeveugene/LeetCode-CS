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

namespace LeetCode.Algorithms.CheckBalancedString;

/// <inheritdoc />
public class CheckBalancedStringIterative : ICheckBalancedString
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public bool IsBalanced(string num)
    {
        var sum = 0;

        for (var i = 0; i < num.Length; i++)
        {
            if (i % 2 == 0)
            {
                sum += num[i] - '0';
            }
            else
            {
                sum -= num[i] - '0';
            }
        }

        return sum == 0;
    }
}