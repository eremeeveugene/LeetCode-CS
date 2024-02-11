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

namespace LeetCode.Algorithms.SortThePeople;

/// <inheritdoc />
public class SortThePeopleLinq : ISortThePeople
{
    /// <summary>
    ///     Time complexity - O(n log n)
    /// </summary>
    /// <param name="names"></param>
    /// <param name="heights"></param>
    /// <returns></returns>
    public string[] SortPeople(string[] names, int[] heights)
    {
        return names.Zip(heights, (name, height) => new { Name = name, Height = height })
            .OrderByDescending(person => person.Height)
            .Select(person => person.Name)
            .ToArray();
    }
}