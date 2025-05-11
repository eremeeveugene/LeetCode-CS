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

using LeetCode.Algorithms.ProductOfTheLastKNumbers;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Exceptions;

namespace LeetCode.Tests.Algorithms.ProductOfTheLastKNumbers;

public abstract class ProductOfTheLastKNumbersTestsBase<T> where T : IProductOfTheLastKNumbers, new()
{
    private const string Add = "add";
    private const string GetProduct = "getProduct";

    [TestMethod]
    [DataRow(
        "[\"add\",\"add\",\"add\",\"add\",\"add\",\"getProduct\",\"getProduct\",\"getProduct\",\"add\",\"getProduct\"]",
        "[[3],[0],[2],[5],[4],[2],[3],[4],[8],[2]]", "[20,40,0,32]")]
    public void ProductOfTheLastKNumbers_WithMixedOperations_ProcessesOperationsAccordingToSpecification(
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
                case Add:
                    solution.Add((int)arguments[i][0]);
                    break;
                case GetProduct:
                    actualResult.Add(solution.GetProduct((int)arguments[i][0]));
                    break;
                default:
                    throw new UnexpectedMethodException(methods[i]);
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}