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

public static class HowManyNumbersAreSmallerThanTheCurrentNumberUsingSortingAndHashing
{
    /// <summary>
    ///     Time complexity - O(n log n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public static int[] GetResult(int[] nums)
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

    /// <summary>
    ///     Time complexity - O(n^2)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    //public static int[] GetResult(int[] nums)
    //{
    //    var result = new int[nums.Length];

    //    var numsLength = nums.Length;

    //    for (var i = 0; i < numsLength; i++)
    //    {
    //        var count = 0;

    //        for (var j = 0; j < numsLength; j++)
    //        {
    //            if (nums[i] > nums[j])
    //            {
    //                count++;
    //            }
    //        }

    //        result[i] = count;
    //    }

    //    return result;
    //}
}