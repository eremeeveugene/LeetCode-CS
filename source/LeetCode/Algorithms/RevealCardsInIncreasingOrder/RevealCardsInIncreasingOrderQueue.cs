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

namespace LeetCode.Algorithms.RevealCardsInIncreasingOrder;

/// <inheritdoc />
public sealed class RevealCardsInIncreasingOrderQueue : IRevealCardsInIncreasingOrder
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int[] DeckRevealedIncreasing(int[] deck)
    {
        Array.Sort(deck);

        var queue = new Queue<int>();

        for (var i = deck.Length - 1; i >= 0; i--)
        {
            if (queue.Count > 0)
            {
                queue.Enqueue(queue.Dequeue());
            }

            queue.Enqueue(deck[i]);
        }

        return queue.Reverse().ToArray();
    }
}