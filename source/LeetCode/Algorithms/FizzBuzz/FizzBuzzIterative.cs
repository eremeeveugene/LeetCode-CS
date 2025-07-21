// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.FizzBuzz;

/// <inheritdoc />
public class FizzBuzzIterative : IFizzBuzz
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public IList<string> FizzBuzz(int n)
    {
        var values = new string[n];

        for (var i = 1; i <= n; i++)
        {
            values[i - 1] = GetValue(i);
        }

        return values;
    }

    private static string GetValue(int i)
    {
        if (i % 15 == 0)
        {
            return "FizzBuzz";
        }

        if (i % 3 == 0)
        {
            return "Fizz";
        }

        return i % 5 == 0 ? "Buzz" : i.ToString();
    }
}