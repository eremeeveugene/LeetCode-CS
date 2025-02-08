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

using LeetCode.Algorithms.DesignNumberContainerSystem;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.DesignNumberContainerSystem;

public abstract class DesignNumberContainerSystemTestsBase<T> where T : IDesignNumberContainerSystemFactory, new()
{
    private const string Change = "change";
    private const string Find = "find";

    [TestMethod]
    [DataRow("[\"find\", \"change\", \"change\", \"change\", \"change\", \"find\", \"change\", \"find\"]",
        "[[10], [2, 10], [1, 10], [3, 10], [5, 10], [10], [1, 20], [10]]",
        "[-1, 1, 2]")]
    public void NumberContainerSystem_WithChangeAndFindOperations_ExecutesOperations(string methodsJsonArray,
        string argsJsonArray, string expectedResultJsonArray)
    {
        // Arrange
        var methods = JsonHelper<string>.DeserializeToArray(methodsJsonArray);
        var args = JsonHelper<int>.DeserializeToJaggedArray(argsJsonArray);
        var expectedResult = JsonHelper<int?>.DeserializeToArray(expectedResultJsonArray);

        var solutionFactory = new T();
        var solution = solutionFactory.Create();

        // Act
        var actualResult = new List<int>();

        for (var i = 0; i < methods.Length; i++)
        {
            switch (methods[i])
            {
                case Change:
                    solution.Change(args[i][0], args[i][1]);
                    break;
                case Find:
                    actualResult.Add(solution.Find(args[i][0]));
                    break;
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}