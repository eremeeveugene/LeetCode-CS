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

namespace LeetCode.Algorithms.ReverseLettersThenSpecialCharactersInString;

/// <inheritdoc />
public sealed class ReverseLettersThenSpecialCharactersInStringTwoPointers : IReverseLettersThenSpecialCharactersInString
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public string ReverseByType(string s)
    {
        var charArray = s.ToCharArray();

        var left = 0;
        var right = charArray.Length - 1;

        while (left < right)
        {
            while (left < right && !char.IsLetter(charArray[left]))
            {
                left++;
            }

            while (left < right && !char.IsLetter(charArray[right]))
            {
                right--;
            }

            if (left >= right)
            {
                break;
            }

            (charArray[left], charArray[right]) = (charArray[right], charArray[left]);

            left++;
            right--;
        }

        left = 0;
        right = charArray.Length - 1;

        while (left < right)
        {
            while (left < right && char.IsLetter(charArray[left]))
            {
                left++;
            }

            while (left < right && char.IsLetter(charArray[right]))
            {
                right--;
            }

            if (left >= right)
            {
                continue;
            }

            (charArray[left], charArray[right]) = (charArray[right], charArray[left]);

            left++;
            right--;
        }

        return new string(charArray);
    }
}