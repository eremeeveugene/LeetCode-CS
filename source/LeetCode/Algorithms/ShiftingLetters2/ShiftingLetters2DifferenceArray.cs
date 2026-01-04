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

using System.Text;

namespace LeetCode.Algorithms.ShiftingLetters2;

/// <inheritdoc />
public class ShiftingLetters2DifferenceArray : IShiftingLetters2
{
    private const int LettersCount = 'z' - 'a' + 1;

    /// <summary>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <param name="shifts"></param>
    /// <returns></returns>
    public string ShiftingLetters(string s, int[][] shifts)
    {
        var differenceArray = new int[s.Length];

        foreach (var shift in shifts)
        {
            var start = shift[0];
            var end = shift[1];
            var direction = shift[2];

            if (direction == 0)
            {
                differenceArray[start]--;

                if (end + 1 < s.Length)
                {
                    differenceArray[end + 1]++;
                }
            }
            else
            {
                differenceArray[start]++;

                if (end + 1 < s.Length)
                {
                    differenceArray[end + 1]--;
                }
            }
        }

        var numberOfShifts = 0;

        var result = new StringBuilder(s);

        for (var i = 0; i < differenceArray.Length; i++)
        {
            numberOfShifts = (numberOfShifts + differenceArray[i]) % LettersCount;

            if (numberOfShifts < 0)
            {
                numberOfShifts += LettersCount;
            }

            result[i] = (char)('a' + ((s[i] - 'a' + numberOfShifts) % LettersCount));
        }

        return result.ToString();
    }
}