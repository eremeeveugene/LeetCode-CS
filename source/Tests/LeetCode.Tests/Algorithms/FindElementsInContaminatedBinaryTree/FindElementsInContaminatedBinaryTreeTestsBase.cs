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

using LeetCode.Algorithms.FindElementsInContaminatedBinaryTree;
using LeetCode.Core.Exceptions;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.FindElementsInContaminatedBinaryTree;

public abstract class FindElementsInContaminatedBinaryTreeTestsBase<T>
    where T : IFindElementsInContaminatedBinaryTreeFactory, new()
{
    private const string Find = "find";

    [TestMethod]
    [DataRow("[-1,null,-1]", "[\"find\",\"find\"]", "[[1],[2]]", "[false,true]")]
    [DataRow("[-1,-1,-1,-1,-1]", "[\"find\",\"find\",\"find\"]", "[[1],[3],[5]]", "[true,true,false]")]
    [DataRow("[-1,null,-1,-1,null,-1]", "[\"find\",\"find\",\"find\",\"find\"]", "[[2],[3],[4],[5]]", "[true,false,false,true]")]
    public void Find_WithVariousTreeStructures_ReturnsIfElementsFound(string rootJson, string methodsJson,
        string argumentsJson, string expectedResultJson)
    {
        // Arrange
        var rootArray = JsonHelper<int?>.DeserializeToArray(rootJson);
        var root = TreeNode.ToTreeNode(rootArray) ?? throw new TreeNodeBuildException();

        var methods = JsonHelper<string>.DeserializeToArray(methodsJson);
        var arguments = JsonHelper<int>.DeserializeToJaggedArray(argumentsJson);
        var expectedResult = JsonHelper<bool>.DeserializeToArray(expectedResultJson);

        var solutionFactory = new T();
        var solution = solutionFactory.Create(root);

        // Act
        var actualResult = new List<object>();

        for (var i = 0; i < methods.Length; i++)
        {
            switch (methods[i])
            {
                case Find:
                    actualResult.Add(solution.Find(arguments[i][0]));

                    break;
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}