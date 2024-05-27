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

namespace LeetCode.Algorithms.SpecialArrayWithXElementsGreaterThanOrEqualX;

/// <inheritdoc />
public class SpecialArrayWithXElementsGreaterThanOrEqualXBruteForce : ISpecialArrayWithXElementsGreaterThanOrEqualX
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int SpecialArray(int[] nums)
    {
        for (var i = 0; i < nums.Length + 1; i++)
        {
            var count = nums.Count(num => num >= i);

            if (count == i)
            {
                return count;
            }
        }

        return -1;
    }
}