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

using LeetCode.Algorithms.DefuseTheBomb;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.DefuseTheBomb;

public abstract class DefuseTheBombTestsBase<T> where T : IDefuseTheBomb, new()
{
    [TestMethod]
    [DataRow("[5,7,1,4]", 3, "[12,10,16,13]")]
    [DataRow("[1,2,3,4]", 0, "[0,0,0,0]")]
    [DataRow("[2,4,9,3]", -2, "[12,5,6,13]")]
    public void Decrypt_WithCodeArrayAndShiftValue_ReturnsDecryptedArray(string codeJsonArray, int k,
        string expectedResultJsonArray)
    {
        // Arrange
        var code = JsonHelper<int>.DeserializeToArray(codeJsonArray);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.Decrypt(code, k);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}