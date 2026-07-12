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
public sealed class FindAllNumbersDisappearedInArrayHashSet : IFindAllNumbersDisappearedInArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        var hashSet = new HashSet<int>(nums);

        var result = new List<int>();

        for (var i = 1; i <= nums.Length; i++)
        {
            if (!hashSet.Contains(i))
            {
                result.Add(i);
            }
        }

        return result;
    }
}