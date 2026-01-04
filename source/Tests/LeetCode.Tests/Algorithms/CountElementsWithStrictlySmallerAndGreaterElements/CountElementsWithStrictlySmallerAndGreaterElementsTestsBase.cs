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

using LeetCode.Algorithms.CountElementsWithStrictlySmallerAndGreaterElements;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CountElementsWithStrictlySmallerAndGreaterElements;

public abstract class CountElementsWithStrictlySmallerAndGreaterElementsTestsBase<T>
    where T : ICountElementsWithStrictlySmallerAndGreaterElements, new()
{
    [TestMethod]
    [DataRow("[11,7,2,15]", 2)]
    [DataRow("[-3,3,3,90]", 2)]
    public void CountElements_GivenArray_ReturnsCountOfElementsMatchingCriteria(string numsJson,
        int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.CountElements(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}