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

namespace LeetCode.Algorithms.ShortestDistanceToTargetStringInCircularArray;

/// <inheritdoc />
public sealed class ShortestDistanceToTargetStringInCircularArrayIterative : IShortestDistanceToTargetStringInCircularArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int ClosestTarget(string[] words, string target, int startIndex)
    {
        var closestDistance = int.MaxValue;
        var targetFound = false;

        for (var i = 0; i < words.Length; i++)
        {
            if (words[i] != target)
            {
                continue;
            }

            targetFound = true;

            var directDistance = Math.Abs(i - startIndex);
            var circularDistance = words.Length - directDistance;
            var distance = Math.Min(directDistance, circularDistance);

            closestDistance = Math.Min(closestDistance, distance);
        }

        return targetFound ? closestDistance : -1;
    }
}