# C# Basics

This repository contains solutions for a set of coding tasks. Each task is described below along with its requirements and expected output.

## Table of Contents
- [Task 1: Palindrome Checker](#task-1-palindrome-checker)
- [Task 2: Array Value Swapper](#task-2-array-value-swapper)
- [Task 3: Matrix Transformation](#task-3-matrix-transformation)
- [Task 4: Game of Life](#task-4-game-of-life)

## Task 1: Palindrome Checker

**Description**: Write a console application that accepts a string and determines for each word in the string whether it is a palindrome. Ignore letter case and hyphens.

**Example**:
Input: "Hgggh, jsj lkks, a lil-lil – lop."
Output: 
- Hgggh – palindrome
- jsj – palindrome
- lkks – not palindrome
- a - palindrome
- lil-lil – palindrome
- lop – not palindrome

## Task 2: Array Value Swapper

**Description**: Write code that swaps specific values in an array, e.g., the first and last values, the second and penultimate values, and so on. The array input and output can be done from the console.

**Example**:
Input: [10, 5, 3, 4]
Output: [4, 3, 5, 10]

## Task 3: Matrix Transformation

**Description**: Write code that inserts the value of zero to the elements on the left side of the main diagonal into an array-matrix of arbitrary size and a value of one to the right. The initial matrix should be declared and filled in the code. Write the result to another variable - an array of the same size as the original one without modifying the original matrix.

## Task 4: Game of Life

**Description**: Implement Conway's Game of Life. The initial state of the field is set using a two-dimensional array. Output the initial state of the field to the console, and for each generation, output the new state of the field to the console in the specified format.

**Rules**: 
- '+' stands for living cells
- '-' stands for empty cells
- If the field is empty, display "Game over."
- If the field does not change during a generation, display "Game over."
