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

namespace LeetCode.Algorithms.TakeGiftsFromTheRichestPile;

/// <inheritdoc />
public sealed class TakeGiftsFromTheRichestPilePriorityQueue : ITakeGiftsFromTheRichestPile
{
    /// <summary>
    ///     Time complexity - O((n + k) * log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="gifts"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public long PickGifts(int[] gifts, int k)
    {
        var giftsPriorityQueue = new PriorityQueue<int, int>();

        foreach (var gift in gifts)
        {
            giftsPriorityQueue.Enqueue(gift, -gift);
        }

        for (var i = 0; i < k; i++)
        {
            var gift = giftsPriorityQueue.Dequeue();

            gift = (int)Math.Sqrt(gift);

            giftsPriorityQueue.Enqueue(gift, -gift);
        }

        long remainingGifts = 0;

        while (giftsPriorityQueue.Count > 0)
        {
            var gift = giftsPriorityQueue.Dequeue();

            remainingGifts += gift;
        }

        return remainingGifts;
    }
}