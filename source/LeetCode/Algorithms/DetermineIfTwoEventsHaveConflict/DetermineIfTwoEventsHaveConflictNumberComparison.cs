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
public class DetermineIfTwoEventsHaveConflictNumberComparison : IDetermineIfTwoEventsHaveConflict
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
        var event1Start = ConvertToMinutes(event1[0]);
        var event1End = ConvertToMinutes(event1[1]);
        var event2Start = ConvertToMinutes(event2[0]);
        var event2End = ConvertToMinutes(event2[1]);

        return event1Start <= event2End && event1End >= event2Start;
    }

    private static int ConvertToMinutes(string time)
    {
        var parts = time.Split(':');

        return (int.Parse(parts[0]) * 60) + int.Parse(parts[1]);
    }
}