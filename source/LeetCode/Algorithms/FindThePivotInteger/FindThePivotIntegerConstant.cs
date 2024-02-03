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

namespace LeetCode.Algorithms.FindThePivotInteger;

/// <inheritdoc />
public class FindThePivotIntegerConstant : IFindThePivotInteger
{
    public int PivotInteger(int n)
    {
        var t = Math.Sqrt(n * (n + 1) / 2.0);

        var r = (int)t;

        return Math.Abs(t - r) < double.Epsilon ? r : -1;
    }
}