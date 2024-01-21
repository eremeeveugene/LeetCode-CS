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

namespace LeetCode.Algorithms.HowManyNumbersAreSmallerThanTheCurrentNumber;

/// <summary>
///     https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/description/
/// </summary>
public interface IHowManyNumbersAreSmallerThanTheCurrentNumber
{
    int[] SmallerNumbersThanCurrent(int[] nums);
}