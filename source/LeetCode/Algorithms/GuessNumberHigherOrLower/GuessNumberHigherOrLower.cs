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

namespace LeetCode.Algorithms.GuessNumberHigherOrLower;

public abstract class GuessNumberHigherOrLower : IGuessNumberHigherOrLower
{
    private readonly int _pickedNumber;

    protected GuessNumberHigherOrLower(int pickedNumber)
    {
        _pickedNumber = pickedNumber;
    }

    public abstract int GuessNumber(int n);

    public int Guess(int num)
    {
        if (num == _pickedNumber)
        {
            return 0;
        }

        if (num < _pickedNumber)
        {
            return 1;
        }

        return -1;
    }
}