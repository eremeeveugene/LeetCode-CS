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

namespace LeetCode.Algorithms.DesignExamScoresTracker;

/// <inheritdoc />
/// <remarks>
///     Stores increasing exam times and their corresponding cumulative scores in separate lists.
/// </remarks>
public sealed class DesignExamScoresTrackerPrefixSumWithBinarySearch : IDesignExamScoresTracker
{
    private readonly List<long> _cumulativeScores = [];
    private readonly List<int> _examTimes = [];

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void Record(int time, int score)
    {
        var previousTotalScore = _cumulativeScores.Count > 0 ? _cumulativeScores[^1] : 0;
        var totalScore = previousTotalScore + score;

        _examTimes.Add(time);
        _cumulativeScores.Add(totalScore);
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </remarks>
    public long TotalScore(int startTime, int endTime)
    {
        var firstExamIndex = GetFirstExamIndexAtOrAfter(startTime);
        var lastExamIndex = GetLastExamIndexAtOrBefore(endTime);

        if (firstExamIndex > lastExamIndex)
        {
            return 0;
        }

        var endTotalScore = _cumulativeScores[lastExamIndex];
        var beforeStartTotalScore = firstExamIndex > 0 ? _cumulativeScores[firstExamIndex - 1] : 0;

        return endTotalScore - beforeStartTotalScore;
    }

    /// <summary>
    ///     Returns the first exam index at or after the given time, or the exam count if none exists.
    /// </summary>
    /// <remarks>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </remarks>
    private int GetFirstExamIndexAtOrAfter(int time)
    {
        var searchResult = _examTimes.BinarySearch(time);

        return searchResult >= 0 ? searchResult : ~searchResult;
    }

    /// <summary>
    ///     Returns the last exam index at or before the given time, or -1 if none exists.
    /// </summary>
    /// <remarks>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </remarks>
    private int GetLastExamIndexAtOrBefore(int time)
    {
        var searchResult = _examTimes.BinarySearch(time);

        return searchResult >= 0 ? searchResult : ~searchResult - 1;
    }
}