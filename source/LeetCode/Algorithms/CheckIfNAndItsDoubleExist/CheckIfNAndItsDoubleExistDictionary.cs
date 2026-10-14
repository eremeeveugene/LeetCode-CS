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

namespace LeetCode.Algorithms.CheckIfNAndItsDoubleExist;

/// <inheritdoc />
public sealed class CheckIfNAndItsDoubleExistDictionary : ICheckIfNAndItsDoubleExist
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public bool CheckIfExist(int[] arr)
    {
        var dictionary = new Dictionary<int, int>();

        for (var i = 0; i < arr.Length; i++)
        {
            var item = arr[i];

            if (dictionary.TryGetValue(item, out var value))
            {
                dictionary[item] = value + 1;
            }
            else
            {
                dictionary.Add(item, 1);
            }
        }

        for (var i = 0; i < arr.Length; i++)
        {
            var item = arr[i];

            if (item != 0)
            {
                if (dictionary.ContainsKey(item * 2))
                {
                    return true;
                }
            }
            else
            {
                dictionary.TryGetValue(item, out var value);

                if (value > 1)
                {
                    return true;
                }
            }
        }

        return false;
    }
}