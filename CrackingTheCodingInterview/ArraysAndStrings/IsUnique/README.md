# Is Unique
Implement an algorithm to determine if a string has all unique characters. 
What if you cannot use additional data structures? 

## Line of thinking
- Ask if string is ASCII or Unicode. ASCII have 128 characteres, while Unicode over 143k.
- If string exceeds the ASCII table size (considering an ASCII string), it is already false, because you cannot write an string with more than the avaiable chars without repeating.
- 

## First Try
**Time Complexity:** O(n)  
**Space Complexity:** O(1)

## Second Try
**Time Complexity:** O(n)  
**Space Complexity:** O(1)



# Hints
- [#44](../../../hints.md#44)
- [#117](../../../hints.md#117)
- [#132](../../../hints.md#132)

# Benchmark