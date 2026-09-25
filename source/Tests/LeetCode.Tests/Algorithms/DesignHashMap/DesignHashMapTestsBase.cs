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

using LeetCode.Algorithms.DesignHashMap;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.DesignHashMap;

public abstract class DesignHashMapTestsBase<T> where T : IDesignHashMap, new()
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void DesignHashMap_WithMixedOperations_ProcessesOperationsAccordingToSpecification(IScenario<IDesignHashMap> scenario)
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

    private static IEnumerable<IScenario<IDesignHashMap>[]> GetScenarios()
    {
        yield return
        [
            new Scenario<IDesignHashMap>(
                [
                    new PutOperation(1, 1),
                    new PutOperation(2, 2),
                    new GetOperation(1),
                    new GetOperation(3),
                    new PutOperation(2, 1),
                    new GetOperation(2),
                    new RemoveOperation(2),
                    new GetOperation(2)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(1),
                    new GetOperation.Result(-1),
                    VoidOperationResult.Instance,
                    new GetOperation.Result(1),
                    VoidOperationResult.Instance,
                    new GetOperation.Result(-1)
                ])
        ];
    }

    private sealed class PutOperation : IOperation<IDesignHashMap>
    {
        private readonly int _key;
        private readonly int _value;

        public PutOperation(int key, int value)
        {
            _key = key;
            _value = value;
        }

        public IOperationResult Execute(IDesignHashMap solution)
        {
            solution.Put(_key, _value);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class GetOperation : IOperation<IDesignHashMap>
    {
        private readonly int _key;

        public GetOperation(int key)
        {
            _key = key;
        }

        public IOperationResult Execute(IDesignHashMap solution)
        {
            var result = solution.Get(_key);

            return new Result(result);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly int _value;

            public Result(int value)
            {
                _value = value;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _value == other._value;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_value);
            }
        }
    }

    private sealed class RemoveOperation : IOperation<IDesignHashMap>
    {
        private readonly int _key;

        public RemoveOperation(int key)
        {
            _key = key;
        }

        public IOperationResult Execute(IDesignHashMap solution)
        {
            solution.Remove(_key);

            return VoidOperationResult.Instance;
        }
    }
}