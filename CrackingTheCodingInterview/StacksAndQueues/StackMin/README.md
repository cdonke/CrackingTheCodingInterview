# Exercise

How would you design a stack which, in addition to push and pop, has a function min 
which returns the minimum element? Push, pop and min should all operate in 0(1) time. 

## First Try
Time and Space complexity are mainly O(1) for Push, Pop and Min, 
except when the Popped item is the Min... Then it is O(n), because it will run the list for the new minimum

## Second Try
Time is always O(1), but space becomes O(2n) because a second Stack with the minimum are kept.

# Hints


# Benchmark
