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
public class SpecialArrayWithXElementsGreaterThanOrEqualXSorting : ISpecialArrayWithXElementsGreaterThanOrEqualX
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int SpecialArray(int[] nums)
    {
        Array.Sort(nums);

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] < nums.Length - i)
            {
                continue;
            }

            if (i == 0 || nums[i - 1] < nums.Length - i)
            {
                return nums.Length - i;
            }
        }

        return -1;
    }
}