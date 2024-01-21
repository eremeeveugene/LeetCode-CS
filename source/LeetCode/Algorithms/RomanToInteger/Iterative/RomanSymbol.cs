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

internal class RomanSymbol(char @char)
{
    public char Char { get; } = @char;

    public static RomanSymbol I => new(RomanChars.I);
    public static RomanSymbol V => new(RomanChars.V);
    public static RomanSymbol X => new(RomanChars.X);
    public static RomanSymbol L => new(RomanChars.L);
    public static RomanSymbol C => new(RomanChars.C);
    public static RomanSymbol D => new(RomanChars.D);
    public static RomanSymbol M => new(RomanChars.M);

    public override string ToString()
    {
        return Char.ToString();
    }

    public override bool Equals(object? @object)
    {
        if (@object is RomanSymbol romanSymbol)
        {
            return Equals(romanSymbol);
        }

        return Equals(this, @object);
    }

    protected bool Equals(RomanSymbol romanSymbol)
    {
        return Char == romanSymbol.Char;
    }

    public override int GetHashCode()
    {
        return Char.GetHashCode();
    }
}