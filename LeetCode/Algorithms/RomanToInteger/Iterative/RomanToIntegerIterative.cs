// --------------------------------------------------------------------------------
// Copyright (C) 2023 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.RomanToIntegerTask.Iterative;

/// <summary>
///     Roman to Integer
///     https://leetcode.com/problems/roman-to-integer/
///     Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
///     Symbol       Value
///     I             1
///     V             5
///     X             10
///     L             50
///     C             100
///     D             500
///     M             1000
///     For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is
///     simply X + II. The number 27 is written as XXVII, which is XX + V + II.
///     Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not
///     IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The
///     same principle applies to the number nine, which is written as IX. There are six instances where subtraction is
///     used:
///     I can be placed before V (5) and X (10) to make 4 and 9.
///     X can be placed before L (50) and C (100) to make 40 and 90.
///     C can be placed before D (500) and M (1000) to make 400 and 900.
///     Given a roman numeral, convert it to an integer.
///     Example 1:
///     Input: s = "III"
///     Output: 3
///     Explanation: III = 3.
///     Example 2:
///     Input: s = "LVIII"
///     Output: 58
///     Explanation: L = 50, V= 5, III = 3.
///     Example 3:
///     Input: s = "MCMXCIV"
///     Output: 1994
///     Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
///     Constraints:
///     1 less than or equal to s.length less than or equal to 15
///     s contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').
///     It is guaranteed that s is a valid roman numeral in the range [1, 3999].
/// </summary>
public static class RomanToIntegerIterative
{
    public static int GetResult(string romanString)
    {
        var romanNumerals = new List<RomanNumeral>();

        for (var i = 0; i < romanString.Length; i++)
        {
            var currentChar = romanString.ElementAt(i);
            var nextChar = romanString.ElementAtOrDefault(i + 1);

            var subtractiveRomanNumeral = SubtractiveRomanNumeral.SubtractiveRomanNumerals.FirstOrDefault(
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