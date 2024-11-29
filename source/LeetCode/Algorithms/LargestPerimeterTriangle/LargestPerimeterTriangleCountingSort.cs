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
public class LargestPerimeterTriangleCountingSort : ILargestPerimeterTriangle
{
    /// <summary>
    ///     Time complexity - O(n + k), where k is the maximum value in nums
    ///     Space complexity - O(n + k), where k is the maximum value in nums
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int LargestPerimeter(int[] nums)
    {
        var maxNum = nums.Max();

        var count = new int[maxNum + 1];

        foreach (var num in nums)
        {
            count[num]++;
        }

        var sortedNums = new int[nums.Length];

        var index = 0;

        for (var i = maxNum; i >= 0; i--)
        {
            while (count[i]-- > 0)
            {
                sortedNums[index++] = i;
            }
        }

        for (var i = 0; i < sortedNums.Length - 2; i++)
        {
            if (sortedNums[i] < sortedNums[i + 1] + sortedNums[i + 2])
            {
                return sortedNums[i] + sortedNums[i + 1] + sortedNums[i + 2];
            }
        }

        return 0;
    }
}