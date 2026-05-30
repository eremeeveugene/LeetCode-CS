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

using LeetCode.Algorithms.AllOneDataStructure;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.AllOneDataStructure;

public abstract class AllOneDataStructureTestsBase<T> where T : IAllOneDataStructure, new()
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void AllOneDataStructure_WithMixedOperations_ProcessesOperationsAccordingToSpecification(IScenario<IAllOneDataStructure> scenario)
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

    private static IEnumerable<IScenario<IAllOneDataStructure>[]> GetScenarios()
    {
        yield return [new Scenario<IAllOneDataStructure>([new IncOperation("hello"), new IncOperation("hello"), new GetMaxKeyOperation(), new GetMinKeyOperation(), new IncOperation("leet"), new GetMaxKeyOperation(), new GetMinKeyOperation()], [VoidOperationResult.Instance, VoidOperationResult.Instance, new GetKeyOperation.Result("hello"), new GetKeyOperation.Result("hello"), VoidOperationResult.Instance, new GetKeyOperation.Result("hello"), new GetKeyOperation.Result("leet")])];

        yield return [new Scenario<IAllOneDataStructure>([new IncOperation("a"), new DecOperation("a"), new GetMaxKeyOperation(), new GetMinKeyOperation()], [VoidOperationResult.Instance, VoidOperationResult.Instance, new GetKeyOperation.Result(""), new GetKeyOperation.Result("")])];

        yield return [new Scenario<IAllOneDataStructure>([new IncOperation("a"), new IncOperation("b"), new IncOperation("b"), new GetMaxKeyOperation(), new GetMinKeyOperation()], [VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, new GetKeyOperation.Result("b"), new GetKeyOperation.Result("a")])];

        yield return [new Scenario<IAllOneDataStructure>([new IncOperation("a"), new IncOperation("a"), new IncOperation("b"), new IncOperation("b"), new DecOperation("a"), new GetMaxKeyOperation(), new GetMinKeyOperation()], [VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, new GetKeyOperation.Result("b"), new GetKeyOperation.Result("a")])];

        yield return [new Scenario<IAllOneDataStructure>([new IncOperation("a"), new IncOperation("b"), new IncOperation("b"), new IncOperation("c"), new IncOperation("c"), new IncOperation("c"), new DecOperation("b"), new DecOperation("b"), new GetMaxKeyOperation(), new GetMinKeyOperation()], [VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, new GetKeyOperation.Result("c"), new GetKeyOperation.Result("a")])];
    }

    private sealed class IncOperation : IOperation<IAllOneDataStructure>
    {
        private readonly string _key;

        public IncOperation(string key)
        {
            _key = key;
        }

        public IOperationResult Execute(IAllOneDataStructure allOneDataStructure)
        {
            allOneDataStructure.Inc(_key);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class DecOperation : IOperation<IAllOneDataStructure>
    {
        private readonly string _key;

        public DecOperation(string key)
        {
            _key = key;
        }

        public IOperationResult Execute(IAllOneDataStructure allOneDataStructure)
        {
            allOneDataStructure.Dec(_key);

            return VoidOperationResult.Instance;
        }
    }

    protected abstract class GetKeyOperation : IOperation<IAllOneDataStructure>
    {
        public abstract IOperationResult Execute(IAllOneDataStructure solution);

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly string _key;

            public Result(string key)
            {
                _key = key;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _key == other._key;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_key);
            }
        }
    }

    private sealed class GetMaxKeyOperation : GetKeyOperation
    {
        public override IOperationResult Execute(IAllOneDataStructure allOneDataStructure)
        {
            var maxKey = allOneDataStructure.GetMaxKey();

            return new Result(maxKey);
        }
    }

    private sealed class GetMinKeyOperation : GetKeyOperation
    {
        public override IOperationResult Execute(IAllOneDataStructure allOneDataStructure)
        {
            var minKey = allOneDataStructure.GetMinKey();

            return new Result(minKey);
        }
    }
}