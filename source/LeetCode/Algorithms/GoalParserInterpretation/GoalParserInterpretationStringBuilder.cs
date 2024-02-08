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

using System.Text;

namespace LeetCode.Algorithms.GoalParserInterpretation;

/// <inheritdoc />
public class GoalParserInterpretationStringBuilder : IGoalParserInterpretation
{
    /// <summary>
    ///     Time complexity - O(n)
    /// </summary>
    /// <param name="command"></param>
    /// <returns></returns>
    public string Interpret(string command)
    {
        var stringBuilder = new StringBuilder();

        for (var i = 0; i < command.Length; i++)
        {
            if (i < command.Length - 1)
            {
                switch (command[i])
                {
                    case '(' when command[i + 1] == ')':
                        stringBuilder.Append('o');
                        i++;
                        break;
                    case '(':
                        stringBuilder.Append("al");
                        i += 3;
                        break;
                    default:
                        stringBuilder.Append(command[i]);
                        break;
                }
            }
            else
            {
                stringBuilder.Append(command[i]);
            }
        }

        return stringBuilder.ToString();
    }
}