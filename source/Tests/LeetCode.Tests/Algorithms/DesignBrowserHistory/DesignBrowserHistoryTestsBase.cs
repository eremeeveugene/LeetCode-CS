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

using LeetCode.Algorithms.DesignBrowserHistory;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.DesignBrowserHistory;

public abstract class DesignBrowserHistoryTestsBase
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void DesignBrowserHistory_WithMixedOperations_ProcessesOperationsAccordingToSpecification(
        BrowserHistoryScenario scenario)
    {
        // Arrange
        var expectedResult = scenario.OperationResults;

        var solution = GetSolution(scenario.Homepage);

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

    protected abstract IDesignBrowserHistory GetSolution(string homepage);

    private static IEnumerable<BrowserHistoryScenario[]> GetScenarios()
    {
        yield return
        [
            new BrowserHistoryScenario("leetcode.com",
                [
                    new VisitOperation("google.com"),
                    new VisitOperation("facebook.com"),
                    new VisitOperation("youtube.com"),
                    new BackOperation(1),
                    new BackOperation(1),
                    new ForwardOperation(1),
                    new VisitOperation("linkedin.com"),
                    new ForwardOperation(2),
                    new BackOperation(2),
                    new BackOperation(7)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("facebook.com"),
                    new NavigateOperation.Result("google.com"),
                    new NavigateOperation.Result("facebook.com"),
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("linkedin.com"),
                    new NavigateOperation.Result("google.com"),
                    new NavigateOperation.Result("leetcode.com")
                ])
        ];

        yield return
        [
            new BrowserHistoryScenario("home.com",
                [
                    new BackOperation(1),
                    new ForwardOperation(1)
                ],
                [
                    new NavigateOperation.Result("home.com"),
                    new NavigateOperation.Result("home.com")
                ])
        ];

        yield return
        [
            new BrowserHistoryScenario("home.com",
                [
                    new VisitOperation("a.com"),
                    new VisitOperation("b.com"),
                    new BackOperation(1),
                    new VisitOperation("c.com"),
                    new ForwardOperation(1),
                    new BackOperation(1)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("a.com"),
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("c.com"),
                    new NavigateOperation.Result("a.com")
                ])
        ];

        yield return
        [
            new BrowserHistoryScenario("home.com",
                [
                    new VisitOperation("a.com"),
                    new VisitOperation("b.com"),
                    new BackOperation(2),
                    new ForwardOperation(10)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("home.com"),
                    new NavigateOperation.Result("b.com")
                ])
        ];

        yield return
        [
            new BrowserHistoryScenario("home.com",
                [
                    new VisitOperation("a.com"),
                    new BackOperation(1)
                ],
                [
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("home.com")
                ])
        ];
    }

    public sealed class BrowserHistoryScenario : IScenario<IDesignBrowserHistory>
    {
        private readonly Scenario<IDesignBrowserHistory> _scenario;

        public BrowserHistoryScenario(
            string homepage,
            IOperation<IDesignBrowserHistory>[] operations,
            IOperationResult[] operationResults)
        {
            Homepage = homepage;
            _scenario = new Scenario<IDesignBrowserHistory>(operations, operationResults);
        }

        public string Homepage { get; }

        public IOperation<IDesignBrowserHistory>[] Operations => _scenario.Operations;

        public IOperationResult[] OperationResults => _scenario.OperationResults;
    }

    private sealed class VisitOperation : IOperation<IDesignBrowserHistory>
    {
        private readonly string _url;

        public VisitOperation(string url)
        {
            _url = url;
        }

        public IOperationResult Execute(IDesignBrowserHistory designBrowserHistory)
        {
            designBrowserHistory.Visit(_url);

            return VoidOperationResult.Instance;
        }
    }

    protected abstract class NavigateOperation : IOperation<IDesignBrowserHistory>
    {
        public abstract IOperationResult Execute(IDesignBrowserHistory designBrowserHistory);

        public sealed class Result : IOperationResult, IEquatable<Result>
        {
            private readonly string? _url;

            public Result(string? url)
            {
                _url = url;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _url == other._url;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_url);
            }
        }
    }

    private sealed class BackOperation : NavigateOperation
    {
        private readonly int _steps;

        public BackOperation(int steps)
        {
            _steps = steps;
        }

        public override IOperationResult Execute(IDesignBrowserHistory designBrowserHistory)
        {
            var url = designBrowserHistory.Back(_steps);

            return new Result(url);
        }
    }

    private sealed class ForwardOperation : NavigateOperation
    {
        private readonly int _steps;

        public ForwardOperation(int steps)
        {
            _steps = steps;
        }

        public override IOperationResult Execute(IDesignBrowserHistory designBrowserHistory)
        {
            var url = designBrowserHistory.Forward(_steps);

            return new Result(url);
        }
    }
}