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

namespace LeetCode.Algorithms.MaximizeHappinessOfSelectedChildren;

/// <inheritdoc />
public sealed class MaximizeHappinessOfSelectedChildrenIterative : IMaximizeHappinessOfSelectedChildren
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </remarks>
    public long MaximumHappinessSum(int[] happiness, int k)
    {
        long result = 0;

        Array.Sort(happiness);

        var i = 0;

        while (k > 0)
        {
            var happinessValue = happiness[happiness.Length - 1 - i] - i;

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