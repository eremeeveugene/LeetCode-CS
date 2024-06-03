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

namespace LeetCode.Algorithms.PalindromeNumber;

/// <inheritdoc />
public class PalindromeNumberByReversingDigits : IPalindromeNumber
{
    /// <summary>
    ///     Time complexity - O(d), where d is the number of digits in the integer x
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public bool IsPalindrome(int x)
    {
        switch (x)
        {
            case < 0:
                return false;
            case < 10:
                return true;
        }

        if (x % 10 == 0)
        {
            return false;
        }

        var reversedHalf = 0;

        while (x > reversedHalf)
        {
            reversedHalf = (reversedHalf * 10) + (x % 10);

            x /= 10;
        }

        return x == reversedHalf || x == reversedHalf / 10;
    }
}