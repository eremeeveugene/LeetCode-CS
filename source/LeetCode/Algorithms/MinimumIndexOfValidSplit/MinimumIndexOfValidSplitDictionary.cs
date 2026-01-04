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

namespace LeetCode.Algorithms.MinimumIndexOfValidSplit;

/// <inheritdoc />
public class MinimumIndexOfValidSplitDictionary : IMinimumIndexOfValidSplit
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MinimumIndex(IList<int> nums)
    {
        var frequencyDictionary = new Dictionary<int, int>();
        var dominant = nums[0];
        var dominantFreq = 0;

        foreach (var num in nums)
        {
            frequencyDictionary[num] = frequencyDictionary.GetValueOrDefault(num) + 1;

            if (frequencyDictionary[num] <= dominantFreq)
            {
                continue;
            }

            dominant = num;
            dominantFreq = frequencyDictionary[num];
        }

        var leftDominantCount = 0;

        for (var i = 0; i < nums.Count - 1; i++)
        {
            if (nums[i] == dominant)
            {
                leftDominantCount++;
            }

            var leftIsDominant = leftDominantCount * 2 > i + 1;
            var rightIsDominant = (dominantFreq - leftDominantCount) * 2 > nums.Count - i - 1;

            if (leftIsDominant && rightIsDominant)
            {
                return i;
            }
        }

        return -1;
    }
}