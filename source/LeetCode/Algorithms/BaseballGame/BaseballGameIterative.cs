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

namespace LeetCode.Algorithms.BaseballGame;

/// <inheritdoc />
public class BaseballGameIterative : IBaseballGame
{
    public int CalPoints(string[] operations)
    {
        var scores = new List<int>();

        foreach (var operation in operations)
        {
            switch (operation)
            {
                case "D":
                    scores.Add(scores[^1] * 2);
                    break;
                case "C":
                    scores.RemoveAt(scores.Count - 1);
                    break;
                case "+":
                    scores.Add(scores[^1] + scores[^2]);
                    break;
                default:
                    scores.Add(int.Parse(operation));
                    break;
            }
        }

        return scores.Sum();
    }
}