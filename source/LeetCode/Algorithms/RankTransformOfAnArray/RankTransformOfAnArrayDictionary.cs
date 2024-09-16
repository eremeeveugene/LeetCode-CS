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

namespace LeetCode.Algorithms.RankTransformOfAnArray;

/// <inheritdoc />
public class RankTransformOfAnArrayDictionary : IRankTransformOfAnArray
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] ArrayRankTransform(int[] nums)
    {
        var sortedNums = nums.Distinct().Order().ToArray();

        var rankDictionary = new Dictionary<int, int>();

        for (var rank = 0; rank < sortedNums.Length; rank++)
        {
            rankDictionary.Add(sortedNums[rank], rank + 1);
        }

        for (var i = 0; i < nums.Length; i++)
        {
            nums[i] = rankDictionary[nums[i]];
        }

        return nums;
    }
}