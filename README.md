# LeetCode C# Solutions

[![.NET](https://github.com/eremeeveugene/leetcode/actions/workflows/dotnet.yml/badge.svg)](https://github.com/eremeeveugene/leetcode)

## Overview

Welcome to my repository of LeetCode solutions, all implemented in C#. Each solution is implemented using **Test-Driven Development (TDD)** and follows the **AAA (Arrange-Act-Assert)** pattern. I start by writing the tests before diving into the actual code, ensuring the solutions meet expected outcomes and minimizing bugs. This method is perfect for tackling algorithmic challenges where precision is crucial.

## Purpose

The primary goal of this repository is to improve my own skills and demonstrate my capabilities. I am focused on my growth and learning by providing efficient and well-tested solutions to a wide range of LeetCode problems.

## Technologies Used

- **[.NET 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)**: The latest version of the .NET platform for building and running applications.
- **[C# 12](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12)**: The programming language used to implement the solutions.
- **[MSTest](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest)**: A testing framework for .NET to write and run tests.
- **[Coverlet](https://github.com/coverlet-coverage/coverlet)**: A code coverage library for .NET that collects coverage data and integrates with build tasks.
- **[ReportGenerator](https://reportgenerator.io/)**: A tool to generate reports from the test coverage data.

## Time and Space Complexity

I analyze the time and space complexity using Big O notation for every algorithm solution in this repo. This analysis helps me understand each solution's efficiency and scalability.

## Automation Jobs

I've created automation jobs for this repository to streamline the development process. These jobs are defined in the `dotnet.yml` file and include steps for building the project, running tests with coverage, checking code style, and generating and uploading coverage reports. The jobs run on every push and pull request to the `develop` branch.

## Code Coverage Report

You can view the code coverage report [here](https://eremeeveugene.github.io/LeetCode-CS/).

## LeetCode Profile

Check out my [LeetCode](https://leetcode.com/u/eremeeveugene/) profile to see more about my problem-solving journey.

## Solutions by Category

Below are the LeetCode problems sorted by category. Click on the category names to explore the problems.

<details>
  <summary><strong>Algorithms</strong></summary>
  <p>

- [1. Two Sum](https://leetcode.com/problems/two-sum/description/)
- [2. Add Two Numbers](https://leetcode.com/problems/add-two-numbers/description/)
- [3. Longest Substring Without Repeating Characters](https://leetcode.com/problems/longest-substring-without-repeating-characters/description/)
- [4. Median of Two Sorted Arrays](https://leetcode.com/problems/median-of-two-sorted-arrays/description/)
- [5. Longest Palindromic Substring](https://leetcode.com/problems/longest-palindromic-substring/description/)
- [7. Reverse Integer](https://leetcode.com/problems/reverse-integer/description/)
- [9. Palindrome Number](https://leetcode.com/problems/palindrome-number/description/)
- [13. Roman to Integer](https://leetcode.com/problems/roman-to-integer/description/)
- [14. Longest Common Prefix](https://leetcode.com/problems/longest-common-prefix/description/)
- [15. 3Sum](https://leetcode.com/problems/3sum/description/)
- [19. Remove Nth Node From End of List](https://leetcode.com/problems/remove-nth-node-from-end-of-list/description/)
- [20. Valid Parentheses](https://leetcode.com/problems/valid-parentheses/description/)
- [21. Merge Two Sorted Lists](https://leetcode.com/problems/merge-two-sorted-lists/description/)
- [26. Remove Duplicates from Sorted Array](https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/)
- [27. Remove Element](https://leetcode.com/problems/remove-element/description/)
- [28. Find the Index of the First Occurrence in a String](https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/description/)
- [35. Search Insert Position](https://leetcode.com/problems/search-insert-position/description/)
- [41. First Missing Positive](https://leetcode.com/problems/first-missing-positive/description/)
- [42. Trapping Rain Water](https://leetcode.com/problems/trapping-rain-water/description/)
- [46. Permutations](https://leetcode.com/problems/permutations/description/)
- [57. Insert Interval](https://leetcode.com/problems/insert-interval/description/)
- [58. Length of Last Word](https://leetcode.com/problems/length-of-last-word/description/)
- [66. Plus One](https://leetcode.com/problems/plus-one/description/)
- [67. Add Binary](https://leetcode.com/problems/add-binary/description/)
- [69. Sqrt(x)](https://leetcode.com/problems/sqrtx/description/)
- [70. Climbing Stairs](https://leetcode.com/problems/climbing-stairs/description/)
- [75. Sort Colors](https://leetcode.com/problems/sort-colors/)
- [78. Subsets](https://leetcode.com/problems/subsets/description/)
- [79. Word Search](https://leetcode.com/problems/word-search/description/)
- [83. Remove Duplicates from Sorted List](https://leetcode.com/problems/remove-duplicates-from-sorted-list/description/)
- [85. Maximal Rectangle](https://leetcode.com/problems/maximal-rectangle/description/)
- [88. Merge Sorted Array](https://leetcode.com/problems/merge-sorted-array/description/)
- [94. Binary Tree Inorder Traversal](https://leetcode.com/problems/binary-tree-inorder-traversal/description/)
- [100. Same Tree](https://leetcode.com/problems/same-tree/description/)
- [101. Symmetric Tree](https://leetcode.com/problems/symmetric-tree/description/)
- [104. Maximum Depth of Binary Tree](https://leetcode.com/problems/maximum-depth-of-binary-tree/description/)
- [108. Convert Sorted Array to Binary Search Tree](https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/description/)
- [110. Balanced Binary Tree](https://leetcode.com/problems/balanced-binary-tree/description/)
- [111. Minimum Depth of Binary Tree](https://leetcode.com/problems/minimum-depth-of-binary-tree/description/)
- [112. Path Sum](https://leetcode.com/problems/path-sum/description/)
- [113. Path Sum II](https://leetcode.com/problems/path-sum-ii/description/)
- [118. Pascal's Triangle](https://leetcode.com/problems/pascals-triangle/description/)
- [119. Pascal's Triangle II](https://leetcode.com/problems/pascals-triangle-ii/description/)
- [121. Best Time to Buy and Sell Stock](https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/)
- [125. Valid Palindrome](https://leetcode.com/problems/valid-palindrome/description/)
- [129. Sum Root to Leaf Numbers](https://leetcode.com/problems/sum-root-to-leaf-numbers/description/)
- [131. Palindrome Partitioning](https://leetcode.com/problems/palindrome-partitioning/description/)
- [136. Single Number](https://leetcode.com/problems/single-number/description/)
- [137. Single Number II](https://leetcode.com/problems/single-number-ii/description/)
- [141. Linked List Cycle](https://leetcode.com/problems/linked-list-cycle/description/)
- [143. Reorder List](https://leetcode.com/problems/reorder-list/description/)
- [144. Binary Tree Preorder Traversal](https://leetcode.com/problems/binary-tree-preorder-traversal/description/)
- [145. Binary Tree Postorder Traversal](https://leetcode.com/problems/binary-tree-postorder-traversal/description/)
- [160. Intersection of Two Linked Lists](https://leetcode.com/problems/intersection-of-two-linked-lists/description/)
- [165. Compare Version Numbers](https://leetcode.com/problems/compare-version-numbers/description/)
- [168. Excel Sheet Column Title](https://leetcode.com/problems/excel-sheet-column-title/description/)
- [169. Majority Element](https://leetcode.com/problems/majority-element/description/)
- [171. Excel Sheet Column Number](https://leetcode.com/problems/excel-sheet-column-number/description/)
- [190. Reverse Bits](https://leetcode.com/problems/reverse-bits/description/)
- [191. Number of 1 Bits](https://leetcode.com/problems/number-of-1-bits/description/)
- [200. Number of Islands](https://leetcode.com/problems/number-of-islands/description/)
- [202. Happy Number](https://leetcode.com/problems/happy-number/description/)
- [203. Remove Linked List Elements](https://leetcode.com/problems/remove-linked-list-elements/description/)
- [205. Isomorphic Strings](https://leetcode.com/problems/isomorphic-strings/description/)
- [206. Reverse Linked List](https://leetcode.com/problems/reverse-linked-list/description/)
- [217. Contains Duplicate](https://leetcode.com/problems/contains-duplicate/description/)
- [219. Contains Duplicate II](https://leetcode.com/problems/contains-duplicate-ii/description/)
- [220. Contains Duplicate III](https://leetcode.com/problems/contains-duplicate-iii/description/)
- [222. Count Complete Tree Nodes](https://leetcode.com/problems/count-complete-tree-nodes/description/)
- [225. Implement Stack using Queues](https://leetcode.com/problems/implement-stack-using-queues/description/)
- [226. Invert Binary Tree](https://leetcode.com/problems/invert-binary-tree/description/)
- [228. Summary Ranges](https://leetcode.com/problems/summary-ranges/description/)
- [231. Power of Two](https://leetcode.com/problems/power-of-two/description/)
- [232. Implement Queue using Stacks](https://leetcode.com/problems/implement-queue-using-stacks/description/)
- [234. Palindrome Linked List](https://leetcode.com/problems/palindrome-linked-list/description/)
- [237. Delete Node in a Linked List](https://leetcode.com/problems/delete-node-in-a-linked-list/description/)
- [242. Valid Anagram](https://leetcode.com/problems/valid-anagram/description/)
- [257. Binary Tree Paths](https://leetcode.com/problems/binary-tree-paths/description/)
- [258. Add Digits](https://leetcode.com/problems/add-digits/description/)
- [260. Single Number III](https://leetcode.com/problems/single-number-iii/description/)
- [263. Ugly Number](https://leetcode.com/problems/ugly-number/description/)
- [268. Missing Number](https://leetcode.com/problems/missing-number/description/)
- [279. Perfect Squares](https://leetcode.com/problems/perfect-squares/description/)
- [283. Move Zeroes](https://leetcode.com/problems/move-zeroes/description/)
- [287. Find the Duplicate Number](https://leetcode.com/problems/find-the-duplicate-number/description/)
- [290. Word Pattern](https://leetcode.com/problems/word-pattern/description/)
- [292. Nim Game](https://leetcode.com/problems/nim-game/description/)
- [303. Range Sum Query - Immutable](https://leetcode.com/problems/range-sum-query-immutable/description/)
- [310. Minimum Height Trees](https://leetcode.com/problems/minimum-height-trees/description/)
- [326. Power of Three](https://leetcode.com/problems/power-of-three/description/)
- [338. Counting Bits](https://leetcode.com/problems/counting-bits/description/)
- [342. Power of Four](https://leetcode.com/problems/power-of-four/description/)
- [344. Reverse String](https://leetcode.com/problems/reverse-string/description/)
- [345. Reverse Vowels of a String](https://leetcode.com/problems/reverse-vowels-of-a-string/description/)
- [349. Intersection of Two Arrays](https://leetcode.com/problems/intersection-of-two-arrays/description/)
- [350. Intersection of Two Arrays II](https://leetcode.com/problems/intersection-of-two-arrays-ii/description/)
- [367. Valid Perfect Square](https://leetcode.com/problems/valid-perfect-square/description/)
- [392. Is Subsequence](https://leetcode.com/problems/is-subsequence/description/)
- [402. Remove K Digits](https://leetcode.com/problems/remove-k-digits/description/)
- [404. Sum of Left Leaves](https://leetcode.com/problems/sum-of-left-leaves/description/)
- [409. Longest Palindrome](https://leetcode.com/problems/longest-palindrome/description/)
- [414. Third Maximum Number](https://leetcode.com/problems/third-maximum-number/description/)
- [415. Add Strings](https://leetcode.com/problems/add-strings/description/)
- [429. N-ary Tree Level Order Traversal](https://leetcode.com/problems/n-ary-tree-level-order-traversal/description/)
- [441. Arranging Coins](https://leetcode.com/problems/arranging-coins/description/)
- [442. Find All Duplicates in an Array](https://leetcode.com/problems/find-all-duplicates-in-an-array/description/)
- [452. Minimum Number of Arrows to Burst Balloons](https://leetcode.com/problems/minimum-number-of-arrows-to-burst-balloons/description/)
- [459. Repeated Substring Pattern](https://leetcode.com/problems/repeated-substring-pattern/description/)
- [463. Island Perimeter](https://leetcode.com/problems/island-perimeter/description/)
- [496. Next Greater Element I](https://leetcode.com/problems/next-greater-element-i/description/)
- [501. Find Mode in Binary Search Tree](https://leetcode.com/problems/find-mode-in-binary-search-tree/description/)
- [506. Relative Ranks](https://leetcode.com/problems/relative-ranks/description/)
- [509. Fibonacci Number](https://leetcode.com/problems/fibonacci-number/description/)
- [513. Find Bottom Left Tree Value](https://leetcode.com/problems/find-bottom-left-tree-value/description/)
- [514. Freedom Trail](https://leetcode.com/problems/freedom-trail/description/)
- [523. Continuous Subarray Sum](https://leetcode.com/problems/continuous-subarray-sum/description/)
- [525. Contiguous Array](https://leetcode.com/problems/contiguous-array/description/)
- [541. Reverse String II](https://leetcode.com/problems/reverse-string-ii/description/)
- [543. Diameter of Binary Tree](https://leetcode.com/problems/diameter-of-binary-tree/description/)
- [557. Reverse Words in a String III](https://leetcode.com/problems/reverse-words-in-a-string-iii/description/)
- [561. Array Partition](https://leetcode.com/problems/array-partition/description/)
- [589. N-ary Tree Preorder Traversal](https://leetcode.com/problems/n-ary-tree-preorder-traversal/description/)
- [590. N-ary Tree Postorder Traversal](https://leetcode.com/problems/n-ary-tree-postorder-traversal/description/)
- [621. Task Scheduler](https://leetcode.com/problems/task-scheduler/description/)
- [623. Add One Row to Tree](https://leetcode.com/problems/add-one-row-to-tree/description/)
- [633. Sum of Square Numbers](https://leetcode.com/problems/sum-of-square-numbers/description/)
- [643. Maximum Average Subarray I](https://leetcode.com/problems/maximum-average-subarray-i/description/)
- [648. Replace Words](https://leetcode.com/problems/replace-words/description/)
- [678. Valid Parenthesis String](https://leetcode.com/problems/valid-parenthesis-string/description/)
- [680. Valid Palindrome II](https://leetcode.com/problems/valid-palindrome-ii/description/)
- [700. Search in a Binary Search Tree](https://leetcode.com/problems/search-in-a-binary-search-tree/description/)
- [704. Binary Search](https://leetcode.com/problems/binary-search/description/)
- [713. Subarray Product Less Than K](https://leetcode.com/problems/subarray-product-less-than-k/description/)
- [724. Find Pivot Index](https://leetcode.com/problems/find-pivot-index/description/)
- [733. Flood Fill](https://leetcode.com/problems/flood-fill/description/)
- [746. Min Cost Climbing Stairs](https://leetcode.com/problems/min-cost-climbing-stairs/description/)
- [752. Open the Lock](https://leetcode.com/problems/open-the-lock/description/)
- [771. Jewels and Stones](https://leetcode.com/problems/jewels-and-stones/description/)
- [786. K-th Smallest Prime Fraction](https://leetcode.com/problems/k-th-smallest-prime-fraction/description/)
- [787. Cheapest Flights Within K Stops](https://leetcode.com/problems/cheapest-flights-within-k-stops/description/)
- [791. Custom Sort String](https://leetcode.com/problems/custom-sort-string/description/)
- [804. Unique Morse Code Words](https://leetcode.com/problems/unique-morse-code-words/description/)
- [834. Sum of Distances in Tree](https://leetcode.com/problems/sum-of-distances-in-tree/description/)
- [846. Hand of Straights](https://leetcode.com/problems/hand-of-straights/description/)
- [857. Minimum Cost to Hire K Workers](https://leetcode.com/problems/minimum-cost-to-hire-k-workers/description/)
- [861. Score After Flipping Matrix](https://leetcode.com/problems/score-after-flipping-matrix/description/)
- [881. Boats to Save People](https://leetcode.com/problems/boats-to-save-people/description/)
- [912. Sort an Array](https://leetcode.com/problems/sort-an-array/description/)
- [930. Binary Subarrays With Sum](https://leetcode.com/problems/binary-subarrays-with-sum/description/)
- [938. Range Sum of BST](https://leetcode.com/problems/range-sum-of-bst/description/)
- [945. Minimum Increment to Make Array Unique](https://leetcode.com/problems/minimum-increment-to-make-array-unique/description/)
- [948. Bag of Tokens](https://leetcode.com/problems/bag-of-tokens/description/)
- [950. Reveal Cards In Increasing Order](https://leetcode.com/problems/reveal-cards-in-increasing-order/description/)
- [974. Subarray Sums Divisible by K](https://leetcode.com/problems/subarray-sums-divisible-by-k/description/)
- [977. Squares of a Sorted Array](https://leetcode.com/problems/squares-of-a-sorted-array/description/)
- [979. Distribute Coins in Binary Tree](https://leetcode.com/problems/distribute-coins-in-binary-tree/description/)
- [988. Smallest String Starting From Leaf](https://leetcode.com/problems/smallest-string-starting-from-leaf/description/)
- [989. Add to Array-Form of Integer](https://leetcode.com/problems/add-to-array-form-of-integer/description/)
- [992. Subarrays with K Different Integers](https://leetcode.com/problems/subarrays-with-k-different-integers/description/)
- [997. Find the Town Judge](https://leetcode.com/problems/find-the-town-judge/description/)
- [1002. Find Common Characters](https://leetcode.com/problems/find-common-characters/description/)
- [1013. Partition Array Into Three Parts With Equal Sum](https://leetcode.com/problems/partition-array-into-three-parts-with-equal-sum/description/)
- [1025. Divisor Game](https://leetcode.com/problems/divisor-game/description/)
- [1051. Height Checker](https://leetcode.com/problems/height-checker/description/)
- [1108. Defanging an IP Address](https://leetcode.com/problems/defanging-an-ip-address/description/)
- [1110. Delete Nodes And Return Forest](https://leetcode.com/problems/delete-nodes-and-return-forest/description/)
- [1122. Relative Sort Array](https://leetcode.com/problems/relative-sort-array/description/)
- [1137. N-th Tribonacci Number](https://leetcode.com/problems/n-th-tribonacci-number/description/)
- [1171. Remove Zero Sum Consecutive Nodes from Linked List](https://leetcode.com/problems/remove-zero-sum-consecutive-nodes-from-linked-list/description/)
- [1185. Day of the Week](https://leetcode.com/problems/day-of-the-week/description/)
- [1190. Reverse Substrings Between Each Pair of Parentheses](https://leetcode.com/problems/reverse-substrings-between-each-pair-of-parentheses/description/)
- [1208. Get Equal Substrings Within Budget](https://leetcode.com/problems/get-equal-substrings-within-budget/description/)
- [1219. Path with Maximum Gold](https://leetcode.com/problems/path-with-maximum-gold/description/)
- [1249. Minimum Remove to Make Valid Parentheses](https://leetcode.com/problems/minimum-remove-to-make-valid-parentheses/description/)
- [1281. Subtract the Product and Sum of Digits of an Integer](https://leetcode.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/description/)
- [1289. Minimum Falling Path Sum II](https://leetcode.com/problems/minimum-falling-path-sum-ii/description/)
- [1296. Divide Array in Sets of K Consecutive Numbers](https://leetcode.com/problems/divide-array-in-sets-of-k-consecutive-numbers/description/)
- [1323. Maximum 69 Number](https://leetcode.com/problems/maximum-69-number/description/)
- [1325. Delete Leaves With a Given Value](https://leetcode.com/problems/delete-leaves-with-a-given-value/description/)
- [1342. Number of Steps to Reduce a Number to Zero](https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/description/)
- [1365. How Many Numbers Are Smaller Than the Current Number](https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/description/)
- [1370. Increasing Decreasing String](https://leetcode.com/problems/increasing-decreasing-string/description/)
- [1379. Find a Corresponding Node of a Binary Tree in a Clone of That Tree](https://leetcode.com/problems/find-a-corresponding-node-of-a-binary-tree-in-a-clone-of-that-tree/description/)
- [1380. Lucky Numbers in a Matrix](https://leetcode.com/problems/lucky-numbers-in-a-matrix/description/)
- [1404. Number of Steps to Reduce a Number in Binary Representation to One](https://leetcode.com/problems/number-of-steps-to-reduce-a-number-in-binary-representation-to-one/description/)
- [1408. String Matching in an Array](https://leetcode.com/problems/string-matching-in-an-array/)
- [1442. Count Triplets That Can Form Two Arrays of Equal XOR](https://leetcode.com/problems/count-triplets-that-can-form-two-arrays-of-equal-xor/description/)
- [1464. Maximum Product of Two Elements in an Array](https://leetcode.com/problems/maximum-product-of-two-elements-in-an-array/description/)
- [1470. Shuffle the Array](https://leetcode.com/problems/shuffle-the-array/description/)
- [1480. Running Sum of 1d Array](https://leetcode.com/problems/running-sum-of-1d-array/description/)
- [1486. XOR Operation in an Array](https://leetcode.com/problems/xor-operation-in-an-array/description/)
- [1500. Three Consecutive Odds](https://leetcode.com/problems/three-consecutive-odds/description/)
- [1509. Minimum Difference Between Largest and Smallest Value in Three Moves](https://leetcode.com/problems/minimum-difference-between-largest-and-smallest-value-in-three-moves/description/)
- [1512. Number of Good Pairs](https://leetcode.com/problems/number-of-good-pairs/description/)
- [1518. Water Bottles](https://leetcode.com/problems/water-bottles/description/)
- [1528. Shuffle String](https://leetcode.com/problems/shuffle-string/description/)
- [1530. Number of Good Leaf Nodes Pairs](https://leetcode.com/problems/number-of-good-leaf-nodes-pairs/description/)
- [1544. Make The String Great](https://leetcode.com/problems/make-the-string-great/description/)
- [1598. Crawler Log Folder](https://leetcode.com/problems/crawler-log-folder/description/)
- [1605. Find Valid Matrix Given Row and Column Sums](https://leetcode.com/problems/find-valid-matrix-given-row-and-column-sums/description/)
- [1608. Special Array With X Elements Greater Than or Equal X](https://leetcode.com/problems/special-array-with-x-elements-greater-than-or-equal-x/description/)
- [1609. Even Odd Tree](https://leetcode.com/problems/even-odd-tree/description/)
- [1614. Maximum Nesting Depth of the Parentheses](https://leetcode.com/problems/maximum-nesting-depth-of-the-parentheses/description/)
- [1630. Arithmetic Subarrays](https://leetcode.com/problems/arithmetic-subarrays/description/)
- [1636. Sort Array by Increasing Frequency](https://leetcode.com/problems/sort-array-by-increasing-frequency/description/)
- [1637. Widest Vertical Area Between Two Points Containing No Points](https://leetcode.com/problems/widest-vertical-area-between-two-points-containing-no-points/description/)
- [1656. Design an Ordered Stream](https://leetcode.com/problems/design-an-ordered-stream/description/)
- [1662. Check If Two String Arrays are Equivalent](https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/description/)
- [1672. Richest Customer Wealth](https://leetcode.com/problems/richest-customer-wealth/description/)
- [1678. Goal Parser Interpretation](https://leetcode.com/problems/goal-parser-interpretation/description/)
- [1688. Count of Matches in Tournament](https://leetcode.com/problems/count-of-matches-in-tournament/description/)
- [1700. Number of Students Unable to Eat Lunch](https://leetcode.com/problems/number-of-students-unable-to-eat-lunch/description/)
- [1716. Calculate Money in Leetcode Bank](https://leetcode.com/problems/calculate-money-in-leetcode-bank/description/)
- [1720. Decode XORed Array](https://leetcode.com/problems/decode-xored-array/description/)
- [1750. Minimum Length of String After Deleting Similar Ends](https://leetcode.com/problems/minimum-length-of-string-after-deleting-similar-ends/description/)
- [1791. Find Center of Star Graph](https://leetcode.com/problems/find-center-of-star-graph/description/)
- [1832. Check if the Sentence Is Pangram](https://leetcode.com/problems/check-if-the-sentence-is-pangram/description/)
- [1859. Sorting the Sentence](https://leetcode.com/problems/sorting-the-sentence/description/)
- [1863. Sum of All Subset XOR Totals](https://leetcode.com/problems/sum-of-all-subset-xor-totals/description/)
- [1915. Number of Wonderful Substrings](https://leetcode.com/problems/number-of-wonderful-substrings/description/)
- [1920. Build Array from Permutation](https://leetcode.com/problems/build-array-from-permutation/description/)
- [1929. Concatenation of Array](https://leetcode.com/problems/concatenation-of-array/description/)
- [1935. Maximum Number of Words You Can Type](https://leetcode.com/problems/maximum-number-of-words-you-can-type/description/)
- [1971. Find if Path Exists in Graph](https://leetcode.com/problems/find-if-path-exists-in-graph/description/)
- [1991. Find the Middle Index in Array](https://leetcode.com/problems/find-the-middle-index-in-array/description/)
- [1992. Find All Groups of Farmland](https://leetcode.com/problems/find-all-groups-of-farmland/description/)
- [2000. Reverse Prefix of Word](https://leetcode.com/problems/reverse-prefix-of-word/description/)
- [2011. Final Value of Variable After Performing Operations](https://leetcode.com/problems/final-value-of-variable-after-performing-operations/description/)
- [2037. Minimum Number of Moves to Seat Everyone](https://leetcode.com/problems/minimum-number-of-moves-to-seat-everyone/description/)
- [2058. Find the Minimum and Maximum Number of Nodes Between Critical Points](https://leetcode.com/problems/find-the-minimum-and-maximum-number-of-nodes-between-critical-points/description/)
- [2073. Time Needed to Buy Tickets](https://leetcode.com/problems/time-needed-to-buy-tickets/description/)
- [2114. Maximum Number of Words Found in Sentences](https://leetcode.com/problems/maximum-number-of-words-found-in-sentences/description/)
- [2160. Minimum Sum of Four Digit Number After Splitting Digits](https://leetcode.com/problems/minimum-sum-of-four-digit-number-after-splitting-digits/description/)
- [2181. Merge Nodes in Between Zeros](https://leetcode.com/problems/merge-nodes-in-between-zeros/description/)
- [2191. Sort the Jumbled Numbers](https://leetcode.com/problems/sort-the-jumbled-numbers/description/)
- [2196. Create Binary Tree From Descriptions](https://leetcode.com/problems/create-binary-tree-from-descriptions/description/)
- [2215. Find the Difference of Two Arrays](https://leetcode.com/problems/find-the-difference-of-two-arrays/description/)
- [2235. Add Two Integers](https://leetcode.com/problems/add-two-integers/description/)
- [2236. Root Equals Sum of Children](https://leetcode.com/problems/root-equals-sum-of-children/description/)
- [2331. Evaluate Boolean Binary Tree](https://leetcode.com/problems/evaluate-boolean-binary-tree/description/)
- [2370. Longest Ideal Subsequence](https://leetcode.com/problems/longest-ideal-subsequence/description/)
- [2373. Largest Local Values in a Matrix](https://leetcode.com/problems/largest-local-values-in-a-matrix/description/)
- [2413. Smallest Even Multiple](https://leetcode.com/problems/smallest-even-multiple/description/)
- [2415. Reverse Odd Levels of Binary Tree](https://leetcode.com/problems/reverse-odd-levels-of-binary-tree/description/)
- [2418. Sort the People](https://leetcode.com/problems/sort-the-people/description/)
- [2433. Find The Original Array of Prefix Xor](https://leetcode.com/problems/find-the-original-array-of-prefix-xor/description/)
- [2441. Largest Positive Integer That Exists With Its Negative](https://leetcode.com/problems/largest-positive-integer-that-exists-with-its-negative/description/)
- [2444. Count Subarrays With Fixed Bounds](https://leetcode.com/problems/count-subarrays-with-fixed-bounds/description/)
- [2469. Convert the Temperature](https://leetcode.com/problems/convert-the-temperature/description/)
- [2485. Find the Pivot Integer](https://leetcode.com/problems/find-the-pivot-integer/description/)
- [2486. Append Characters to String to Make Subsequence](https://leetcode.com/problems/append-characters-to-string-to-make-subsequence/description/)
- [2487. Remove Nodes From Linked List](https://leetcode.com/problems/remove-nodes-from-linked-list/description/)
- [2520. Count the Digits That Divide a Number](https://leetcode.com/problems/count-the-digits-that-divide-a-number/description/)
- [2535. Difference Between Element Sum and Digit Sum of an Array](https://leetcode.com/problems/difference-between-element-sum-and-digit-sum-of-an-array/description/)
- [2540. Minimum Common Value](https://leetcode.com/problems/minimum-common-value/description/)
- [2574. Left and Right Sum Differences](https://leetcode.com/problems/left-and-right-sum-differences/description/)
- [2582. Pass the Pillow](https://leetcode.com/problems/pass-the-pillow/description/)
- [2591. Distribute Money to Maximum Children](https://leetcode.com/problems/distribute-money-to-maximum-children/description/)
- [2597. The Number of Beautiful Subsets](https://leetcode.com/problems/the-number-of-beautiful-subsets/description/)
- [2651. Calculate Delayed Arrival Time](https://leetcode.com/problems/calculate-delayed-arrival-time/description/)
- [2652. Sum Multiples](https://leetcode.com/problems/sum-multiples/description/)
- [2706. Buy Two Chocolates](https://leetcode.com/problems/buy-two-chocolates/description/)
- [2733. Neither Minimum nor Maximum](https://leetcode.com/problems/neither-minimum-nor-maximum/description/)
- [2769. Find the Maximum Achievable Number](https://leetcode.com/problems/find-the-maximum-achievable-number/description/)
- [2810. Faulty Keyboard](https://leetcode.com/problems/faulty-keyboard/description/)
- [2812. Find the Safest Path in a Grid](https://leetcode.com/problems/find-the-safest-path-in-a-grid/description/)
- [2816. Double a Number Represented as a Linked List](https://leetcode.com/problems/double-a-number-represented-as-a-linked-list/description/)
- [2824. Count Pairs Whose Sum is Less than Target](https://leetcode.com/problems/count-pairs-whose-sum-is-less-than-target/description/)
- [2864. Maximum Odd Binary Number](https://leetcode.com/problems/maximum-odd-binary-number/description/)
- [2894. Divisible and Non-divisible Sums Difference](https://leetcode.com/problems/divisible-and-non-divisible-sums-difference/description/)
- [2942. Find Words Containing Character](https://leetcode.com/problems/find-words-containing-character/description/)
- [2958. Length of Longest Subarray With at Most K Frequency](https://leetcode.com/problems/length-of-longest-subarray-with-at-most-k-frequency/description/)
- [2962. Count Subarrays Where Max Element Appears at Least K Times](https://leetcode.com/problems/count-subarrays-where-max-element-appears-at-least-k-times/description/)
- [2974. Minimum Number Game](https://leetcode.com/problems/minimum-number-game/description/)
- [2997. Minimum Number of Operations to Make Array XOR Equal to K](https://leetcode.com/problems/minimum-number-of-operations-to-make-array-xor-equal-to-k/description/)
- [3005. Count Elements With Maximum Frequency](https://leetcode.com/problems/count-elements-with-maximum-frequency/description/)
- [3068. Find the Maximum Sum of Node Values](https://leetcode.com/problems/find-the-maximum-sum-of-node-values/description/)
- [3075. Maximize Happiness of Selected Children](https://leetcode.com/problems/maximize-happiness-of-selected-children/description/)
- [3110. Score of a String](https://leetcode.com/problems/score-of-a-string/description/)
- [3190. Find Minimum Operations to Make All Elements Divisible by Three](https://leetcode.com/problems/find-minimum-operations-to-make-all-elements-divisible-by-three/description/)

  </p>
</details>

<details>
  <summary><strong>Concurrency</strong></summary>
  <p>
    
- [1114. Print in Order](https://leetcode.com/problems/print-in-order/description/)
- [1195. Fizz Buzz Multithreaded](https://leetcode.com/problems/fizz-buzz-multithreaded/description/)

  </p>
</details>

## License

This project is licensed under a custom license. See the [LICENSE](LICENSE) file for details.
