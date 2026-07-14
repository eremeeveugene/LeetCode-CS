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

using LeetCode.Algorithms.ProductOfTheLastKNumbers;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.ProductOfTheLastKNumbers;

public abstract class ProductOfTheLastKNumbersTestsBase<T> where T : IProductOfTheLastKNumbers, new()
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void ProductOfTheLastKNumbers_WithMixedOperations_ProcessesOperationsAccordingToSpecification(
        IScenario<IProductOfTheLastKNumbers> scenario)
    {
        // Arrange
        var expectedResult = scenario.OperationResults;

        var solution = new T();

        // Act
        var operations = scenario.Operations;
        var operationsLength = operations.Length;

        var actualResult = new IOperationResult[operationsLength];

        for (var i = 0; i < operationsLength; i++)
        {
            var operation = operations[i];

            actualResult[i] = operation.Execute(solution);
        }

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    private static IEnumerable<IScenario<IProductOfTheLastKNumbers>[]> GetScenarios()
    {
        yield return
        [
            new Scenario<IProductOfTheLastKNumbers>(
                [
                    new AddOperation(3),
                    new AddOperation(0),
                    new AddOperation(2),
                    new AddOperation(5),
                    new AddOperation(4),
                    new GetProductOperation(2),
                    new GetProductOperation(3),
                    new GetProductOperation(4),
                    new AddOperation(8),
                    new GetProductOperation(2)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetProductOperation.Result(20),
                    new GetProductOperation.Result(40),
                    new GetProductOperation.Result(0),
                    VoidOperationResult.Instance,
                    new GetProductOperation.Result(32)
                ])
        ];

        yield return
        [
            new Scenario<IProductOfTheLastKNumbers>(
                [
                    new AddOperation(1),
                    new AddOperation(2),
                    new AddOperation(0),
                    new AddOperation(3),
                    new GetProductOperation(1),
                    new GetProductOperation(2),
                    new GetProductOperation(3),
                    new GetProductOperation(4)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetProductOperation.Result(3),
                    new GetProductOperation.Result(0),
                    new GetProductOperation.Result(0),
                    new GetProductOperation.Result(0)
                ])
        ];

        yield return
        [
            new Scenario<IProductOfTheLastKNumbers>(
                [new AddOperation(5), new GetProductOperation(1), new AddOperation(7), new GetProductOperation(1)],
                [
                    VoidOperationResult.Instance,
                    new GetProductOperation.Result(5),
                    VoidOperationResult.Instance,
                    new GetProductOperation.Result(7)
                ])
        ];

        yield return
        [
            new Scenario<IProductOfTheLastKNumbers>(
                [
                    new AddOperation(0),
                    new AddOperation(0),
                    new AddOperation(4),
                    new AddOperation(5),
                    new GetProductOperation(2),
                    new GetProductOperation(3),
                    new GetProductOperation(4)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetProductOperation.Result(20),
                    new GetProductOperation.Result(0),
                    new GetProductOperation.Result(0)
                ])
        ];
    }

    private sealed class AddOperation : IOperation<IProductOfTheLastKNumbers>
    {
        private readonly int _value;

        public AddOperation(int value)
        {
            _value = value;
        }

        public IOperationResult Execute(IProductOfTheLastKNumbers productOfTheLastKNumbers)
        {
            productOfTheLastKNumbers.Add(_value);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class GetProductOperation : IOperation<IProductOfTheLastKNumbers>
    {
        private readonly int _k;

        public GetProductOperation(int k)
        {
            _k = k;
        }

        public IOperationResult Execute(IProductOfTheLastKNumbers productOfTheLastKNumbers)
        {
            var product = productOfTheLastKNumbers.GetProduct(_k);

            return new Result(product);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly int _product;

            public Result(int product)
            {
                _product = product;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _product == other._product;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_product);
            }
        }
    }
}