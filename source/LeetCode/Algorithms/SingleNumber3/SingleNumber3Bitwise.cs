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

namespace LeetCode.Algorithms.SingleNumber3;

/// <inheritdoc />
public sealed class SingleNumber3Bitwise : ISingleNumber3
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int[] SingleNumber(int[] nums)
    {
        var xor = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            xor ^= num;
        }


        var rightmostSetBit = xor & ~(xor - 1);
        var result = new int[2];

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

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