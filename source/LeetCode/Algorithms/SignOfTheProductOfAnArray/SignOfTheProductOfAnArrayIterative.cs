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

namespace LeetCode.Algorithms.SignOfTheProductOfAnArray;

/// <inheritdoc />
public class SignOfTheProductOfAnArrayIterative : ISignOfTheProductOfAnArray
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int ArraySign(int[] nums)
    {
        var sign = 1;

        foreach (var num in nums)
        {
            if (num == 0)
            {
                return 0;
            }

            sign = Math.Sign(num * sign);
        }

        return sign;
    }
}