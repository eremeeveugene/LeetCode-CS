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

using LeetCode.Algorithms.SpecialArrayWithXElementsGreaterThanOrEqualX;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.SpecialArrayWithXElementsGreaterThanOrEqualX;

public abstract class SpecialArrayWithXElementsGreaterThanOrEqualXTestsBase<T>
    where T : ISpecialArrayWithXElementsGreaterThanOrEqualX, new()
{
    [TestMethod]
    [DataRow("[3,5]", 2)]
    [DataRow("[0,0]", -1)]
    [DataRow("[0,4,3,0,4]", 3)]
    public void SpecialArray_GivenArrayOfIntegers_ReturnsExpectedResult(string numsJsonArray, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.SpecialArray(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}