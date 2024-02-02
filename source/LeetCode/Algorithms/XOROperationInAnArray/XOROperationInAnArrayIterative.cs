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

namespace LeetCode.Algorithms.XOROperationInAnArray;

/// <inheritdoc />
public class XOROperationInAnArrayIterative : IXOROperationInAnArray
{
    public int XorOperation(int n, int start)
    {
        var result = 0;

        for (var i = 0; i < n; i++)
        {
            result ^= start + (2 * i);
        }

        return result;
    }
}