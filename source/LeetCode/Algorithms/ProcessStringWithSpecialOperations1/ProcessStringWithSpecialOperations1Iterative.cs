// --------------------------------------------------------------------------------
// Copyright (C) 2026 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using System.Text;

namespace LeetCode.Algorithms.ProcessStringWithSpecialOperations1;

/// <inheritdoc />
public sealed class ProcessStringWithSpecialOperations1Iterative : IProcessStringWithSpecialOperations1
{
    /// <summary>
    ///     Time complexity - O(n * m), where n is the length of <c>s</c> and m is the length of the final result
    ///     Space complexity - O(m)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public string ProcessStr(string s)
    {
        var result = new StringBuilder();

        foreach (var character in s)
        {
            switch (character)
            {
                case '*':
                    if (result.Length > 0)
                    {
                        result.Remove(result.Length - 1, 1);
                    }

                    break;
                case '#':
                    result.Append(result);

                    break;
                case '%':
                    Reverse(result);

                    break;
                default:
                    result.Append(character);

                    break;
            }
        }

        return result.ToString();
    }

    private static void Reverse(StringBuilder builder)
    {
        for (int left = 0, right = builder.Length - 1; left < right; left++, right--)
        {
            (builder[left], builder[right]) = (builder[right], builder[left]);
        }
    }
}