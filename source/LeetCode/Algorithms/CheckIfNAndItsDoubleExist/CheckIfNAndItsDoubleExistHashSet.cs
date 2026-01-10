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
public sealed class CheckIfNAndItsDoubleExistHashSet : ICheckIfNAndItsDoubleExist
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public bool CheckIfExist(int[] arr)
    {
        var hashSet = new HashSet<int>();

        foreach (var item in arr)
        {
            if (hashSet.Contains(item * 2) || (item % 2 == 0 && hashSet.Contains(item / 2)))
            {
                return true;
            }

            hashSet.Add(item);
        }

        return false;
    }
}