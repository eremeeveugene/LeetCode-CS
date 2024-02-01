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

namespace LeetCode.Algorithms.FindTheMaximumAchievableNumber;

/// <inheritdoc />
public class FindTheMaximumAchievableNumberLinear : IFindTheMaximumAchievableNumber
{
    /// <summary>
    ///     Time complexity - O(1)
    /// </summary>
    /// <param name="num"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    public int TheMaximumAchievableX(int num, int t)
    {
        return num + (t * 2);
    }
}