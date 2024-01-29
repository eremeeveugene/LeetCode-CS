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

namespace LeetCode.Algorithms.SingleNumber;

/// <inheritdoc />
public class SingleNumberHashSet : ISingleNumber
{
    /// <summary>
    ///     Time complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int SingleNumber(int[] nums)
    {
        var numsHashSet = new HashSet<int>();

        foreach (var num in nums)
        {
            if (!numsHashSet.Add(num))
            {
                numsHashSet.Remove(num);
            }
        }

        return numsHashSet.Single();
    }
}