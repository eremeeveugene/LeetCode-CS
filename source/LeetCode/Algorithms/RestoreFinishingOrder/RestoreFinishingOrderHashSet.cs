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
public class RestoreFinishingOrderHashSet : IRestoreFinishingOrder
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="orders"></param>
    /// <param name="friends"></param>
    /// <returns></returns>
    public int[] RecoverOrder(int[] orders, int[] friends)
    {
        var friendsHashSet = new HashSet<int>(friends);

        var friendsIndex = 0;

        foreach (var order in orders)
        {
            if (!friendsHashSet.Contains(order))
            {
                continue;
            }

            friends[friendsIndex++] = order;

            if (friendsIndex == friends.Length)
            {
                break;
            }
        }

        return friends;
    }
}