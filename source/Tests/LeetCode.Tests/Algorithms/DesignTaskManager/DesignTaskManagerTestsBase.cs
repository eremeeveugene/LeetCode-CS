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

using LeetCode.Algorithms.DesignTaskManager;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.DesignTaskManager;

public abstract class DesignTaskManagerTestsBase
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void DesignTaskManager_WithMixedOperations_ProcessesOperationsAccordingToSpecification(TaskManagerScenario scenario)
    {
        // Arrange
        var expectedResult = scenario.OperationResults;

        var solution = GetSolution(scenario.Tasks);

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

    protected abstract IDesignTaskManager GetSolution(IList<IList<int>> tasks);

    private static IEnumerable<TaskManagerScenario[]> GetScenarios()
    {
        yield return [new TaskManagerScenario([[1, 101, 10], [2, 102, 20], [3, 103, 15]], [new AddOperation(4, 104, 5), new EditOperation(102, 8), new ExecTopOperation(), new RmvOperation(101), new AddOperation(5, 105, 15), new ExecTopOperation()], [VoidOperationResult.Instance, VoidOperationResult.Instance, new ExecTopOperation.Result(3), VoidOperationResult.Instance, VoidOperationResult.Instance, new ExecTopOperation.Result(5)])];

        yield return [new TaskManagerScenario([], [new ExecTopOperation()], [new ExecTopOperation.Result(-1)])];

        yield return [new TaskManagerScenario([[1, 101, 5], [2, 102, 10]], [new EditOperation(101, 20), new ExecTopOperation()], [VoidOperationResult.Instance, new ExecTopOperation.Result(1)])];

        yield return [new TaskManagerScenario([[1, 101, 5], [2, 102, 10], [3, 103, 15]], [new RmvOperation(103), new ExecTopOperation()], [VoidOperationResult.Instance, new ExecTopOperation.Result(2)])];

        yield return [new TaskManagerScenario([[1, 101, 5]], [new AddOperation(2, 102, 50), new ExecTopOperation(), new ExecTopOperation()], [VoidOperationResult.Instance, new ExecTopOperation.Result(2), new ExecTopOperation.Result(1)])];
    }

    public sealed class TaskManagerScenario : IScenario<IDesignTaskManager>
    {
        public TaskManagerScenario(IList<IList<int>> tasks, IOperation<IDesignTaskManager>[] operations, IOperationResult[] operationResults)
        {
            Tasks = tasks;
            Operations = operations;
            OperationResults = operationResults;
        }

        public IList<IList<int>> Tasks { get; }

        public IOperation<IDesignTaskManager>[] Operations { get; }

        public IOperationResult[] OperationResults { get; }
    }

    private sealed class AddOperation : IOperation<IDesignTaskManager>
    {
        private readonly int _priority;
        private readonly int _taskId;
        private readonly int _userId;

        public AddOperation(int userId, int taskId, int priority)
        {
            _userId = userId;
            _taskId = taskId;
            _priority = priority;
        }

        public IOperationResult Execute(IDesignTaskManager designTaskManager)
        {
            designTaskManager.Add(_userId, _taskId, _priority);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class EditOperation : IOperation<IDesignTaskManager>
    {
        private readonly int _newPriority;
        private readonly int _taskId;

        public EditOperation(int taskId, int newPriority)
        {
            _taskId = taskId;
            _newPriority = newPriority;
        }

        public IOperationResult Execute(IDesignTaskManager designTaskManager)
        {
            designTaskManager.Edit(_taskId, _newPriority);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class RmvOperation : IOperation<IDesignTaskManager>
    {
        private readonly int _taskId;

        public RmvOperation(int taskId)
        {
            _taskId = taskId;
        }

        public IOperationResult Execute(IDesignTaskManager designTaskManager)
        {
            designTaskManager.Rmv(_taskId);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class ExecTopOperation : IOperation<IDesignTaskManager>
    {
        public IOperationResult Execute(IDesignTaskManager designTaskManager)
        {
            var userId = designTaskManager.ExecTop();

            return new Result(userId);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly int _userId;

            public Result(int userId)
            {
                _userId = userId;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _userId == other._userId;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_userId);
            }
        }
    }
}