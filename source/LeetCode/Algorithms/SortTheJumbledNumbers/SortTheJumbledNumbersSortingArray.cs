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

namespace LeetCode.Algorithms.SortTheJumbledNumbers;

/// <inheritdoc />
public class SortTheJumbledNumbersSortingArray : ISortTheJumbledNumbers
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="mapping"></param>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] SortJumbled(int[] mapping, int[] nums)
    {
        var mappedNums = new (int mapped, int original)[nums.Length];

        for (var i = 0; i < nums.Length; i++)
        {
            var originalNum = nums[i];
            var mappedNum = 0;
            var multiplier = 1;

            do
            {
                mappedNum += mapping[originalNum % 10] * multiplier;
                originalNum /= 10;
                multiplier *= 10;
            } while (originalNum > 0);

            mappedNums[i] = (mappedNum, nums[i]);
        }

        Array.Sort(mappedNums, (a, b) => a.mapped.CompareTo(b.mapped));

        for (var i = 0; i < nums.Length; i++)
        {
            nums[i] = mappedNums[i].original;
        }

        return nums;
    }
}