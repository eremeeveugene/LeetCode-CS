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

namespace LeetCode.Algorithms.LargestPerimeterTriangle;

/// <inheritdoc />
public class LargestPerimeterTriangleSorting : ILargestPerimeterTriangle
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int LargestPerimeter(int[] nums)
    {
        Array.Sort(nums);

        for (var i = nums.Length - 3; i >= 0; i--)
        {
            if (nums[i] + nums[i + 1] > nums[i + 2])
            {
                return nums[i] + nums[i + 1] + nums[i + 2];
            }
        }

        return 0;
    }
}