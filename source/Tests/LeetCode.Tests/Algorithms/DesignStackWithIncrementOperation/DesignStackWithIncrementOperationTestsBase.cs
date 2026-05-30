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

using LeetCode.Algorithms.DesignStackWithIncrementOperation;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.DesignStackWithIncrementOperation;

public abstract class DesignStackWithIncrementOperationTestsBase
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void DesignStackWithIncrementOperation_WithMixedOperations_ProcessesOperationsAccordingToSpecification(StackWithIncrementScenario scenario)
    {
        // Arrange
        var expectedResult = scenario.OperationResults;

        var solution = GetSolution(scenario.MaxSize);

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

    protected abstract IDesignStackWithIncrementOperation GetSolution(int maxSize);

    private static IEnumerable<StackWithIncrementScenario[]> GetScenarios()
    {
        yield return [new StackWithIncrementScenario(3, [new PushOperation(1), new PushOperation(2), new PopOperation(), new PushOperation(2), new PushOperation(3), new PushOperation(4), new IncrementOperation(5, 100), new IncrementOperation(2, 100), new PopOperation(), new PopOperation(), new PopOperation(), new PopOperation()], [VoidOperationResult.Instance, VoidOperationResult.Instance, new PopOperation.Result(2), VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, new PopOperation.Result(103), new PopOperation.Result(202), new PopOperation.Result(201), new PopOperation.Result(-1)])];

        yield return [new StackWithIncrementScenario(2, [new PopOperation()], [new PopOperation.Result(-1)])];

        yield return [new StackWithIncrementScenario(2, [new PushOperation(1), new PushOperation(2), new PushOperation(3), new PopOperation(), new PopOperation(), new PopOperation()], [VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, new PopOperation.Result(2), new PopOperation.Result(1), new PopOperation.Result(-1)])];

        yield return [new StackWithIncrementScenario(3, [new PushOperation(1), new PushOperation(2), new IncrementOperation(10, 5), new PopOperation(), new PopOperation()], [VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, new PopOperation.Result(7), new PopOperation.Result(6)])];

        yield return [new StackWithIncrementScenario(3, [new PushOperation(5), new PushOperation(10), new IncrementOperation(0, 100), new PopOperation(), new PopOperation()], [VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, new PopOperation.Result(10), new PopOperation.Result(5)])];
    }

    public sealed class StackWithIncrementScenario : IScenario<IDesignStackWithIncrementOperation>
    {
        public StackWithIncrementScenario(int maxSize, IOperation<IDesignStackWithIncrementOperation>[] operations, IOperationResult[] operationResults)
        {
            MaxSize = maxSize;
            Operations = operations;
            OperationResults = operationResults;
        }

        public int MaxSize { get; }

        public IOperation<IDesignStackWithIncrementOperation>[] Operations { get; }

        public IOperationResult[] OperationResults { get; }
    }

    private sealed class PushOperation : IOperation<IDesignStackWithIncrementOperation>
    {
        private readonly int _value;

        public PushOperation(int value)
        {
            _value = value;
        }

        public IOperationResult Execute(IDesignStackWithIncrementOperation designStackWithIncrementOperation)
        {
            designStackWithIncrementOperation.Push(_value);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class PopOperation : IOperation<IDesignStackWithIncrementOperation>
    {
        public IOperationResult Execute(IDesignStackWithIncrementOperation designStackWithIncrementOperation)
        {
            var value = designStackWithIncrementOperation.Pop();

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

    private sealed class IncrementOperation : IOperation<IDesignStackWithIncrementOperation>
    {
        private readonly int _k;
        private readonly int _val;

        public IncrementOperation(int k, int val)
        {
            _k = k;
            _val = val;
        }

        public IOperationResult Execute(IDesignStackWithIncrementOperation designStackWithIncrementOperation)
        {
            designStackWithIncrementOperation.Increment(_k, _val);

            return VoidOperationResult.Instance;
        }
    }
}