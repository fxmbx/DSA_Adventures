// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using Intro;

using Intro.ADT;
using Intro.ADT.LinkedList;


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


Node nodeA = new Node();
Node nodeB = new Node();
Node nodeC = new Node();
Node nodeD = new Node();

nodeA.Data = 10;
nodeB.Data = 20;
nodeC.Data = 30;
nodeD.Data = 40;

nodeA.Next = nodeB;
nodeB.Next = nodeC;
nodeC.Next = nodeD;
// nodeD.Next = nodeB;
