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

namespace LeetCode.Algorithms.DetermineIfTwoEventsHaveConflict;

/// <inheritdoc />
public class DetermineIfTwoEventsHaveConflictStringComparison : IDetermineIfTwoEventsHaveConflict
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="event1"></param>
    /// <param name="event2"></param>
    /// <returns></returns>
    public bool HaveConflict(string[] event1, string[] event2)
    {
        return string.CompareOrdinal(event1[0], event2[1]) <= 0 && string.CompareOrdinal(event1[1], event2[0]) >= 0;
    }
}