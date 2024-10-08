﻿// --------------------------------------------------------------------------------
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

internal class SubtractiveRomanNumeral(RomanSymbol firstSymbol, RomanSymbol secondSymbol, int value)
    : RomanNumeral(firstSymbol,
        value)
{
    private static List<SubtractiveRomanNumeral>? _subtractiveRomanNumerals;

    public RomanSymbol SecondSymbol { get; } = secondSymbol;

    public static SubtractiveRomanNumeral IV => new(RomanSymbol.I, RomanSymbol.V, 4);
    public static SubtractiveRomanNumeral IX => new(RomanSymbol.I, RomanSymbol.X, 9);
    public static SubtractiveRomanNumeral XL => new(RomanSymbol.X, RomanSymbol.L, 40);
    public static SubtractiveRomanNumeral XC => new(RomanSymbol.X, RomanSymbol.C, 90);
    public static SubtractiveRomanNumeral CD => new(RomanSymbol.C, RomanSymbol.D, 400);
    public static SubtractiveRomanNumeral CM => new(RomanSymbol.C, RomanSymbol.M, 900);

    public static List<SubtractiveRomanNumeral> SubtractiveRomanNumerals =>
        _subtractiveRomanNumerals ??= GetSubtractiveRomanNumerals();

    public override string ToString()
    {
        return Symbol.ToString() + SecondSymbol;
    }

    private static List<SubtractiveRomanNumeral> GetSubtractiveRomanNumerals()
    {
        return
        [
            IV,
            IX,
            XC,
            XL,
            CD,
            CM
        ];
    }
}