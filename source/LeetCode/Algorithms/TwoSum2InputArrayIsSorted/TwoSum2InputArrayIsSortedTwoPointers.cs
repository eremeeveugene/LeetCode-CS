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

namespace LeetCode.Algorithms.TwoSum2InputArrayIsSorted;

/// <inheritdoc />
public class TwoSum2InputArrayIsSortedTwoPointers : ITwoSum2InputArrayIsSorted
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="numbers"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int[] TwoSum(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;

        while (left < right)
        {
            var sum = numbers[left] + numbers[right];

            if (sum == target)
            {
                break;
            }

            if (sum < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return [left + 1, right + 1];
    }
}