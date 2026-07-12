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

namespace LeetCode.Algorithms.ToggleLightBulbs;

/// <inheritdoc />
public sealed class ToggleLightBulbsLookup : IToggleLightBulbs
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public IList<int> ToggleLightBulbs(IList<int> bulbs)
    {
        Span<bool> bulbsLookup = stackalloc bool[101];

        for (var i = 0; i < bulbs.Count; i++)
        {
            var bulb = bulbs[i];

            bulbsLookup[bulb] = !bulbsLookup[bulb];
        }

        bulbs.Clear();

        for (var i = 1; i < bulbsLookup.Length; i++)
        {
            if (bulbsLookup[i])
            {
                bulbs.Add(i);
            }
        }

        return bulbs;
    }
}