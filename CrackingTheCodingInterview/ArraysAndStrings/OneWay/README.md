# One Way
There are three types of edits that can be performed on strings: insert a character, 
remove a character, or replace a character. Given two strings, write a function to check if they are 
one edit (or zero edits) away

## Line of thinking
- Insert or Remove a character follows the same principal. +/-n appart in Length. This way `0 < |len(A)-len(B)| < 1`. 
If it's out of this range, More than 1 insertion/replacement has been made, and it's false.
- Replacement means something changed. Since I can only do 1 change, if a letter is different at the current iteration, 
the next MUST be equal to evaluate true. So we move one of the pointers ahead.
- On each iteraction, we count the changes. At the end `changes <= 1`.

# Hints
- [#23](../../../hints.md#23)
- [#97](../../../hints.md#97)
- [#130](../../../hints.md#130)

# Benchmark