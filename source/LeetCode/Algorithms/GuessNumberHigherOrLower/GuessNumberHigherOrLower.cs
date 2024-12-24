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

namespace LeetCode.Algorithms.GuessNumberHigherOrLower;

public abstract class GuessNumberHigherOrLower(int pickedNumber) : IGuessNumberHigherOrLower
{
    public abstract int GuessNumber(int n);

    // ReSharper disable once InconsistentNaming
    public int guess(int num)
    {
        if (num == pickedNumber)
        {
            return 0;
        }

        if (num < pickedNumber)
        {
            return 1;
        }

        return -1;
    }
}