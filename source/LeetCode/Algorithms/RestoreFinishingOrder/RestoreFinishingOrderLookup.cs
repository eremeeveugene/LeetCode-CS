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
public sealed class RestoreFinishingOrderLookup : IRestoreFinishingOrder
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int[] RecoverOrder(int[] order, int[] friends)
    {
        var orderLength = order.Length;
        var friendsLength = friends.Length;

        Span<bool> friendsLookup = stackalloc bool[orderLength];

        for (var i = 0; i < friendsLength; i++)
        {
            friendsLookup[friends[i] - 1] = true;
        }

        var friendsIndex = 0;

        for (var i = 0; i < orderLength && friendsIndex < friendsLength; i++)
        {
            var racer = order[i];

            if (friendsLookup[racer - 1])
            {
                friends[friendsIndex++] = racer;
            }
        }

        return friends;
    }
}