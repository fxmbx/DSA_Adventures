// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using Intro;

using Intro.ADT;
using Intro.ADT.LinkedList;
using Intro.ADT.Stack;
using Intro.ADT.Queue;


// Person p = new Person();
// // Stack st= new System.Collections.Generic.Stack();

// var arr = new string[] {"hello","hello1","helo2","heelo3"};
// for (int i = 0; i < arr.Length; i++)
// {
//     if(arr[i] == "heelo3"){
//         System.Console.WriteLine(i);
//     }
// }

// ArrayOperations ao = new ArrayOperations();
// ao.InsertingToArray();
// ao.InsertingAtArrayStart();
// ao.InsertingAnywhere();
// ao.DeletingFromEndOfArray();
// ao.DeletingFromArrayStart();


// Search ls = new Search();
// int[] array = new int[] {1,2,3,4,5,6,7,8,9,10};
// System.Console.WriteLine(ls.LinearSearch(array, 8));


// Node nodeA = new Node();
// Node nodeB = new Node();
// Node nodeC = new Node();
// Node nodeD = new Node();

// nodeA.Data = 10;
// nodeB.Data = 20;
// nodeC.Data = 30;
// nodeD.Data = 40;

// nodeA.Next = nodeB;
// nodeB.Next = nodeC;
// nodeC.Next = nodeD;
// nodeD.Next = nodeB;

// var linkedListDS = new LinkedListDS();
// linkedListDS.InsertHead(1);
// linkedListDS.InsertHead(2);
// linkedListDS.InsertHead(3);
// linkedListDS.InsertHead(4);
// linkedListDS.InsertHead(5);


// linkedListDS.DeleteFirst();
// linkedListDS.DeleteFirst();


// linkedListDS.InsertLast(60);
// linkedListDS.InsertLast(70);

// linkedListDS.Display();

var queue = new Queue(10);

queue.Enquque(1);
queue.Enquque(2);
queue.Enquque(3);
queue.Enquque(4);

queue.Dequeue();
queue.Enquque(5);

System.Console.WriteLine( queue.Peek());

