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

namespace LeetCode.Algorithms.MaximumNumberOfIntegersToChooseFromRange1;

/// <inheritdoc />
public class MaximumNumberOfIntegersToChooseFromRange1HashSet : IMaximumNumberOfIntegersToChooseFromRange1
{
    /// <summary>
    ///     Time complexity - O(m + n)
    ///     Space complexity - O(m)
    /// </summary>
    /// <param name="banned"></param>
    /// <param name="n"></param>
    /// <param name="maxSum"></param>
    /// <returns></returns>
    public int MaxCount(int[] banned, int n, int maxSum)
    {
        var result = 0;
        var sum = 0;

        var bannedHashSet = new HashSet<int>(banned);

        for (var i = 1; i <= n; i++)
        {
            if (bannedHashSet.Contains(i))
            {
                continue;
            }

            sum += i;

            if (sum > maxSum)
            {
                break;
            }

            result++;
        }

        return result;
    }
}