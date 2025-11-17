# FsDSA - F# Data Structures & Algorithms

A collection of data structures, algorithms, and problem solutions implemented in F#, demonstrating functional programming patterns and best practices.

**Target Framework:** .NET 9.0
**Last Updated:** November 2025

## Project Structure

```
FsDSA/
├── FsDSA/                   # Main F# library project
│   ├── DataStructures/      # Data structure implementations
│   ├── Problems/            # Problem solutions
│   │   ├── Arrays/          # Array-specific problems
│   │   └── Strings/         # String manipulation problems
│   ├── Utilities/           # Helper functions and utilities
│   └── LanguageUsage/       # F# language feature examples
├── FsDSA.Tests/             # xUnit test project
│   ├── DataStructures/      # Data structure tests
│   ├── Problems/            # Problem solution tests
│   │   ├── Arrays/          # Array problem tests
│   │   └── Strings/         # String problem tests
│   └── LanguageUsage/       # Language feature tests
└── Python/                  # Python implementations
    ├── array_string.py      # Array and string problem solutions
    └── tests/               # Python test suite
        └── test_array_string.py
```

## Data Structures

### Binary Tree (`DataStructures/Tree.fs`)

Immutable binary tree implementation using discriminated unions:

```fsharp
type BinaryTree<'a> =
    | Empty
    | Node of value: 'a * left : BinaryTree<'a> * right : BinaryTree<'a>
```

**Operations:**
- `preorder` - Root → Left → Right traversal
- `inorder` - Left → Root → Right traversal
- `postorder` - Left → Right → Root traversal
- `height` - Calculate tree height
- `isBalanced` - Check if height difference ≤ 1
- `isSymmetric` - Check if tree is a mirror of itself

## Problems

### Array Problems (`Problems/Arrays/`)

- **Two Sum** (`TwoSum.fs`) - Find two numbers that add up to a target
- **Remove Duplicates** (`RemoveDuplicates.fs`) - Remove duplicates from sorted array
- **Product Except Self** (`ProductExceptSelf.fs`) - Calculate product of array except self
- **Increasing Triplet** (`IncreasingTriplet.fs`) - Find if there exists an increasing triplet subsequence

### String Problems (`Problems/Strings/`)

- **Palindrome** (`Palindrome.fs`) - Check if a string is a palindrome
- **GCD of Strings** (`GcdOfStrings.fs`) - Find greatest common divisor of two strings
- **Merge Alternately** (`MergeAlternately.fs`) - Merge two strings by alternating characters

## Utilities

Helper functions and utilities to support the implementations:

- **Print Helpers** (`Utilities/PrintHelpers.fs`) - Formatting and display utilities
- **List Helpers** (`Utilities/ListHelpers.fs`) - Common list operations and helpers

## Language Usage Examples

Examples demonstrating F# language features and patterns:

- **Optional Parameters** (`LanguageUsage/OptionalParameters.fs`) - Working with optional parameters
- **Query Parameter Pretty Print** (`LanguageUsage/QueryParameterPrettyPrint.fs`) - Query parameter formatting


# DSA Concepts

**Arrays and Strings**
- Two pointers (opposite direction)
- Two pointers (same direction)
- Sliding window (fixed size)
- Sliding window (variable size)
- Prefix/suffix arrays
- In-place manipulation
- Sorting + custom logic

**Hashmaps and Sets**
- Frequency counting
- Grouping/bucketing with hash keys
- O(1) lookup for existence checks
- Prefix sum + hashmap
- Multiple hashsets for constraints
- Deduplication

**Linked Lists**
- Fast/slow pointers (cycle detection, finding middle)
- Dummy node pattern
- Two pointer with gap
- In-place reversal
- Merging lists
- Recursion vs iteration trade-offs

**Stacks and Queues**
- Monotonic stack (next greater/smaller element)
- Stack for matching/validation
- Stack for evaluation (postfix, infix)
- Augmented data structures (min/max tracking)
- Queue simulation with stacks
- Deque for sliding window maximum

**Trees and Graphs**
- DFS (preorder, inorder, postorder)
- BFS (level-order traversal)
- Binary search tree properties
- Lowest common ancestor
- Graph traversal (DFS/BFS on grids and graphs)
- Topological sort
- Cycle detection
- Union-find (disjoint sets)

**Heaps**
- Kth largest/smallest element
- Top K elements
- Two heaps pattern (median maintenance)
- K-way merge
- Priority queue simulation
- Custom comparators

**Greedy**
- Feasibility greedy (can we do it?)
- Optimization greedy (what's the best way?)
- Interval scheduling
- Sorting + greedy choice
- Local optimal → global optimal proof

**Binary Search**
- Basic binary search template
- Search in modified arrays (rotated, shifted)
- Finding boundaries (first/last occurrence)
- Binary search on answer space
- Minimizing maximum / maximizing minimum

**Backtracking**
- Subset generation
- Permutation generation
- Combination generation
- Constraint propagation
- Pruning strategies
- State space exploration (N-Queens, Sudoku)

**Dynamic Programming**
- 1D DP (Fibonacci-style)
- 1D DP with constraints
- 2D DP (grid problems, LCS)
- Knapsack variants (0/1, unbounded, bounded)
- State transition identification
- Memoization vs tabulation
- Space optimization
