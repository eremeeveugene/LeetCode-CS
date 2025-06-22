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

namespace LeetCode.Algorithms.DivideStringIntoGroupsOfSizeK;

/// <inheritdoc />
public class DivideStringIntoGroupsOfSizeKSimulation : IDivideStringIntoGroupsOfSizeK
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <param name="k"></param>
    /// <param name="fill"></param>
    /// <returns></returns>
    public string[] DivideString(string s, int k, char fill)
    {
        var groupsCount = (int)Math.Ceiling(s.Length / (double)k);

        var result = new string[groupsCount];

        var sIndex = 0;

        for (var i = 0; i < groupsCount; i++)
        {
            var stringBuilder = new StringBuilder();

            for (var j = 0; j < k; j++)
            {
                if (sIndex < s.Length)
                {
                    stringBuilder.Append(s[sIndex]);

                    sIndex++;
                }
                else
                {
                    stringBuilder.Append(fill);
                }
            }

            result[i] = stringBuilder.ToString();
        }

        return result;
    }
}