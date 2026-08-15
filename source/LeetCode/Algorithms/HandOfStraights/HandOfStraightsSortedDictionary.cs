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

namespace LeetCode.Algorithms.HandOfStraights;

/// <inheritdoc />
public sealed class HandOfStraightsSortedDictionary : IHandOfStraights
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </remarks>
    public bool IsNStraightHand(int[] hand, int groupSize)
    {
        if (hand.Length % groupSize != 0)
        {
            return false;
        }

        var cardsDictionary = new SortedDictionary<int, int>();

        for (var i = 0; i < hand.Length; i++)
        {
            var card = hand[i];

            if (!cardsDictionary.TryAdd(card, 1))
            {
                cardsDictionary[card]++;
            }
        }

        while (cardsDictionary.Count > 0)
        {
            var firstCard = cardsDictionary.First().Key;

            if (!TryRemoveGroup(cardsDictionary, firstCard, groupSize))
            {
                return false;
            }
        }

        return true;
    }

    private static bool TryRemoveGroup(SortedDictionary<int, int> cardsDictionary, int firstCard, int groupSize)
    {
        for (var i = 0; i < groupSize; i++)
        {
            var currentCard = firstCard + i;

            if (!cardsDictionary.TryGetValue(currentCard, out var value))
            {
                return false;
            }

            if (value == 1)
            {
                cardsDictionary.Remove(currentCard);
            }
            else
            {
                cardsDictionary[currentCard] = value - 1;
            }
        }

        return true;
    }
}