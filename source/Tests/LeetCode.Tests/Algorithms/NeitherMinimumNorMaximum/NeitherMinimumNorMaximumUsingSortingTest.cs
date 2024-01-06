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

using LeetCode.Algorithms.NeitherMinimumNorMaximum;

namespace LeetCode.Tests.Algorithms.NeitherMinimumNorMaximum;

[TestClass]
public class NeitherMinimumNorMaximumUsingSortingTest
{
    [TestMethod]
    [DataRow(new[] { 3, 2, 1, 4 }, 2)]
    [DataRow(new[] { 1, 2 }, -1)]
    [DataRow(new[] { 2, 1, 3 }, 2)]
    [DataRow(new[] { 3, 30, 24 }, 24)]
    public void NeitherMinimumNorMaximumUsingSorting_GetResult_ReturnsExpectedMiddleValue(int[] nums,
        int expectedResult)
    {
        // Act
        var actualResult = NeitherMinimumNorMaximumUsingSorting.GetResult(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}