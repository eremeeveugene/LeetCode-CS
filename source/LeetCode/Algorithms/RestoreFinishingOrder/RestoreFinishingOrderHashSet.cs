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

namespace LeetCode.Algorithms.RestoreFinishingOrder;

/// <inheritdoc />
public sealed class RestoreFinishingOrderHashSet : IRestoreFinishingOrder
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int[] RecoverOrder(int[] order, int[] friends)
    {
        var n = order.Length;
        var m = friends.Length;

        var friendsIndex = 0;
        var friendsHashSet = new HashSet<int>(friends);

        for (var i = 0; i < n; i++)
        {
            if (friendsIndex >= m)
            {
                break;
            }

            var racer = order[i];

            if (!friendsHashSet.Contains(racer))
            {
                continue;
            }

            friends[friendsIndex] = racer;

            friendsIndex++;
        }

        return friends;
    }
}