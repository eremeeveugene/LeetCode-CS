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

namespace LeetCode.Algorithms.CanMakeArithmeticProgressionFromSequence;

/// <inheritdoc />
public sealed class CanMakeArithmeticProgressionFromSequenceSorting : ICanMakeArithmeticProgressionFromSequence
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(log n)
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public bool CanMakeArithmeticProgression(int[] arr)
    {
        if (arr.Length < 3)
        {
            return true;
        }

        Array.Sort(arr);

        var difference = arr[1] - arr[0];

        for (var i = 2; i < arr.Length; i++)
        {
            if (arr[i] - arr[i - 1] != difference)
            {
                return false;
            }
        }

        return true;
    }
}