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

namespace LeetCode.Algorithms.ButtonWithLongestPushTime;

/// <inheritdoc />
public class ButtonWithLongestPushTimeIterative : IButtonWithLongestPushTime
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="events"></param>
    /// <returns></returns>
    public int ButtonWithLongestTime(int[][] events)
    {
        var resultIndex = events[0][0];
        var longestTime = events[0][1];

        for (var i = 1; i < events.Length; i++)
        {
            var index = events[i][0];
            var time = events[i][1];
            var previousTime = events[i - 1][1];
            var currentTime = time - previousTime;

            if (currentTime < longestTime || (currentTime == longestTime && index >= resultIndex))
            {
                continue;
            }

            longestTime = currentTime;
            resultIndex = index;
        }

        return resultIndex;
    }
}