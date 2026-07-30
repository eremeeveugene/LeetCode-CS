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

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
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
        var found = false;
        var largest = 0;
        var result = 0;

        for (var i = numsFrequencies.Length - 1; i >= 0 && !found; i--)
        {
            while (!found && numsFrequencies[i] > 0)
            {
                var value = GetValue(i);

                if (firstFound)
                {
                    result = largest + value - smallest;

                    found = true;

                    break;
                }

                largest = value;

                firstFound = true;

                numsFrequencies[i]--;
            }
        }

        return result;
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