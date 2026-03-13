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

namespace LeetCode.Algorithms.AppleRedistributionIntoBoxes;

/// <inheritdoc />
public sealed class AppleRedistributionIntoBoxesGreedy : IAppleRedistributionIntoBoxes
{
    private const int MaxSize = 50;

    /// <summary>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="apples"></param>
    /// <param name="capacities"></param>
    /// <returns></returns>
    public int MinimumBoxes(int[] apples, int[] capacities)
    {
        var applesCount = 0;

        for (var i = 0; i < apples.Length; i++)
        {
            var apple = apples[i];

            applesCount += apple;
        }

        Span<int> boxes = stackalloc int[MaxSize + 1];

        for (var i = 0; i < capacities.Length; i++)
        {
            var capacity = capacities[i];

            boxes[capacity]++;
        }

        var result = 0;

        for (var i = boxes.Length - 1; i >= 0; i--)
        {
            if (applesCount == 0)
            {
                break;
            }

            var box = boxes[i];

            while (box > 0 && applesCount > 0)
            {
                applesCount -= i;

                box--;

                result++;
            }
        }

        return result;
    }
}