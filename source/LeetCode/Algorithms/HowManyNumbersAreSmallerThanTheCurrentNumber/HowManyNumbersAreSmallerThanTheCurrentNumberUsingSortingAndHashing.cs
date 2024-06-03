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

namespace LeetCode.Algorithms.HowManyNumbersAreSmallerThanTheCurrentNumber;

/// <inheritdoc />
public class HowManyNumbersAreSmallerThanTheCurrentNumberUsingSortingAndHashing :
    IHowManyNumbersAreSmallerThanTheCurrentNumber
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        var sortedNums = nums.Order().ToArray();

        var ranks = new Dictionary<int, int>();

        for (var i = 0; i < sortedNums.Length; i++)
        {
            if (!ranks.ContainsKey(sortedNums[i]))
            {
                ranks[sortedNums[i]] = i;
            }
        }

        var result = new int[nums.Length];

        for (var i = 0; i < nums.Length; i++)
        {
            result[i] = ranks[nums[i]];
        }

        return result;
    }
}