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

internal class RomanNumeral
{
    private static List<RomanNumeral>? _romanNumerals;

    public RomanNumeral(RomanSymbol symbol, int value)
    {
        Symbol = symbol;
        Value = value;
    }

    public RomanSymbol Symbol { get; }
    public int Value { get; }

    public static RomanNumeral I => new(RomanSymbol.I, 1);
    public static RomanNumeral V => new(RomanSymbol.V, 5);
    public static RomanNumeral X => new(RomanSymbol.X, 10);
    public static RomanNumeral L => new(RomanSymbol.L, 50);
    public static RomanNumeral C => new(RomanSymbol.C, 100);
    public static RomanNumeral D => new(RomanSymbol.D, 500);
    public static RomanNumeral M => new(RomanSymbol.M, 1000);

    public static List<RomanNumeral> RomanNumerals => _romanNumerals ??= GetRomanNumerals();

    public override string ToString()
    {
        return Symbol.ToString();
    }

    private static List<RomanNumeral> GetRomanNumerals()
    {
        return new List<RomanNumeral>
        {
            I,
            V,
            X,
            L,
            C,
            D,
            M
        };
    }
}