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

namespace LeetCode.Algorithms.FindAllDuplicatesInAnArray;

/// <inheritdoc />
public class FindAllDuplicatesInAnArrayIterative : IFindAllDuplicatesInAnArray
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public IList<int> FindDuplicates(int[] nums)
    {
        var duplicates = new List<int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var index = Math.Abs(nums[i]) - 1;

            if (nums[index] < 0)
            {
                duplicates.Add(index + 1);
            }
            else
            {
                nums[index] = -nums[index];
            }
        }

        return duplicates;
    }
}