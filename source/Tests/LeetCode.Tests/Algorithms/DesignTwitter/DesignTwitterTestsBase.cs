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

using LeetCode.Algorithms.DesignTwitter;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.DesignTwitter;

public abstract class DesignTwitterTestsBase<T> where T : IDesignTwitter, new()
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void DesignTwitter_WithMixedOperations_ProcessesOperationsAccordingToSpecification(IScenario<IDesignTwitter> scenario)
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

    private static IEnumerable<IScenario<IDesignTwitter>[]> GetScenarios()
    {
        yield return
        [
            new Scenario<IDesignTwitter>(
                [
                    new PostTweetOperation(1, 5), new GetNewsFeedOperation(1), new FollowOperation(1, 2), new PostTweetOperation(2, 6),
                    new GetNewsFeedOperation(1), new UnfollowOperation(1, 2), new GetNewsFeedOperation(1)
                ],
                [
                    VoidOperationResult.Instance, new GetNewsFeedOperation.Result([5]), VoidOperationResult.Instance, VoidOperationResult.Instance,
                    new GetNewsFeedOperation.Result([6, 5]), VoidOperationResult.Instance, new GetNewsFeedOperation.Result([5])
                ])
        ];

        yield return
        [
            new Scenario<IDesignTwitter>(
                [new PostTweetOperation(1, 5), new PostTweetOperation(1, 3), new PostTweetOperation(1, 101), new GetNewsFeedOperation(1)],
                [
                    VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance,
                    new GetNewsFeedOperation.Result([101, 3, 5])
                ])
        ];

        yield return [new Scenario<IDesignTwitter>([new GetNewsFeedOperation(1)], [new GetNewsFeedOperation.Result([])])];

        yield return
        [
            new Scenario<IDesignTwitter>(
                [
                    new PostTweetOperation(1, 1), new PostTweetOperation(2, 2), new FollowOperation(1, 2), new GetNewsFeedOperation(1),
                    new GetNewsFeedOperation(2)
                ],
                [
                    VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, new GetNewsFeedOperation.Result([2, 1]),
                    new GetNewsFeedOperation.Result([2])
                ])
        ];

        yield return
        [
            new Scenario<IDesignTwitter>(
                [
                    new PostTweetOperation(1, 1), new PostTweetOperation(1, 2), new PostTweetOperation(1, 3), new PostTweetOperation(1, 4),
                    new PostTweetOperation(1, 5), new PostTweetOperation(1, 6), new PostTweetOperation(1, 7), new PostTweetOperation(1, 8),
                    new PostTweetOperation(1, 9), new PostTweetOperation(1, 10), new PostTweetOperation(1, 11), new GetNewsFeedOperation(1)
                ],
                [
                    VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance,
                    VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance,
                    VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance,
                    new GetNewsFeedOperation.Result([11, 10, 9, 8, 7, 6, 5, 4, 3, 2])
                ])
        ];

        yield return
        [
            new Scenario<IDesignTwitter>(
                [
                    new PostTweetOperation(1, 10), new PostTweetOperation(2, 20), new PostTweetOperation(3, 30), new FollowOperation(1, 2),
                    new FollowOperation(1, 3), new GetNewsFeedOperation(1)
                ],
                [
                    VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance,
                    VoidOperationResult.Instance, new GetNewsFeedOperation.Result([30, 20, 10])
                ])
        ];

        yield return
        [
            new Scenario<IDesignTwitter>(
                [new PostTweetOperation(1, 5), new UnfollowOperation(1, 2), new GetNewsFeedOperation(1)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new GetNewsFeedOperation.Result([5])])
        ];

        yield return
        [
            new Scenario<IDesignTwitter>(
                [
                    new FollowOperation(1, 2), new PostTweetOperation(2, 1), new PostTweetOperation(2, 2), new PostTweetOperation(2, 3),
                    new PostTweetOperation(2, 4), new PostTweetOperation(2, 5), new PostTweetOperation(2, 6), new PostTweetOperation(2, 7),
                    new PostTweetOperation(2, 8), new PostTweetOperation(2, 9), new PostTweetOperation(2, 10), new PostTweetOperation(2, 11),
                    new PostTweetOperation(2, 12), new GetNewsFeedOperation(1)
                ],
                [
                    VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance,
                    VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance,
                    VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance,
                    VoidOperationResult.Instance, new GetNewsFeedOperation.Result([12, 11, 10, 9, 8, 7, 6, 5, 4, 3])
                ])
        ];

        yield return
        [
            new Scenario<IDesignTwitter>(
                [
                    new FollowOperation(1, 2), new PostTweetOperation(1, 1), new PostTweetOperation(2, 2), new PostTweetOperation(1, 3),
                    new PostTweetOperation(2, 4), new GetNewsFeedOperation(1)
                ],
                [
                    VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance,
                    VoidOperationResult.Instance, new GetNewsFeedOperation.Result([4, 3, 2, 1])
                ])
        ];

        yield return
        [
            new Scenario<IDesignTwitter>(
                [new FollowOperation(1, 2), new PostTweetOperation(2, 7), new GetNewsFeedOperation(1)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new GetNewsFeedOperation.Result([7])])
        ];

        yield return
        [
            new Scenario<IDesignTwitter>(
                [
                    new PostTweetOperation(1, 1), new FollowOperation(1, 2), new PostTweetOperation(2, 2), new GetNewsFeedOperation(1),
                    new UnfollowOperation(1, 2), new GetNewsFeedOperation(1)
                ],
                [
                    VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, new GetNewsFeedOperation.Result([2, 1]),
                    VoidOperationResult.Instance, new GetNewsFeedOperation.Result([1])
                ])
        ];

        yield return
        [
            new Scenario<IDesignTwitter>(
                [
                    new FollowOperation(1, 2), new FollowOperation(1, 3), new PostTweetOperation(2, 2), new PostTweetOperation(3, 3),
                    new GetNewsFeedOperation(1), new UnfollowOperation(1, 2), new GetNewsFeedOperation(1)
                ],
                [
                    VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance,
                    new GetNewsFeedOperation.Result([3, 2]), VoidOperationResult.Instance, new GetNewsFeedOperation.Result([3])
                ])
        ];

        yield return
        [
            new Scenario<IDesignTwitter>(
                [
                    new FollowOperation(1, 2), new PostTweetOperation(2, 9), new UnfollowOperation(1, 2), new GetNewsFeedOperation(1),
                    new FollowOperation(1, 2), new GetNewsFeedOperation(1)
                ],
                [
                    VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, new GetNewsFeedOperation.Result([]),
                    VoidOperationResult.Instance, new GetNewsFeedOperation.Result([9])
                ])
        ];

        yield return
        [
            new Scenario<IDesignTwitter>(
                [new PostTweetOperation(1, 1), new GetNewsFeedOperation(1), new PostTweetOperation(1, 2), new GetNewsFeedOperation(1)],
                [
                    VoidOperationResult.Instance, new GetNewsFeedOperation.Result([1]), VoidOperationResult.Instance,
                    new GetNewsFeedOperation.Result([2, 1])
                ])
        ];

        yield return
        [
            new Scenario<IDesignTwitter>(
                [new PostTweetOperation(1, 1), new PostTweetOperation(2, 2), new GetNewsFeedOperation(1), new GetNewsFeedOperation(2)],
                [
                    VoidOperationResult.Instance, VoidOperationResult.Instance, new GetNewsFeedOperation.Result([1]),
                    new GetNewsFeedOperation.Result([2])
                ])
        ];

        yield return
        [
            new Scenario<IDesignTwitter>(
                [new FollowOperation(1, 2), new FollowOperation(2, 3), new PostTweetOperation(3, 3), new GetNewsFeedOperation(1)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, new GetNewsFeedOperation.Result([])])
        ];

        yield return
        [
            new Scenario<IDesignTwitter>(
                [
                    new FollowOperation(1, 2), new PostTweetOperation(1, 1), new PostTweetOperation(2, 2), new PostTweetOperation(1, 3),
                    new PostTweetOperation(2, 4), new PostTweetOperation(1, 5), new PostTweetOperation(2, 6), new PostTweetOperation(1, 7),
                    new PostTweetOperation(2, 8), new PostTweetOperation(1, 9), new PostTweetOperation(2, 10), new PostTweetOperation(1, 11),
                    new PostTweetOperation(2, 12), new GetNewsFeedOperation(1)
                ],
                [
                    VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance,
                    VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance,
                    VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance,
                    VoidOperationResult.Instance, new GetNewsFeedOperation.Result([12, 11, 10, 9, 8, 7, 6, 5, 4, 3])
                ])
        ];

        yield return
        [
            new Scenario<IDesignTwitter>(
                [new PostTweetOperation(5, 50), new PostTweetOperation(5, 51), new GetNewsFeedOperation(5)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new GetNewsFeedOperation.Result([51, 50])])
        ];

        yield return
        [
            new Scenario<IDesignTwitter>(
                [
                    new PostTweetOperation(1, 1), new PostTweetOperation(1, 2), new FollowOperation(1, 2), new PostTweetOperation(2, 3),
                    new UnfollowOperation(1, 2), new GetNewsFeedOperation(1)
                ],
                [
                    VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance,
                    VoidOperationResult.Instance, new GetNewsFeedOperation.Result([2, 1])
                ])
        ];

        yield return
        [
            new Scenario<IDesignTwitter>(
                [
                    new FollowOperation(1, 3), new FollowOperation(2, 3), new PostTweetOperation(3, 30), new GetNewsFeedOperation(1),
                    new GetNewsFeedOperation(2), new GetNewsFeedOperation(3)
                ],
                [
                    VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, new GetNewsFeedOperation.Result([30]),
                    new GetNewsFeedOperation.Result([30]), new GetNewsFeedOperation.Result([30])
                ])
        ];

        yield return
        [
            new Scenario<IDesignTwitter>(
                [new FollowOperation(1, 2), new FollowOperation(1, 3), new GetNewsFeedOperation(1)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new GetNewsFeedOperation.Result([])])
        ];

        yield return
        [
            new Scenario<IDesignTwitter>(
                [
                    new FollowOperation(1, 2), new PostTweetOperation(2, 100), new PostTweetOperation(1, 1), new PostTweetOperation(1, 2),
                    new PostTweetOperation(1, 3), new PostTweetOperation(1, 4), new PostTweetOperation(1, 5), new PostTweetOperation(1, 6),
                    new PostTweetOperation(1, 7), new PostTweetOperation(1, 8), new PostTweetOperation(1, 9), new PostTweetOperation(1, 10),
                    new GetNewsFeedOperation(1)
                ],
                [
                    VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance,
                    VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance,
                    VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance,
                    new GetNewsFeedOperation.Result([10, 9, 8, 7, 6, 5, 4, 3, 2, 1])
                ])
        ];

        yield return
        [
            new Scenario<IDesignTwitter>(
                [new PostTweetOperation(1, 5), new FollowOperation(1, 1), new GetNewsFeedOperation(1)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new GetNewsFeedOperation.Result([5])])
        ];

        yield return
        [
            new Scenario<IDesignTwitter>(
                [
                    new FollowOperation(1, 1), new FollowOperation(1, 2), new PostTweetOperation(1, 1), new PostTweetOperation(2, 2),
                    new GetNewsFeedOperation(1)
                ],
                [
                    VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance,
                    new GetNewsFeedOperation.Result([2, 1])
                ])
        ];
    }

    private sealed class PostTweetOperation : IOperation<IDesignTwitter>
    {
        private readonly int _tweetId;
        private readonly int _userId;

        public PostTweetOperation(int userId, int tweetId)
        {
            _userId = userId;
            _tweetId = tweetId;
        }

        public IOperationResult Execute(IDesignTwitter designTwitter)
        {
            designTwitter.PostTweet(_userId, _tweetId);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class FollowOperation : IOperation<IDesignTwitter>
    {
        private readonly int _followeeId;
        private readonly int _followerId;

        public FollowOperation(int followerId, int followeeId)
        {
            _followerId = followerId;
            _followeeId = followeeId;
        }

        public IOperationResult Execute(IDesignTwitter designTwitter)
        {
            designTwitter.Follow(_followerId, _followeeId);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class UnfollowOperation : IOperation<IDesignTwitter>
    {
        private readonly int _followeeId;
        private readonly int _followerId;

        public UnfollowOperation(int followerId, int followeeId)
        {
            _followerId = followerId;
            _followeeId = followeeId;
        }

        public IOperationResult Execute(IDesignTwitter designTwitter)
        {
            designTwitter.Unfollow(_followerId, _followeeId);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class GetNewsFeedOperation : IOperation<IDesignTwitter>
    {
        private readonly int _userId;

        public GetNewsFeedOperation(int userId)
        {
            _userId = userId;
        }

        public IOperationResult Execute(IDesignTwitter designTwitter)
        {
            var newsFeed = designTwitter.GetNewsFeed(_userId);

            return new Result(newsFeed.ToArray());
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly int[] _newsFeed;

            public Result(int[] newsFeed)
            {
                _newsFeed = newsFeed;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _newsFeed.SequenceEqual(other._newsFeed);
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                var hashCode = new HashCode();

                foreach (var tweetId in _newsFeed)
                {
                    hashCode.Add(tweetId);
                }

                return hashCode.ToHashCode();
            }
        }
    }
}