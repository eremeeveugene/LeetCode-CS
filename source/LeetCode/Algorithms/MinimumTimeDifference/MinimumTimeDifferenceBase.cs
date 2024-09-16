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

namespace LeetCode.Algorithms.MinimumTimeDifference;

/// <inheritdoc />
public abstract class MinimumTimeDifferenceBase : IMinimumTimeDifference
{
    protected const int DayMinutes = 60 * 24;

    public int FindMinDifference(IList<string> timePoints)
    {
        return timePoints.Count > DayMinutes ? 0 : FindMinDifferenceInternal(timePoints);
    }

    public abstract int FindMinDifferenceInternal(IList<string> timePoints);
}