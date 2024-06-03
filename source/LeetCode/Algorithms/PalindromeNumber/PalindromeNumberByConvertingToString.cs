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
public class PalindromeNumberByConvertingToString : IPalindromeNumber
{
    /// <summary>
    ///     Time complexity - O(d), where d is the number of digits in the integer x
    ///     Space complexity - O(d), where d is the number of digits in the integer x
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

        var xString = x.ToString();
        var i = 0;
        var j = xString.Length - 1;

        while (i < j)
        {
            if (xString[i].Equals(xString[j]))
            {
                i++;
                j--;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}