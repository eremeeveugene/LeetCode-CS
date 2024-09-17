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

using LeetCode.Algorithms.PartitionArrayIntoThreePartsWithEqualSum;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.PartitionArrayIntoThreePartsWithEqualSum;

public abstract class PartitionArrayIntoThreePartsWithEqualSumTestsBase<T>
    where T : IPartitionArrayIntoThreePartsWithEqualSum, new()
{
    [TestMethod]
    [DataRow("[1,1,1,1]", false)]
    [DataRow("[2,2,3]", false)]
    [DataRow("[1,-1,1,-1]", false)]
    [DataRow("[0,2,1,-6,6,-7,9,1,2,0,1]", true)]
    [DataRow("[0,2,1,-6,6,7,9,-1,2,0,1]", false)]
    [DataRow("[3,3,6,5,-2,2,5,1,-9,4]", true)]
    [DataRow("[0,0,0,0,0]", true)]
    [DataRow("[0,0,0,0,1]", false)]
    [DataRow("[1,2,3,0,3,2,1]", false)]
    [DataRow("[1,1,1,1,1,1,1,1,1,1]", false)]
    [DataRow("[1,-1,1,-1,1,-1,1,-1,1,-1]", true)]
    [DataRow("[6,1,1,1,1,1,1,1,1,1,1,1,1]", true)]
    [DataRow("[1,2,3,4,5,6]", false)]
    [DataRow("[-3,3,-3,3,-3,3]", true)]
    [DataRow("[1,1,1,0,1,1,1,0,1,1,1]", true)]
    public void CanThreePartsEqualSum_GivenArray_ReturnsExpectedBoolean(string arrJsonArray, bool expectedResult)
    {
        // Arrange
        var arr = JsonHelper<int>.DeserializeToArray(arrJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.CanThreePartsEqualSum(arr);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}