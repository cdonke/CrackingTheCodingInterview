To understand these expressions, recall that these operations occur *bit-by-bit*, with what's happening on 
one bit never impacting the other bits. 

This means that if one of the above statements is true for a single bit, 
then it's true for a sequence of bits

# x XOR 0s = x
- 0s is 00000
## Rule
- 1 ^ 0 = 1
- 0 ^ 0 = 0

This way, anything XOR 0, is anything, since there is no change.

# x XOR 1s = ~x

## Rule
- 1 ^ 1 = 0
- 0 ^ 1 = 1

Anything XOR 1 is inverted.

# x XOR x = 0
- 1 ^ 1 = 0
- 0 ^ 0 = 0

XOR of the same bit is the inverse of it

# x AND 0s = 0
- AND is only 1, when both are 1

# x AND 1s = x
- if x is 1, it will be 1, otherwise, 0

# x AND x = x
- 1 & 1 = 1, then 1s will continue to be 1
- 0 & 1 = 0, then 0s will continue to be 0

# x OR 0s = x
- 1 | 0 = 1
- 0 | 0 = 0

If bit is set, it will be 1

# x OR 1s = 1s
- If it's set, will remain set
- It it's not, will become 1

OR returns 1 if any of the bits are set.

# x OR x = x
- OR returns 1 if any of the bits are set.
