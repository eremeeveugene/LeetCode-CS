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

namespace LeetCode.Algorithms.FindMissingElements;

/// <inheritdoc />
public class FindMissingElementsSorting : IFindMissingElements
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(log n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public IList<int> FindMissingElements(int[] nums)
    {
        Array.Sort(nums);

        var missingElements = new List<int>();

        for (var i = 1; i < nums.Length; i++)
        {
            var num = nums[i];

            var missingElement = nums[i - 1] + 1;

            while (missingElement < num)
            {
                missingElements.Add(missingElement);

                missingElement++;
            }
        }

        return missingElements;
    }
}