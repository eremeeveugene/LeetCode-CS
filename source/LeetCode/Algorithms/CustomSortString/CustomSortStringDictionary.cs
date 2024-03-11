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

namespace LeetCode.Algorithms.CustomSortString;

/// <inheritdoc />
public class CustomSortStringDictionary : ICustomSortString
{
    /// <summary>
    ///     Time complexity - O (m log m + n)
    ///     Space complexity -  O (n + n)
    ///     Where m is the length of the 's' string and n is the length of the 'order' string
    /// </summary>
    /// <param name="order"></param>
    /// <param name="s"></param>
    /// <returns></returns>
    public string CustomSortString(string order, string s)
    {
        var orderDictionary = new Dictionary<char, int>();

        for (var i = 0; i < order.Length; i++)
        {
            orderDictionary[order[i]] = i;
        }

        var sortedChars = s.ToList();

        sortedChars.Sort((x, y) =>
        {
            var orderX = orderDictionary.GetValueOrDefault(x, int.MaxValue);
            var orderY = orderDictionary.GetValueOrDefault(y, int.MaxValue);

            return orderX.CompareTo(orderY);
        });

        return new string(sortedChars.ToArray());
    }
}