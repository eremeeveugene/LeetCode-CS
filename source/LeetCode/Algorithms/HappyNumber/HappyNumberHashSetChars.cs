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
public class HappyNumberHashSetChars : IHappyNumber
{
    /// <summary>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public bool IsHappy(int n)
    {
        if (n == 1)
        {
            return true;
        }

        var hashSet = new HashSet<int>();

        while (n > 1 && !hashSet.Contains(n))
        {
            hashSet.Add(n);
            n = n.ToString().Sum(c => (int)Math.Pow(char.GetNumericValue(c), 2));
        }

        return n == 1;
    }
}