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

namespace LeetCode.Algorithms.MaximizeHappinessOfSelectedChildren;

/// <inheritdoc />
public class MaximizeHappinessOfSelectedChildrenIterative : IMaximizeHappinessOfSelectedChildren
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="happiness"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public long MaximumHappinessSum(int[] happiness, int k)
    {
        long result = 0;

        Array.Sort(happiness, (a, b) => b.CompareTo(a));

        var i = 0;

        while (k > 0)
        {
            var happinessValue = happiness[i] - i;

            if (happinessValue > 0)
            {
                result += happinessValue;
            }

            i++;
            k--;
        }

        return result;
    }
}