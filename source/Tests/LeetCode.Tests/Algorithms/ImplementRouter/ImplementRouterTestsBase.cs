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

using LeetCode.Algorithms.ImplementRouter;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Exceptions;

namespace LeetCode.Tests.Algorithms.ImplementRouter;

public abstract class ImplementRouterTestsBase
{
    private const string AddPacket = "addPacket";
    private const string ForwardPacket = "forwardPacket";
    private const string GetCount = "getCount";

    [TestMethod]
    [DataRow(3,
        "[\"addPacket\", \"addPacket\", \"addPacket\", \"addPacket\", \"addPacket\", \"forwardPacket\", \"addPacket\", \"getCount\"]",
        "[[1, 4, 90], [2, 5, 90], [1, 4, 90], [3, 5, 95], [4, 5, 105], [], [5, 2, 110], [5, 100, 110]]",
        "[true, true, false, true, true, [2, 5, 90], true, 1]")]
    [DataRow(4,
        "[\"addPacket\",\"addPacket\",\"getCount\"]",
        "[[4,2,1],[3,2,1],[2,1,1]]",
        "[true,true,2]")]
    public void ImplementRouter_WithMixedOperations_ProcessesOperationsAccordingToSpecification(int memoryLimit,
        string methodsJson, string argumentsJson, string expectedResultJson)
    {
        // Arrange
        var methods = JsonHelper<string[]>.Parse(methodsJson);
        var arguments = JsonHelper<object[][]>.Parse(argumentsJson);
        var expectedResult = JsonHelper<object[]>.Parse(expectedResultJson);

        var solution = GetSolution(memoryLimit);

        // Act
        var actualResult = new List<object>();

        for (var i = 0; i < methods.Length; i++)
        {
            switch (methods[i])
            {
                case AddPacket:
                    actualResult.Add(solution.AddPacket((int)arguments[i][0], (int)arguments[i][1],
                        (int)arguments[i][2]));
                    break;
                case ForwardPacket:
                    actualResult.Add(solution.ForwardPacket());
                    break;
                case GetCount:
                    actualResult.Add(
                        solution.GetCount((int)arguments[i][0], (int)arguments[i][1], (int)arguments[i][2]));
                    break;
                default:
                    throw new UnexpectedMethodException(methods[i]);
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    protected abstract IImplementRouter GetSolution(int memoryLimit);
}