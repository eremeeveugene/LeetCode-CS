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

using LeetCode.Algorithms.InsertDeleteGetRandom;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Exceptions;

namespace LeetCode.Tests.Algorithms.InsertDeleteGetRandom;

public abstract class InsertDeleteGetRandomTestsBase<T> where T : IInsertDeleteGetRandom, new()
{
    private const string Insert = "insert";
    private const string Remove = "remove";
    private const string GetRandom = "getRandom";

    [TestMethod]
    [DataRow("[\"insert\", \"remove\", \"insert\", \"getRandom\", \"remove\", \"insert\", \"getRandom\"]",
        "[[1], [2], [2], [], [1], [2], []]",
        "[true, false, true, 2, true, false, 2]")]
    public void InsertDeleteGetRandom_WithMixedOperations_ProcessesOperationsAccordingToSpecification(
        string methodsJson, string argumentsJson, string expectedResultJson)
    {
        // Arrange
        var methods = JsonHelper<string[]>.Parse(methodsJson);
        var arguments = JsonHelper<object[][]>.Parse(argumentsJson);
        var expectedResult = JsonHelper<object[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = new List<object>();

        for (var i = 0; i < methods.Length; i++)
        {
            switch (methods[i])
            {
                case Insert:
                    actualResult.Add(solution.Insert((int)arguments[i][0]));
                    break;
                case Remove:
                    actualResult.Add(solution.Remove((int)arguments[i][0]));
                    break;
                case GetRandom:
                    actualResult.Add(solution.GetRandom());
                    break;
                default:
                    throw new UnexpectedMethodException(methods[i]);
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}