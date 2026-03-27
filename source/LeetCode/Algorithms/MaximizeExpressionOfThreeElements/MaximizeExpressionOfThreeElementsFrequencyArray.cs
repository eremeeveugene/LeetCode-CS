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

namespace LeetCode.Algorithms.MaximizeExpressionOfThreeElements;

/// <inheritdoc />
public sealed class MaximizeExpressionOfThreeElementsFrequencyArray : IMaximizeExpressionOfThreeElements
{
    private const int Offset = 100;
    private const int Size = 201;

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MaximizeExpressionOfThree(int[] nums)
    {
        Span<int> numsFrequencies = stackalloc int[Size];

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            var index = GetIndex(num);

            numsFrequencies[index]++;
        }

        var smallest = 0;

        for (var i = 0; i < numsFrequencies.Length; i++)
        {
            if (numsFrequencies[i] <= 0)
            {
                continue;
            }

            smallest = GetValue(i);

            break;
        }

        var firstFound = false;
        var largest = 0;

        for (var i = numsFrequencies.Length - 1; i >= 0; i--)
        {
            while (numsFrequencies[i] > 0)
            {
                var value = GetValue(i);

                if (firstFound)
                {
                    return largest + value - smallest;
                }

                largest = value;

                firstFound = true;

                numsFrequencies[i]--;
            }
        }

        return 0;
    }

    private static int GetValue(int index)
    {
        return index - Offset;
    }

    private static int GetIndex(int value)
    {
        return value + Offset;
    }
}