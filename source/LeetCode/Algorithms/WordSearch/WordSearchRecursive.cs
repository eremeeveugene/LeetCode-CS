// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.WordSearch;

/// <inheritdoc />
public class WordSearchRecursive : IWordSearch
{
    /// <summary>
    ///     Time complexity - O(m * n * 3^L), where m and n are the dimensions of the board and L is the length of the word
    ///     Space complexity - O(m * n), where m and n are the dimensions of the board
    /// </summary>
    /// <param name="board"></param>
    /// <param name="word"></param>
    /// <returns></returns>
    public bool Exist(char[][] board, string word)
    {
        var visited = new bool[board.Length, board[0].Length];

        for (var i = 0; i < board.Length; i++)
        {
            for (var j = 0; j < board[i].Length; j++)
            {
                if (board[i][j] != word[0])
                {
                    continue;
                }

                if (Search(board, word, i, j, 0, visited))
                {
                    return true;
                }
            }
        }

        return false;
    }

    private static bool Search(IReadOnlyList<char[]> board, string word, int i, int j, int index, bool[,] visited)
    {
        if (index == word.Length)
        {
            return true;
        }

        if (i < 0 || i >= board.Count || j < 0 || j >= board[0].Length)
        {
            return false;
        }

        if (visited[i, j] || board[i][j] != word[index])
        {
            return false;
        }

        visited[i, j] = true;

        if (Search(board, word, i + 1, j, index + 1, visited) ||
            Search(board, word, i - 1, j, index + 1, visited) ||
            Search(board, word, i, j + 1, index + 1, visited) ||
            Search(board, word, i, j - 1, index + 1, visited))
        {
            return true;
        }

        visited[i, j] = false;

        return false;
    }
}