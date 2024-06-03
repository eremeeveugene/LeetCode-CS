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

namespace LeetCode.Algorithms.SingleNumber3;

/// <inheritdoc />
public class SingleNumber3Bitwise : ISingleNumber3
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] SingleNumber(int[] nums)
    {
        var xor = nums.Aggregate((current, num) => current ^ num);

        var rightmostSetBit = xor & ~(xor - 1);
        var result = new int[2];

        foreach (var num in nums)
        {
            if ((num & rightmostSetBit) != 0)
            {
                result[0] ^= num;
            }
            else
            {
                result[1] ^= num;
            }
        }

        return result;
    }
}