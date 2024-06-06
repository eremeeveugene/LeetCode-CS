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

namespace LeetCode.Algorithms.HandOfStraights;

/// <inheritdoc />
public class HandOfStraightsDictionary : IHandOfStraights
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="hand"></param>
    /// <param name="groupSize"></param>
    /// <returns></returns>
    public bool IsNStraightHand(int[] hand, int groupSize)
    {
        if (hand.Length % groupSize != 0)
        {
            return false;
        }

        Array.Sort(hand);

        var cardsDictionary = new Dictionary<int, int>();

        foreach (var card in hand)
        {
            if (!cardsDictionary.TryAdd(card, 1))
            {
                cardsDictionary[card]++;
            }
        }

        while (cardsDictionary.Count > 0)
        {
            var firstCard = cardsDictionary.First().Key;

            for (var i = 0; i < groupSize; i++)
            {
                var currentCard = firstCard + i;

                if (cardsDictionary.TryGetValue(currentCard, out var value))
                {
                    if (value == 1)
                    {
                        cardsDictionary.Remove(currentCard);
                    }
                    else
                    {
                        cardsDictionary[currentCard] = value - 1;
                    }
                }
                else
                {
                    return false;
                }
            }
        }

        return true;
    }
}