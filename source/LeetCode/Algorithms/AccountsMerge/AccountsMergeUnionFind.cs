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

namespace LeetCode.Algorithms.AccountsMerge;

/// <inheritdoc />
public sealed class AccountsMergeUnionFind : IAccountsMerge
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </remarks>
    public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
    {
        var n = accounts.Count;

        Span<int> parents = stackalloc int[n];
        Span<int> ranks = stackalloc int[n];

        for (var i = 0; i < n; i++)
        {
            parents[i] = i;
        }

        var emailToAccountIndexDictionary = new Dictionary<string, int>();
        var distinctEmails = new List<string>();

        for (var i = 0; i < n; i++)
        {
            var account = accounts[i];
            var accountLength = account.Count;

            for (var j = 1; j < accountLength; j++)
            {
                var email = account[j];

                if (emailToAccountIndexDictionary.TryGetValue(email, out var ownerAccountIndex))
                {
                    Union(parents, ranks, i, ownerAccountIndex);

                    continue;
                }

                emailToAccountIndexDictionary[email] = i;

                distinctEmails.Add(email);
            }
        }

        var rootToMergedAccountIndexDictionary = new Dictionary<int, int>();
        var mergedAccounts = new List<List<string>>();
        var distinctEmailsCount = distinctEmails.Count;

        for (var i = 0; i < distinctEmailsCount; i++)
        {
            var email = distinctEmails[i];
            var ownerAccountIndex = emailToAccountIndexDictionary[email];
            var root = Find(parents, ownerAccountIndex);

            if (!rootToMergedAccountIndexDictionary.TryGetValue(root, out var mergedAccountIndex))
            {
                mergedAccountIndex = mergedAccounts.Count;

                rootToMergedAccountIndexDictionary[root] = mergedAccountIndex;

                var ownerAccount = accounts[ownerAccountIndex];
                var name = ownerAccount[0];

                mergedAccounts.Add([name]);
            }

            var mergedAccount = mergedAccounts[mergedAccountIndex];

            mergedAccount.Add(email);
        }

        var mergedAccountsCount = mergedAccounts.Count;
        var result = new List<IList<string>>(mergedAccountsCount);

        for (var i = 0; i < mergedAccountsCount; i++)
        {
            var mergedAccount = mergedAccounts[i];
            var emailsCount = mergedAccount.Count - 1;

            mergedAccount.Sort(1, emailsCount, StringComparer.Ordinal);

            result.Add(mergedAccount);
        }

        return result;
    }

    /// <summary>
    ///     Finds the root of the set containing <paramref name="node" />, halving the path along the way.
    /// </summary>
    /// <param name="parents">The parent of each node, where a root is its own parent.</param>
    /// <param name="node">The node whose set root to find.</param>
    /// <returns>The root of the set containing <paramref name="node" />.</returns>
    /// <remarks>
    ///     Time complexity - O(α(n))
    ///     Space complexity - O(1)
    /// </remarks>
    private static int Find(Span<int> parents, int node)
    {
        var currentNode = node;

        for (var parent = parents[currentNode]; parent != currentNode; parent = parents[currentNode])
        {
            var grandparent = parents[parent];

            parents[currentNode] = grandparent;

            currentNode = grandparent;
        }

        return currentNode;
    }

    /// <summary>
    ///     Merges the sets containing <paramref name="x" /> and <paramref name="y" />, attaching the lower-rank root
    ///     under the higher-rank one.
    /// </summary>
    /// <param name="parents">The parent of each node, where a root is its own parent.</param>
    /// <param name="ranks">The rank of each root, an upper bound on its tree height.</param>
    /// <param name="x">A node of the first set.</param>
    /// <param name="y">A node of the second set.</param>
    /// <remarks>
    ///     Time complexity - O(α(n))
    ///     Space complexity - O(1)
    /// </remarks>
    private static void Union(Span<int> parents, Span<int> ranks, int x, int y)
    {
        var rootX = Find(parents, x);
        var rootY = Find(parents, y);

        if (rootX == rootY)
        {
            return;
        }

        var rankX = ranks[rootX];
        var rankY = ranks[rootY];

        if (rankX < rankY)
        {
            parents[rootX] = rootY;

            return;
        }

        parents[rootY] = rootX;

        if (rankX != rankY)
        {
            return;
        }

        ranks[rootX]++;
    }
}