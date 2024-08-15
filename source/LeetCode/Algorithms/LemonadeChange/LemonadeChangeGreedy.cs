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

namespace LeetCode.Algorithms.LemonadeChange;

/// <inheritdoc />
public class LemonadeChangeGreedy : ILemonadeChange
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="bills"></param>
    /// <returns></returns>
    public bool LemonadeChange(int[] bills)
    {
        var fiveBills = 0;
        var tenBills = 0;

        foreach (var bill in bills)
        {
            switch (bill)
            {
                case 5:
                    fiveBills++;

                    break;
                case 10 when fiveBills > 0:
                    fiveBills--;
                    tenBills++;

                    break;
                case 10:
                    return false;
                case 20:
                    switch (fiveBills)
                    {
                        case > 0 when tenBills > 0:
                            fiveBills--;
                            tenBills--;
                            break;
                        case > 2:
                            fiveBills -= 3;
                            break;
                        default:
                            return false;
                    }

                    break;
            }
        }

        return true;
    }
}