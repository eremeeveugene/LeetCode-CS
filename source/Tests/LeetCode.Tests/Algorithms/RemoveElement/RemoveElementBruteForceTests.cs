// --------------------------------------------------------------------------------
// Copyright (C) 2023 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.RemoveElement;

namespace LeetCode.Tests.Algorithms.RemoveElement;

[TestClass]
public class RemoveElementBruteForceTests
{
    [TestMethod]
    [DataRow(new[] { 3, 2, 2, 3 }, 3, new[] { 2, 2, 3, 3 }, 2)]
    [DataRow(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, new[] { 0, 1, 3, 0, 4, 2, 2, 2 }, 5)]
    public void RemoveElementBruteForce_GetResult_ShouldRemoveSpecifiedValueAndUpdateArrayLength(int[] actualNums,
        int val,
        int[] expectedNums, int expectedResult)
    {
        // Act
        int actualResult = RemoveElementBruteForce.GetResult(actualNums, val);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
        CollectionAssert.AreEqual(expectedNums, actualNums);
    }
}