# String Rotation
Assume you have a method `isSubstring` which checks if one word is a substring 
of another.  
Given two strings, `s1` and `s2`, write code to check if `s2` is a rotation of `s1` using only one 
call to `isSubstring`  

(e.g., "waterbottle" is a rotation of"erbottlewat"). 

## Line of thinking
### First Try
- Loop through rotate string until find the strings start matching
- Calculate the position to compare using a circular position (`string[position % length]`)
- Use `2*len` a secure stop-point, in case the string doesn't match
- Slower, but no allocation required.

### Second Try
- Concatenates the rotated string (`s2+s2`) to join the parts rotated
- After, call the `isSubstring(s1,s2)` to find if the concatenated string have the original one
- Faster, but requires allocation

# Hints
- [#34](../../../hints.md#34)
- [#88](../../../hints.md#88)
- [#104](../../../hints.md#104)


# Benchmark
