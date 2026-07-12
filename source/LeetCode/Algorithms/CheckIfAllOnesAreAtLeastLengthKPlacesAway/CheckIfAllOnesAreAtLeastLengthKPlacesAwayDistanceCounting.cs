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

namespace LeetCode.Algorithms.CheckIfAllOnesAreAtLeastLengthKPlacesAway;

/// <inheritdoc />
public sealed class CheckIfAllOnesAreAtLeastLengthKPlacesAwayDistanceCounting : ICheckIfAllOnesAreAtLeastLengthKPlacesAway
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool KLengthApart(int[] nums, int k)
    {
        var previousIndex = -1;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                continue;
            }

            if (previousIndex < 0 || i - previousIndex - 1 >= k)
            {
                previousIndex = i;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}