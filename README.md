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

