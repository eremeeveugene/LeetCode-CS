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

namespace LeetCode.Algorithms.ArrangingCoins;

/// <inheritdoc />
public class ArrangingCoinsIterative : IArrangingCoins
{
    /// <summary>
    ///     Time complexity - O(sqrt n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int ArrangeCoins(int n)
    {
        var i = 1;

        while (n - i >= 0)
        {
            n -= i;

            i++;
        }

        return i - 1;
    }
}