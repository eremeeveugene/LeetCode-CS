// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.LargestThreeSameDigitNumberInString;

/// <inheritdoc />
public class LargestThreeSameDigitNumberInStringGreedy : ILargestThreeSameDigitNumberInString
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public string LargestGoodInteger(string num)
    {
        var maxChar = '\0';

        for (var i = 0; i <= num.Length - 3; i++)
        {
            if (num[i] == num[i + 1] && num[i] == num[i + 2] && num[i] > maxChar)
            {
                maxChar = num[i];
            }
        }

        return maxChar == '\0' ? "" : new string(maxChar, 3);
    }
}