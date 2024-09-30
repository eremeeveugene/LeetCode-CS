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

using LeetCode.Algorithms.DesignCircularDeque;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.DesignCircularDeque;

public abstract class DesignCircularDequeTestsBase<T> where T : IDesignCircularDequeFactory, new()
{
    [TestMethod]
    [DataRow(3, "[true,true,true,false,2,true,true,true,4]")]
    public void CircularDequeOperations_WithMultipleInsertsAndDeletions_ReturnsCorrectResults(int k,
        string expectedResultJson)
    {
        // Arrange
        var expectedResult = JsonHelper<string>.DeserializeToArray(expectedResultJson);

        var solutionFactory = new T();
        var solution = solutionFactory.Create(k);

        // Act
        var actualResult = new List<object>
        {
            solution.InsertLast(1),
            solution.InsertLast(2),
            solution.InsertFront(3),
            solution.InsertFront(4),
            solution.GetRear(),
            solution.IsFull(),
            solution.DeleteLast(),
            solution.InsertFront(4),
            solution.GetFront()
        };

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult.Select(r => r.ToString()?.ToLower()).ToArray());
    }
}