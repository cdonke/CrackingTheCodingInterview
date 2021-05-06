# Hints

### 1 <a name="1"></a>
Describe what it means for two strings to be permutations of each other.  
Now, look at that definition you provided.  
Can you check the strings against that definition? 

### 3 <a name="3"></a>
There are many solutions to this problem, most of which are equally optimal in runtime. 
Some have shorter, cleaner code than others. Can you brainstorm different solutions?

### 8 <a name="8"></a>
What if you knew the linked list size? What is the difference between finding the Kth-tolast element and finding the Xth element?


### 17 <a name="17"></a>
If you just cleared the rows and columns as you found Os, you'd likely wind up clearing 
the whole matrix. Try finding the cells with zeros first before making any changes to the 
matrix. 

### 23 <a name="23"></a>
Start with the easy thing. Can you check each of the conditions separately?

### 24 <a name="24"></a>
Consider that the elements don't have to stay in the same relative order. We only need 
to ensure that elements less than the pivot must be before elements greater than the 
pivot. Does that help you come up with more solutions?

### 25 <a name="25"></a>
If you don't know the linked list size, can you compute it? How does this impact the runtime? 

### 34 <a name="34"></a>
If a string is a rotation of another, then it's a rotation at a particular point. For example, 
a rotation of waterbottle at character 3 means cutting waterbottle at character 3 
and putting the right half (erbottle) before the left half (wat). 

### 41 <a name="41"></a>
Try implementing it recursively. If you could find the (K-l)th to last element, can you 
find the Kth element? 

### 44 <a name="44"></a>
Try a hash table. 

### 53 <a name="53"></a>
It's often easiest to modify strings by going from the end of the string to the beginning. 

### 67 <a name="67"></a>
You might find it useful to return multiple values. Some languages don't directly support 
this, but there are workarounds in essentially any language. What are some of those 
workarounds?

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

### 126 <a name="126"></a>
Can you do it iteratively? Imagine if you had two pointers pointing to adjacent nodes 
and they were moving at the same speed through the linked list. When one hits the end 
of the linked list, where will the other be? 

### 130 <a name="130"></a>
Can you do all three checks in a single pass?

### 131 <a name="131"></a>
Two strings that are permutations should have the same characters, but in different orders.  
Can you make the orders the same? 

### 132 <a name="132"></a>
Can you solve it in O(N log N) time? What might a solution like that look like