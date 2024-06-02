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

namespace LeetCode.Algorithms.FaultyKeyboard;

/// <inheritdoc />
public class FaultyKeyboardStringBuilder : IFaultyKeyboard
{
    public string FinalString(string s)
    {
        var stringBuilder = new StringBuilder();

        foreach (var c in s)
        {
            if (c == 'i')
            {
                var left = 0;
                var right = stringBuilder.Length - 1;

                while (left < right)
                {
                    (stringBuilder[left], stringBuilder[right]) = (stringBuilder[right], stringBuilder[left]);

                    left++;
                    right--;
                }
            }
            else
            {
                stringBuilder.Append(c);
            }
        }

        return stringBuilder.ToString();
    }
}