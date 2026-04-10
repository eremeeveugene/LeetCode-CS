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

using LeetCode.Algorithms.HowManyNumbersAreSmallerThanTheCurrentNumber;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.HowManyNumbersAreSmallerThanTheCurrentNumber;

public abstract class HowManyNumbersAreSmallerThanTheCurrentNumberTestsBase<T>
    where T : IHowManyNumbersAreSmallerThanTheCurrentNumber, new()
{
    [TestMethod]
    [DataRow("[8, 1, 2, 2, 3]", "[4, 0, 1, 1, 3]")]
    [DataRow("[6, 5, 4, 8]", "[2, 1, 0, 3]")]
    [DataRow("[7, 7, 7, 7]", "[0, 0, 0, 0]")]
    public void SmallerNumbersThanCurrent_WithIntArray_ReturnsCountsArray(string numsJson,
        string expectedResultJson)
    {
        // Arrange
        var nums = JsonHelper.Parse<int[]>(numsJson);
        var expectedResult = JsonHelper.Parse<int[]>(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.SmallerNumbersThanCurrent(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}