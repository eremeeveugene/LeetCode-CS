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

using LeetCode.Core.Models;

namespace LeetCode.Algorithms.FindTheMinimumAndMaximumNumberOfNodesBetweenCriticalPoints;

/// <inheritdoc />
public class FindTheMinimumAndMaximumNumberOfNodesBetweenCriticalPointsIterative :
    IFindTheMinimumAndMaximumNumberOfNodesBetweenCriticalPoints
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public int[] NodesBetweenCriticalPoints(ListNode? head)
    {
        if (head?.next?.next == null)
        {
            return [-1, -1];
        }

        var criticalPoints = new List<int>();
        var prev = head;
        var curr = head.next;
        var next = head.next.next;

        var index = 1;

        while (next != null)
        {
            if ((curr.val > prev.val && curr.val > next.val) || (curr.val < prev.val && curr.val < next.val))
            {
                criticalPoints.Add(index);
            }

            prev = curr;
            curr = next;
            next = next.next;
            index++;
        }

        if (criticalPoints.Count < 2)
        {
            return [-1, -1];
        }

        var minDistance = int.MaxValue;
        var maxDistance = criticalPoints[^1] - criticalPoints[0];

        for (var i = 1; i < criticalPoints.Count; i++)
        {
            minDistance = Math.Min(minDistance, criticalPoints[i] - criticalPoints[i - 1]);
        }

        return [minDistance, maxDistance];
    }
}