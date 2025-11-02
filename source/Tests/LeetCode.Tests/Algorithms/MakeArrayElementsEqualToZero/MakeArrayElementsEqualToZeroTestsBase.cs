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

using LeetCode.Algorithms.MakeArrayElementsEqualToZero;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MakeArrayElementsEqualToZero;

public abstract class MakeArrayElementsEqualToZeroTestsBase<T>
    where T : IMakeArrayElementsEqualToZero, new()
{
    [TestMethod]
    [DataRow("[1,0,2,0,3]", 2)]
    [DataRow("[2,3,4,0,4,1,0]", 0)]
    public void CountValidSelections_WithNumsArray_ReturnsNumberOfValidStartPositions(string numsJson,
        int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.CountValidSelections(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}