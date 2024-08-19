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

namespace LeetCode.Algorithms.TwoKeysKeyboard;

/// <inheritdoc />
public class TwoKeysKeyboardSimulation : ITwoKeysKeyboard
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int MinSteps(int n)
    {
        var minSteps = 0;
        var currentN = 1;
        var copiedCount = 0;

        var paste = false;

        while (currentN < n)
        {
            if (paste)
            {
                currentN += copiedCount;
                minSteps++;

                paste = false;
            }
            else
            {
                if (copiedCount > 0)
                {
                    if (n % currentN == 0)
                    {
                        copiedCount = currentN;
                        minSteps++;
                    }
                }
                else
                {
                    copiedCount = 1;
                    minSteps++;
                }

                paste = true;
            }
        }

        return minSteps;
    }
}