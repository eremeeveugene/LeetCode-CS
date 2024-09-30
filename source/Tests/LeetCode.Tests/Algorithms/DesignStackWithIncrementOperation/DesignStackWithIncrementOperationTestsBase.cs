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

using LeetCode.Algorithms.DesignStackWithIncrementOperation;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.DesignStackWithIncrementOperation;

public abstract class DesignStackWithIncrementOperationTestsBase<T>
    where T : IDesignStackWithIncrementOperationFactory, new()
{
    private const string Push = "push";
    private const string Pop = "pop";
    private const string Increment = "increment";

    [TestMethod]
    [DataRow(3,
        "[\"push\",\"push\",\"pop\",\"push\",\"push\",\"push\",\"increment\",\"increment\",\"pop\",\"pop\",\"pop\",\"pop\"]",
        "[[1],[2],[],[2],[3],[4],[5,100],[2,100],[],[],[],[]]",
        "[2,103,202,201,-1]")]
    public void DataStructureOperations_WithMaxSizeAndCommands_ReturnsOperationResults(int maxSize,
        string methodsJsonArray, string argsJsonArray, string expectedResultJsonArray)
    {
        // Arrange
        var methods = JsonHelper<string>.DeserializeToArray(methodsJsonArray);
        var args = JsonHelper<int>.DeserializeToJaggedArray(argsJsonArray);
        var expectedResult = JsonHelper<int?>.DeserializeToArray(expectedResultJsonArray);

        var solutionFactory = new T();
        var solution = solutionFactory.Create(maxSize);

        // Act
        var actualResult = new List<int>();

        for (var i = 0; i < methods.Length; i++)
        {
            switch (methods[i])
            {
                case Push:
                    solution.Push(args[i][0]);
                    break;
                case Pop:
                    actualResult.Add(solution.Pop());
                    break;
                case Increment:
                    solution.Increment(args[i][0], args[i][1]);
                    break;
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}