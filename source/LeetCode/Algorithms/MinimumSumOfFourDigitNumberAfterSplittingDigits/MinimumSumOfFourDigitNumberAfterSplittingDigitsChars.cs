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

namespace LeetCode.Algorithms.MinimumSumOfFourDigitNumberAfterSplittingDigits;

/// <inheritdoc />
public class MinimumSumOfFourDigitNumberAfterSplittingDigitsChars : IMinimumSumOfFourDigitNumberAfterSplittingDigits
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public int MinimumSum(int num)
    {
        var sortedNums = num.ToString().Order().ToArray();

        return ((int)char.GetNumericValue(sortedNums[0]) * 10) +
               ((int)char.GetNumericValue(sortedNums[1]) * 10) +
               (int)char.GetNumericValue(sortedNums[2]) +
               (int)char.GetNumericValue(sortedNums[3]);
    }
}