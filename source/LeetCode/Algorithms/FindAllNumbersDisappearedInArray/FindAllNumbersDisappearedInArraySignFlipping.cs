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

namespace LeetCode.Algorithms.FindAllNumbersDisappearedInArray;

/// <inheritdoc />
public sealed class FindAllNumbersDisappearedInArraySignFlipping : IFindAllNumbersDisappearedInArray
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            var index = Math.Abs(nums[i]) - 1;

            if (nums[index] > 0)
            {
                nums[index] = -nums[index];
            }
        }

        var result = new List<int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                result.Add(i + 1);
            }
        }

        return result;
    }
}