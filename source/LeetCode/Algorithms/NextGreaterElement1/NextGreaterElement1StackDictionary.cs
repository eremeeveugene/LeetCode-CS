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

namespace LeetCode.Algorithms.NextGreaterElement1;

/// <inheritdoc />
public class NextGreaterElement1StackDictionary : INextGreaterElement1
{
    /// <summary>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums1"></param>
    /// <param name="nums2"></param>
    /// <returns></returns>
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        var result = new int[nums1.Length];

        var stack = new Stack<int>();
        var dictionary = new Dictionary<int, int>();

        foreach (var num in nums2)
        {
            while (stack.Count > 0 && stack.Peek() < num)
            {
                dictionary[stack.Pop()] = num;
            }

            stack.Push(num);
        }

        while (stack.Count > 0)
        {
            dictionary[stack.Pop()] = -1;
        }

        for (var i = 0; i < nums1.Length; i++)
        {
            result[i] = dictionary.GetValueOrDefault(nums1[i], -1);
        }

        return result;
    }
}