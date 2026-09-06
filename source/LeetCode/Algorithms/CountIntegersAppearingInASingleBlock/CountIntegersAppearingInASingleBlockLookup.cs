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

namespace LeetCode.Algorithms.CountIntegersAppearingInASingleBlock;

/// <inheritdoc />
public sealed class CountIntegersAppearingInASingleBlockLookup : ICountIntegersAppearingInASingleBlock
{
    private const int MaxValue = 100;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int CountSpecialIntegers(int[] nums)
    {
        var n = nums.Length;

        Span<byte> numsLookup = stackalloc byte[MaxValue + 1];

        var result = 0;

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            if (i > 0 && num == nums[i - 1])
            {
                continue;
            }

            switch (numsLookup[num])
            {
                case 0:
                    numsLookup[num] = 1;

                    result++;

                    break;
                case 1:
                    numsLookup[num] = 2;

                    result--;

                    break;
            }
        }

        return result;
    }
}