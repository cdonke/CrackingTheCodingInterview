# String Compression
Implement a method to perform basic string compression using the counts of repeated characters.  
For example, the string `aabcccccaaa` would become `a2blc5a3`.  
If the "compressed" string would not become smaller than the original string, your method should return 
the original string.  
You can assume the string has only uppercase and lowercase letters (a - z). 

## Line of thinking
- If `len(A) == 1`, there is no way the result would be smaller. Return `A`.
- The most crucial point is how to build the string at the end.
   - There are several options to hold the information while parsing... `StringBuilder`, `char[]`+`int[]`, Stacks. 
   but at the end, building the result string presents an allocation cost.
- Because of that, StringBuilder might be the better choice.


# Hints
- [#92](../../../hints.md#92)
- [#110](../../../hints.md#110)

# Benchmark