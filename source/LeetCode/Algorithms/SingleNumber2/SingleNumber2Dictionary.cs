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

namespace LeetCode.Algorithms.SingleNumber2;

/// <inheritdoc />
public class SingleNumber2Dictionary : ISingleNumber2
{
    public int SingleNumber(int[] nums)
    {
        var numsDictionary = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (numsDictionary.TryAdd(num, 1))
            {
            }
            else
            {
                numsDictionary[num]++;
            }
        }

        return numsDictionary.First(num => num.Value < 3).Key;
    }
}