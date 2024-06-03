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

namespace LeetCode.Algorithms.DistributeMoneyToMaximumChildren;

/// <inheritdoc />
public class DistributeMoneyToMaximumChildrenLinear : IDistributeMoneyToMaximumChildren
{
    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="money"></param>
    /// <param name="children"></param>
    /// <returns></returns>
    public int DistMoney(int money, int children)
    {
        if (money < children)
        {
            return -1;
        }

        money -= children;

        var max = money / 7;
        var rest = money % 7;

        if (max == children)
        {
            return rest == 0 ? children : children - 1;
        }

        if (max < children)
        {
            return rest == 3 && children - max == 1 ? max - 1 : max;
        }

        return children - 1;
    }
}