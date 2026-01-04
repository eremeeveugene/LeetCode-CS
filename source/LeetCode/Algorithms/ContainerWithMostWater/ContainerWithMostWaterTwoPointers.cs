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

namespace LeetCode.Algorithms.ContainerWithMostWater;

/// <inheritdoc />
public class ContainerWithMostWaterTwoPointers : IContainerWithMostWater
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="heights"></param>
    /// <returns></returns>
    public int MaxArea(int[] heights)
    {
        var left = 0;
        var right = heights.Length - 1;

        var maxArea = 0;

        while (left < right)
        {
            var leftHeight = heights[left];
            var rightHeight = heights[right];
            var height = int.Min(leftHeight, rightHeight);

            var width = right - left;

            var area = height * width;

            if (area > maxArea)
            {
                maxArea = area;
            }

            if (leftHeight < rightHeight)
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }
}