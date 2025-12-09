// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.CountSpecialTriplets;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CountSpecialTriplets;

public abstract class CountSpecialTripletsTestsBase<T> where T : ICountSpecialTriplets, new()
{
    [TestMethod]
    [DataRow("[6,3,6]", 1)]
    [DataRow("[0,1,0,0]", 1)]
    [DataRow("[8,4,2,8,4]", 2)]
    public void SpecialTriplets_WithNumsArray_ReturnsCountOfSpecialTriplets(string numsJson, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.SpecialTriplets(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}