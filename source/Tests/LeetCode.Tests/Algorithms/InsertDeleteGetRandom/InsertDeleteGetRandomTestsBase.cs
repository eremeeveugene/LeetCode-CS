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

using LeetCode.Algorithms.InsertDeleteGetRandom;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.InsertDeleteGetRandom;

public abstract class InsertDeleteGetRandomTestsBase<T> where T : IInsertDeleteGetRandom, new()
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void InsertDeleteGetRandom_WithMixedOperations_ProcessesOperationsAccordingToSpecification(
        IScenario<IInsertDeleteGetRandom> scenario)
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
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<IScenario<IInsertDeleteGetRandom>[]> GetScenarios()
    {
        yield return
        [
            new Scenario<IInsertDeleteGetRandom>(
                [
                    new InsertOperation(1),
                    new RemoveOperation(2),
                    new InsertOperation(2),
                    new GetRandomOperation(),
                    new RemoveOperation(1),
                    new InsertOperation(2),
                    new GetRandomOperation(),
                    new RemoveOperation(1),
                    new RemoveOperation(2),
                    new InsertOperation(3),
                    new GetRandomOperation()
                ],
                [
                    new InsertOperation.Result(true),
                    new RemoveOperation.Result(false),
                    new InsertOperation.Result(true),
                    new GetRandomOperation.Result([1, 2]),
                    new RemoveOperation.Result(true),
                    new InsertOperation.Result(false),
                    new GetRandomOperation.Result([2]),
                    new RemoveOperation.Result(false),
                    new RemoveOperation.Result(true),
                    new InsertOperation.Result(true),
                    new GetRandomOperation.Result([3])
                ])
        ];

        yield return
        [
            new Scenario<IInsertDeleteGetRandom>(
                [
                    new InsertOperation(5),
                    new InsertOperation(5),
                    new GetRandomOperation()
                ],
                [
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(false),
                    new GetRandomOperation.Result([5])
                ])
        ];

        yield return
        [
            new Scenario<IInsertDeleteGetRandom>(
                [
                    new InsertOperation(1),
                    new RemoveOperation(99),
                    new GetRandomOperation()
                ],
                [
                    new InsertOperation.Result(true),
                    new RemoveOperation.Result(false),
                    new GetRandomOperation.Result([1])
                ])
        ];

        yield return
        [
            new Scenario<IInsertDeleteGetRandom>(
                [
                    new InsertOperation(42),
                    new GetRandomOperation(),
                    new GetRandomOperation()
                ],
                [
                    new InsertOperation.Result(true),
                    new GetRandomOperation.Result([42]),
                    new GetRandomOperation.Result([42])
                ])
        ];
    }

    private sealed class InsertOperation : IOperation<IInsertDeleteGetRandom>
    {
        private readonly int _value;

        public InsertOperation(int value)
        {
            _value = value;
        }

        public IOperationResult Execute(IInsertDeleteGetRandom insertDeleteGetRandom)
        {
            var result = insertDeleteGetRandom.Insert(_value);

            return new Result(result);
        }

        public sealed class Result : IOperationResult, IEquatable<Result>
        {
            private readonly bool _inserted;

            public Result(bool inserted)
            {
                _inserted = inserted;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _inserted == other._inserted;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_inserted);
            }
        }
    }

    private sealed class RemoveOperation : IOperation<IInsertDeleteGetRandom>
    {
        private readonly int _value;

        public RemoveOperation(int value)
        {
            _value = value;
        }

        public IOperationResult Execute(IInsertDeleteGetRandom insertDeleteGetRandom)
        {
            var result = insertDeleteGetRandom.Remove(_value);

            return new Result(result);
        }

        public sealed class Result : IOperationResult, IEquatable<Result>
        {
            private readonly bool _removed;

            public Result(bool removed)
            {
                _removed = removed;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _removed == other._removed;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_removed);
            }
        }
    }

    private sealed class GetRandomOperation : IOperation<IInsertDeleteGetRandom>
    {
        public IOperationResult Execute(IInsertDeleteGetRandom insertDeleteGetRandom)
        {
            var value = insertDeleteGetRandom.GetRandom();

            return new Result([value]);
        }

        public sealed class Result : IOperationResult, IEquatable<Result>
        {
            private readonly int[] _validOptions;

            public Result(int[] validOptions)
            {
                _validOptions = validOptions;
            }

            public bool Equals(Result? other)
            {
                return other is not null && other._validOptions.Any(o => _validOptions.Contains(o));
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return 0;
            }
        }
    }
}