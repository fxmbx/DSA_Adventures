my DSA journey let's go! 🚀 🚀

opelope youtube lara mi

ADT - Abstract Data Type to me is like a class/object that allows you perfom crud operations on data

representaton and actions on data

## Big-O Complexity

--Horrible 👎
O(n!)
O(2^n)
O(n^2)h

--Bad 👎
O(n log n)

--Fair 💁
O(n)

--Good 👍
O(log n)

--Excellent 👌✨
O(1) constant

Focusing on O(1) and O(n)

### Constant i.e O(1) can be seen in; Assignment, Declaration, Arithmetic, Comparison, Accessong Element, Calling function

### Linear i.e O(n) can be seen in loops(iteration operations) where number of unputs increase time

int t = 0;
int i = 2;

while (i<=10){
t += i;
i += 1;
}

### Quadratic i.e O(n^2) can be seen in nested loops

for( int i =0; i <= nli++){
for(int j=0;j<=n;j++){
}
}

### LinkedList there's always a null at the end

Insert, Delete are O(1)

## Insert

-create a new node
-assign data to next field
-assign the head

## Delete

-assign a temp var
-asssign new head
-return temp

## Iterate

-asign current node
-loop
check current node is null

### Stacks follow LIFO . a linked list typically be use but stakcs cant be implemented with arrays also

## Push Pop Peek are 0(1)

### Queue FIFO

## Enqueue

-add items to the end

## Dequeue

-remove item from the front

### Binary Search . NOTE : only works sorted data

## steps for the algorithm for find f

--Find middle element i.e m= n-1/2
--is f the element the middle? if yes done if not
--is m > f ? search left side
--is m < f? search right side
--keep halfing till you find the number ➿

### Binary Search Tree heirachical data sttucture. utilizes reursion

it is sorted in a sense . gretaer number goes to the right lesser number to the left

--max of two nodes per parent
--left node is less than the parent
--right node is greater than parent

### BUBBLE SORT 😬 that algorithm you have to know but should never use cause its quadratic i.e O(n^2) complexity which is bad

take the first two elements in the array and swap based on which is larger
i.e and array of
var arry = new int[]{6,5,7,2};
on first pass becomes 5,6,7,2
second pass becomes 5,6,7,2
third pass becomes 5,6,2,7
...➿

### Recursion 😮 function that calls itself
