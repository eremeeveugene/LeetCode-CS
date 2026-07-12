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

namespace LeetCode.Algorithms.RabbitsInForest;

/// <inheritdoc />
public sealed class RabbitsInForestFrequencyArray : IRabbitsInForest
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int NumRabbits(int[] answers)
    {
        var frequencyArray = new int[1000];

        foreach (var answer in answers)
        {
            frequencyArray[answer]++;
        }

        var rabbits = 0;

        for (var i = 0; i < frequencyArray.Length; i++)
        {
            if (frequencyArray[i] == 0)
            {
                continue;
            }

            var groupSize = i + 1;
            var groups = (frequencyArray[i] + groupSize - 1) / groupSize;

            rabbits += groups * groupSize;
        }

        return rabbits;
    }
}