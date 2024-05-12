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

namespace LeetCode.Algorithms.ReverseInteger;

public class ReverseIntegerIterative : IReverseInteger
{
    /// <summary>
    ///     Time complexity - O(log(n))
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public int Reverse(int x)
    {
        long result = 0;

        while (x != 0)
        {
            result *= 10;
            result += x % 10;

            if (result is > int.MaxValue or < int.MinValue)
            {
                return 0;
            }

            x /= 10;
        }

        return (int)result;
    }
}