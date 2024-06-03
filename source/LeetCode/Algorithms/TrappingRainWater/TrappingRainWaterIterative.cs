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

namespace LeetCode.Algorithms.TrappingRainWater;

/// <inheritdoc />
public class TrappingRainWaterIterative : ITrappingRainWater
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="height"></param>
    /// <returns></returns>
    public int Trap(int[] height)
    {
        var result = 0;

        var left = 0;
        var right = height.Length - 1;

        var leftMax = 0;
        var rightMax = 0;

        while (left < right)
        {
            if (height[left] <= height[right])
            {
                if (height[left] >= leftMax)
                {
                    leftMax = height[left];
                }
                else
                {
                    result += leftMax - height[left];
                }

                left++;
            }
            else
            {
                if (height[right] >= rightMax)
                {
                    rightMax = height[right];
                }
                else
                {
                    result += rightMax - height[right];
                }

                right--;
            }
        }

        return result;
    }
}