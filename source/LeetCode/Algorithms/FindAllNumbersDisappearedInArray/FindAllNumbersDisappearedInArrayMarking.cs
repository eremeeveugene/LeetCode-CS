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
public sealed class FindAllNumbersDisappearedInArrayMarking : IFindAllNumbersDisappearedInArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        var markedNums = new bool[nums.Length];

        foreach (var num in nums)
        {
            markedNums[num - 1] = true;
        }

        var result = new List<int>();

        for (var i = 0; i < markedNums.Length; i++)
        {
            if (!markedNums[i])
            {
                result.Add(i + 1);
            }
        }

        return result;
    }
}