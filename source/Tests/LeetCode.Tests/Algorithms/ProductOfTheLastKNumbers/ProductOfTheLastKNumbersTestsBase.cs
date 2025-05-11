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

namespace LeetCode.Tests.Algorithms.ProductOfTheLastKNumbers;

public abstract class ProductOfTheLastKNumbersTestsBase<T> where T : IProductOfTheLastKNumbersFactory, new()
{
    private const string Add = "add";
    private const string GetProduct = "getProduct";

    [TestMethod]
    [DataRow(
        "[\"add\",\"add\",\"add\",\"add\",\"add\",\"getProduct\",\"getProduct\",\"getProduct\",\"add\",\"getProduct\"]",
        "[[3],[0],[2],[5],[4],[2],[3],[4],[8],[2]]", "[20,40,0,32]")]
    public void test(string methodsJson,
        string argsJson, string expectedResultJson)
    {
        // Arrange
        var methods = JsonHelper<string[]>.Parse(methodsJson);
        var args = JsonHelper<int>.DeserializeToJaggedArray(argsJson);
        var expectedResult = JsonHelper<int?[]>.Parse(expectedResultJson);

        var solutionFactory = new T();
        var solution = solutionFactory.Create();

        // Act
        var actualResult = new List<int>();

        for (var i = 0; i < methods.Length; i++)
        {
            switch (methods[i])
            {
                case Add:
                    solution.Add(args[i][0]);
                    break;
                case GetProduct:
                    actualResult.Add(solution.GetProduct(args[i][0]));
                    break;
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}