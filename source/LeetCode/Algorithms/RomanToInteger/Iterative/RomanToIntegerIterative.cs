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

namespace LeetCode.Algorithms.RomanToInteger.Iterative;

/// <summary>
///     https://leetcode.com/problems/roman-to-integer/description/
/// </summary>
public static class RomanToIntegerIterative
{
    public static int GetResult(string romanString)
    {
        List<RomanNumeral> romanNumerals = new();

        for (var i = 0; i < romanString.Length; i++)
        {
            var currentChar = romanString.ElementAt(i);
            var nextChar = romanString.ElementAtOrDefault(i + 1);

            var subtractiveRomanNumeral =
                SubtractiveRomanNumeral.SubtractiveRomanNumerals.FirstOrDefault(
                    s => s.Symbol.Char.Equals(currentChar) && s.SecondSymbol.Char.Equals(nextChar));

            if (subtractiveRomanNumeral != null)
            {
                romanNumerals.Add(subtractiveRomanNumeral);
                i++;
            }
            else
            {
                romanNumerals.Add(RomanNumeral.RomanNumerals.First(s => s.Symbol.Char.Equals(currentChar)));
            }
        }

        return romanNumerals.Sum(romanNumeral => romanNumeral.Value);
    }
}