# Check Permutations
Given two strings, write a method to decide if one is a permutation of the other.

## Thinking
- If lengths are different, they are not the permutation.
- Consider ASCII vs Unicode for allocation

## Possibilities
- It's possible to create 2 `int[ASCII TABLE SIZE(128)]`, and increment when the char is found, 
and then compare the lists for the same counts.
  - Not implemented, but would be an O(n), with more allocation.
- On the other hand, it's possible to use only one `int[128]` and increment with `string A` and decrement with 
`string B`. This way, the list must have only `0's` at the end to be equal.
  - O(n).
- Convert `A` and `B` to `char[]`, sort the array, return to `string` and compare. Not the best performance, but the cleaner code.
  - Loop twice on each string... It's a O(n), more precisely O(2n).
- In some sense, following the last option, we can compare the `char[]` instead of returning to string. This will save a lot of allocation space.
  - More than O(n), perhaps O(n log n) due sorting.


# Hints
- [#1](../../../hints.md#1)
- [#84](../../../hints.md#84)
- [#122](../../../hints.md#122)
- [#131](../../../hints.md#131)


# Benchmark