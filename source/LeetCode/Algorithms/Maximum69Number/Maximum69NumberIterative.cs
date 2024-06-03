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

namespace LeetCode.Algorithms.Maximum69Number;

/// <inheritdoc />
public class Maximum69NumberIterative : IMaximum69Number
{
    /// <summary>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public int Maximum69Number(int num)
    {
        var multiplier = 1;
        var maximum = 9;

        while (num != maximum)
        {
            if (num < maximum)
            {
                if (num + (3 * multiplier) > maximum)
                {
                    if (num + (3 * multiplier / 10) > maximum)
                    {
                        multiplier /= 10;
                    }
                    else
                    {
                        return num + (3 * multiplier / 10);
                    }
                }
                else
                {
                    return num + (3 * multiplier);
                }
            }
            else
            {
                multiplier *= 10;
                maximum = (maximum * 10) + 9;
            }
        }

        return num;
    }
}