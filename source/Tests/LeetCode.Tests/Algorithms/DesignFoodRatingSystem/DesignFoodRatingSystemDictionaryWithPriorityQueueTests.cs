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

using LeetCode.Algorithms.DesignFoodRatingSystem;

namespace LeetCode.Tests.Algorithms.DesignFoodRatingSystem;

[TestClass]
public class DesignFoodRatingSystemDictionaryWithPriorityQueueTests : DesignFoodRatingSystemTestsBase
{
    protected override IDesignFoodRatingSystem GetSolution(string[] foods, string[] cuisines, int[] ratings)
    {
        return new DesignFoodRatingSystemDictionaryWithPriorityQueue(foods, cuisines, ratings);
    }
}