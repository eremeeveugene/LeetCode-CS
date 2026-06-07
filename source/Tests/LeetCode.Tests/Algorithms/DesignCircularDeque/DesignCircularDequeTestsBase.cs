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

using LeetCode.Algorithms.DesignCircularDeque;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.DesignCircularDeque;

public abstract class DesignCircularDequeTestsBase
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void DesignCircularDeque_WithMixedOperations_ProcessesOperationsAccordingToSpecification(CircularDequeScenario scenario)
    {
        // Arrange
        var expectedResult = scenario.OperationResults;

        var solution = GetSolution(scenario.K);

        // Act
        var operations = scenario.Operations;
        var operationsLength = operations.Length;

        var actualResult = new IOperationResult?[operationsLength];

        for (var i = 0; i < operationsLength; i++)
        {
            var operation = operations[i];

            actualResult[i] = operation.Execute(solution);
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    protected abstract IDesignCircularDeque GetSolution(int k);

    private static IEnumerable<CircularDequeScenario[]> GetScenarios()
    {
        yield return [new CircularDequeScenario(3, [new InsertLastOperation(1), new InsertLastOperation(2), new InsertFrontOperation(3), new InsertFrontOperation(4), new GetRearOperation(), new IsFullOperation(), new DeleteLastOperation(), new InsertFrontOperation(4), new GetFrontOperation()], [new InsertLastOperation.Result(true), new InsertLastOperation.Result(true), new InsertFrontOperation.Result(true), new InsertFrontOperation.Result(false), new GetRearOperation.Result(2), new IsFullOperation.Result(true), new DeleteLastOperation.Result(true), new InsertFrontOperation.Result(true), new GetFrontOperation.Result(4)])];

        yield return [new CircularDequeScenario(1, [new InsertFrontOperation(1), new InsertFrontOperation(2), new GetFrontOperation(), new DeleteFrontOperation(), new IsEmptyOperation()], [new InsertFrontOperation.Result(true), new InsertFrontOperation.Result(false), new GetFrontOperation.Result(1), new DeleteFrontOperation.Result(true), new IsEmptyOperation.Result(true)])];

        yield return [new CircularDequeScenario(2, [new IsEmptyOperation(), new InsertLastOperation(5), new InsertLastOperation(6), new IsFullOperation(), new GetRearOperation(), new GetFrontOperation(), new DeleteLastOperation(), new GetRearOperation()], [new IsEmptyOperation.Result(true), new InsertLastOperation.Result(true), new InsertLastOperation.Result(true), new IsFullOperation.Result(true), new GetRearOperation.Result(6), new GetFrontOperation.Result(5), new DeleteLastOperation.Result(true), new GetRearOperation.Result(5)])];

        yield return [new CircularDequeScenario(3, [new GetFrontOperation(), new GetRearOperation(), new DeleteFrontOperation(), new DeleteLastOperation()], [new GetFrontOperation.Result(-1), new GetRearOperation.Result(-1), new DeleteFrontOperation.Result(false), new DeleteLastOperation.Result(false)])];

        yield return [new CircularDequeScenario(1, [new InsertLastOperation(1), new GetFrontOperation(), new GetRearOperation(), new DeleteFrontOperation(), new IsEmptyOperation()], [new InsertLastOperation.Result(true), new GetFrontOperation.Result(1), new GetRearOperation.Result(1), new DeleteFrontOperation.Result(true), new IsEmptyOperation.Result(true)])];

        yield return [new CircularDequeScenario(1, [new InsertFrontOperation(5), new IsFullOperation(), new InsertLastOperation(6), new GetFrontOperation()], [new InsertFrontOperation.Result(true), new IsFullOperation.Result(true), new InsertLastOperation.Result(false), new GetFrontOperation.Result(5)])];

        yield return [new CircularDequeScenario(3, [new InsertFrontOperation(1), new InsertFrontOperation(2), new InsertFrontOperation(3), new IsFullOperation(), new InsertFrontOperation(4)], [new InsertFrontOperation.Result(true), new InsertFrontOperation.Result(true), new InsertFrontOperation.Result(true), new IsFullOperation.Result(true), new InsertFrontOperation.Result(false)])];

        yield return [new CircularDequeScenario(3, [new InsertLastOperation(1), new InsertLastOperation(2), new InsertLastOperation(3), new DeleteLastOperation(), new DeleteLastOperation(), new DeleteLastOperation(), new IsEmptyOperation()], [new InsertLastOperation.Result(true), new InsertLastOperation.Result(true), new InsertLastOperation.Result(true), new DeleteLastOperation.Result(true), new DeleteLastOperation.Result(true), new DeleteLastOperation.Result(true), new IsEmptyOperation.Result(true)])];

        yield return [new CircularDequeScenario(2, [new InsertFrontOperation(1), new InsertLastOperation(2), new GetFrontOperation(), new GetRearOperation(), new DeleteFrontOperation(), new GetFrontOperation()], [new InsertFrontOperation.Result(true), new InsertLastOperation.Result(true), new GetFrontOperation.Result(1), new GetRearOperation.Result(2), new DeleteFrontOperation.Result(true), new GetFrontOperation.Result(2)])];

        yield return [new CircularDequeScenario(4, [new InsertFrontOperation(10), new InsertFrontOperation(20), new InsertLastOperation(30), new InsertLastOperation(40), new GetFrontOperation(), new GetRearOperation(), new IsFullOperation()], [new InsertFrontOperation.Result(true), new InsertFrontOperation.Result(true), new InsertLastOperation.Result(true), new InsertLastOperation.Result(true), new GetFrontOperation.Result(20), new GetRearOperation.Result(40), new IsFullOperation.Result(true)])];

        yield return [new CircularDequeScenario(3, [new InsertLastOperation(1), new DeleteFrontOperation(), new InsertLastOperation(2), new InsertLastOperation(3), new InsertLastOperation(4), new GetFrontOperation(), new GetRearOperation()], [new InsertLastOperation.Result(true), new DeleteFrontOperation.Result(true), new InsertLastOperation.Result(true), new InsertLastOperation.Result(true), new InsertLastOperation.Result(true), new GetFrontOperation.Result(2), new GetRearOperation.Result(4)])];

        yield return [new CircularDequeScenario(5, [new IsEmptyOperation(), new IsFullOperation(), new InsertFrontOperation(7), new IsEmptyOperation()], [new IsEmptyOperation.Result(true), new IsFullOperation.Result(false), new InsertFrontOperation.Result(true), new IsEmptyOperation.Result(false)])];

        yield return [new CircularDequeScenario(2, [new InsertFrontOperation(1), new InsertLastOperation(2), new DeleteLastOperation(), new GetRearOperation(), new DeleteLastOperation(), new GetFrontOperation()], [new InsertFrontOperation.Result(true), new InsertLastOperation.Result(true), new DeleteLastOperation.Result(true), new GetRearOperation.Result(1), new DeleteLastOperation.Result(true), new GetFrontOperation.Result(-1)])];

        yield return [new CircularDequeScenario(3, [new InsertFrontOperation(1), new InsertFrontOperation(2), new InsertFrontOperation(3), new GetRearOperation(), new DeleteLastOperation(), new GetRearOperation()], [new InsertFrontOperation.Result(true), new InsertFrontOperation.Result(true), new InsertFrontOperation.Result(true), new GetRearOperation.Result(1), new DeleteLastOperation.Result(true), new GetRearOperation.Result(2)])];

        yield return [new CircularDequeScenario(3, [new InsertLastOperation(5), new InsertLastOperation(10), new InsertLastOperation(15), new GetFrontOperation(), new DeleteFrontOperation(), new GetFrontOperation()], [new InsertLastOperation.Result(true), new InsertLastOperation.Result(true), new InsertLastOperation.Result(true), new GetFrontOperation.Result(5), new DeleteFrontOperation.Result(true), new GetFrontOperation.Result(10)])];

        yield return [new CircularDequeScenario(2, [new InsertFrontOperation(3), new DeleteFrontOperation(), new InsertLastOperation(4), new InsertLastOperation(5), new IsFullOperation(), new GetFrontOperation(), new GetRearOperation()], [new InsertFrontOperation.Result(true), new DeleteFrontOperation.Result(true), new InsertLastOperation.Result(true), new InsertLastOperation.Result(true), new IsFullOperation.Result(true), new GetFrontOperation.Result(4), new GetRearOperation.Result(5)])];

        yield return [new CircularDequeScenario(1, [new IsEmptyOperation(), new IsFullOperation(), new DeleteFrontOperation(), new DeleteLastOperation(), new GetFrontOperation(), new GetRearOperation()], [new IsEmptyOperation.Result(true), new IsFullOperation.Result(false), new DeleteFrontOperation.Result(false), new DeleteLastOperation.Result(false), new GetFrontOperation.Result(-1), new GetRearOperation.Result(-1)])];

        yield return [new CircularDequeScenario(4, [new InsertFrontOperation(1), new InsertLastOperation(2), new InsertFrontOperation(3), new InsertLastOperation(4), new DeleteFrontOperation(), new DeleteLastOperation(), new GetFrontOperation(), new GetRearOperation()], [new InsertFrontOperation.Result(true), new InsertLastOperation.Result(true), new InsertFrontOperation.Result(true), new InsertLastOperation.Result(true), new DeleteFrontOperation.Result(true), new DeleteLastOperation.Result(true), new GetFrontOperation.Result(1), new GetRearOperation.Result(2)])];

        yield return [new CircularDequeScenario(3, [new InsertLastOperation(1), new InsertFrontOperation(2), new InsertLastOperation(3), new GetFrontOperation(), new GetRearOperation()], [new InsertLastOperation.Result(true), new InsertFrontOperation.Result(true), new InsertLastOperation.Result(true), new GetFrontOperation.Result(2), new GetRearOperation.Result(3)])];

        yield return [new CircularDequeScenario(2, [new InsertLastOperation(1), new InsertLastOperation(2), new DeleteFrontOperation(), new InsertFrontOperation(3), new GetFrontOperation(), new GetRearOperation()], [new InsertLastOperation.Result(true), new InsertLastOperation.Result(true), new DeleteFrontOperation.Result(true), new InsertFrontOperation.Result(true), new GetFrontOperation.Result(3), new GetRearOperation.Result(2)])];
    }

    public sealed class CircularDequeScenario : IScenario<IDesignCircularDeque>
    {
        public CircularDequeScenario(int k, IOperation<IDesignCircularDeque>[] operations, IOperationResult[] operationResults)
        {
            K = k;
            Operations = operations;
            OperationResults = operationResults;
        }

        public int K { get; }

        public IOperation<IDesignCircularDeque>[] Operations { get; }

        public IOperationResult[] OperationResults { get; }
    }

    private sealed class InsertLastOperation : IOperation<IDesignCircularDeque>
    {
        private readonly int _value;

        public InsertLastOperation(int value)
        {
            _value = value;
        }

        public IOperationResult Execute(IDesignCircularDeque designCircularDeque)
        {
            var result = designCircularDeque.InsertLast(_value);

            return new Result(result);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly bool _success;

            public Result(bool success)
            {
                _success = success;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _success == other._success;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_success);
            }
        }
    }

    private sealed class InsertFrontOperation : IOperation<IDesignCircularDeque>
    {
        private readonly int _value;

        public InsertFrontOperation(int value)
        {
            _value = value;
        }

        public IOperationResult Execute(IDesignCircularDeque designCircularDeque)
        {
            var result = designCircularDeque.InsertFront(_value);

            return new Result(result);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly bool _success;

            public Result(bool success)
            {
                _success = success;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _success == other._success;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_success);
            }
        }
    }

    private sealed class DeleteFrontOperation : IOperation<IDesignCircularDeque>
    {
        public IOperationResult Execute(IDesignCircularDeque designCircularDeque)
        {
            var result = designCircularDeque.DeleteFront();

            return new Result(result);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly bool _success;

            public Result(bool success)
            {
                _success = success;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _success == other._success;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_success);
            }
        }
    }

    private sealed class DeleteLastOperation : IOperation<IDesignCircularDeque>
    {
        public IOperationResult Execute(IDesignCircularDeque designCircularDeque)
        {
            var result = designCircularDeque.DeleteLast();

            return new Result(result);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly bool _success;

            public Result(bool success)
            {
                _success = success;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _success == other._success;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_success);
            }
        }
    }

    private sealed class GetFrontOperation : IOperation<IDesignCircularDeque>
    {
        public IOperationResult Execute(IDesignCircularDeque designCircularDeque)
        {
            var value = designCircularDeque.GetFront();

            return new Result(value);
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

    private sealed class GetRearOperation : IOperation<IDesignCircularDeque>
    {
        public IOperationResult Execute(IDesignCircularDeque designCircularDeque)
        {
            var value = designCircularDeque.GetRear();

            return new Result(value);
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

    private sealed class IsEmptyOperation : IOperation<IDesignCircularDeque>
    {
        public IOperationResult Execute(IDesignCircularDeque designCircularDeque)
        {
            var result = designCircularDeque.IsEmpty();

            return new Result(result);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly bool _isEmpty;

            public Result(bool isEmpty)
            {
                _isEmpty = isEmpty;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _isEmpty == other._isEmpty;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_isEmpty);
            }
        }
    }

    private sealed class IsFullOperation : IOperation<IDesignCircularDeque>
    {
        public IOperationResult Execute(IDesignCircularDeque designCircularDeque)
        {
            var result = designCircularDeque.IsFull();

            return new Result(result);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly bool _isFull;

            public Result(bool isFull)
            {
                _isFull = isFull;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _isFull == other._isFull;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_isFull);
            }
        }
    }
}