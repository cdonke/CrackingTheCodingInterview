# Hints

### 1 <a name="1"></a>
Describe what it means for two strings to be permutations of each other.  
Now, look at that definition you provided.  
Can you check the strings against that definition? 

### 23 <a name="23"></a>
Start with the easy thing. Can you check each of the conditions separately?


### 44 <a name="44"></a>
Try a hash table. 



### 53 <a name="53"></a>
It's often easiest to modify strings by going from the end of the string to the beginning. 


### 84 <a name="84"></a>
There is one solution that is 0( N log N) time.  
Another solution uses some space, but is O(N) time. 

### 92 <a name="92"></a>
Do the easy thing first. Compress the string, then compare the lengths.

### 97 <a name="97"></a>
What is the relationship between the "insert character" option and the "remove character" option? Do these need to be two separate checks?

### 110 <a name="110"></a>
Be careful that you aren't repeatedly concatenating strings together. This can be very inefficient. 

### 117 <a name="117"></a>
Could a bit vector be useful? 


### 118 <a name="118"></a>
You might find you need to know the number of spaces. Can you just count them? 

### 122 <a name="122"></a>
Could a hash table be useful? 

### 130 <a name="130"></a>
Can you do all three checks in a single pass?

### 131 <a name="131"></a>
Two strings that are permutations should have the same characters, but in different orders.  
Can you make the orders the same? 

### 132 <a name="132"></a>
Can you solve it in O(N log N) time? What might a solution like that look like