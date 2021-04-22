# Hints

### 1 <a name="1"></a>
Describe what it means for two strings to be permutations of each other.  
Now, look at that definition you provided.  
Can you check the strings against that definition? 

### 17 <a name="17"></a>
If you just cleared the rows and columns as you found Os, you'd likely wind up clearing 
the whole matrix. Try finding the cells with zeros first before making any changes to the 
matrix. 

### 23 <a name="23"></a>
Start with the easy thing. Can you check each of the conditions separately?

### 34 <a name="34"></a>
If a string is a rotation of another, then it's a rotation at a particular point. For example, 
a rotation of waterbottle at character 3 means cutting waterbottle at character 3 
and putting the right half (erbottle) before the left half (wat). 

### 44 <a name="44"></a>
Try a hash table. 

### 53 <a name="53"></a>
It's often easiest to modify strings by going from the end of the string to the beginning. 


### 74 <a name="74"></a>
Can you use O(N) additional space instead of O(N2)? What information do you really 
need from the list of cells that are zero?


### 84 <a name="84"></a>
There is one solution that is 0( N log N) time.  
Another solution uses some space, but is O(N) time. 

### 88 <a name="88"></a>
We are essentially asking if there's a way of splitting the first string into two parts, x and 
y, such that the first string is xy and the second string is yx. For example, x = wat and 
y = erbottle. The first string is xy = waterbottle. The second string is yx = 
erbottlewat. 

### 92 <a name="92"></a>
Do the easy thing first. Compress the string, then compare the lengths.

### 97 <a name="97"></a>
What is the relationship between the "insert character" option and the "remove character" option? Do these need to be two separate checks?

### 102 <a name="102"></a>
You probably need some data storage to maintain a list of the rows and columns that 
need to be zeroed. Can you reduce the additional space usage to 0(1) by using the 
matrix itself for data storage?

### 104 <a name="104"></a>
Think about the earlier hint. Then think about what happens when you concatenate 
erbottlewat to itself. You get erbottlewaterbottlewat. 

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