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

using LeetCode.Algorithms.FindElementsInContaminatedBinaryTree;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Exceptions;

namespace LeetCode.Tests.Algorithms.FindElementsInContaminatedBinaryTree;

public abstract class FindElementsInContaminatedBinaryTreeTestsBase
{
    private const string Find = "find";

    [TestMethod]
    [DataRow("[-1,null,-1]", "[\"find\",\"find\"]", "[[1],[2]]", "[false,true]")]
    [DataRow("[-1,-1,-1,-1,-1]", "[\"find\",\"find\",\"find\"]", "[[1],[3],[5]]", "[true,true,false]")]
    [DataRow("[-1,null,-1,-1,null,-1]", "[\"find\",\"find\",\"find\",\"find\"]", "[[2],[3],[4],[5]]",
        "[true,false,false,true]")]
    public void FindElementsInContaminatedBinaryTree_WithVariousTreeStructures_ReturnsIfElementsFound(string rootJson,
        string methodsJson, string argumentsJson, string expectedResultJson)
    {
        // Arrange
        var rootArray = JsonHelper<int?[]>.Parse(rootJson);
        var root = TreeNode.ToTreeNodeOrThrow(rootArray);
        var methods = JsonHelper<string[]>.Parse(methodsJson);
        var arguments = JsonHelper<object[][]>.Parse(argumentsJson);
        var expectedResult = JsonHelper<object[]>.Parse(expectedResultJson);

        var solution = GetSolution(root);

        // Act
        var actualResult = new List<object>();

        for (var i = 0; i < methods.Length; i++)
        {
            switch (methods[i])
            {
                case Find:
                    actualResult.Add(solution.Find((int)arguments[i][0]));
                    break;
                default:
                    throw new UnexpectedMethodException(methods[i]);
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    protected abstract IFindElementsInContaminatedBinaryTree GetSolution(TreeNode root);
}