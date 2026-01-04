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

namespace LeetCode.Algorithms.MaxDifferenceYouCanGetFromChangingAnInteger;

/// <inheritdoc />
public class MaxDifferenceYouCanGetFromChangingAnIntegerGreedy : IMaxDifferenceYouCanGetFromChangingAnInteger
{
    /// <summary>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public int MaxDiff(int num)
    {
        var mostSignificantPlace = 1;

        while (num / mostSignificantPlace >= 10)
        {
            mostSignificantPlace *= 10;
        }

        var targetForMax = -1;
        var targetForMin = -1;
        var replacementForMin = 0;

        var firstDigit = num / mostSignificantPlace % 10;

        if (firstDigit > 1)
        {
            targetForMin = firstDigit;

            replacementForMin = 1;
        }

        for (var place = mostSignificantPlace; place > 0; place /= 10)
        {
            var digit = num / place % 10;

            if (targetForMax == -1 && digit < 9)
            {
                targetForMax = digit;
            }

            if (targetForMin == -1 && firstDigit <= 1 && place < mostSignificantPlace && digit > 1)
            {
                targetForMin = digit;

                replacementForMin = 0;
            }
        }

        var maxValue = 0;
        var minValue = 0;

        for (var place = mostSignificantPlace; place > 0; place /= 10)
        {
            var digit = num / place % 10;

            maxValue = (maxValue * 10) + ReplaceDigit(digit, targetForMax, 9);
            minValue = (minValue * 10) + ReplaceDigit(digit, targetForMin, replacementForMin);
        }

        return maxValue - minValue;
    }

    private static int ReplaceDigit(int digit, int target, int replacement)
    {
        return digit == target ? replacement : digit;
    }
}