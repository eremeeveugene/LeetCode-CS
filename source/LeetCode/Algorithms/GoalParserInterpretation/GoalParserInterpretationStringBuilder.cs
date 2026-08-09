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

namespace LeetCode.Algorithms.GoalParserInterpretation;

/// <inheritdoc />
public sealed class GoalParserInterpretationStringBuilder : IGoalParserInterpretation
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public string Interpret(string command)
    {
        var stringBuilder = new StringBuilder();

        var i = 0;

        while (i < command.Length)
        {
            if (i < command.Length - 1)
            {
                switch (command[i])
                {
                    case '(' when command[i + 1] == ')':
                        stringBuilder.Append('o');
                        i += 2;
                        break;
                    case '(':
                        stringBuilder.Append("al");
                        i += 4;
                        break;
                    default:
                        stringBuilder.Append(command[i]);
                        i++;
                        break;
                }
            }
            else
            {
                stringBuilder.Append(command[i]);

                i++;
            }
        }

        return stringBuilder.ToString();
    }
}