# FsDSA - F# Data Structures & Algorithms

A collection of data structures, algorithms, and problem solutions implemented in F#, demonstrating functional programming patterns and best practices.

**Target Framework:** .NET 9.0
**Last Updated:** November 2025

## Project Structure

```
FsDSA/
├── FsDSA/                    # Main library project
│   ├── Algos/               # Algorithm implementations
│   ├── DataStructures/      # Data structure implementations
│   ├── Problems/            # Problem solutions
│   │   └── Arrays/          # Array-specific problems
│   └── LanguageUsage/       # F# language feature examples
└── FsDSA.Tests/             # xUnit test project
    ├── Algos/               # Algorithm tests
    ├── Problems/            # Problem solution tests
    └── LanguageUsage/       # Language feature tests
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

## Algorithms

### Array Operations (`Algos/Arrays.fs`)
- **print2DArray** - Utility for printing 2D arrays

### List Operations (`Algos/Lists.fs`)
- **sum** - Tail-recursive list sum (stack-safe)
- **print2DList** - Utility for printing 2D lists
- **allPermutations** - Generate all permutations of a list

### String Operations (`Algos/Strings.fs`)
- **isPalindrome** - Case-insensitive palindrome check (alphanumeric only)
- **mergeAlternately** - Merge two strings by alternating characters from each string

## Problem Solutions

### 1. Two Sum (`Problems/SumTo.fs`)

**Problem:** Given a list of numbers and target `k`, determine if any two numbers sum to `k`.

**Solution:** `hasSumTo`
- **Approach:** Single-pass using a Set for O(1) lookups
- **Time Complexity:** O(n)
- **Space Complexity:** O(n)

**Test Coverage:** 8 test cases

---

### 2. Product of Array Except Self (`Problems/Products.fs`)

**Problem:** Return an array where each element is the product of all other elements (no division allowed for optimal solution).

**Three Implementations:**

1. **productsWithDivision** - Uses total product divided by current element
   - Time: O(n), Space: O(1)

2. **productsQuadratic** - Naive nested loop approach
   - Time: O(n²), Space: O(1)

3. **products** - Optimal prefix/suffix product approach
   - Time: O(n), Space: O(n)
   - **Recommended solution**

**Test Coverage:** 2 test cases

---

### 3. Remove Duplicates from Sorted Array (`Problems/Arrays/RemoveDuplicates.fs`)

**Problem:** Remove duplicates in-place from a sorted array, return count of unique elements.

**Solution:** `removeDuplicates`
- **Approach:** Two-pointer technique with cascade swapping
- **Mutates:** Array in-place (pushes duplicates to end)
- **Uses:** Set to track seen elements

**Test Coverage:** 2 test cases

## F# Language Features Demonstrated

### Core Functional Patterns
- **Discriminated Unions** - Algebraic data types for tree structure
- **Pattern Matching** - Expressive handling of different cases
- **Tail Recursion** - Stack-safe recursive algorithms (marked with `[<TailCall>]`)
- **Immutability** - Default approach for most data structures
- **Option Types** - Safe handling of optional values
- **Piping (`|>`)** - Clean data transformation pipelines

### Advanced Features (`LanguageUsage/`)
- **Optional Parameters** - Methods with `?` operator
- **Type Inference** - Generic types (`'a`) throughout
- **String Interpolation** - F# 5.0+ style

## Running Tests

```bash
# Run all tests
dotnet test

# Run with coverage
dotnet test /p:CollectCoverage=true
```

**Test Statistics:** 20 unit tests across 6 test files

## Getting Started

```fsharp
// Example: Using Binary Tree
open FsDSA.DataStructures

let tree = Node(5, Node(3, Empty, Empty), Node(7, Empty, Empty))
let height = BinaryTree.height tree  // Returns 2
let balanced = BinaryTree.isBalanced tree  // Returns true

// Example: Two Sum problem
open FsDSA.Problems

let numbers = [2; 7; 11; 15]
let hasSum = SumTo.hasSumTo 9 numbers  // Returns true (2 + 7 = 9)

// Example: Product of Array Except Self
open FsDSA.Problems

let arr = [|1; 2; 3; 4|]
let result = Products.products arr  // Returns [|24; 12; 8; 6|]
```

## Code Quality Features

- **Comprehensive Testing** - xUnit tests with descriptive names
- **Multiple Approaches** - Demonstrates trade-offs (e.g., Products problem)
- **Complexity Analysis** - Comments document time/space complexity
- **Clean Organization** - Logical file structure and compilation order
- **Documentation** - Clear problem statements and solution explanations

## Notes

- The project prioritizes **clarity and functional style** over mutation
- **RemoveDuplicates** is the only solution using in-place mutation (by requirement)
- Multiple solution variations show algorithm evolution and trade-offs
- All recursive solutions are tail-call optimized where possible

## Contributing

When adding new solutions:
1. Add implementation to appropriate folder in `FsDSA/`
2. Add corresponding tests in `FsDSA.Tests/`
3. Update `.fsproj` files with compilation order
4. Document time/space complexity in comments
5. Use descriptive test names with backticks

## License

Educational project for learning F# and data structures & algorithms.
