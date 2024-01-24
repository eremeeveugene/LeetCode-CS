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

namespace LeetCode.Algorithms.HappyNumber;

/// <inheritdoc />
public class HappyNumber1 : IHappyNumber
{
    private readonly HashSet<int> _hashSet = [];

    public bool IsHappy(int n)
    {
        if (n == 1)
        {
            return true;
        }

        while (n > 1)
        {
            n = n.ToString().Sum(c => (int)Math.Pow(char.GetNumericValue(c), 2));

            if (!_hashSet.Add(n))
            {
                break;
            }
        }

        return n == 1;
    }
}