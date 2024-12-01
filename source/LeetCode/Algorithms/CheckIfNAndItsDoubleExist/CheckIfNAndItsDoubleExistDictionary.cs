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

namespace LeetCode.Algorithms.CheckIfNAndItsDoubleExist;

/// <inheritdoc />
public class CheckIfNAndItsDoubleExistDictionary : ICheckIfNAndItsDoubleExist
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public bool CheckIfExist(int[] arr)
    {
        var dictionary = new Dictionary<int, int>();

        foreach (var item in arr)
        {
            if (dictionary.TryGetValue(item, out var value))
            {
                dictionary[item] = value + 1;
            }
            else
            {
                dictionary.Add(item, 1);
            }
        }

        foreach (var item in arr)
        {
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