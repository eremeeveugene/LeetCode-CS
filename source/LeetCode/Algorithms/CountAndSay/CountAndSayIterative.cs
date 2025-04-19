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

using System.Text;

namespace LeetCode.Algorithms.CountAndSay;

/// <inheritdoc />
public class CountAndSayIterative : ICountAndSay
{
    /// <summary>
    ///     Time complexity - O(2^n)
    ///     Space complexity - O(2^n)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public string CountAndSay(int n)
    {
        var result = "1";

        for (var i = 1; i < n; i++)
        {
            var stringBuilder = new StringBuilder();

            var previous = result[0];
            var count = 1;

            for (var j = 1; j < result.Length; j++)
            {
                if (previous == result[j])
                {
                    count++;
                }
                else
                {
                    stringBuilder.Append(count);
                    stringBuilder.Append(previous);

                    previous = result[j];
                    count = 1;
                }
            }

            stringBuilder.Append(count);
            stringBuilder.Append(previous);

            result = stringBuilder.ToString();
        }

        return result;
    }
}