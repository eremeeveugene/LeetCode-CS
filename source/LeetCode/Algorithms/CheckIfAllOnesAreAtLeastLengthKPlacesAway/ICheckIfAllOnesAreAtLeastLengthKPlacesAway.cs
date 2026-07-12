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

/// <summary>
///     https://leetcode.com/problems/check-if-all-1s-are-at-least-length-k-places-away/description/
/// </summary>
public interface ICheckIfAllOnesAreAtLeastLengthKPlacesAway
{
    /// <summary>
    ///     Determines whether all ones in <paramref name="nums" /> are at least <paramref name="k" /> places away from each
    ///     other.
    /// </summary>
    /// <param name="nums">The binary array of zeros and ones.</param>
    /// <param name="k">The minimum required distance between any two ones.</param>
    /// <returns><c>true</c> if all ones are at least <paramref name="k" /> places away from each other; otherwise, <c>false</c>.</returns>
    bool KLengthApart(int[] nums, int k);
}