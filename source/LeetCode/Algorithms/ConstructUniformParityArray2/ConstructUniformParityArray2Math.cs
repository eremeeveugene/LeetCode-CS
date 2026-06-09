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

namespace LeetCode.Algorithms.ConstructUniformParityArray2;

/// <inheritdoc />
public sealed class ConstructUniformParityArray2Math : IConstructUniformParityArray2
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool UniformArray(int[] nums1)
    {
        var min = int.MaxValue;

        var allEven = true;

        for (var i = 0; i < nums1.Length; i++)
        {
            var num = nums1[i];

            min = Math.Min(min, num);

            if (num % 2 == 1)
            {
                allEven = false;
            }
        }

        return allEven || min % 2 == 1;
    }
}