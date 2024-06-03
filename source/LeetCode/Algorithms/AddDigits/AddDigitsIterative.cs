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

namespace LeetCode.Algorithms.AddDigits;

/// <inheritdoc />
public class AddDigitsIterative : IAddDigits
{
    /// <summary>
    ///     Time complexity - O(log(n))
    ///     Space complexity - O(log(n))
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public int AddDigits(int num)
    {
        while (num > 9)
        {
            num = num.ToString().Sum(c => (int)char.GetNumericValue(c));
        }

        return num;
    }
}