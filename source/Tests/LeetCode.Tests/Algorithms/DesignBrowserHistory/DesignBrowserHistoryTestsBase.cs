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
    public void DesignBrowserHistory_WithMixedOperations_ProcessesOperationsAccordingToSpecification(BrowserHistoryScenario scenario)
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
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    protected abstract IDesignBrowserHistory GetSolution(string homepage);

    private static IEnumerable<BrowserHistoryScenario[]> GetScenarios()
    {
        yield return
        [
            new BrowserHistoryScenario(
                "leetcode.com",
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
            new BrowserHistoryScenario(
                "home.com",
                [new BackOperation(1), new ForwardOperation(1)],
                [new NavigateOperation.Result("home.com"), new NavigateOperation.Result("home.com")])
        ];

        yield return
        [
            new BrowserHistoryScenario(
                "home.com",
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
            new BrowserHistoryScenario(
                "home.com",
                [new VisitOperation("a.com"), new VisitOperation("b.com"), new BackOperation(2), new ForwardOperation(10)],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("home.com"),
                    new NavigateOperation.Result("b.com")
                ])
        ];

        yield return
        [
            new BrowserHistoryScenario(
                "home.com",
                [new VisitOperation("a.com"), new BackOperation(1)],
                [VoidOperationResult.Instance, new NavigateOperation.Result("home.com")])
        ];

        yield return
        [
            new BrowserHistoryScenario(
                "a.com",
                [
                    new BackOperation(1),
                    new BackOperation(5),
                    new ForwardOperation(1)
                ],
                [
                    new NavigateOperation.Result("a.com"),
                    new NavigateOperation.Result("a.com"),
                    new NavigateOperation.Result("a.com")
                ])
        ];

        yield return
        [
            new BrowserHistoryScenario(
                "a.com",
                [
                    new VisitOperation("b.com"),
                    new VisitOperation("c.com"),
                    new VisitOperation("d.com"),
                    new BackOperation(2),
                    new ForwardOperation(1),
                    new ForwardOperation(5)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("b.com"),
                    new NavigateOperation.Result("c.com"),
                    new NavigateOperation.Result("d.com")
                ])
        ];

        yield return
        [
            new BrowserHistoryScenario(
                "x.org",
                [
                    new VisitOperation("y.org"),
                    new BackOperation(100),
                    new ForwardOperation(100)
                ],
                [
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("x.org"),
                    new NavigateOperation.Result("y.org")
                ])
        ];

        yield return
        [
            new BrowserHistoryScenario(
                "x.org",
                [
                    new VisitOperation("y.org"),
                    new VisitOperation("z.org"),
                    new BackOperation(1),
                    new VisitOperation("w.org"),
                    new ForwardOperation(1),
                    new BackOperation(2)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("y.org"),
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("w.org"),
                    new NavigateOperation.Result("x.org")
                ])
        ];

        yield return
        [
            new BrowserHistoryScenario(
                "start.io",
                [
                    new ForwardOperation(3),
                    new VisitOperation("one.io"),
                    new ForwardOperation(1),
                    new BackOperation(1),
                    new ForwardOperation(1)
                ],
                [
                    new NavigateOperation.Result("start.io"),
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("one.io"),
                    new NavigateOperation.Result("start.io"),
                    new NavigateOperation.Result("one.io")
                ])
        ];

        yield return
        [
            new BrowserHistoryScenario(
                "p.com",
                [
                    new VisitOperation("q.com"),
                    new BackOperation(1),
                    new VisitOperation("r.com"),
                    new BackOperation(1),
                    new VisitOperation("s.com"),
                    new BackOperation(2),
                    new ForwardOperation(2)
                ],
                [
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("p.com"),
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("p.com"),
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("p.com"),
                    new NavigateOperation.Result("s.com")
                ])
        ];

        yield return
        [
            new BrowserHistoryScenario(
                "leetcode.com",
                [
                    new VisitOperation("a.com"),
                    new VisitOperation("b.com"),
                    new VisitOperation("c.com"),
                    new VisitOperation("d.com"),
                    new VisitOperation("e.com"),
                    new BackOperation(4),
                    new ForwardOperation(2),
                    new BackOperation(1),
                    new ForwardOperation(1)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("a.com"),
                    new NavigateOperation.Result("c.com"),
                    new NavigateOperation.Result("b.com"),
                    new NavigateOperation.Result("c.com")
                ])
        ];

        yield return
        [
            new BrowserHistoryScenario(
                "h.com",
                [
                    new VisitOperation("h.com"),
                    new BackOperation(1),
                    new BackOperation(1),
                    new ForwardOperation(1)
                ],
                [
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("h.com"),
                    new NavigateOperation.Result("h.com"),
                    new NavigateOperation.Result("h.com")
                ])
        ];

        yield return
        [
            new BrowserHistoryScenario(
                "h.com",
                [
                    new VisitOperation("i.com"),
                    new BackOperation(1),
                    new VisitOperation("j.com"),
                    new BackOperation(1),
                    new VisitOperation("k.com"),
                    new ForwardOperation(1),
                    new BackOperation(1),
                    new BackOperation(1)
                ],
                [
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("h.com"),
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("h.com"),
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("k.com"),
                    new NavigateOperation.Result("h.com"),
                    new NavigateOperation.Result("h.com")
                ])
        ];

        yield return
        [
            new BrowserHistoryScenario(
                "home5.com",
                [
                    new VisitOperation("s1.com"),
                    new VisitOperation("s2.com"),
                    new BackOperation(4),
                    new VisitOperation("s3.com"),
                    new BackOperation(4),
                    new ForwardOperation(3),
                    new VisitOperation("s4.com"),
                    new BackOperation(4)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("home5.com"),
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("home5.com"),
                    new NavigateOperation.Result("s3.com"),
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("home5.com")
                ])
        ];

        yield return
        [
            new BrowserHistoryScenario(
                "home6.com",
                [
                    new ForwardOperation(1),
                    new ForwardOperation(3),
                    new BackOperation(2),
                    new VisitOperation("s1.com"),
                    new VisitOperation("s2.com"),
                    new BackOperation(3),
                    new VisitOperation("s3.com"),
                    new VisitOperation("s4.com")
                ],
                [
                    new NavigateOperation.Result("home6.com"),
                    new NavigateOperation.Result("home6.com"),
                    new NavigateOperation.Result("home6.com"),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("home6.com"),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new BrowserHistoryScenario(
                "home9.com",
                [
                    new BackOperation(2),
                    new BackOperation(3),
                    new VisitOperation("s1.com"),
                    new BackOperation(3)
                ],
                [
                    new NavigateOperation.Result("home9.com"),
                    new NavigateOperation.Result("home9.com"),
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("home9.com")
                ])
        ];

        yield return
        [
            new BrowserHistoryScenario(
                "home2.com",
                [
                    new ForwardOperation(2),
                    new VisitOperation("s1.com"),
                    new VisitOperation("s2.com"),
                    new BackOperation(1),
                    new VisitOperation("s3.com"),
                    new VisitOperation("s4.com"),
                    new VisitOperation("s5.com")
                ],
                [
                    new NavigateOperation.Result("home2.com"),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("s1.com"),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new BrowserHistoryScenario(
                "home8.com",
                [
                    new BackOperation(1),
                    new VisitOperation("s1.com"),
                    new ForwardOperation(3),
                    new BackOperation(2),
                    new VisitOperation("s2.com"),
                    new ForwardOperation(4),
                    new ForwardOperation(3),
                    new ForwardOperation(3),
                    new ForwardOperation(1),
                    new VisitOperation("s3.com")
                ],
                [
                    new NavigateOperation.Result("home8.com"),
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("s1.com"),
                    new NavigateOperation.Result("home8.com"),
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("s2.com"),
                    new NavigateOperation.Result("s2.com"),
                    new NavigateOperation.Result("s2.com"),
                    new NavigateOperation.Result("s2.com"),
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new BrowserHistoryScenario(
                "home1.com",
                [
                    new ForwardOperation(3),
                    new VisitOperation("s1.com"),
                    new VisitOperation("s2.com"),
                    new VisitOperation("s3.com"),
                    new ForwardOperation(3),
                    new VisitOperation("s4.com"),
                    new ForwardOperation(4)
                ],
                [
                    new NavigateOperation.Result("home1.com"),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("s3.com"),
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("s4.com")
                ])
        ];

        yield return
        [
            new BrowserHistoryScenario(
                "home3.com",
                [
                    new VisitOperation("s1.com"),
                    new BackOperation(4),
                    new BackOperation(4),
                    new ForwardOperation(3),
                    new ForwardOperation(4),
                    new ForwardOperation(1),
                    new ForwardOperation(3),
                    new BackOperation(2),
                    new VisitOperation("s2.com")
                ],
                [
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("home3.com"),
                    new NavigateOperation.Result("home3.com"),
                    new NavigateOperation.Result("s1.com"),
                    new NavigateOperation.Result("s1.com"),
                    new NavigateOperation.Result("s1.com"),
                    new NavigateOperation.Result("s1.com"),
                    new NavigateOperation.Result("home3.com"),
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new BrowserHistoryScenario(
                "home2.com",
                [
                    new BackOperation(3),
                    new VisitOperation("s1.com"),
                    new BackOperation(4),
                    new ForwardOperation(3),
                    new BackOperation(1),
                    new VisitOperation("s2.com"),
                    new VisitOperation("s3.com"),
                    new ForwardOperation(1),
                    new BackOperation(1)
                ],
                [
                    new NavigateOperation.Result("home2.com"),
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("home2.com"),
                    new NavigateOperation.Result("s1.com"),
                    new NavigateOperation.Result("home2.com"),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("s3.com"),
                    new NavigateOperation.Result("s2.com")
                ])
        ];

        yield return
        [
            new BrowserHistoryScenario(
                "home7.com",
                [
                    new VisitOperation("s1.com"),
                    new VisitOperation("s2.com"),
                    new VisitOperation("s3.com"),
                    new VisitOperation("s4.com"),
                    new VisitOperation("s5.com")
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new BrowserHistoryScenario(
                "home9.com",
                [
                    new BackOperation(1),
                    new VisitOperation("s1.com"),
                    new ForwardOperation(1),
                    new VisitOperation("s2.com"),
                    new VisitOperation("s3.com"),
                    new ForwardOperation(1),
                    new VisitOperation("s4.com"),
                    new VisitOperation("s5.com")
                ],
                [
                    new NavigateOperation.Result("home9.com"),
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("s1.com"),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new NavigateOperation.Result("s3.com"),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];
    }

    public sealed class BrowserHistoryScenario : IScenario<IDesignBrowserHistory>
    {
        public BrowserHistoryScenario(string homepage, IOperation<IDesignBrowserHistory>[] operations, IOperationResult[] operationResults)
        {
            Homepage = homepage;
            Operations = operations;
            OperationResults = operationResults;
        }

        public string Homepage { get; }

        public IOperation<IDesignBrowserHistory>[] Operations { get; }

        public IOperationResult[] OperationResults { get; }
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

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
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