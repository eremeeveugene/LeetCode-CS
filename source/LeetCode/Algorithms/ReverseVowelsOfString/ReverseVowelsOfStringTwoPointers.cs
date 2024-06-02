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

namespace LeetCode.Algorithms.ReverseVowelsOfString;

/// <inheritdoc />
public class ReverseVowelsOfStringTwoPointers : IReverseVowelsOfString
{
    private readonly HashSet<char> _vowelsHashSet =
    [
        'a',
        'e',
        'i',
        'o',
        'u',
        'A',
        'E',
        'I',
        'O',
        'U'
    ];

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public string ReverseVowels(string s)
    {
        var sArray = s.ToCharArray();

        var left = 0;
        var right = s.Length - 1;

        while (left < right)
        {
            if (!_vowelsHashSet.Contains(s[left]))
            {
                left++;

                continue;
            }

            if (!_vowelsHashSet.Contains(s[right]))
            {
                right--;

                continue;
            }

            (sArray[left], sArray[right]) = (sArray[right], sArray[left]);

            left++;
            right--;
        }

        return new string(sArray);
    }
}